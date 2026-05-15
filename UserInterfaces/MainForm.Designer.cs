namespace ProjectTracker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            projectsGV = new DataGridView();
            IDCol = new DataGridViewTextBoxColumn();
            projectNameCol = new DataGridViewTextBoxColumn();
            projectDescriptionCol = new DataGridViewTextBoxColumn();
            languageCol = new DataGridViewTextBoxColumn();
            startDateCol = new DataGridViewTextBoxColumn();
            endDateCol = new DataGridViewTextBoxColumn();
            projectMinutesCol = new DataGridViewTextBoxColumn();
            projectStatusCol = new DataGridViewTextBoxColumn();
            editBtnCol = new DataGridViewButtonColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            newProjectBtn = new Button();
            submitBtn = new Button();
            minutesToLogTXT = new TextBox();
            minsTBLogLbl = new Label();
            projectNameCBO = new ComboBox();
            proNameLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)projectsGV).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // projectsGV
            // 
            projectsGV.AllowUserToAddRows = false;
            projectsGV.AllowUserToDeleteRows = false;
            projectsGV.AllowUserToResizeRows = false;
            projectsGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            projectsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectsGV.Columns.AddRange(new DataGridViewColumn[] { IDCol, projectNameCol, projectDescriptionCol, languageCol, startDateCol, endDateCol, projectMinutesCol, projectStatusCol, editBtnCol });
            tableLayoutPanel1.SetColumnSpan(projectsGV, 8);
            projectsGV.Dock = DockStyle.Fill;
            projectsGV.Location = new Point(3, 3);
            projectsGV.MultiSelect = false;
            projectsGV.Name = "projectsGV";
            projectsGV.RowHeadersVisible = false;
            projectsGV.Size = new Size(999, 351);
            projectsGV.TabIndex = 0;
            projectsGV.CellContentClick += projectsGV_CellContentClick;
            // 
            // IDCol
            // 
            IDCol.HeaderText = "ID";
            IDCol.Name = "IDCol";
            IDCol.ReadOnly = true;
            IDCol.Visible = false;
            // 
            // projectNameCol
            // 
            projectNameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            projectNameCol.HeaderText = "Project Name";
            projectNameCol.MinimumWidth = 100;
            projectNameCol.Name = "projectNameCol";
            projectNameCol.ReadOnly = true;
            projectNameCol.Width = 104;
            // 
            // projectDescriptionCol
            // 
            projectDescriptionCol.HeaderText = "Description";
            projectDescriptionCol.MinimumWidth = 100;
            projectDescriptionCol.Name = "projectDescriptionCol";
            projectDescriptionCol.ReadOnly = true;
            projectDescriptionCol.Resizable = DataGridViewTriState.False;
            // 
            // languageCol
            // 
            languageCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            languageCol.HeaderText = "Language";
            languageCol.Name = "languageCol";
            languageCol.ReadOnly = true;
            languageCol.Width = 84;
            // 
            // startDateCol
            // 
            startDateCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            startDateCol.HeaderText = "Start Date";
            startDateCol.Name = "startDateCol";
            startDateCol.ReadOnly = true;
            startDateCol.Width = 83;
            // 
            // endDateCol
            // 
            endDateCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            endDateCol.HeaderText = "End Date";
            endDateCol.Name = "endDateCol";
            endDateCol.ReadOnly = true;
            endDateCol.Width = 79;
            // 
            // projectMinutesCol
            // 
            projectMinutesCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            projectMinutesCol.HeaderText = "Minutes";
            projectMinutesCol.Name = "projectMinutesCol";
            projectMinutesCol.ReadOnly = true;
            projectMinutesCol.Width = 75;
            // 
            // projectStatusCol
            // 
            projectStatusCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            projectStatusCol.HeaderText = "Status";
            projectStatusCol.Name = "projectStatusCol";
            projectStatusCol.ReadOnly = true;
            projectStatusCol.Width = 64;
            // 
            // editBtnCol
            // 
            editBtnCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            editBtnCol.HeaderText = "View/Edit";
            editBtnCol.MinimumWidth = 70;
            editBtnCol.Name = "editBtnCol";
            editBtnCol.Resizable = DataGridViewTriState.False;
            editBtnCol.Text = "Edit";
            editBtnCol.UseColumnTextForButtonValue = true;
            editBtnCol.Width = 70;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 113F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 184F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 74F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(newProjectBtn, 1, 1);
            tableLayoutPanel1.Controls.Add(projectsGV, 0, 0);
            tableLayoutPanel1.Controls.Add(submitBtn, 6, 1);
            tableLayoutPanel1.Controls.Add(minutesToLogTXT, 5, 1);
            tableLayoutPanel1.Controls.Add(minsTBLogLbl, 4, 1);
            tableLayoutPanel1.Controls.Add(projectNameCBO, 3, 1);
            tableLayoutPanel1.Controls.Add(proNameLbl, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanel1.Size = new Size(1005, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // newProjectBtn
            // 
            newProjectBtn.Anchor = AnchorStyles.None;
            newProjectBtn.Location = new Point(201, 384);
            newProjectBtn.Name = "newProjectBtn";
            newProjectBtn.Size = new Size(84, 39);
            newProjectBtn.TabIndex = 16;
            newProjectBtn.Text = "Add New Project";
            newProjectBtn.UseVisualStyleBackColor = true;
            newProjectBtn.Click += newProjectBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.Anchor = AnchorStyles.None;
            submitBtn.Location = new Point(721, 392);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(90, 23);
            submitBtn.TabIndex = 15;
            submitBtn.Text = "Log Minutes";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // minutesToLogTXT
            // 
            minutesToLogTXT.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            minutesToLogTXT.Location = new Point(666, 392);
            minutesToLogTXT.MaxLength = 1000;
            minutesToLogTXT.Name = "minutesToLogTXT";
            minutesToLogTXT.Size = new Size(45, 23);
            minutesToLogTXT.TabIndex = 14;
            // 
            // minsTBLogLbl
            // 
            minsTBLogLbl.Anchor = AnchorStyles.Right;
            minsTBLogLbl.AutoSize = true;
            minsTBLogLbl.Location = new Point(593, 388);
            minsTBLogLbl.Name = "minsTBLogLbl";
            minsTBLogLbl.Size = new Size(67, 30);
            minsTBLogLbl.TabIndex = 13;
            minsTBLogLbl.Text = "Minutes to be Logged:";
            // 
            // projectNameCBO
            // 
            projectNameCBO.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            projectNameCBO.FormattingEnabled = true;
            projectNameCBO.Location = new Point(408, 392);
            projectNameCBO.Name = "projectNameCBO";
            projectNameCBO.Size = new Size(178, 23);
            projectNameCBO.TabIndex = 12;
            // 
            // proNameLbl
            // 
            proNameLbl.Anchor = AnchorStyles.Right;
            proNameLbl.AutoSize = true;
            proNameLbl.Location = new Point(320, 396);
            proNameLbl.Name = "proNameLbl";
            proNameLbl.Size = new Size(82, 15);
            proNameLbl.TabIndex = 0;
            proNameLbl.Text = "Project Name:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(660, 300);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personal Project Tracker";
            ((System.ComponentModel.ISupportInitialize)projectsGV).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView projectsGV;
        private TableLayoutPanel tableLayoutPanel1;
        private Label proNameLbl;
        private Label minsTBLogLbl;
        private ComboBox projectNameCBO;
        private TextBox minutesToLogTXT;
        private Button submitBtn;
        private Button newProjectBtn;
        private DataGridViewTextBoxColumn IDCol;
        private DataGridViewTextBoxColumn projectNameCol;
        private DataGridViewTextBoxColumn projectDescriptionCol;
        private DataGridViewTextBoxColumn languageCol;
        private DataGridViewTextBoxColumn startDateCol;
        private DataGridViewTextBoxColumn endDateCol;
        private DataGridViewTextBoxColumn projectMinutesCol;
        private DataGridViewTextBoxColumn projectStatusCol;
        private DataGridViewButtonColumn editBtnCol;
    }
}
