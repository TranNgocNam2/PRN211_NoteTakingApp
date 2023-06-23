namespace NoteTakingApp.Forms
{
    partial class Todo
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
            btnDone = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnNew = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker = new DateTimePicker();
            txtDescription = new TextBox();
            txtTitle = new TextBox();
            dgvTasks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // btnDone
            // 
            btnDone.Anchor = AnchorStyles.Top;
            btnDone.Location = new Point(650, 77);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(94, 29);
            btnDone.TabIndex = 21;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.Location = new Point(495, 77);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top;
            btnEdit.Location = new Point(650, 32);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top;
            btnNew.Location = new Point(495, 32);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 18;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 17;
            label3.Text = "DueDate";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(1, 56);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 16;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(22, 11);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 15;
            label1.Text = "Title";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top;
            dateTimePicker.Location = new Point(91, 101);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(290, 27);
            dateTimePicker.TabIndex = 14;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top;
            txtDescription.Location = new Point(91, 53);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(290, 27);
            txtDescription.TabIndex = 13;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top;
            txtTitle.Location = new Point(91, 9);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(290, 27);
            txtTitle.TabIndex = 12;
            // 
            // dgvTasks
            // 
            dgvTasks.Anchor = AnchorStyles.None;
            dgvTasks.BackgroundColor = Color.FromArgb(30, 34, 74);
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.GridColor = Color.FromArgb(32, 34, 72);
            dgvTasks.Location = new Point(1, 154);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.RowTemplate.Height = 29;
            dgvTasks.Size = new Size(743, 398);
            dgvTasks.TabIndex = 11;
            dgvTasks.CellContentDoubleClick += dgvTasks_CellContentDoubleClick;
            // 
            // Todo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 34, 74);
            ClientSize = new Size(1083, 554);
            Controls.Add(btnDone);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(dgvTasks);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Todo";
            Text = "Todo";
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDone;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnNew;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker;
        private TextBox txtDescription;
        private TextBox txtTitle;
        private DataGridView dgvTasks;
    }
}