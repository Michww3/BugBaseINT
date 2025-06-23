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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isComplitedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugBaseDBDataSet = new BugBase.BugBaseDBDataSet();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
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
            this.bugsTableAdapter = new BugBase.BugBaseDBDataSetTableAdapters.BugsTableAdapter();
            this.employesTableAdapter = new BugBase.BugBaseDBDataSet1TableAdapters.EmployesTableAdapter();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.EmployeFilterTextbox = new System.Windows.Forms.TextBox();
            this.EmployeFilteLabel = new System.Windows.Forms.Label();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.BugIdLabel = new System.Windows.Forms.Label();
            this.BugIdTextBox = new System.Windows.Forms.TextBox();
            this.ChangeImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BugsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugBaseDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugBaseDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
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
            this.BugsDataGrid.AllowDrop = true;
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
            this.BugsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.BugsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.BugsDataGrid.MultiSelect = false;
            this.BugsDataGrid.Name = "BugsDataGrid";
            this.BugsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.BugsDataGrid.Size = new System.Drawing.Size(789, 1017);
            this.BugsDataGrid.TabIndex = 8;
            this.BugsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BugsDataGrid_CellClick);
            this.BugsDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.BugsDataGrid_CellEndEdit);
            this.BugsDataGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BugsDataGrid_CellMouseDown);
            this.BugsDataGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.BugsDataGrid_CellValidating);
            this.BugsDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.BugsDataGrid_CellValueChanged);
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
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // isComplitedDataGridViewCheckBoxColumn
            // 
            this.isComplitedDataGridViewCheckBoxColumn.DataPropertyName = "IsComplited";
            this.isComplitedDataGridViewCheckBoxColumn.HeaderText = "IsComplited";
            this.isComplitedDataGridViewCheckBoxColumn.Name = "isComplitedDataGridViewCheckBoxColumn";
            // 
            // employeIdDataGridViewTextBoxColumn
            // 
            this.employeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeId";
            this.employeIdDataGridViewTextBoxColumn.HeaderText = "EmployeId";
            this.employeIdDataGridViewTextBoxColumn.Name = "employeIdDataGridViewTextBoxColumn";
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
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(836, 932);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(159, 63);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadImageButton.Location = new System.Drawing.Point(798, 553);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(114, 30);
            this.LoadImageButton.TabIndex = 10;
            this.LoadImageButton.Text = "Load image";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(1051, 932);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(150, 63);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
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
            // bugsTableAdapter
            // 
            this.bugsTableAdapter.ClearBeforeFill = true;
            // 
            // employesTableAdapter
            // 
            this.employesTableAdapter.ClearBeforeFill = true;
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePictureBox.Location = new System.Drawing.Point(809, 605);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(418, 241);
            this.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePictureBox.TabIndex = 25;
            this.ImagePictureBox.TabStop = false;
            // 
            // EmployeFilterTextbox
            // 
            this.EmployeFilterTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeFilterTextbox.Location = new System.Drawing.Point(1154, 0);
            this.EmployeFilterTextbox.Name = "EmployeFilterTextbox";
            this.EmployeFilterTextbox.Size = new System.Drawing.Size(100, 20);
            this.EmployeFilterTextbox.TabIndex = 26;
            this.EmployeFilterTextbox.TextChanged += new System.EventHandler(this.TextBoxFilter_TextChanged);
            // 
            // EmployeFilteLabel
            // 
            this.EmployeFilteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeFilteLabel.AutoSize = true;
            this.EmployeFilteLabel.Location = new System.Drawing.Point(1064, 3);
            this.EmployeFilteLabel.Name = "EmployeFilteLabel";
            this.EmployeFilteLabel.Size = new System.Drawing.Size(84, 13);
            this.EmployeFilteLabel.TabIndex = 27;
            this.EmployeFilteLabel.Text = "Search by name";
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadDataButton.Location = new System.Drawing.Point(809, 863);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(159, 63);
            this.LoadDataButton.TabIndex = 28;
            this.LoadDataButton.Text = "Load data";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // BugIdLabel
            // 
            this.BugIdLabel.AutoSize = true;
            this.BugIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BugIdLabel.Location = new System.Drawing.Point(1006, 863);
            this.BugIdLabel.Name = "BugIdLabel";
            this.BugIdLabel.Size = new System.Drawing.Size(54, 20);
            this.BugIdLabel.TabIndex = 29;
            this.BugIdLabel.Text = "Bug id";
            // 
            // BugIdTextBox
            // 
            this.BugIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BugIdTextBox.Location = new System.Drawing.Point(987, 894);
            this.BugIdTextBox.Name = "BugIdTextBox";
            this.BugIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.BugIdTextBox.TabIndex = 30;
            // 
            // ChangeImageButton
            // 
            this.ChangeImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeImageButton.Location = new System.Drawing.Point(1106, 863);
            this.ChangeImageButton.Name = "ChangeImageButton";
            this.ChangeImageButton.Size = new System.Drawing.Size(139, 63);
            this.ChangeImageButton.TabIndex = 31;
            this.ChangeImageButton.Text = "Change image";
            this.ChangeImageButton.UseVisualStyleBackColor = true;
            this.ChangeImageButton.Click += new System.EventHandler(this.ChangeImageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1725, 1017);
            this.Controls.Add(this.ChangeImageButton);
            this.Controls.Add(this.BugIdTextBox);
            this.Controls.Add(this.BugIdLabel);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.EmployeFilteLabel);
            this.Controls.Add(this.EmployeFilterTextbox);
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.EmployeIdTextBox);
            this.Controls.Add(this.EmployeLabel);
            this.Controls.Add(this.EmployesDataGrid);
            this.Controls.Add(this.PriorityComboBox);
            this.Controls.Add(this.PriorityLabel);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BugsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugBaseDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugBaseDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
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
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.ComboBox PriorityComboBox;
        private System.Windows.Forms.DataGridView EmployesDataGrid;
        private System.Windows.Forms.Label EmployeLabel;
        private System.Windows.Forms.TextBox EmployeIdTextBox;
        private BugBaseDBDataSet bugBaseDBDataSet;
        private System.Windows.Forms.BindingSource bugsBindingSource;
        private BugBaseDBDataSetTableAdapters.BugsTableAdapter bugsTableAdapter;
        private BugBaseDBDataSet1 bugBaseDBDataSet1;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private BugBaseDBDataSet1TableAdapters.EmployesTableAdapter employesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.TextBox EmployeFilterTextbox;
        private System.Windows.Forms.Label EmployeFilteLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isComplitedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.Label BugIdLabel;
        private System.Windows.Forms.TextBox BugIdTextBox;
        private System.Windows.Forms.Button ChangeImageButton;
    }
}

