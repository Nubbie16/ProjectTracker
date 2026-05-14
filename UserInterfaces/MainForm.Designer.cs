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
            dataGridView1 = new DataGridView();
            projectNameCol = new DataGridViewTextBoxColumn();
            projectDescriptionCol = new DataGridViewTextBoxColumn();
            languageCol = new DataGridViewTextBoxColumn();
            startDateCol = new DataGridViewTextBoxColumn();
            endDateCol = new DataGridViewTextBoxColumn();
            projectMinutesCol = new DataGridViewTextBoxColumn();
            projectStatusCol = new DataGridViewTextBoxColumn();
            editBtnCol = new DataGridViewButtonColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            proNameLbl = new Label();
            langCBO = new ComboBox();
            minstbLogLbl = new Label();
            minsTXT = new TextBox();
            submitBtn = new Button();
            newProjectBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { projectNameCol, projectDescriptionCol, languageCol, startDateCol, endDateCol, projectMinutesCol, projectStatusCol, editBtnCol });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(800, 334);
            dataGridView1.TabIndex = 0;
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 216F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.Controls.Add(newProjectBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(submitBtn, 5, 0);
            tableLayoutPanel1.Controls.Add(minsTXT, 4, 0);
            tableLayoutPanel1.Controls.Add(minstbLogLbl, 3, 0);
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
            // proNameLbl
            // 
            proNameLbl.Anchor = AnchorStyles.Right;
            proNameLbl.AutoSize = true;
            proNameLbl.Location = new Point(204, 50);
            proNameLbl.Name = "proNameLbl";
            proNameLbl.Size = new Size(82, 15);
            proNameLbl.TabIndex = 0;
            proNameLbl.Text = "Project Name:";
            // 
            // langCBO
            // 
            langCBO.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            langCBO.FormattingEnabled = true;
            langCBO.Location = new Point(292, 46);
            langCBO.Name = "langCBO";
            langCBO.Size = new Size(210, 23);
            langCBO.TabIndex = 12;
            // 
            // minstbLogLbl
            // 
            minstbLogLbl.Anchor = AnchorStyles.Right;
            minstbLogLbl.AutoSize = true;
            minstbLogLbl.Location = new Point(513, 50);
            minstbLogLbl.Name = "minstbLogLbl";
            minstbLogLbl.Size = new Size(126, 15);
            minstbLogLbl.TabIndex = 13;
            minstbLogLbl.Text = "Minutes to be Logged:";
            // 
            // minsTXT
            // 
            minsTXT.Anchor = AnchorStyles.Left;
            minsTXT.Location = new Point(645, 46);
            minsTXT.MaxLength = 1000;
            minsTXT.Name = "minsTXT";
            minsTXT.Size = new Size(45, 23);
            minsTXT.TabIndex = 14;
            // 
            // submitBtn
            // 
            submitBtn.Anchor = AnchorStyles.None;
            submitBtn.Location = new Point(711, 46);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(75, 23);
            submitBtn.TabIndex = 15;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // newProjectBtn
            // 
            newProjectBtn.Anchor = AnchorStyles.None;
            newProjectBtn.Location = new Point(47, 38);
            newProjectBtn.Name = "newProjectBtn";
            newProjectBtn.Size = new Size(85, 39);
            newProjectBtn.TabIndex = 16;
            newProjectBtn.Text = "Add New Project";
            newProjectBtn.UseVisualStyleBackColor = true;
            newProjectBtn.Click += newProjectBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personal Project Tracker";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn projectNameCol;
        private DataGridViewTextBoxColumn projectDescriptionCol;
        private DataGridViewTextBoxColumn languageCol;
        private DataGridViewTextBoxColumn startDateCol;
        private DataGridViewTextBoxColumn endDateCol;
        private DataGridViewTextBoxColumn projectMinutesCol;
        private DataGridViewTextBoxColumn projectStatusCol;
        private DataGridViewButtonColumn editBtnCol;
        private TableLayoutPanel tableLayoutPanel1;
        private Label proNameLbl;
        private Label minstbLogLbl;
        private ComboBox langCBO;
        private TextBox minsTXT;
        private Button submitBtn;
        private Button newProjectBtn;
    }
}
