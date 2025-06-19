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
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.PriorityComboBox = new System.Windows.Forms.ComboBox();
            this.EmployesDataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugBaseDBDataSet1 = new BugBase.BugBaseDBDataSet1();
            this.EmployeLabel = new System.Windows.Forms.Label();
            this.EmployeIdTextBox = new System.Windows.Forms.TextBox();
            this.BugIdDeleteLabel = new System.Windows.Forms.Label();
            this.DeleteIdTextBox = new System.Windows.Forms.TextBox();
            this.BugIdEditLabel = new System.Windows.Forms.Label();
            this.EditIdTextBox = new System.Windows.Forms.TextBox();
            this.bugsTableAdapter = new BugBase.BugBaseDBDataSetTableAdapters.BugsTableAdapter();
            this.employesTableAdapter = new BugBase.BugBaseDBDataSet1TableAdapters.EmployesTableAdapter();
            this.SaveEditButton = new System.Windows.Forms.Button();
            this.ImageSelectLabel = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isComplitedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BugsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugBaseDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployesDataGrid)).BeginInit();
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
            this.BugsDataGrid.AllowUserToAddRows = false;
            this.BugsDataGrid.AllowUserToDeleteRows = false;
            this.BugsDataGrid.AutoGenerateColumns = false;
            this.BugsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BugsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BugsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
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
            this.BugsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BugsDataGrid_CellClick);
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
            this.SaveButton.Location = new System.Drawing.Point(798, 618);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 49);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(795, 554);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(106, 23);
            this.LoadImageButton.TabIndex = 10;
            this.LoadImageButton.Text = "Load image";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(922, 618);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(82, 49);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(819, 741);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(1012, 741);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 13;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
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
            // EmployesDataGrid
            // 
            this.EmployesDataGrid.AllowUserToAddRows = false;
            this.EmployesDataGrid.AllowUserToDeleteRows = false;
            this.EmployesDataGrid.AutoGenerateColumns = false;
            this.EmployesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.professionDataGridViewTextBoxColumn});
            this.EmployesDataGrid.DataSource = this.employesBindingSource;
            this.EmployesDataGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.EmployesDataGrid.Location = new System.Drawing.Point(1260, 0);
            this.EmployesDataGrid.Name = "EmployesDataGrid";
            this.EmployesDataGrid.Size = new System.Drawing.Size(465, 1017);
            this.EmployesDataGrid.TabIndex = 16;
            this.EmployesDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployesDataGrid_CellClick);
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
            // EmployeLabel
            // 
            this.EmployeLabel.AutoSize = true;
            this.EmployeLabel.Location = new System.Drawing.Point(794, 486);
            this.EmployeLabel.Name = "EmployeLabel";
            this.EmployeLabel.Size = new System.Drawing.Size(59, 13);
            this.EmployeLabel.TabIndex = 17;
            this.EmployeLabel.Text = "Employe Id";
            // 
            // EmployeIdTextBox
            // 
            this.EmployeIdTextBox.Location = new System.Drawing.Point(794, 511);
            this.EmployeIdTextBox.Name = "EmployeIdTextBox";
            this.EmployeIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeIdTextBox.TabIndex = 18;
            // 
            // BugIdDeleteLabel
            // 
            this.BugIdDeleteLabel.AutoSize = true;
            this.BugIdDeleteLabel.Location = new System.Drawing.Point(800, 680);
            this.BugIdDeleteLabel.Name = "BugIdDeleteLabel";
            this.BugIdDeleteLabel.Size = new System.Drawing.Size(108, 13);
            this.BugIdDeleteLabel.TabIndex = 19;
            this.BugIdDeleteLabel.Text = "Enter bug id to delete";
            // 
            // DeleteIdTextBox
            // 
            this.DeleteIdTextBox.Location = new System.Drawing.Point(803, 706);
            this.DeleteIdTextBox.Name = "DeleteIdTextBox";
            this.DeleteIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.DeleteIdTextBox.TabIndex = 20;
            // 
            // BugIdEditLabel
            // 
            this.BugIdEditLabel.AutoSize = true;
            this.BugIdEditLabel.Location = new System.Drawing.Point(1038, 680);
            this.BugIdEditLabel.Name = "BugIdEditLabel";
            this.BugIdEditLabel.Size = new System.Drawing.Size(97, 13);
            this.BugIdEditLabel.TabIndex = 21;
            this.BugIdEditLabel.Text = "Enter bug Id to edit";
            // 
            // EditIdTextBox
            // 
            this.EditIdTextBox.Location = new System.Drawing.Point(1035, 706);
            this.EditIdTextBox.Name = "EditIdTextBox";
            this.EditIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.EditIdTextBox.TabIndex = 22;
            // 
            // bugsTableAdapter
            // 
            this.bugsTableAdapter.ClearBeforeFill = true;
            // 
            // employesTableAdapter
            // 
            this.employesTableAdapter.ClearBeforeFill = true;
            // 
            // SaveEditButton
            // 
            this.SaveEditButton.Location = new System.Drawing.Point(1093, 741);
            this.SaveEditButton.Name = "SaveEditButton";
            this.SaveEditButton.Size = new System.Drawing.Size(75, 23);
            this.SaveEditButton.TabIndex = 23;
            this.SaveEditButton.Text = "Save";
            this.SaveEditButton.UseVisualStyleBackColor = true;
            this.SaveEditButton.Click += new System.EventHandler(this.SaveEditButton_Click);
            // 
            // ImageSelectLabel
            // 
            this.ImageSelectLabel.AutoSize = true;
            this.ImageSelectLabel.Location = new System.Drawing.Point(919, 559);
            this.ImageSelectLabel.Name = "ImageSelectLabel";
            this.ImageSelectLabel.Size = new System.Drawing.Size(85, 13);
            this.ImageSelectLabel.TabIndex = 24;
            this.ImageSelectLabel.Text = "Image not select";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.employeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeId";
            this.employeIdDataGridViewTextBoxColumn.HeaderText = "EmployeId";
            this.employeIdDataGridViewTextBoxColumn.Name = "employeIdDataGridViewTextBoxColumn";
            this.employeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1725, 1017);
            this.Controls.Add(this.ImageSelectLabel);
            this.Controls.Add(this.SaveEditButton);
            this.Controls.Add(this.EditIdTextBox);
            this.Controls.Add(this.BugIdEditLabel);
            this.Controls.Add(this.DeleteIdTextBox);
            this.Controls.Add(this.BugIdDeleteLabel);
            this.Controls.Add(this.EmployeIdTextBox);
            this.Controls.Add(this.EmployeLabel);
            this.Controls.Add(this.EmployesDataGrid);
            this.Controls.Add(this.PriorityComboBox);
            this.Controls.Add(this.PriorityLabel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.LoadImageButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.EmployesDataGrid)).EndInit();
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
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.ComboBox PriorityComboBox;
        private System.Windows.Forms.DataGridView EmployesDataGrid;
        private System.Windows.Forms.Label EmployeLabel;
        private System.Windows.Forms.TextBox EmployeIdTextBox;
        private System.Windows.Forms.Label BugIdDeleteLabel;
        private System.Windows.Forms.TextBox DeleteIdTextBox;
        private System.Windows.Forms.Label BugIdEditLabel;
        private System.Windows.Forms.TextBox EditIdTextBox;
        private BugBaseDBDataSet bugBaseDBDataSet;
        private System.Windows.Forms.BindingSource bugsBindingSource;
        private BugBaseDBDataSetTableAdapters.BugsTableAdapter bugsTableAdapter;
        private BugBaseDBDataSet1 bugBaseDBDataSet1;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private BugBaseDBDataSet1TableAdapters.EmployesTableAdapter employesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SaveEditButton;
        private System.Windows.Forms.Label ImageSelectLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isComplitedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeIdDataGridViewTextBoxColumn;
    }
}

