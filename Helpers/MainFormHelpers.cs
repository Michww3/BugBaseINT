using BugBase.DTOs;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BugBase.Helpers
{
    public static class MainFormHelpers
    {
        public static void AddBug(TextBox textBoxName, RichTextBox textBoxDescription, ComboBox comboBoxPriority, DateTimePicker dateTimePicker, CheckBox checkBoxStatus, TextBox textBoxId, string imageString, PictureBox pictureBox)
        {
            var name = textBoxName.Text;
            var description = textBoxDescription.Text;
            var priority = comboBoxPriority.Text;
            var end = dateTimePicker.Value;
            var isComplete = checkBoxStatus.Checked;
            if (!int.TryParse(textBoxId.Text, out int employeId))
            {
                MessageBox.Show("Incorrect employe Id");
                return;
            }

            if (!CheckData(name, description, priority, end))
                return;

            using (AppDbContext context = new AppDbContext())
            {
                var employe = context.Employes.Find(employeId);
                if (employe == null)
                {
                    MessageBox.Show("No employe with this Id");
                    return;
                }
                Bug bug = new Bug(name, description, priority, end, isComplete, employeId);
                bug.Base64Image = imageString;
                context.Bugs.Add(bug);
                context.SaveChanges();
                ClearUserData(textBoxName, textBoxDescription, comboBoxPriority, dateTimePicker, checkBoxStatus, textBoxId, imageString, pictureBox);
            }
        }
        public static string LoadImageAsBase64(PictureBox imagePictureBox)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var imageBytes = File.ReadAllBytes(openFileDialog.FileName);
                    imagePictureBox.Image = Image.FromFile(openFileDialog.FileName); ;
                    return Convert.ToBase64String(imageBytes);
                }
            }
            return null;
        }

        public static void DeleteBug(int bugId)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var bug = context.Bugs.Find(bugId);

                if (bug == null)
                {
                    MessageBox.Show("No data with this Id");
                    return;
                }

                context.Bugs.Remove(bug);
                context.SaveChanges();
            }
        }
        private static bool CheckData(string name, string description, string priority, DateTime dateTime)
        {
            var valid = true;
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name must be select");
                valid = false;
            }
            if (String.IsNullOrEmpty(description))
            {
                MessageBox.Show("Description must be select");
                valid = false;
            }
            if (String.IsNullOrEmpty(priority))
            {
                MessageBox.Show("Priority must be select");
                valid = false;
            }
            if (dateTime < DateTime.Now)
            {
                MessageBox.Show("End date must be correct");
                valid = false;
            }
            return valid;
        }

        public static void ClearUserData(TextBox nameTextBox, RichTextBox descriptionTextBox, ComboBox priorityComboBox, DateTimePicker endDatePicker, CheckBox statusCheckBox, TextBox employeIdTextBox, string imageString, PictureBox imagePictureBox)
        {
            nameTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            priorityComboBox.Text = string.Empty;
            endDatePicker.Value = DateTime.Now;
            statusCheckBox.Checked = false;
            employeIdTextBox.Text = string.Empty;
            imageString = null;
            imagePictureBox.Image = null;
        }
        public static void CellVaildate(DataGridView BugsDataGrid, DataGridViewCellValidatingEventArgs e)
        {
            if (BugsDataGrid.Columns[e.ColumnIndex].Name == "nameDataGridViewTextBoxColumn")
            {
                var newValue = e.FormattedValue.ToString();

                if (string.IsNullOrWhiteSpace(newValue))
                {
                    MessageBox.Show("Поле не может быть пустым.");
                    e.Cancel = true;
                    BugsDataGrid.Rows[e.RowIndex].ErrorText = "Имя не может быть пустым";
                }
            }

            if (BugsDataGrid.Columns[e.ColumnIndex].Name == "descriptionDataGridViewTextBoxColumn")
            {
                var newValue = e.FormattedValue.ToString();

                if (string.IsNullOrWhiteSpace(newValue))
                {
                    MessageBox.Show("Поле не может быть пустым.");
                    e.Cancel = true;
                    BugsDataGrid.Rows[e.RowIndex].ErrorText = "Описание не может быть пустым";
                }
            }

            if (BugsDataGrid.Columns[e.ColumnIndex].Name == "priorityDataGridViewTextBoxColumn")
            {
                var newValue = e.FormattedValue.ToString();

                if (string.IsNullOrWhiteSpace(newValue))
                {
                    MessageBox.Show("Поле не может быть пустым.");
                    e.Cancel = true;
                    BugsDataGrid.Rows[e.RowIndex].ErrorText = "Приоритет не может быть пустым";
                    return;
                }
                if (newValue != "low" && newValue != "medium" && newValue != "high")
                {
                    MessageBox.Show("Enter a valid priority(low, medium or high)");
                    e.Cancel = true;
                    BugsDataGrid.Rows[e.RowIndex].ErrorText = "Enter a valid priority(low, medium or high)";
                }
            }

            if (BugsDataGrid.Columns[e.ColumnIndex].Name == "endDateDataGridViewTextBoxColumn")
            {
                var newValue = e.FormattedValue.ToString();
                DateTime endDate;

                if (string.IsNullOrWhiteSpace(newValue))
                {
                    MessageBox.Show("End date not be null");
                    e.Cancel = true;
                    BugsDataGrid.Rows[e.RowIndex].ErrorText = "End date not be null";
                    return;
                }
                if (!DateTime.TryParse(newValue, out endDate))
                {
                    MessageBox.Show("Date not in correct format");
                    e.Cancel = true;
                    BugsDataGrid.Rows[e.RowIndex].ErrorText = "Date not in correct format";
                    return;
                }
                if (endDate <= DateTime.Now)
                {
                    MessageBox.Show("Enter a correct end date");
                    e.Cancel = true;
                    BugsDataGrid.Rows[e.RowIndex].ErrorText = "Enter a correct end date";
                }
            }

            if (BugsDataGrid.Columns[e.ColumnIndex].Name == "employeIdDataGridViewTextBoxColumn")
            {
                string newValue = e.FormattedValue.ToString();
                int employeId;

                if (string.IsNullOrWhiteSpace(newValue))
                {
                    MessageBox.Show("Employe id not be null");
                    e.Cancel = true;
                    BugsDataGrid.Rows[e.RowIndex].ErrorText = "Employe id not be null";
                    return;
                }
                if (!Int32.TryParse(newValue, out employeId))
                {
                    MessageBox.Show("Employe id not in correct format");
                    e.Cancel = true;
                    BugsDataGrid.Rows[e.RowIndex].ErrorText = "Employe id not in correct format";
                    return;
                }
                using (var context = new AppDbContext())
                {
                    var employe = context.Employes.Find(employeId);
                    if (employe == null)
                    {
                        MessageBox.Show("No employe with this id");
                        e.Cancel = true;
                        BugsDataGrid.Rows[e.RowIndex].ErrorText = "No employe with this id";
                    }
                }
            }
        }
        public static void DatagridMouseDown(DataGridView BugsDataGrid, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                BugsDataGrid.ClearSelection();
                BugsDataGrid.Rows[e.RowIndex].Selected = true;

                var bugId = Convert.ToInt32(BugsDataGrid.Rows[e.RowIndex].Cells[0].Value);

                var confirmResult = MessageBox.Show("Удалить запись с Id = " + bugId + "?",
                                                    "Подтвердите удаление",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DeleteBug(bugId);
                }
            }
        }
        public static void LoadData(TextBox bugIdTextBox, TextBox nameTextBox, RichTextBox descriptionTextBox, ComboBox priorityComboBox, DateTimePicker emdDatePicker, CheckBox statusCheckBox, TextBox employeIdTextBox, PictureBox imagePictureBox)
        {
            if (String.IsNullOrEmpty(bugIdTextBox.Text))
            {
                MessageBox.Show("Enter a bug id to view data");
                return;
            }
            if (!Int32.TryParse(bugIdTextBox.Text, out var bugId))
            {
                MessageBox.Show("Bug id not in correct format");
                return;
            }
            using (var context = new AppDbContext())
            {
                var bug = context.Bugs.Find(bugId);
                if (bug == null)
                {
                    MessageBox.Show($"No bug with this id");
                    return;
                }

                nameTextBox.Text = bug.Name;
                descriptionTextBox.Text = bug.Description;
                priorityComboBox.Text = bug.Priority;
                emdDatePicker.Value = bug.EndDate;
                statusCheckBox.Checked = bug.IsComplited;
                employeIdTextBox.Text = bug.EmployeId.ToString();
                LoadBase64ImageToPictureBox(bug.Base64Image, imagePictureBox);
            }
        }
        public static void LoadBase64ImageToPictureBox(string base64String, PictureBox pictureBox)
        {
            if (string.IsNullOrWhiteSpace(base64String))
            {
                pictureBox.Image = null;
                return;
            }

            try
            {
                var imageBytes = Convert.FromBase64String(base64String);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);
            }
        }
    }
}
