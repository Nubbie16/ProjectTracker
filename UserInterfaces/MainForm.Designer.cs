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
            minsTXT = new TextBox();
            minsTBLogLbl = new Label();
            langCBO = new ComboBox();
            proNameLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)projectsGV).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // projectsGV
            // 
            projectsGV.AllowUserToAddRows = false;
            projectsGV.AllowUserToDeleteRows = false;
            projectsGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            projectsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectsGV.Columns.AddRange(new DataGridViewColumn[] { IDCol, projectNameCol, projectDescriptionCol, languageCol, startDateCol, endDateCol, projectMinutesCol, projectStatusCol, editBtnCol });
            projectsGV.Dock = DockStyle.Top;
            projectsGV.Location = new Point(0, 0);
            projectsGV.Name = "projectsGV";
            projectsGV.RowHeadersVisible = false;
            projectsGV.Size = new Size(800, 334);
            projectsGV.TabIndex = 0;
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
            projectNameCol.HeaderText = "Project Name";
            projectNameCol.Name = "projectNameCol";
            projectNameCol.ReadOnly = true;
            // 
            // projectDescriptionCol
            // 
            projectDescriptionCol.HeaderText = "Description";
            projectDescriptionCol.Name = "projectDescriptionCol";
            projectDescriptionCol.ReadOnly = true;
            // 
            // languageCol
            // 
            languageCol.HeaderText = "Language";
            languageCol.Name = "languageCol";
            languageCol.ReadOnly = true;
            // 
            // startDateCol
            // 
            startDateCol.HeaderText = "Start Date";
            startDateCol.Name = "startDateCol";
            startDateCol.ReadOnly = true;
            // 
            // endDateCol
            // 
            endDateCol.HeaderText = "End Date";
            endDateCol.Name = "endDateCol";
            endDateCol.ReadOnly = true;
            // 
            // projectMinutesCol
            // 
            projectMinutesCol.HeaderText = "Minutes";
            projectMinutesCol.Name = "projectMinutesCol";
            projectMinutesCol.ReadOnly = true;
            // 
            // projectStatusCol
            // 
            projectStatusCol.HeaderText = "Status";
            projectStatusCol.Name = "projectStatusCol";
            projectStatusCol.ReadOnly = true;
            // 
            // editBtnCol
            // 
            editBtnCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            editBtnCol.HeaderText = "Edit/View";
            editBtnCol.Name = "editBtnCol";
            editBtnCol.Text = "";
            editBtnCol.UseColumnTextForButtonValue = true;
            editBtnCol.Width = 63;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.9377174F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.0622826F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 209F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127F));
            tableLayoutPanel1.Controls.Add(newProjectBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(submitBtn, 5, 0);
            tableLayoutPanel1.Controls.Add(minsTXT, 4, 0);
            tableLayoutPanel1.Controls.Add(minsTBLogLbl, 3, 0);
            tableLayoutPanel1.Controls.Add(langCBO, 2, 0);
            tableLayoutPanel1.Controls.Add(proNameLbl, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 334);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 116);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // newProjectBtn
            // 
            newProjectBtn.Anchor = AnchorStyles.None;
            newProjectBtn.Location = new Point(38, 38);
            newProjectBtn.Name = "newProjectBtn";
            newProjectBtn.Size = new Size(85, 39);
            newProjectBtn.TabIndex = 16;
            newProjectBtn.Text = "Add New Project";
            newProjectBtn.UseVisualStyleBackColor = true;
            newProjectBtn.Click += newProjectBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.Anchor = AnchorStyles.None;
            submitBtn.Location = new Point(691, 46);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(90, 23);
            submitBtn.TabIndex = 15;
            submitBtn.Text = "Log Minutes";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // minsTXT
            // 
            minsTXT.Anchor = AnchorStyles.Left;
            minsTXT.Location = new Point(615, 46);
            minsTXT.MaxLength = 1000;
            minsTXT.Name = "minsTXT";
            minsTXT.Size = new Size(45, 23);
            minsTXT.TabIndex = 14;
            // 
            // minsTBLogLbl
            // 
            minsTBLogLbl.Anchor = AnchorStyles.Right;
            minsTBLogLbl.AutoSize = true;
            minsTBLogLbl.Location = new Point(483, 50);
            minsTBLogLbl.Name = "minsTBLogLbl";
            minsTBLogLbl.Size = new Size(126, 15);
            minsTBLogLbl.TabIndex = 13;
            minsTBLogLbl.Text = "Minutes to be Logged:";
            // 
            // langCBO
            // 
            langCBO.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            langCBO.FormattingEnabled = true;
            langCBO.Location = new Point(264, 46);
            langCBO.Name = "langCBO";
            langCBO.Size = new Size(203, 23);
            langCBO.TabIndex = 12;
            // 
            // proNameLbl
            // 
            proNameLbl.Anchor = AnchorStyles.Right;
            proNameLbl.AutoSize = true;
            proNameLbl.Location = new Point(176, 50);
            proNameLbl.Name = "proNameLbl";
            proNameLbl.Size = new Size(82, 15);
            proNameLbl.TabIndex = 0;
            proNameLbl.Text = "Project Name:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(projectsGV);
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
        private ComboBox langCBO;
        private TextBox minsTXT;
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
