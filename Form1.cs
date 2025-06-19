using BugBase.Helpers;
using System;
using System.IO;
using System.Windows.Forms;

namespace BugBase
{
    public partial class Form1 : Form
    {
        private string imageString;
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MainFormHelpers.AddBug(NameTextBox, DescriptionTextBox, PriorityComboBox, EndDatePicker, StatusCheckBox, EmployeIdTextBox, imageString);
            Form1_Load(sender, e);
            ClearButton_Click(sender, e);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
            PriorityComboBox.Text = string.Empty;
            EndDatePicker.Value = DateTime.Now;
            StatusCheckBox.Checked = false;
            EmployeIdTextBox.Text = string.Empty;
            imageString = null;
            ImageSelectLabel.Text = "Image not select";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            MainFormHelpers.DeleteBug(DeleteIdTextBox);
            Form1_Load(sender, e);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            imageString = MainFormHelpers.EditBug(EditIdTextBox, NameTextBox, DescriptionTextBox, PriorityComboBox, EndDatePicker, StatusCheckBox, EmployeIdTextBox, ImageSelectLabel, imageString);
        }

        private void SaveEditButton_Click(object sender, EventArgs e)
        {
            MainFormHelpers.SaveEditBug(EditIdTextBox, NameTextBox, DescriptionTextBox, PriorityComboBox, EndDatePicker, StatusCheckBox, EmployeIdTextBox, ImageSelectLabel, imageString);
            ClearButton_Click(sender, e);
            Form1_Load(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bugBaseDBDataSet1.Employes' table. You can move, or remove it, as needed.
            this.employesTableAdapter.Fill(this.bugBaseDBDataSet1.Employes);
            // TODO: This line of code loads data into the 'bugBaseDBDataSet.Bugs' table. You can move, or remove it, as needed.
            this.bugsTableAdapter.Fill(this.bugBaseDBDataSet.Bugs);

        }

        private void EmployesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = EmployesDataGrid.Rows[e.RowIndex];
            string value = row.Cells[0].Value?.ToString();
            EmployeIdTextBox.Text = value;
        }

        private void BugsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = BugsDataGrid.Rows[e.RowIndex];
            string value = row.Cells[0].Value?.ToString();
            DeleteIdTextBox.Text = value;
            EditIdTextBox.Text = value;
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            imageString = MainFormHelpers.LoadImageAsBase64(ImageSelectLabel);
        }
    }
}
