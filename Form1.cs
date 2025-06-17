using BugBase.DTOs;
using BugBase.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BugBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name must be select");
                return;
            }
            string description = DescriptionTextBox.Text;
            if (String.IsNullOrEmpty(description))
            {
                MessageBox.Show("Description must be select");
                return;
            }
            string priority = PriorityComboBox.Text;
            if (String.IsNullOrEmpty(priority))
            {
                MessageBox.Show("Priority must be select");
                return;
            }
            DateTime end = EndDatePicker.Value;
            bool isComplete = StatusCheckBox.Checked;

            if (!int.TryParse(EmployeIdTextBox.Text, out int employeId))
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
                context.Bugs.Add(new Bug(name, description, priority, end, isComplete, employeId));
                await context.SaveChangesAsync();
                Form1_Load(sender, e);
                ClearButton_Click(sender, e);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
            PriorityComboBox.Text = string.Empty;
            EndDatePicker.Value = DateTime.Now;
            StatusCheckBox.Checked = false;
            EmployeIdTextBox.Text = string.Empty;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IdTextBox.Text))
            {
                MessageBox.Show("Enter Id");
                return;
            }
            if (!int.TryParse(IdTextBox.Text, out int bugId))
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

                MessageBox.Show("Deleting complete");
                Form1_Load(sender, e);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(BugEditIdTextBox.Text))
            {
                MessageBox.Show("Enter Id");
                return;
            }
            if (!int.TryParse(BugEditIdTextBox.Text, out int Id))
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
                NameTextBox.Text = bug.Name;
                DescriptionTextBox.Text = bug.Description;
                PriorityComboBox.Text = bug.Priority;
                EndDatePicker.Value = bug.EndDate;
                StatusCheckBox.Checked = bug.IsComplited;
                EmployeIdTextBox.Text = bug.EmployeId.ToString();
            }

        }

        private void SaveEditButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(BugEditIdTextBox.Text))
            {
                MessageBox.Show("Enter Id");
                return;
            }
            if (!int.TryParse(BugEditIdTextBox.Text, out int Id))
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
                bug.Name = NameTextBox.Text;
                bug.Description = DescriptionTextBox.Text;
                bug.Priority = PriorityComboBox.Text;
                bug.EndDate = EndDatePicker.Value;
                bug.IsComplited = StatusCheckBox.Checked;
                if (!int.TryParse(EmployeIdTextBox.Text, out int employeId))
                {
                    MessageBox.Show("Incorrect employe Id");
                    return;
                }
                bug.EmployeId = employeId;
                context.SaveChanges();
                Form1_Load(sender,e);
            }
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
    }
}
