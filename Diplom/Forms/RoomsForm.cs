using System;
using System.Linq;
using System.Windows.Forms;
using Diplom.Models;
using Diplom.Services;

namespace Diplom.Forms
{
    public partial class RoomsForm : Form
    {
        private DatabaseService _db;
        private bool _isEditing = false;
        private int _currentEditId = -1;

        public RoomsForm()
        {
            InitializeComponent();
            _db = new DatabaseService();
            LoadData();

            SetEditMode(false);
        }

        private void LoadData()
        {
            dgvRooms.DataSource = null;
            dgvRooms.DataSource = DataStore.Rooms.Select(r => new
            {
                r.RoomId,
                r.RoomNumber,
                r.Category,
                r.BasePricePerNight,
                r.Capacity,
                r.Status
            }).ToList();

            if (dgvRooms.Columns.Count > 0)
            {
                dgvRooms.Columns["RoomId"].HeaderText = "ID";
                dgvRooms.Columns["RoomNumber"].HeaderText = "Номер";
                dgvRooms.Columns["Category"].HeaderText = "Категория";
                dgvRooms.Columns["BasePricePerNight"].HeaderText = "Цена за ночь, руб.";
                dgvRooms.Columns["Capacity"].HeaderText = "Вместимость";
                dgvRooms.Columns["Status"].HeaderText = "Статус";
            }

            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UpdateStatusLabel();
        }

        private void UpdateStatusLabel()
        {
            lblStatus.Text = $"Всего номеров: {DataStore.Rooms.Count}";
        }

        private void SetEditMode(bool enable)
        {
            grpEdit.Enabled = enable;

            txtRoomNumber.Enabled = enable;
            txtCategory.Enabled = enable;
            txtPrice.Enabled = enable;
            txtCapacity.Enabled = enable;
            cmbStatus.Enabled = enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;

            btnAdd.Enabled = !enable;
            btnEdit.Enabled = !enable;
            btnDelete.Enabled = !enable;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtRoomNumber.Text = "";
            txtCategory.Text = "";
            txtPrice.Text = "";
            txtCapacity.Text = "";
            txtMaintenanceCost.Text = "";
            cmbStatus.SelectedIndex = -1;

            _isEditing = false;
            _currentEditId = -1;

            SetEditMode(true);

            txtRoomNumber.Focus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRooms.CurrentRow == null)
            {
                MessageBox.Show("Выберите номер для редактирования", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRoom = GetSelectedRoom();
            if (selectedRoom == null) return;

            txtRoomNumber.Text = selectedRoom.RoomNumber;
            txtCategory.Text = selectedRoom.Category;
            txtPrice.Text = selectedRoom.BasePricePerNight.ToString();
            txtMaintenanceCost.Text = selectedRoom.MaintenanceCost.ToString();
            txtCapacity.Text = selectedRoom.Capacity.ToString();
            cmbStatus.SelectedItem = selectedRoom.Status;


            _isEditing = true;
            _currentEditId = selectedRoom.RoomId;

            SetEditMode(true);

            txtRoomNumber.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text))
            {
                MessageBox.Show("Введите номер комнаты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Введите категорию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Введите корректную цену (число > 0)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtMaintenanceCost.Text, out decimal maintCost) || maintCost < 0)
            {
                MessageBox.Show("Введите корректные затраты (число >= 0)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCapacity.Text, out int capacity) || capacity <= 0 || capacity > 10)
            {
                MessageBox.Show("Введите корректную вместимость (1-10)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = cmbStatus.SelectedItem?.ToString() ?? "свободен";

            if (_isEditing)
            {
                var room = DataStore.Rooms.FirstOrDefault(r => r.RoomId == _currentEditId);
                if (room != null)
                {
                    room.RoomNumber = txtRoomNumber.Text;
                    room.Category = txtCategory.Text;
                    room.BasePricePerNight = price;
                    room.Capacity = capacity;
                    room.MaintenanceCost = maintCost;
                    room.Status = status;
                    room.UpdatedAt = DateTime.Now;

                    _db.UpdateRoom(room);
                    MessageBox.Show("Номер успешно обновлён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                var newRoom = new HotelRoom
                {
                    RoomNumber = txtRoomNumber.Text,
                    Category = txtCategory.Text,
                    BasePricePerNight = price,
                    Capacity = capacity,
                    MaintenanceCost = maintCost,
                    Status = status,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                int newId = _db.AddRoomAndGetId(newRoom);
                newRoom.RoomId = newId;
                DataStore.Rooms.Add(newRoom);

                if (newId >= DataStore.NextRoomId)
                    DataStore.NextRoomId = newId + 1;

                MessageBox.Show("Номер успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadData();
            CancelEdit();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CancelEdit();
        }

        private void CancelEdit()
        {
            txtRoomNumber.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtCapacity.Clear();
            txtMaintenanceCost.Clear();
            cmbStatus.SelectedIndex = -1;

            _isEditing = false;
            _currentEditId = -1;

            SetEditMode(false);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var selectedRoom = GetSelectedRoom();
            if (selectedRoom == null) return;

            bool hasActiveBookings = DataStore.Bookings.Any(b => b.RoomId == selectedRoom.RoomId && b.Status != "отменено");

            if (hasActiveBookings)
            {
                MessageBox.Show($"Номер {selectedRoom.RoomNumber} имеет активные бронирования.\n\nСначала отмените или удалите их.",
                    "Нельзя удалить номер", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Удалить номер {selectedRoom.RoomNumber}?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _db.DeleteRoom(selectedRoom.RoomId);
                    DataStore.Rooms.RemoveAll(r => r.RoomId == selectedRoom.RoomId);
                    LoadData();
                    MessageBox.Show($"Номер {selectedRoom.RoomNumber} успешно удалён", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось удалить номер {selectedRoom.RoomNumber}.\n\n{ex.Message}",
                        "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private HotelRoom GetSelectedRoom()
        {
            if (dgvRooms.CurrentRow == null) return null;

            int roomId = (int)dgvRooms.CurrentRow.Cells["RoomId"].Value;
            return DataStore.Rooms.FirstOrDefault(r => r.RoomId == roomId);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}