namespace NoteTakingApp.Authentication.Login
{
    partial class LoginForm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            btnLogin = new Button();
            label2 = new Label();
            btn = new Button();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(202, 102);
            label1.Name = "label1";
            label1.Size = new Size(130, 45);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Login;
            pictureBox2.Location = new Point(115, 157);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Location = new Point(115, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Location = new Point(115, 290);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 1);
            panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Login1;
            pictureBox3.Location = new Point(115, 246);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.System;
            btnLogin.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(115, 354);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(135, 41);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(33, 34, 74);
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(241, 405);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 7;
            label2.Text = "Exit";
            // 
            // btn
            // 
            btn.FlatStyle = FlatStyle.System;
            btn.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn.Location = new Point(284, 354);
            btn.Name = "btn";
            btn.Size = new Size(131, 41);
            btn.TabIndex = 8;
            btn.Text = "SIGN UP";
            btn.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.Location = new Point(177, 176);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(238, 21);
            txtUserName.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(177, 266);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(238, 21);
            txtPassword.TabIndex = 10;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 34, 74);
            ClientSize = new Size(548, 493);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(btn);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = Color.Black;
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Button btnLogin;
        private Label label2;
        private Button btn;
        private TextBox txtUserName;
        private TextBox txtPassword;
    }
}