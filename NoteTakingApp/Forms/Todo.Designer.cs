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
            btnSave = new Button();
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
            // btnSave
            // 
            btnSave.Location = new Point(650, 77);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(495, 77);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(650, 32);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(495, 32);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 18;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 17;
            label3.Text = "DueDate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 56);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 16;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 11);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 15;
            label1.Text = "Title";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(91, 101);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(290, 27);
            dateTimePicker.TabIndex = 14;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(91, 53);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(290, 27);
            txtDescription.TabIndex = 13;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(91, 9);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(290, 27);
            txtTitle.TabIndex = 12;
            // 
            // dgvTasks
            // 
            dgvTasks.BackgroundColor = Color.FromArgb(30, 34, 74);
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.GridColor = Color.FromArgb(32, 34, 72);
            dgvTasks.Location = new Point(1, 154);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.RowTemplate.Height = 29;
            dgvTasks.Size = new Size(798, 288);
            dgvTasks.TabIndex = 11;
            // 
            // Todo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 34, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
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
            Name = "Todo";
            Text = "Todo";
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
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