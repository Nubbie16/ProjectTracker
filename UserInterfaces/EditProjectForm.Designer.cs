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
            descripLbl = new Label();
            nameLBL = new Label();
            nameTXT = new TextBox();
            descripTXT = new TextBox();
            statusLbl = new Label();
            minsLogLbl = new Label();
            langLbl = new Label();
            endDateLbl = new Label();
            startDateLbl = new Label();
            startDateDTP = new DateTimePicker();
            endDTP = new DateTimePicker();
            langCBO = new ComboBox();
            minsLoggedLbl = new Label();
            statusCBP = new ComboBox();
            submitBtn = new Button();
            editLayout.SuspendLayout();
            SuspendLayout();
            // 
            // editLayout
            // 
            editLayout.ColumnCount = 2;
            editLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5460529F));
            editLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.45395F));
            editLayout.Controls.Add(descripLbl, 0, 1);
            editLayout.Controls.Add(nameLBL, 0, 0);
            editLayout.Controls.Add(nameTXT, 1, 0);
            editLayout.Controls.Add(descripTXT, 1, 1);
            editLayout.Controls.Add(statusLbl, 0, 7);
            editLayout.Controls.Add(minsLogLbl, 0, 6);
            editLayout.Controls.Add(langLbl, 0, 5);
            editLayout.Controls.Add(endDateLbl, 0, 4);
            editLayout.Controls.Add(startDateLbl, 0, 3);
            editLayout.Controls.Add(startDateDTP, 1, 3);
            editLayout.Controls.Add(endDTP, 1, 4);
            editLayout.Controls.Add(langCBO, 1, 5);
            editLayout.Controls.Add(minsLoggedLbl, 1, 6);
            editLayout.Controls.Add(statusCBP, 1, 7);
            editLayout.Dock = DockStyle.Top;
            editLayout.Location = new Point(0, 0);
            editLayout.Name = "editLayout";
            editLayout.RowCount = 8;
            editLayout.RowStyles.Add(new RowStyle());
            editLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 13.687151F));
            editLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.3854752F));
            editLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.3854752F));
            editLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.3854752F));
            editLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.2544174F));
            editLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.0141344F));
            editLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.3854752F));
            editLayout.Size = new Size(800, 293);
            editLayout.TabIndex = 0;
            // 
            // descripLbl
            // 
            descripLbl.Anchor = AnchorStyles.Right;
            descripLbl.AutoSize = true;
            descripLbl.Location = new Point(59, 39);
            descripLbl.Name = "descripLbl";
            descripLbl.Size = new Size(110, 15);
            descripLbl.TabIndex = 1;
            descripLbl.Text = "Project Description:";
            // 
            // nameLBL
            // 
            nameLBL.Anchor = AnchorStyles.Right;
            nameLBL.AutoSize = true;
            nameLBL.Location = new Point(87, 7);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(82, 15);
            nameLBL.TabIndex = 0;
            nameLBL.Text = "Project Name:";
            // 
            // nameTXT
            // 
            nameTXT.Anchor = AnchorStyles.Left;
            nameTXT.Location = new Point(175, 3);
            nameTXT.Name = "nameTXT";
            nameTXT.Size = new Size(213, 23);
            nameTXT.TabIndex = 7;
            nameTXT.TextChanged += nameTXT_TextChanged;
            // 
            // descripTXT
            // 
            descripTXT.Anchor = AnchorStyles.Left;
            descripTXT.Location = new Point(175, 32);
            descripTXT.Multiline = true;
            descripTXT.Name = "descripTXT";
            editLayout.SetRowSpan(descripTXT, 2);
            descripTXT.Size = new Size(369, 68);
            descripTXT.TabIndex = 8;
            // 
            // statusLbl
            // 
            statusLbl.Anchor = AnchorStyles.Right;
            statusLbl.AutoSize = true;
            statusLbl.Location = new Point(87, 265);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(82, 15);
            statusLbl.TabIndex = 6;
            statusLbl.Text = "Project Status:";
            // 
            // minsLogLbl
            // 
            minsLogLbl.Anchor = AnchorStyles.Right;
            minsLogLbl.AutoSize = true;
            minsLogLbl.Location = new Point(44, 230);
            minsLogLbl.Name = "minsLogLbl";
            minsLogLbl.Size = new Size(125, 15);
            minsLogLbl.TabIndex = 5;
            minsLogLbl.Text = "Total Minutes Logged:";
            // 
            // langLbl
            // 
            langLbl.Anchor = AnchorStyles.Right;
            langLbl.AutoSize = true;
            langLbl.Location = new Point(30, 193);
            langLbl.Name = "langLbl";
            langLbl.Size = new Size(139, 15);
            langLbl.TabIndex = 4;
            langLbl.Text = "Programming Language:";
            // 
            // endDateLbl
            // 
            endDateLbl.Anchor = AnchorStyles.Right;
            endDateLbl.AutoSize = true;
            endDateLbl.Location = new Point(112, 152);
            endDateLbl.Name = "endDateLbl";
            endDateLbl.Size = new Size(57, 15);
            endDateLbl.TabIndex = 3;
            endDateLbl.Text = "End Date:";
            // 
            // startDateLbl
            // 
            startDateLbl.Anchor = AnchorStyles.Right;
            startDateLbl.AutoSize = true;
            startDateLbl.Location = new Point(108, 114);
            startDateLbl.Name = "startDateLbl";
            startDateLbl.Size = new Size(61, 15);
            startDateLbl.TabIndex = 2;
            startDateLbl.Text = "Start Date:";
            // 
            // startDateDTP
            // 
            startDateDTP.Anchor = AnchorStyles.Left;
            startDateDTP.CustomFormat = "MM/DD/YYYY";
            startDateDTP.Location = new Point(175, 110);
            startDateDTP.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            startDateDTP.Name = "startDateDTP";
            startDateDTP.Size = new Size(213, 23);
            startDateDTP.TabIndex = 9;
            // 
            // endDTP
            // 
            endDTP.Anchor = AnchorStyles.Left;
            endDTP.CustomFormat = "MM/DD/YYYY";
            endDTP.Location = new Point(175, 148);
            endDTP.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            endDTP.Name = "endDTP";
            endDTP.Size = new Size(213, 23);
            endDTP.TabIndex = 10;
            // 
            // langCBO
            // 
            langCBO.Anchor = AnchorStyles.Left;
            langCBO.FormattingEnabled = true;
            langCBO.Location = new Point(175, 189);
            langCBO.Name = "langCBO";
            langCBO.Size = new Size(213, 23);
            langCBO.TabIndex = 11;
            // 
            // minsLoggedLbl
            // 
            minsLoggedLbl.Anchor = AnchorStyles.Left;
            minsLoggedLbl.BackColor = Color.White;
            minsLoggedLbl.Location = new Point(175, 230);
            minsLoggedLbl.Name = "minsLoggedLbl";
            minsLoggedLbl.Size = new Size(67, 15);
            minsLoggedLbl.TabIndex = 12;
            // 
            // statusCBP
            // 
            statusCBP.Anchor = AnchorStyles.Left;
            statusCBP.FormattingEnabled = true;
            statusCBP.Items.AddRange(new object[] { "(Select One)", "Not Started", "In Progress", "On Hold", "Completed", "Abandoned" });
            statusCBP.Location = new Point(175, 261);
            statusCBP.Name = "statusCBP";
            statusCBP.Size = new Size(213, 23);
            statusCBP.TabIndex = 13;
            // 
            // submitBtn
            // 
            submitBtn.Anchor = AnchorStyles.None;
            submitBtn.Location = new Point(175, 299);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(75, 23);
            submitBtn.TabIndex = 16;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            // 
            // EditProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submitBtn);
            Controls.Add(editLayout);
            Name = "EditProjectForm";
            StartPosition = FormStartPosition.CenterScreen;
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
        private DateTimePicker endDTP;
        private ComboBox langCBO;
        private Label minsLoggedLbl;
        private ComboBox statusCBP;
        private Button submitBtn;
    }
}