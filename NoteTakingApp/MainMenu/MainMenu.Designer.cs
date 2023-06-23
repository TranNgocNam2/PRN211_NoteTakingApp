namespace NoteTakingApp.MainMenu
{
    partial class MainMenu
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
            panelMenu = new Panel();
            btnDocs = new FontAwesome.Sharp.IconButton();
            btnTodo = new FontAwesome.Sharp.IconButton();
            btnSearchPage = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            btnLogout = new Button();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(btnDocs);
            panelMenu.Controls.Add(btnTodo);
            panelMenu.Controls.Add(btnSearchPage);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 634);
            panelMenu.TabIndex = 1;
            // 
            // btnDocs
            // 
            btnDocs.Dock = DockStyle.Top;
            btnDocs.FlatAppearance.BorderSize = 0;
            btnDocs.FlatStyle = FlatStyle.Flat;
            btnDocs.ForeColor = Color.Gainsboro;
            btnDocs.IconChar = FontAwesome.Sharp.IconChar.File;
            btnDocs.IconColor = Color.DarkGray;
            btnDocs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDocs.IconSize = 32;
            btnDocs.ImageAlign = ContentAlignment.MiddleLeft;
            btnDocs.Location = new Point(0, 245);
            btnDocs.Name = "btnDocs";
            btnDocs.Padding = new Padding(10, 0, 20, 0);
            btnDocs.Size = new Size(220, 60);
            btnDocs.TabIndex = 3;
            btnDocs.Text = "Docs";
            btnDocs.TextAlign = ContentAlignment.MiddleLeft;
            btnDocs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDocs.UseVisualStyleBackColor = true;
            btnDocs.Click += btnDocs_Click_1;
            // 
            // btnTodo
            // 
            btnTodo.Dock = DockStyle.Top;
            btnTodo.FlatAppearance.BorderSize = 0;
            btnTodo.FlatStyle = FlatStyle.Flat;
            btnTodo.ForeColor = Color.Gainsboro;
            btnTodo.IconChar = FontAwesome.Sharp.IconChar.List;
            btnTodo.IconColor = Color.DarkGray;
            btnTodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTodo.IconSize = 32;
            btnTodo.ImageAlign = ContentAlignment.MiddleLeft;
            btnTodo.Location = new Point(0, 185);
            btnTodo.Name = "btnTodo";
            btnTodo.Padding = new Padding(10, 0, 20, 0);
            btnTodo.Size = new Size(220, 60);
            btnTodo.TabIndex = 2;
            btnTodo.Text = "Todo";
            btnTodo.TextAlign = ContentAlignment.MiddleLeft;
            btnTodo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTodo.UseVisualStyleBackColor = true;
            btnTodo.Click += btnTodo_Click_1;
            // 
            // btnSearchPage
            // 
            btnSearchPage.Dock = DockStyle.Top;
            btnSearchPage.FlatAppearance.BorderSize = 0;
            btnSearchPage.FlatStyle = FlatStyle.Flat;
            btnSearchPage.ForeColor = Color.Gainsboro;
            btnSearchPage.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearchPage.IconColor = Color.DarkGray;
            btnSearchPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearchPage.IconSize = 32;
            btnSearchPage.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchPage.Location = new Point(0, 125);
            btnSearchPage.Name = "btnSearchPage";
            btnSearchPage.Padding = new Padding(10, 0, 20, 0);
            btnSearchPage.Size = new Size(220, 60);
            btnSearchPage.TabIndex = 1;
            btnSearchPage.Text = "Search";
            btnSearchPage.TextAlign = ContentAlignment.MiddleLeft;
            btnSearchPage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchPage.UseVisualStyleBackColor = true;
            btnSearchPage.Click += btnSearchPage_Click_1;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 125);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = Properties.Resources.NOTER_removebg_preview__1_;
            btnHome.Location = new Point(27, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(158, 54);
            btnHome.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click_1;
            // 
            // panelDesktop
            // 
            panelDesktop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDesktop.BackColor = Color.FromArgb(30, 34, 74);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Location = new Point(220, 75);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1233, 681);
            panelDesktop.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.NOTER_removebg_preview__1_;
            pictureBox1.Location = new Point(447, 294);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(26, 25, 62);
            panelTitleBar.Controls.Add(btnLogout);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(995, 75);
            panelTitleBar.TabIndex = 3;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown_1;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Location = new Point(873, 17);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(122, 45);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.ForeColor = Color.Gainsboro;
            lblTitleChildForm.Location = new Point(62, 29);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(50, 20);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(26, 25, 62);
            iconCurrentChildForm.ForeColor = Color.MediumPurple;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.Location = new Point(24, 22);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(32, 32);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 634);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "MainMenu";
            Text = "MainMenu";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDocs;
        private FontAwesome.Sharp.IconButton btnTodo;
        private FontAwesome.Sharp.IconButton btnSearchPage;
        private Panel panelLogo;
        private PictureBox btnHome;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private Panel panelTitleBar;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Button btnLogout;
    }
}