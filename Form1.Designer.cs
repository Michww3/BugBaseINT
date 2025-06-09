namespace BugBase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StatusCheckBox = new System.Windows.Forms.CheckBox();
            this.BugsDataGrid = new System.Windows.Forms.DataGridView();
            this.bugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugBaseDBDataSet = new BugBase.BugBaseDBDataSet();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.PriorityComboBox = new System.Windows.Forms.ComboBox();
            this.bugsTableAdapter = new BugBase.BugBaseDBDataSetTableAdapters.BugsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugBaseDBDataSet1 = new BugBase.BugBaseDBDataSet1();
            this.employesTableAdapter = new BugBase.BugBaseDBDataSet1TableAdapters.EmployesTableAdapter();
            this.EmployeLabel = new System.Windows.Forms.Label();
            this.EmployeIdTextBox = new System.Windows.Forms.TextBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isComplitedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BugsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugBaseDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugBaseDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(795, 22);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(68, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name of bug";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(795, 71);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Description";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(792, 363);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(50, 13);
            this.EndDateLabel.TabIndex = 2;
            this.EndDateLabel.Text = "End date";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(792, 425);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(37, 13);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Status";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(798, 38);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(795, 87);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(396, 197);
            this.DescriptionTextBox.TabIndex = 5;
            this.DescriptionTextBox.Text = "";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(795, 388);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDatePicker.TabIndex = 6;
            // 
            // StatusCheckBox
            // 
            this.StatusCheckBox.Location = new System.Drawing.Point(794, 455);
            this.StatusCheckBox.Name = "StatusCheckBox";
            this.StatusCheckBox.Size = new System.Drawing.Size(104, 24);
            this.StatusCheckBox.TabIndex = 7;
            this.StatusCheckBox.Text = "Is complete?";
            this.StatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // BugsDataGrid
            // 
            this.BugsDataGrid.AutoGenerateColumns = false;
            this.BugsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BugsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BugsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.isComplitedDataGridViewCheckBoxColumn,
            this.employeIdDataGridViewTextBoxColumn});
            this.BugsDataGrid.DataSource = this.bugsBindingSource;
            this.BugsDataGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.BugsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.BugsDataGrid.MultiSelect = false;
            this.BugsDataGrid.Name = "BugsDataGrid";
            this.BugsDataGrid.ReadOnly = true;
            this.BugsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BugsDataGrid.Size = new System.Drawing.Size(789, 1017);
            this.BugsDataGrid.TabIndex = 8;
            // 
            // bugsBindingSource
            // 
            this.bugsBindingSource.DataMember = "Bugs";
            this.bugsBindingSource.DataSource = this.bugBaseDBDataSet;
            // 
            // bugBaseDBDataSet
            // 
            this.bugBaseDBDataSet.DataSetName = "BugBaseDBDataSet";
            this.bugBaseDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(798, 578);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(879, 578);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 10;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(960, 578);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1041, 578);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(1122, 578);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 13;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Location = new System.Drawing.Point(795, 300);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(38, 13);
            this.PriorityLabel.TabIndex = 14;
            this.PriorityLabel.Text = "Priority";
            // 
            // PriorityComboBox
            // 
            this.PriorityComboBox.FormattingEnabled = true;
            this.PriorityComboBox.Items.AddRange(new object[] {
            "low",
            "medium",
            "high"});
            this.PriorityComboBox.Location = new System.Drawing.Point(795, 325);
            this.PriorityComboBox.Name = "PriorityComboBox";
            this.PriorityComboBox.Size = new System.Drawing.Size(121, 21);
            this.PriorityComboBox.TabIndex = 15;
            // 
            // bugsTableAdapter
            // 
            this.bugsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.professionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(1260, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 1017);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // professionDataGridViewTextBoxColumn
            // 
            this.professionDataGridViewTextBoxColumn.DataPropertyName = "Profession";
            this.professionDataGridViewTextBoxColumn.HeaderText = "Profession";
            this.professionDataGridViewTextBoxColumn.Name = "professionDataGridViewTextBoxColumn";
            // 
            // employesBindingSource
            // 
            this.employesBindingSource.DataMember = "Employes";
            this.employesBindingSource.DataSource = this.bugBaseDBDataSet1;
            // 
            // bugBaseDBDataSet1
            // 
            this.bugBaseDBDataSet1.DataSetName = "BugBaseDBDataSet1";
            this.bugBaseDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employesTableAdapter
            // 
            this.employesTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeLabel
            // 
            this.EmployeLabel.AutoSize = true;
            this.EmployeLabel.Location = new System.Drawing.Point(794, 486);
            this.EmployeLabel.Name = "EmployeLabel";
            this.EmployeLabel.Size = new System.Drawing.Size(102, 13);
            this.EmployeLabel.TabIndex = 17;
            this.EmployeLabel.Text = "Add employe from id";
            // 
            // EmployeIdTextBox
            // 
            this.EmployeIdTextBox.Location = new System.Drawing.Point(797, 518);
            this.EmployeIdTextBox.Name = "EmployeIdTextBox";
            this.EmployeIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeIdTextBox.TabIndex = 18;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            this.priorityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isComplitedDataGridViewCheckBoxColumn
            // 
            this.isComplitedDataGridViewCheckBoxColumn.DataPropertyName = "IsComplited";
            this.isComplitedDataGridViewCheckBoxColumn.HeaderText = "IsComplited";
            this.isComplitedDataGridViewCheckBoxColumn.Name = "isComplitedDataGridViewCheckBoxColumn";
            this.isComplitedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // employeIdDataGridViewTextBoxColumn
            // 
            this.employeIdDataGridViewTextBoxColumn.DataPropertyName = "Employe_Id";
            this.employeIdDataGridViewTextBoxColumn.HeaderText = "Employe_Id";
            this.employeIdDataGridViewTextBoxColumn.Name = "employeIdDataGridViewTextBoxColumn";
            this.employeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1725, 1017);
            this.Controls.Add(this.EmployeIdTextBox);
            this.Controls.Add(this.EmployeLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PriorityComboBox);
            this.Controls.Add(this.PriorityLabel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BugsDataGrid);
            this.Controls.Add(this.StatusCheckBox);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BugsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugBaseDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugBaseDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.CheckBox StatusCheckBox;
        private System.Windows.Forms.DataGridView BugsDataGrid;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.ComboBox PriorityComboBox;
        private BugBaseDBDataSet bugBaseDBDataSet;
        private System.Windows.Forms.BindingSource bugsBindingSource;
        private BugBaseDBDataSetTableAdapters.BugsTableAdapter bugsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BugBaseDBDataSet1 bugBaseDBDataSet1;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private BugBaseDBDataSet1TableAdapters.EmployesTableAdapter employesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label EmployeLabel;
        private System.Windows.Forms.TextBox EmployeIdTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isComplitedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeIdDataGridViewTextBoxColumn;
    }
}

