using BugBase.DTOs;
using BugBase.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
//check dataGridView1_CellContentClick
//and add employe and bugs connect
namespace BugBase
{
    public partial class Form1 : Form
    {
        List<Bug> bugs = new List<Bug>();
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

            using (AppDbContext context = new AppDbContext())
            {
                context.Bugs.Add(new Bug(name, description, priority, end, isComplete));
                await context.SaveChangesAsync();
                Form1_Load(sender, e);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
            PriorityComboBox.Text = string.Empty;
            EndDatePicker.Value = DateTime.Now;
            StatusCheckBox.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bugBaseDBDataSet1.Employes' table. You can move, or remove it, as needed.
            this.employesTableAdapter.Fill(this.bugBaseDBDataSet1.Employes);
            // TODO: This line of code loads data into the 'bugBaseDBDataSet.Bugs' table. You can move, or remove it, as needed.
            this.bugsTableAdapter.Fill(this.bugBaseDBDataSet.Bugs);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string value = row.Cells[0].Value?.ToString();
            EmployeIdTextBox.Text = value;
        }
    }
}
