using BugBase.DTOs;
using System;
using System.IO;
using System.Windows.Forms;

namespace BugBase.Helpers
{
    public static class MainFormHelpers
    {
        public static void AddBug(TextBox textBoxName, RichTextBox textBoxDescription, ComboBox comboBoxPriority, DateTimePicker dateTimePicker, CheckBox checkBoxStatus, TextBox textBoxId,Label imageLabel, string imageString)
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
                bug.Base64Image = imageString ?? null;
                context.Bugs.Add(bug);
                context.SaveChanges();
                ClearUserData(textBoxName, textBoxDescription, comboBoxPriority, dateTimePicker, checkBoxStatus, textBoxId, imageString);
            }
        }
        public static string LoadImageAsBase64(Label imageSelectLabel)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);
                    imageSelectLabel.Text = "Image select";
                    return Convert.ToBase64String(imageBytes); // преобразуем в Base64
                }
            }
            imageSelectLabel.Text = "Image not select";
            return null;
        }

        public static void DeleteBug(TextBox deleteIdTextBox)
        {
            if (String.IsNullOrEmpty(deleteIdTextBox.Text))
            {
                MessageBox.Show("Enter Id");
                return;
            }
            if (!int.TryParse(deleteIdTextBox.Text, out int bugId))
            {
                MessageBox.Show("Incorrect Id");
                return;
            }
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

                //MessageBox.Show("Deleting complete");
            }
        }

        public static string EditBug(TextBox editIdTextBox, TextBox textBoxName, RichTextBox textBoxDescription, ComboBox comboBoxPriority, DateTimePicker dateTimePicker, CheckBox checkBoxStatus, TextBox textBoxId, Label imageSelectLabel, string imageString)
        {
            if (String.IsNullOrEmpty(editIdTextBox.Text))
            {
                MessageBox.Show("Enter Id");
                return null;
            }
            if (!int.TryParse(editIdTextBox.Text, out int Id))
            {
                MessageBox.Show("Incorrect bug Id");
                return null;
            }
            using (AppDbContext context = new AppDbContext())
            {
                var bug = context.Bugs.Find(Id);
                if (bug == null)
                {
                    MessageBox.Show("No bug with this Id");
                }
                textBoxName.Text = bug.Name;
                textBoxDescription.Text = bug.Description;
                comboBoxPriority.Text = bug.Priority;
                dateTimePicker.Value = bug.EndDate;
                checkBoxStatus.Checked = bug.IsComplited;
                textBoxId.Text = bug.EmployeId.ToString();
                imageString = bug.Base64Image;
                if (imageString != null)
                    imageSelectLabel.Text = "Image select";
                return imageString;
            }
        }

        public static void SaveEditBug(TextBox editIdTextBox, TextBox textBoxName, RichTextBox textBoxDescription, ComboBox comboBoxPriority, DateTimePicker dateTimePicker, CheckBox checkBoxStatus, TextBox textBoxId, Label imageSelectLabel, string imageString)
        {
            if (String.IsNullOrEmpty(editIdTextBox.Text))
            {
                MessageBox.Show("Enter Id");
                return;
            }
            if (!int.TryParse(editIdTextBox.Text, out int Id))
            {
                MessageBox.Show("Incorrect bug Id");
                return;
            }
            using (AppDbContext context = new AppDbContext())
            {
                var bug = context.Bugs.Find(Id);
                if (bug == null)
                {
                    MessageBox.Show("No bug with this Id");
                    return;
                }
                bug.Name = textBoxName.Text;
                bug.Description = textBoxDescription.Text;
                bug.Priority = comboBoxPriority.Text;
                bug.EndDate = dateTimePicker.Value;
                bug.IsComplited = checkBoxStatus.Checked;
                bug.Base64Image = imageString;
                if (!int.TryParse(textBoxId.Text, out int employeId))
                {
                    MessageBox.Show("Incorrect employe Id");
                    return;
                }
                bug.EmployeId = employeId;
                context.SaveChanges();
            }
            ClearUserData(textBoxName, textBoxDescription, comboBoxPriority, dateTimePicker, checkBoxStatus, textBoxId, imageString, imageSelectLabel);
        }

        private static bool CheckData(string name, string description, string priority, DateTime dateTime)
        {
            var valid = true;
            if(String.IsNullOrEmpty(name))
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

        public static void ClearUserData(TextBox nameTextBox, RichTextBox descriptionTextBox, ComboBox priorityComboBox, DateTimePicker endDatePicker, CheckBox statusCheckBox, TextBox employeIdTextBox, string imageString)
        {
            nameTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            priorityComboBox.Text = string.Empty;
            endDatePicker.Value = DateTime.Now;
            statusCheckBox.Checked = false;
            employeIdTextBox.Text = string.Empty;
            imageString = null;
        }
        public static void ClearUserData(TextBox nameTextBox, RichTextBox descriptionTextBox, ComboBox priorityComboBox, DateTimePicker endDatePicker, CheckBox statusCheckBox, TextBox employeIdTextBox, string imageString, Label imageLabel)
        {
            nameTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            priorityComboBox.Text = string.Empty;
            endDatePicker.Value = DateTime.Now;
            statusCheckBox.Checked = false;
            employeIdTextBox.Text = string.Empty;
            imageString = null;
            imageLabel.Text = "Image not select";
        }
        public static void ClearUserData(TextBox nameTextBox, RichTextBox descriptionTextBox, ComboBox priorityComboBox, DateTimePicker endDatePicker, CheckBox statusCheckBox, TextBox employeIdTextBox, string imageString, Label imageLabel, TextBox deleteIdTextBox, TextBox editIdTextBox)
        {
            nameTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            priorityComboBox.Text = string.Empty;
            endDatePicker.Value = DateTime.Now;
            statusCheckBox.Checked = false;
            employeIdTextBox.Text = string.Empty;
            imageString = null;
            imageLabel.Text = "Image not select";
            deleteIdTextBox.Text = string.Empty;
            editIdTextBox.Text = string.Empty;
        }
    }
}
