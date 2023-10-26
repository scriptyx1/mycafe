namespace mycafe
{
    partial class UsersForm
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
            quitLabel = new Label();
            ArticoliButton = new Button();
            MenuOrdineButton = new Button();
            LogoutLinkLabel = new LinkLabel();
            ItemPanel = new Panel();
            CancellaButton = new Button();
            ModificaButton = new Button();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            PhoneTextBox = new TextBox();
            PhoneLabel = new Label();
            UsernameTextBox = new TextBox();
            UsernameLabel = new Label();
            GestisciUtentiLabel = new Label();
            AggiungiButton = new Button();
            QuitItemLabel = new Label();
            UsersGridView = new DataGridView();
            ItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGridView).BeginInit();
            SuspendLayout();
            // 
            // quitLabel
            // 
            quitLabel.AutoSize = true;
            quitLabel.BackColor = Color.Transparent;
            quitLabel.Cursor = Cursors.Hand;
            quitLabel.Font = new Font("Garamond", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            quitLabel.Location = new Point(1253, 3);
            quitLabel.Name = "quitLabel";
            quitLabel.Size = new Size(25, 24);
            quitLabel.TabIndex = 17;
            quitLabel.Text = "X";
            quitLabel.Click += quitLabel_Click;
            // 
            // ArticoliButton
            // 
            ArticoliButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ArticoliButton.Cursor = Cursors.Hand;
            ArticoliButton.Font = new Font("Garamond", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ArticoliButton.ForeColor = Color.MediumPurple;
            ArticoliButton.Location = new Point(21, 168);
            ArticoliButton.Name = "ArticoliButton";
            ArticoliButton.Size = new Size(85, 40);
            ArticoliButton.TabIndex = 21;
            ArticoliButton.Text = "Articoli";
            ArticoliButton.UseVisualStyleBackColor = true;
            ArticoliButton.Click += ArticoliButton_Click;
            // 
            // MenuOrdineButton
            // 
            MenuOrdineButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MenuOrdineButton.Cursor = Cursors.Hand;
            MenuOrdineButton.Font = new Font("Garamond", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            MenuOrdineButton.ForeColor = Color.MediumPurple;
            MenuOrdineButton.Location = new Point(21, 95);
            MenuOrdineButton.Name = "MenuOrdineButton";
            MenuOrdineButton.Size = new Size(85, 67);
            MenuOrdineButton.TabIndex = 20;
            MenuOrdineButton.Text = "Menu Ordine";
            MenuOrdineButton.UseVisualStyleBackColor = true;
            MenuOrdineButton.Click += MenuOrdineButton_Click;
            // 
            // LogoutLinkLabel
            // 
            LogoutLinkLabel.AutoSize = true;
            LogoutLinkLabel.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutLinkLabel.LinkColor = SystemColors.Control;
            LogoutLinkLabel.Location = new Point(21, 674);
            LogoutLinkLabel.Name = "LogoutLinkLabel";
            LogoutLinkLabel.Size = new Size(80, 27);
            LogoutLinkLabel.TabIndex = 19;
            LogoutLinkLabel.TabStop = true;
            LogoutLinkLabel.Text = "Logout";
            LogoutLinkLabel.LinkClicked += LogoutLinkLabel_LinkClicked;
            // 
            // ItemPanel
            // 
            ItemPanel.BackColor = Color.White;
            ItemPanel.Controls.Add(CancellaButton);
            ItemPanel.Controls.Add(ModificaButton);
            ItemPanel.Controls.Add(PasswordTextBox);
            ItemPanel.Controls.Add(PasswordLabel);
            ItemPanel.Controls.Add(PhoneTextBox);
            ItemPanel.Controls.Add(PhoneLabel);
            ItemPanel.Controls.Add(UsernameTextBox);
            ItemPanel.Controls.Add(UsernameLabel);
            ItemPanel.Controls.Add(GestisciUtentiLabel);
            ItemPanel.Controls.Add(AggiungiButton);
            ItemPanel.Controls.Add(QuitItemLabel);
            ItemPanel.Controls.Add(UsersGridView);
            ItemPanel.Location = new Point(131, 21);
            ItemPanel.Name = "ItemPanel";
            ItemPanel.Size = new Size(1120, 680);
            ItemPanel.TabIndex = 18;
            // 
            // CancellaButton
            // 
            CancellaButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancellaButton.Cursor = Cursors.Hand;
            CancellaButton.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CancellaButton.ForeColor = Color.MediumPurple;
            CancellaButton.Location = new Point(285, 411);
            CancellaButton.Name = "CancellaButton";
            CancellaButton.Size = new Size(109, 40);
            CancellaButton.TabIndex = 23;
            CancellaButton.Text = "Cancella";
            CancellaButton.UseVisualStyleBackColor = true;
            CancellaButton.Click += CancellaButton_Click;
            // 
            // ModificaButton
            // 
            ModificaButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ModificaButton.Cursor = Cursors.Hand;
            ModificaButton.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ModificaButton.ForeColor = Color.MediumPurple;
            ModificaButton.Location = new Point(159, 411);
            ModificaButton.Name = "ModificaButton";
            ModificaButton.Size = new Size(109, 40);
            ModificaButton.TabIndex = 22;
            ModificaButton.Text = "Modifica";
            ModificaButton.UseVisualStyleBackColor = true;
            ModificaButton.Click += ModificaButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Garamond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(159, 306);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(185, 38);
            PasswordTextBox.TabIndex = 21;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.ForeColor = Color.MediumPurple;
            PasswordLabel.Location = new Point(33, 311);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(102, 27);
            PasswordLabel.TabIndex = 20;
            PasswordLabel.Text = "Password";
            PasswordLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Font = new Font("Garamond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneTextBox.Location = new Point(159, 251);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(185, 38);
            PhoneTextBox.TabIndex = 19;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneLabel.ForeColor = Color.MediumPurple;
            PhoneLabel.Location = new Point(33, 256);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(72, 27);
            PhoneLabel.TabIndex = 18;
            PhoneLabel.Text = "Phone";
            PhoneLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Font = new Font("Garamond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTextBox.Location = new Point(159, 195);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(185, 38);
            UsernameTextBox.TabIndex = 17;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLabel.ForeColor = Color.MediumPurple;
            UsernameLabel.Location = new Point(33, 200);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(107, 27);
            UsernameLabel.TabIndex = 16;
            UsernameLabel.Text = "Username";
            UsernameLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // GestisciUtentiLabel
            // 
            GestisciUtentiLabel.Anchor = AnchorStyles.Top;
            GestisciUtentiLabel.AutoSize = true;
            GestisciUtentiLabel.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point);
            GestisciUtentiLabel.ForeColor = Color.MediumPurple;
            GestisciUtentiLabel.Location = new Point(461, 9);
            GestisciUtentiLabel.Name = "GestisciUtentiLabel";
            GestisciUtentiLabel.Size = new Size(165, 27);
            GestisciUtentiLabel.TabIndex = 13;
            GestisciUtentiLabel.Text = "Gestisci Utenti";
            // 
            // AggiungiButton
            // 
            AggiungiButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AggiungiButton.Cursor = Cursors.Hand;
            AggiungiButton.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AggiungiButton.ForeColor = Color.MediumPurple;
            AggiungiButton.Location = new Point(33, 411);
            AggiungiButton.Name = "AggiungiButton";
            AggiungiButton.Size = new Size(109, 40);
            AggiungiButton.TabIndex = 9;
            AggiungiButton.Text = "Aggiungi";
            AggiungiButton.UseVisualStyleBackColor = true;
            AggiungiButton.Click += AggiungiButton_Click;
            // 
            // QuitItemLabel
            // 
            QuitItemLabel.AutoSize = true;
            QuitItemLabel.BackColor = Color.Transparent;
            QuitItemLabel.Cursor = Cursors.Hand;
            QuitItemLabel.Font = new Font("Garamond", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            QuitItemLabel.Location = new Point(1121, -9);
            QuitItemLabel.Name = "QuitItemLabel";
            QuitItemLabel.Size = new Size(25, 24);
            QuitItemLabel.TabIndex = 12;
            QuitItemLabel.Text = "X";
            // 
            // UsersGridView
            // 
            UsersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersGridView.BackgroundColor = Color.White;
            UsersGridView.EditMode = DataGridViewEditMode.EditOnF2;
            UsersGridView.EnableHeadersVisualStyles = false;
            UsersGridView.GridColor = Color.LightSlateGray;
            UsersGridView.Location = new Point(461, 74);
            UsersGridView.Name = "UsersGridView";
            UsersGridView.RowHeadersVisible = false;
            UsersGridView.RowTemplate.Height = 25;
            UsersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersGridView.ShowEditingIcon = false;
            UsersGridView.Size = new Size(608, 547);
            UsersGridView.TabIndex = 4;
            UsersGridView.CellClick += UsersGridView_CellClick;
            UsersGridView.CellContentClick += UsersGridView_CellContentClick;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1280, 720);
            Controls.Add(quitLabel);
            Controls.Add(ArticoliButton);
            Controls.Add(MenuOrdineButton);
            Controls.Add(LogoutLinkLabel);
            Controls.Add(ItemPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsersForm";
            Load += UsersForm_Load;
            ItemPanel.ResumeLayout(false);
            ItemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label quitLabel;
        private Button ArticoliButton;
        private Button MenuOrdineButton;
        private LinkLabel LogoutLinkLabel;
        private Panel ItemPanel;
        private Button CancellaButton;
        private Button ModificaButton;
        private TextBox PasswordTextBox;
        private Label PasswordLabel;
        private TextBox PhoneTextBox;
        private Label PhoneLabel;
        private TextBox UsernameTextBox;
        private Label UsernameLabel;
        private Label GestisciUtentiLabel;
        private Button AggiungiButton;
        private Label QuitItemLabel;
        private DataGridView UsersGridView;
    }
}