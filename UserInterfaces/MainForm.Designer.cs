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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { projectNameCol, projectDescriptionCol, languageCol, startDateCol, endDateCol, projectMinutesCol, projectStatusCol, editBtnCol });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(800, 450);
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
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personal Project Tracker";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}
