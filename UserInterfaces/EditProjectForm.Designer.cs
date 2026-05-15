namespace ProjectTracker.UserInterfaces
{
    partial class EditProjectForm
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
            editLayout = new TableLayoutPanel();
            cancelBtn = new Button();
            descripLbl = new Label();
            submitBtn = new Button();
            nameLBL = new Label();
            nameTXT = new TextBox();
            langCBO = new ComboBox();
            descripTXT = new TextBox();
            langLbl = new Label();
            minsLogLbl = new Label();
            minsLoggedLbl = new Label();
            startDateDTP = new DateTimePicker();
            startDateLbl = new Label();
            endDateLbl = new Label();
            endDateDTP = new DateTimePicker();
            statusLbl = new Label();
            statusCBO = new ComboBox();
            editLayout.SuspendLayout();
            SuspendLayout();
            // 
            // editLayout
            // 
            editLayout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editLayout.ColumnCount = 6;
            editLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            editLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            editLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 239F));
            editLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            editLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 221F));
            editLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            editLayout.Controls.Add(cancelBtn, 2, 7);
            editLayout.Controls.Add(descripLbl, 1, 1);
            editLayout.Controls.Add(submitBtn, 1, 7);
            editLayout.Controls.Add(nameLBL, 1, 0);
            editLayout.Controls.Add(nameTXT, 2, 0);
            editLayout.Controls.Add(langCBO, 2, 3);
            editLayout.Controls.Add(descripTXT, 2, 1);
            editLayout.Controls.Add(langLbl, 1, 3);
            editLayout.Controls.Add(minsLogLbl, 1, 6);
            editLayout.Controls.Add(minsLoggedLbl, 2, 6);
            editLayout.Controls.Add(startDateDTP, 2, 4);
            editLayout.Controls.Add(startDateLbl, 1, 4);
            editLayout.Controls.Add(endDateLbl, 3, 4);
            editLayout.Controls.Add(endDateDTP, 4, 4);
            editLayout.Controls.Add(statusLbl, 1, 5);
            editLayout.Controls.Add(statusCBO, 2, 5);
            editLayout.Location = new Point(0, 0);
            editLayout.Name = "editLayout";
            editLayout.RowCount = 8;
            editLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4319983F));
            editLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4319983F));
            editLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5378523F));
            editLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5378523F));
            editLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5378523F));
            editLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4319983F));
            editLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.545228F));
            editLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.545228F));
            editLayout.Size = new Size(800, 293);
            editLayout.TabIndex = 0;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Left;
            cancelBtn.Location = new Point(215, 261);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 17;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // descripLbl
            // 
            descripLbl.Anchor = AnchorStyles.Right;
            descripLbl.AutoSize = true;
            descripLbl.Location = new Point(99, 46);
            descripLbl.Name = "descripLbl";
            descripLbl.Size = new Size(110, 15);
            descripLbl.TabIndex = 1;
            descripLbl.Text = "Project Description:";
            // 
            // submitBtn
            // 
            submitBtn.Anchor = AnchorStyles.Right;
            submitBtn.Location = new Point(134, 261);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(75, 23);
            submitBtn.TabIndex = 16;
            submitBtn.Text = "Save";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // nameLBL
            // 
            nameLBL.Anchor = AnchorStyles.Right;
            nameLBL.AutoSize = true;
            nameLBL.Location = new Point(127, 10);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(82, 15);
            nameLBL.TabIndex = 0;
            nameLBL.Text = "Project Name:";
            // 
            // nameTXT
            // 
            nameTXT.Anchor = AnchorStyles.Left;
            nameTXT.Location = new Point(215, 6);
            nameTXT.Name = "nameTXT";
            nameTXT.Size = new Size(213, 23);
            nameTXT.TabIndex = 7;
            nameTXT.TextChanged += nameTXT_TextChanged;
            // 
            // langCBO
            // 
            langCBO.Anchor = AnchorStyles.Left;
            langCBO.FormattingEnabled = true;
            langCBO.Items.AddRange(new object[] { "C", "C++", "C#", "Dart", "Go", "Java", "JavaScript", "Kotlin", "PHP", "Python", "Ruby", "Rust", "SQL", "Swift", "TypeScript" });
            langCBO.Location = new Point(215, 114);
            langCBO.Name = "langCBO";
            langCBO.Size = new Size(213, 23);
            langCBO.TabIndex = 11;
            // 
            // descripTXT
            // 
            descripTXT.Anchor = AnchorStyles.Left;
            descripTXT.Location = new Point(215, 39);
            descripTXT.Multiline = true;
            descripTXT.Name = "descripTXT";
            editLayout.SetRowSpan(descripTXT, 2);
            descripTXT.ScrollBars = ScrollBars.Vertical;
            descripTXT.Size = new Size(213, 66);
            descripTXT.TabIndex = 8;
            // 
            // langLbl
            // 
            langLbl.Anchor = AnchorStyles.Right;
            langLbl.AutoSize = true;
            langLbl.Location = new Point(70, 118);
            langLbl.Name = "langLbl";
            langLbl.Size = new Size(139, 15);
            langLbl.TabIndex = 4;
            langLbl.Text = "Programming Language:";
            // 
            // minsLogLbl
            // 
            minsLogLbl.Anchor = AnchorStyles.Right;
            minsLogLbl.AutoSize = true;
            minsLogLbl.Location = new Point(84, 226);
            minsLogLbl.Name = "minsLogLbl";
            minsLogLbl.Size = new Size(125, 15);
            minsLogLbl.TabIndex = 5;
            minsLogLbl.Text = "Total Minutes Logged:";
            // 
            // minsLoggedLbl
            // 
            minsLoggedLbl.Anchor = AnchorStyles.Left;
            minsLoggedLbl.BackColor = SystemColors.Control;
            minsLoggedLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minsLoggedLbl.Location = new Point(215, 226);
            minsLoggedLbl.Name = "minsLoggedLbl";
            minsLoggedLbl.Size = new Size(45, 15);
            minsLoggedLbl.TabIndex = 12;
            minsLoggedLbl.Text = "0";
            // 
            // startDateDTP
            // 
            startDateDTP.Anchor = AnchorStyles.Left;
            startDateDTP.CustomFormat = "MM/DD/YYYY";
            startDateDTP.Location = new Point(215, 150);
            startDateDTP.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            startDateDTP.Name = "startDateDTP";
            startDateDTP.Size = new Size(213, 23);
            startDateDTP.TabIndex = 9;
            // 
            // startDateLbl
            // 
            startDateLbl.Anchor = AnchorStyles.Right;
            startDateLbl.AutoSize = true;
            startDateLbl.Location = new Point(148, 154);
            startDateLbl.Name = "startDateLbl";
            startDateLbl.Size = new Size(61, 15);
            startDateLbl.TabIndex = 2;
            startDateLbl.Text = "Start Date:";
            // 
            // endDateLbl
            // 
            endDateLbl.Anchor = AnchorStyles.Right;
            endDateLbl.AutoSize = true;
            endDateLbl.Location = new Point(456, 154);
            endDateLbl.Name = "endDateLbl";
            endDateLbl.Size = new Size(57, 15);
            endDateLbl.TabIndex = 3;
            endDateLbl.Text = "End Date:";
            // 
            // endDateDTP
            // 
            endDateDTP.Anchor = AnchorStyles.Left;
            endDateDTP.CustomFormat = "MM/DD/YYYY";
            endDateDTP.Location = new Point(519, 150);
            endDateDTP.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            endDateDTP.Name = "endDateDTP";
            endDateDTP.Size = new Size(210, 23);
            endDateDTP.TabIndex = 10;
            // 
            // statusLbl
            // 
            statusLbl.Anchor = AnchorStyles.Right;
            statusLbl.AutoSize = true;
            statusLbl.Location = new Point(127, 190);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(82, 15);
            statusLbl.TabIndex = 6;
            statusLbl.Text = "Project Status:";
            // 
            // statusCBO
            // 
            statusCBO.Anchor = AnchorStyles.Left;
            statusCBO.FormattingEnabled = true;
            statusCBO.Items.AddRange(new object[] { "Not Started", "In Progress", "On Hold", "Completed", "Abandoned" });
            statusCBO.Location = new Point(215, 186);
            statusCBO.Name = "statusCBO";
            statusCBO.Size = new Size(213, 23);
            statusCBO.TabIndex = 13;
            statusCBO.SelectedIndexChanged += statusCBO_SelectedIndexChanged;
            // 
            // EditProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 327);
            Controls.Add(editLayout);
            MaximizeBox = false;
            MinimumSize = new Size(691, 331);
            Name = "EditProjectForm";
            StartPosition = FormStartPosition.CenterParent;
            Tag = "";
            Text = "Project Name";
            editLayout.ResumeLayout(false);
            editLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel editLayout;
        private Label nameLBL;
        private Label descripLbl;
        private Label startDateLbl;
        private Label endDateLbl;
        private Label langLbl;
        private Label minsLogLbl;
        private Label statusLbl;
        private TextBox nameTXT;
        private TextBox descripTXT;
        private DateTimePicker startDateDTP;
        private DateTimePicker endDateDTP;
        private ComboBox langCBO;
        private Label minsLoggedLbl;
        private ComboBox statusCBO;
        private Button submitBtn;
        private Button cancelBtn;
    }
}