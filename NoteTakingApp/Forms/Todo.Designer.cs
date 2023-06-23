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
            btnDone.Location = new Point(569, 58);
            btnDone.Margin = new Padding(3, 2, 3, 2);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(82, 22);
            btnDone.TabIndex = 21;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.Location = new Point(433, 58);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top;
            btnEdit.Location = new Point(569, 24);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 22);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top;
            btnNew.Location = new Point(433, 24);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 22);
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
            label3.Location = new Point(10, 80);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 17;
            label3.Text = "DueDate";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(1, 42);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 16;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(19, 8);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 15;
            label1.Text = "Title";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top;
            dateTimePicker.Location = new Point(80, 76);
            dateTimePicker.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(254, 23);
            dateTimePicker.TabIndex = 14;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top;
            txtDescription.Location = new Point(80, 40);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(254, 23);
            txtDescription.TabIndex = 13;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top;
            txtTitle.Location = new Point(80, 7);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(254, 23);
            txtTitle.TabIndex = 12;
            // 
            // dgvTasks
            // 
            dgvTasks.Anchor = AnchorStyles.None;
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.BackgroundColor = Color.FromArgb(30, 34, 74);
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.GridColor = Color.FromArgb(32, 34, 72);
            dgvTasks.Location = new Point(1, 116);
            dgvTasks.Margin = new Padding(3, 2, 3, 2);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.ReadOnly = true;
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.RowTemplate.Height = 29;
            dgvTasks.Size = new Size(650, 298);
            dgvTasks.TabIndex = 11;
            dgvTasks.CellContentDoubleClick += dgvTasks_CellContentDoubleClick;
            // 
            // Todo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 34, 74);
            ClientSize = new Size(948, 416);
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
            Margin = new Padding(3, 2, 3, 2);
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