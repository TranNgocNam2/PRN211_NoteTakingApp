﻿namespace NoteTakingApp.Forms
{
    partial class NoteEditor
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
            txtContent = new RichTextBox();
            label1 = new Label();
            txtTitle = new TextBox();
            btnApply = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtContent
            // 
            txtContent.Location = new Point(12, 67);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(776, 299);
            txtContent.TabIndex = 0;
            txtContent.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 32);
            label1.TabIndex = 1;
            label1.Text = "Title :";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(92, 18);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(696, 23);
            txtTitle.TabIndex = 2;
            // 
            // btnApply
            // 
            btnApply.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnApply.Location = new Point(538, 383);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(108, 55);
            btnApply.TabIndex = 3;
            btnApply.Text = "APPLY";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(680, 383);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(108, 55);
            btnExit.TabIndex = 4;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // NoteEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnApply);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(txtContent);
            Name = "NoteEditor";
            Text = "NoteEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtContent;
        private Label label1;
        private TextBox txtTitle;
        private Button btnApply;
        private Button btnExit;
    }
}