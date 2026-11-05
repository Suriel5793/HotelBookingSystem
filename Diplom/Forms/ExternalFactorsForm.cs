using System;
using System.Linq;
using System.Windows.Forms;
using Diplom.Models;
using Diplom.Services;

namespace Diplom.Forms
{
    public partial class ExternalFactorsForm : Form
    {
        private DatabaseService _db;
        private bool _isEditing = false;
        private int _currentEditId = -1;

        public ExternalFactorsForm()
        {
            InitializeComponent();
            _db = new DatabaseService();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var factors = _db.GetAllFactors();

                dgvFactors.DataSource = null;
                dgvFactors.DataSource = factors.Select(f => new
                {
                    f.FactorId,
                    Тип = f.Type,
                    Дата = f.Date.ToShortDateString(),
                    Значение = f.Value,
                    Коэффициент = f.ImpactCoefficient,
                    Описание = f.Description
                }).ToList();

                dgvFactors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                UpdateStatusLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatusLabel()
        {
            lblStatus.Text = $"Всего факторов: {dgvFactors.RowCount}";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            _isEditing = false;
            _currentEditId = -1;
            EnableEditMode(true);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvFactors.CurrentRow == null)
            {
                MessageBox.Show("Выберите фактор для редактирования", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvFactors.CurrentRow.Cells["FactorId"].Value;
            var factor = _db.GetAllFactors().FirstOrDefault(f => f.FactorId == id);

            if (factor != null)
            {
                cmbType.SelectedItem = factor.Type;
                dtpDate.Value = factor.Date;
                txtValue.Text = factor.Value;
                numImpact.Value = factor.ImpactCoefficient;
                txtDescription.Text = factor.Description;

                _isEditing = true;
                _currentEditId = id;
                EnableEditMode(true);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem == null)
            {
                MessageBox.Show("Выберите тип фактора", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtValue.Text))
            {
                MessageBox.Show("Введите значение фактора", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var factor = new ExternalFactor
            {
                Type = cmbType.SelectedItem.ToString(),
                Date = dtpDate.Value.Date,
                Value = txtValue.Text,
                ImpactCoefficient = numImpact.Value,
                Description = txtDescription.Text
            };

            try
            {
                if (_isEditing)
                {
                    factor.FactorId = _currentEditId;
                    _db.UpdateFactor(factor);
                    MessageBox.Show("Фактор успешно обновлён", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _db.AddFactor(factor);
                    MessageBox.Show("Фактор успешно добавлен", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadData();
                EnableEditMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFactors.CurrentRow == null)
            {
                MessageBox.Show("Выберите фактор для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvFactors.CurrentRow.Cells["FactorId"].Value;

            var result = MessageBox.Show("Удалить выбранный фактор?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _db.DeleteFactor(id);
                    LoadData();
                    MessageBox.Show("Фактор успешно удалён", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            EnableEditMode(false);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            cmbType.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
            txtValue.Clear();
            numImpact.Value = 1;
            txtDescription.Clear();
        }

        private void EnableEditMode(bool enable)
        {
            grpEdit.Enabled = enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;
            btnAdd.Enabled = !enable;
            btnEdit.Enabled = !enable;
            btnDelete.Enabled = !enable;

            if (!enable)
            {
                ClearFields();
                _isEditing = false;
                _currentEditId = -1;
            }
        }
    }
}