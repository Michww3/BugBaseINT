using BugBase.Helpers;
using System;
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
            MainFormHelpers.AddBug(NameTextBox, DescriptionTextBox, PriorityComboBox, EndDatePicker, StatusCheckBox, EmployeIdTextBox, imageString, ImagePictureBox);
            Form1_Load(sender, e);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MainFormHelpers.ClearUserData(NameTextBox, DescriptionTextBox, PriorityComboBox, EndDatePicker, StatusCheckBox, EmployeIdTextBox, imageString, ImagePictureBox);
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
            string value;
            try
            {
                var row = EmployesDataGrid.Rows[e.RowIndex];
                value = row.Cells[0].Value?.ToString();

            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
            EmployeIdTextBox.Text = value;
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            imageString = MainFormHelpers.LoadImageToPictureBox(ImagePictureBox);
        }

        private void TextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            var filterText = EmployeFilterTextbox.Text.Trim();

            if (string.IsNullOrEmpty(filterText))
                employesBindingSource.RemoveFilter();
            else
                employesBindingSource.Filter = $"Name LIKE '%{filterText}%'";
        }

        private void BugsDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            MainFormHelpers.DatagridMouseDown(BugsDataGrid, e);
            Form1_Load(sender, e);
        }

        private void BugsDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            bugsBindingSource.EndEdit();
            bugsTableAdapter.Update(bugBaseDBDataSet.Bugs);
        }
        private void BugsDataGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            MainFormHelpers.CellVaildate(BugsDataGrid, e);
        }
        private void BugsDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            BugsDataGrid.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            MainFormHelpers.LoadData(BugIdTextBox, NameTextBox, DescriptionTextBox, PriorityComboBox, EndDatePicker, StatusCheckBox, EmployeIdTextBox, ImagePictureBox);
        }

        private void BugsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = BugsDataGrid.Rows[e.RowIndex];
                BugIdTextBox.Text = row.Cells["idDataGridViewTextBoxColumn"].Value?.ToString();
            }
        }

        private void ChangeImageButton_Click(object sender, EventArgs e)
        {
            MainFormHelpers.ChangeImage(BugIdTextBox);
        }
    }
}
