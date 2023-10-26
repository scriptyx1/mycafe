namespace mycafe
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            PurplePanel = new Panel();
            QuitLoginLabel = new Label();
            pictureBox1 = new PictureBox();
            MyCafeLabel = new Label();
            UsernameLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            LoginButton = new Button();
            GuestLinkLabel = new LinkLabel();
            PurplePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PurplePanel
            // 
            PurplePanel.BackColor = Color.MediumPurple;
            PurplePanel.Controls.Add(QuitLoginLabel);
            PurplePanel.Controls.Add(pictureBox1);
            PurplePanel.Dock = DockStyle.Right;
            PurplePanel.Location = new Point(500, 0);
            PurplePanel.Name = "PurplePanel";
            PurplePanel.Size = new Size(780, 720);
            PurplePanel.TabIndex = 0;
            // 
            // QuitLoginLabel
            // 
            QuitLoginLabel.AutoSize = true;
            QuitLoginLabel.BackColor = Color.Transparent;
            QuitLoginLabel.Cursor = Cursors.Hand;
            QuitLoginLabel.Font = new Font("Garamond", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            QuitLoginLabel.Location = new Point(753, 3);
            QuitLoginLabel.Name = "QuitLoginLabel";
            QuitLoginLabel.Size = new Size(25, 24);
            QuitLoginLabel.TabIndex = 1;
            QuitLoginLabel.Text = "X";
            QuitLoginLabel.Click += QuitLoginLabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(193, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 414);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MyCafeLabel
            // 
            MyCafeLabel.AutoSize = true;
            MyCafeLabel.Font = new Font("Garamond", 72F, FontStyle.Italic, GraphicsUnit.Point);
            MyCafeLabel.ForeColor = Color.MediumPurple;
            MyCafeLabel.Location = new Point(85, 68);
            MyCafeLabel.Name = "MyCafeLabel";
            MyCafeLabel.Size = new Size(328, 108);
            MyCafeLabel.TabIndex = 1;
            MyCafeLabel.Text = "My Cafe";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Garamond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLabel.ForeColor = Color.MediumPurple;
            UsernameLabel.Location = new Point(36, 284);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(119, 30);
            UsernameLabel.TabIndex = 2;
            UsernameLabel.Text = "Username";
            UsernameLabel.TextAlign = ContentAlignment.BottomCenter;
            UsernameLabel.Click += label2_Click;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Font = new Font("Garamond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTextBox.Location = new Point(203, 281);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(261, 38);
            UsernameTextBox.TabIndex = 3;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Garamond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(203, 337);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(261, 38);
            PasswordTextBox.TabIndex = 5;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Garamond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.ForeColor = Color.MediumPurple;
            PasswordLabel.Location = new Point(36, 340);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(114, 30);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password";
            PasswordLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LoginButton
            // 
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.Font = new Font("Garamond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.MediumPurple;
            LoginButton.Location = new Point(149, 422);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(186, 43);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // GuestLinkLabel
            // 
            GuestLinkLabel.AutoSize = true;
            GuestLinkLabel.Font = new Font("Garamond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            GuestLinkLabel.LinkColor = Color.MediumPurple;
            GuestLinkLabel.Location = new Point(203, 486);
            GuestLinkLabel.Name = "GuestLinkLabel";
            GuestLinkLabel.Size = new Size(76, 30);
            GuestLinkLabel.TabIndex = 7;
            GuestLinkLabel.TabStop = true;
            GuestLinkLabel.Text = "Guest";
            GuestLinkLabel.LinkClicked += GuestLinkLabel_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(LoginButton);
            Controls.Add(GuestLinkLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameTextBox);
            Controls.Add(UsernameLabel);
            Controls.Add(MyCafeLabel);
            Controls.Add(PurplePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Cafe";
            PurplePanel.ResumeLayout(false);
            PurplePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PurplePanel;
        private Label MyCafeLabel;
        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Label PasswordLabel;
        private Button LoginButton;
        private LinkLabel GuestLinkLabel;
        private PictureBox pictureBox1;
        private Label QuitLoginLabel;
    }
}