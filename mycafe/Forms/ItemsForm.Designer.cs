namespace mycafe
{
    partial class ItemsForm
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
            UtentiButton = new Button();
            MenuOrdineButton = new Button();
            LogoutLinkLabel = new LinkLabel();
            ItemPanel = new Panel();
            CancellaButton = new Button();
            ModificaButton = new Button();
            PrezzoTextBox = new TextBox();
            PrezzoLabel = new Label();
            NomeTextBox = new TextBox();
            NomeLabel = new Label();
            GestisciArticoliLabel = new Label();
            AggiungiButton = new Button();
            QuitItemLabel = new Label();
            CategoriaLabel = new Label();
            ItemGridView = new DataGridView();
            CategoriaDropDown = new ComboBox();
            quitLabel = new Label();
            ItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemGridView).BeginInit();
            SuspendLayout();
            // 
            // UtentiButton
            // 
            UtentiButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UtentiButton.Cursor = Cursors.Hand;
            UtentiButton.Font = new Font("Garamond", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            UtentiButton.ForeColor = Color.MediumPurple;
            UtentiButton.Location = new Point(21, 168);
            UtentiButton.Name = "UtentiButton";
            UtentiButton.Size = new Size(85, 40);
            UtentiButton.TabIndex = 16;
            UtentiButton.Text = "Utenti";
            UtentiButton.UseVisualStyleBackColor = true;
            UtentiButton.Click += UtentiButton_Click;
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
            MenuOrdineButton.TabIndex = 15;
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
            LogoutLinkLabel.TabIndex = 14;
            LogoutLinkLabel.TabStop = true;
            LogoutLinkLabel.Text = "Logout";
            LogoutLinkLabel.LinkClicked += LogoutLinkLabel_LinkClicked;
            // 
            // ItemPanel
            // 
            ItemPanel.BackColor = Color.White;
            ItemPanel.Controls.Add(CancellaButton);
            ItemPanel.Controls.Add(ModificaButton);
            ItemPanel.Controls.Add(PrezzoTextBox);
            ItemPanel.Controls.Add(PrezzoLabel);
            ItemPanel.Controls.Add(NomeTextBox);
            ItemPanel.Controls.Add(NomeLabel);
            ItemPanel.Controls.Add(GestisciArticoliLabel);
            ItemPanel.Controls.Add(AggiungiButton);
            ItemPanel.Controls.Add(QuitItemLabel);
            ItemPanel.Controls.Add(CategoriaLabel);
            ItemPanel.Controls.Add(ItemGridView);
            ItemPanel.Controls.Add(CategoriaDropDown);
            ItemPanel.Location = new Point(131, 21);
            ItemPanel.Name = "ItemPanel";
            ItemPanel.Size = new Size(1120, 680);
            ItemPanel.TabIndex = 13;
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
            // PrezzoTextBox
            // 
            PrezzoTextBox.Font = new Font("Garamond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            PrezzoTextBox.Location = new Point(159, 306);
            PrezzoTextBox.Name = "PrezzoTextBox";
            PrezzoTextBox.Size = new Size(185, 38);
            PrezzoTextBox.TabIndex = 21;
            // 
            // PrezzoLabel
            // 
            PrezzoLabel.AutoSize = true;
            PrezzoLabel.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PrezzoLabel.ForeColor = Color.MediumPurple;
            PrezzoLabel.Location = new Point(33, 311);
            PrezzoLabel.Name = "PrezzoLabel";
            PrezzoLabel.Size = new Size(76, 27);
            PrezzoLabel.TabIndex = 20;
            PrezzoLabel.Text = "Prezzo";
            PrezzoLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // NomeTextBox
            // 
            NomeTextBox.Font = new Font("Garamond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            NomeTextBox.Location = new Point(159, 251);
            NomeTextBox.Name = "NomeTextBox";
            NomeTextBox.Size = new Size(185, 38);
            NomeTextBox.TabIndex = 19;
            // 
            // NomeLabel
            // 
            NomeLabel.AutoSize = true;
            NomeLabel.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NomeLabel.ForeColor = Color.MediumPurple;
            NomeLabel.Location = new Point(33, 256);
            NomeLabel.Name = "NomeLabel";
            NomeLabel.Size = new Size(72, 27);
            NomeLabel.TabIndex = 18;
            NomeLabel.Text = "Nome";
            NomeLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // GestisciArticoliLabel
            // 
            GestisciArticoliLabel.Anchor = AnchorStyles.Top;
            GestisciArticoliLabel.AutoSize = true;
            GestisciArticoliLabel.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point);
            GestisciArticoliLabel.ForeColor = Color.MediumPurple;
            GestisciArticoliLabel.Location = new Point(461, 9);
            GestisciArticoliLabel.Name = "GestisciArticoliLabel";
            GestisciArticoliLabel.Size = new Size(176, 27);
            GestisciArticoliLabel.TabIndex = 13;
            GestisciArticoliLabel.Text = "Gestisci Articoli";
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
            // CategoriaLabel
            // 
            CategoriaLabel.AutoSize = true;
            CategoriaLabel.BackColor = Color.Transparent;
            CategoriaLabel.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriaLabel.ForeColor = Color.MediumPurple;
            CategoriaLabel.Location = new Point(159, 57);
            CategoriaLabel.Name = "CategoriaLabel";
            CategoriaLabel.Size = new Size(101, 27);
            CategoriaLabel.TabIndex = 6;
            CategoriaLabel.Text = "Categoria";
            CategoriaLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // ItemGridView
            // 
            ItemGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ItemGridView.BackgroundColor = Color.White;
            ItemGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemGridView.EditMode = DataGridViewEditMode.EditOnF2;
            ItemGridView.Location = new Point(461, 74);
            ItemGridView.Name = "ItemGridView";
            ItemGridView.RowHeadersVisible = false;
            ItemGridView.RowTemplate.Height = 25;
            ItemGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemGridView.Size = new Size(608, 547);
            ItemGridView.TabIndex = 4;
            ItemGridView.CellClick += ItemGridView_CellClick;
            ItemGridView.CellContentClick += ItemGridView_CellContentClick;
            // 
            // CategoriaDropDown
            // 
            CategoriaDropDown.BackColor = Color.White;
            CategoriaDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoriaDropDown.Font = new Font("Garamond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriaDropDown.ForeColor = Color.MediumPurple;
            CategoriaDropDown.FormattingEnabled = true;
            CategoriaDropDown.Items.AddRange(new object[] { "Cibi", "Bevande" });
            CategoriaDropDown.Location = new Point(117, 87);
            CategoriaDropDown.Name = "CategoriaDropDown";
            CategoriaDropDown.Size = new Size(185, 38);
            CategoriaDropDown.TabIndex = 3;
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
            quitLabel.TabIndex = 13;
            quitLabel.Text = "X";
            quitLabel.Click += label1_Click;
            // 
            // ItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1280, 720);
            Controls.Add(quitLabel);
            Controls.Add(UtentiButton);
            Controls.Add(MenuOrdineButton);
            Controls.Add(LogoutLinkLabel);
            Controls.Add(ItemPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ItemsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItemsForm";
            ItemPanel.ResumeLayout(false);
            ItemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UtentiButton;
        private Button MenuOrdineButton;
        private LinkLabel LogoutLinkLabel;
        private Panel ItemPanel;
        private Button AggiungiButton;
        private Label CategoriaLabel;
        private ComboBox CategoriaDropDown;
        private Label QuitItemLabel;
        private Label quitLabel;
        private Label GestisciArticoliLabel;
        private DataGridView ItemGridView;
        private Button CancellaButton;
        private Button ModificaButton;
        private TextBox PrezzoTextBox;
        private Label PrezzoLabel;
        private TextBox NomeTextBox;
        private Label NomeLabel;
    }
}