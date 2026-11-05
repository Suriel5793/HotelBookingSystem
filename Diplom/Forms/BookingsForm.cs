using System;
using System.Linq;
using System.Windows.Forms;
using Diplom.Models;
using Diplom.Services;

namespace Diplom.Forms
{
    public partial class BookingsForm : Form
    {
        private DatabaseService _db;
        private bool _isEditing = false;
        private int _currentEditId = -1;

        public BookingsForm()
        {
            InitializeComponent();
            _db = new DatabaseService();
            LoadData();
        }

        private void LoadData()
        {
            LoadRoomsCombo();

            dgvBookings.DataSource = null;
            dgvBookings.DataSource = DataStore.Bookings.Select(b => new
            {
                b.BookingId,
                Номер = GetRoomNumber(b.RoomId),
                Категория = GetRoomCategory(b.RoomId),
                b.GuestCount,
                Заезд = b.CheckInDate.ToShortDateString(),
                Выезд = b.CheckOutDate.ToShortDateString(),
                Цена = b.TotalPrice,
                Источник = b.BookingSource,
                Статус = b.Status,
                Телефон = b.CustomerPhone,
                Email = b.CustomerEmail
            }).ToList();

            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            UpdateStatusLabel();
        }

        private void LoadRoomsCombo()
        {
            cmbRoomId.DataSource = null;
            cmbRoomId.DisplayMember = "RoomNumber";
            cmbRoomId.ValueMember = "RoomId";
            cmbRoomId.DataSource = DataStore.Rooms.ToList();
        }

        private string GetRoomNumber(int roomId)
        {
            var room = DataStore.Rooms.FirstOrDefault(r => r.RoomId == roomId);
            return room?.RoomNumber ?? "—";
        }

        private string GetRoomCategory(int roomId)
        {
            var room = DataStore.Rooms.FirstOrDefault(r => r.RoomId == roomId);
            return room?.Category ?? "—";
        }

        private void UpdateStatusLabel()
        {
            lblStatus.Text = $"Всего бронирований: {DataStore.Bookings.Count}";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (DataStore.Rooms.Count == 0)
            {
                MessageBox.Show("Сначала добавьте номера в справочник", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClearFields();
            _isEditing = false;
            _currentEditId = -1;
            EnableEditMode(true);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBookings.CurrentRow == null)
            {
                MessageBox.Show("Выберите бронирование для редактирования", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedBooking = GetSelectedBooking();
            if (selectedBooking == null) return;

            cmbRoomId.SelectedValue = selectedBooking.RoomId;
            dtpCheckIn.Value = selectedBooking.CheckInDate;
            dtpCheckOut.Value = selectedBooking.CheckOutDate;
            numGuestCount.Value = selectedBooking.GuestCount;
            txtCustomerPhone.Text = selectedBooking.CustomerPhone;
            txtCustomerEmail.Text = selectedBooking.CustomerEmail;
            cmbBookingSource.SelectedItem = selectedBooking.BookingSource;
            cmbBookingStatus.SelectedItem = selectedBooking.Status;
            txtNotes.Text = selectedBooking.Notes;

            _isEditing = true;
            _currentEditId = selectedBooking.BookingId;
            EnableEditMode(true);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (cmbRoomId.SelectedItem == null)
            {
                MessageBox.Show("Выберите номер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roomId = (int)cmbRoomId.SelectedValue;
            DateTime checkIn = dtpCheckIn.Value.Date;
            DateTime checkOut = dtpCheckOut.Value.Date;
            int guestCount = (int)numGuestCount.Value;
            string customerPhone = txtCustomerPhone.Text;
            string customerEmail = txtCustomerEmail.Text;
            string bookingSource = cmbBookingSource.SelectedItem?.ToString() ?? "Сайт отеля";
            string status = cmbBookingStatus.SelectedItem?.ToString() ?? "подтверждено";
            string notes = txtNotes.Text;

            if (checkOut <= checkIn)
            {
                MessageBox.Show("Дата выезда должна быть позже даты заезда", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasConflict = DataStore.Bookings.Any(b =>
                b.RoomId == roomId &&
                b.BookingId != _currentEditId &&
                b.Status != "отменено" &&
                ((checkIn >= b.CheckInDate && checkIn < b.CheckOutDate) ||
                 (checkOut > b.CheckInDate && checkOut <= b.CheckOutDate) ||
                 (checkIn <= b.CheckInDate && checkOut >= b.CheckOutDate)));

            if (hasConflict)
            {
                MessageBox.Show("Номер уже забронирован на выбранные даты", "Конфликт дат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var room = DataStore.Rooms.FirstOrDefault(r => r.RoomId == roomId);
            int nights = (checkOut - checkIn).Days;
            decimal totalPrice = nights * (room?.BasePricePerNight ?? 0);

            if (_isEditing)
            {
                var booking = DataStore.Bookings.FirstOrDefault(b => b.BookingId == _currentEditId);
                if (booking != null)
                {
                    booking.RoomId = roomId;
                    booking.CheckInDate = checkIn;
                    booking.CheckOutDate = checkOut;
                    booking.GuestCount = guestCount;
                    booking.TotalPrice = totalPrice;
                    booking.BookingSource = bookingSource;
                    booking.Status = status;
                    booking.CustomerPhone = customerPhone;
                    booking.CustomerEmail = customerEmail;
                    booking.Notes = notes;

                    _db.UpdateBooking(booking);
                    MessageBox.Show("Бронирование успешно обновлено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                var newBooking = new Booking
                {
                    RoomId = roomId,
                    CheckInDate = checkIn,
                    CheckOutDate = checkOut,
                    GuestCount = guestCount,
                    TotalPrice = totalPrice,
                    BookingSource = bookingSource,
                    Status = status,
                    CustomerPhone = customerPhone,
                    CustomerEmail = customerEmail,
                    Notes = notes
                };

                int newId = _db.AddBookingAndGetId(newBooking);
                newBooking.BookingId = newId;
                DataStore.Bookings.Add(newBooking);

                if (newId >= DataStore.NextBookingId)
                    DataStore.NextBookingId = newId + 1;

                MessageBox.Show("Бронирование успешно добавлено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadData();
            EnableEditMode(false);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            EnableEditMode(false);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var selectedBooking = GetSelectedBooking();
            if (selectedBooking == null) return;

            var result = MessageBox.Show($"Удалить бронирование #{selectedBooking.BookingId}?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _db.DeleteBooking(selectedBooking.BookingId);
                DataStore.Bookings.RemoveAll(b => b.BookingId == selectedBooking.BookingId);
                LoadData();
                MessageBox.Show("Бронирование успешно удалено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCancelBooking_Click(object sender, EventArgs e)
        {
            var selectedBooking = GetSelectedBooking();
            if (selectedBooking == null)
            {
                MessageBox.Show("Выберите бронирование для отмены", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedBooking.Status == "отменено")
            {
                MessageBox.Show("Бронирование уже отменено", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show($"Отменить бронирование #{selectedBooking.BookingId}?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                selectedBooking.Status = "отменено";
                _db.UpdateBooking(selectedBooking);
                LoadData();
                MessageBox.Show("Бронирование успешно отменено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Booking GetSelectedBooking()
        {
            if (dgvBookings.CurrentRow == null) return null;

            int bookingId = (int)dgvBookings.CurrentRow.Cells[0].Value;
            return DataStore.Bookings.FirstOrDefault(b => b.BookingId == bookingId);
        }

        private void ClearFields()
        {
            cmbRoomId.SelectedIndex = -1;
            dtpCheckIn.Value = DateTime.Now.Date;
            dtpCheckOut.Value = DateTime.Now.Date.AddDays(1);
            numGuestCount.Value = 1;
            txtCustomerPhone.Clear();
            txtCustomerEmail.Clear();
            txtNotes.Clear();
            cmbBookingSource.SelectedIndex = 0;
            cmbBookingStatus.SelectedIndex = 0;
        }

        private void EnableEditMode(bool enable)
        {
            grpEdit.Enabled = enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;
            btnAdd.Enabled = !enable;
            btnEdit.Enabled = !enable;
            btnDelete.Enabled = !enable;
            btnCancelBooking.Enabled = !enable;

            if (!enable)
            {
                ClearFields();
                _isEditing = false;
                _currentEditId = -1;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookingsForm_Load(object sender, EventArgs e)
        {
            cmbBookingSource.SelectedIndex = 0;
            cmbBookingStatus.SelectedIndex = 0;
        }
    }
}