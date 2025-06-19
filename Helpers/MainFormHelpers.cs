using BugBase.DTOs;
using System;
using System.IO;
using System.Windows.Forms;

namespace BugBase.Helpers
{
    public static class MainFormHelpers
    {
        public static void AddBug(TextBox textBoxName, RichTextBox textBoxDescription, ComboBox comboBoxPriority, DateTimePicker dateTimePicker, CheckBox checkBoxStatus, TextBox textBoxId, string imageString)
        {
            string name = textBoxName.Text;
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name must be select");
                return;
            }
            string description = textBoxDescription.Text;
            if (String.IsNullOrEmpty(description))
            {
                MessageBox.Show("Description must be select");
                return;
            }
            string priority = comboBoxPriority.Text;
            if (String.IsNullOrEmpty(priority))
            {
                MessageBox.Show("Priority must be select");
                return;
            }
            DateTime end = dateTimePicker.Value;
            bool isComplete = checkBoxStatus.Checked;

            if (!int.TryParse(textBoxId.Text, out int employeId))
            {
                MessageBox.Show("Incorrect employe Id");
                return;
            }

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

        public static void EditBug(TextBox editIdTextBox, TextBox textBoxName, RichTextBox textBoxDescription, ComboBox comboBoxPriority, DateTimePicker dateTimePicker, CheckBox checkBoxStatus, TextBox textBoxId,Label imageSelectLabel, string imageString)
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
                }
                textBoxName.Text = bug.Name;
                textBoxDescription.Text = bug.Description;
                comboBoxPriority.Text = bug.Priority;
                dateTimePicker.Value = bug.EndDate;
                checkBoxStatus.Checked = bug.IsComplited;
                textBoxId.Text = bug.EmployeId.ToString();
                imageString = bug.Base64Image;
                imageSelectLabel.Text = "Image select";
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
        }
    }
}
