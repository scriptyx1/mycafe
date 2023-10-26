namespace mycafe
{
    partial class UserOrderForm
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
            CategoriaDropDown = new ComboBox();
            ClienteLabel = new Label();
            ItemGridView = new DataGridView();
            CategoriaLabel = new Label();
            AggiungiCarrelloButton = new Button();
            RiepilogoGridView = new DataGridView();
            OrdinaButton = new Button();
            ItemPanel = new Panel();
            PrezzoTotaleLabel = new Label();
            TotaleLabel = new Label();
            QuantityButton = new Button();
            QuantityTextBox = new TextBox();
            QuantityLabel = new Label();
            RiepilogoLabel = new Label();
            MenuLabel = new Label();
            LogoutLinkLabel = new LinkLabel();
            ArticoliButton = new Button();
            QuitItemLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ItemGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RiepilogoGridView).BeginInit();
            ItemPanel.SuspendLayout();
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
            UtentiButton.TabIndex = 11;
            UtentiButton.Text = "Utenti";
            UtentiButton.UseVisualStyleBackColor = true;
            UtentiButton.Click += UtentiButton_Click;
            // 
            // CategoriaDropDown
            // 
            CategoriaDropDown.BackColor = Color.White;
            CategoriaDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoriaDropDown.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriaDropDown.ForeColor = Color.MediumPurple;
            CategoriaDropDown.FormattingEnabled = true;
            CategoriaDropDown.Items.AddRange(new object[] { "Cibi", "Bevande" });
            CategoriaDropDown.Location = new Point(950, 84);
            CategoriaDropDown.Name = "CategoriaDropDown";
            CategoriaDropDown.Size = new Size(148, 35);
            CategoriaDropDown.TabIndex = 3;
            CategoriaDropDown.DropDown += CategoriaDropDown_DropDown;
            CategoriaDropDown.SelectedIndexChanged += CategoriaDropDown_SelectedIndexChanged;
            // 
            // ClienteLabel
            // 
            ClienteLabel.AutoSize = true;
            ClienteLabel.BackColor = Color.Transparent;
            ClienteLabel.Font = new Font("Garamond", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            ClienteLabel.ForeColor = Color.MediumPurple;
            ClienteLabel.Location = new Point(0, 0);
            ClienteLabel.Name = "ClienteLabel";
            ClienteLabel.Size = new Size(216, 39);
            ClienteLabel.TabIndex = 2;
            ClienteLabel.Text = "NomeCliente";
            // 
            // ItemGridView
            // 
            ItemGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ItemGridView.BackgroundColor = Color.White;
            ItemGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemGridView.EditMode = DataGridViewEditMode.EditOnF2;
            ItemGridView.Location = new Point(54, 74);
            ItemGridView.Name = "ItemGridView";
            ItemGridView.RowHeadersVisible = false;
            ItemGridView.RowTemplate.Height = 25;
            ItemGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemGridView.Size = new Size(766, 247);
            ItemGridView.TabIndex = 4;
            // 
            // CategoriaLabel
            // 
            CategoriaLabel.AutoSize = true;
            CategoriaLabel.BackColor = Color.Transparent;
            CategoriaLabel.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriaLabel.ForeColor = Color.MediumPurple;
            CategoriaLabel.Location = new Point(843, 87);
            CategoriaLabel.Name = "CategoriaLabel";
            CategoriaLabel.Size = new Size(101, 27);
            CategoriaLabel.TabIndex = 6;
            CategoriaLabel.Text = "Categoria";
            CategoriaLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // AggiungiCarrelloButton
            // 
            AggiungiCarrelloButton.AutoSize = true;
            AggiungiCarrelloButton.Cursor = Cursors.Hand;
            AggiungiCarrelloButton.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AggiungiCarrelloButton.ForeColor = Color.MediumPurple;
            AggiungiCarrelloButton.Location = new Point(869, 279);
            AggiungiCarrelloButton.Name = "AggiungiCarrelloButton";
            AggiungiCarrelloButton.Size = new Size(210, 42);
            AggiungiCarrelloButton.TabIndex = 7;
            AggiungiCarrelloButton.Text = "Aggiungi al Carrello";
            AggiungiCarrelloButton.UseVisualStyleBackColor = true;
            AggiungiCarrelloButton.Click += AggiungiCarrelloButton_Click;
            // 
            // RiepilogoGridView
            // 
            RiepilogoGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RiepilogoGridView.BackgroundColor = Color.White;
            RiepilogoGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RiepilogoGridView.Location = new Point(56, 405);
            RiepilogoGridView.Name = "RiepilogoGridView";
            RiepilogoGridView.RowHeadersVisible = false;
            RiepilogoGridView.RowTemplate.Height = 25;
            RiepilogoGridView.Size = new Size(766, 262);
            RiepilogoGridView.TabIndex = 8;
            // 
            // OrdinaButton
            // 
            OrdinaButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            OrdinaButton.Cursor = Cursors.Hand;
            OrdinaButton.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            OrdinaButton.ForeColor = Color.MediumPurple;
            OrdinaButton.Location = new Point(921, 523);
            OrdinaButton.Name = "OrdinaButton";
            OrdinaButton.Size = new Size(117, 47);
            OrdinaButton.TabIndex = 9;
            OrdinaButton.Text = "Ordina";
            OrdinaButton.UseVisualStyleBackColor = true;
            OrdinaButton.Click += OrdinaButton_Click;
            // 
            // ItemPanel
            // 
            ItemPanel.BackColor = Color.White;
            ItemPanel.Controls.Add(PrezzoTotaleLabel);
            ItemPanel.Controls.Add(TotaleLabel);
            ItemPanel.Controls.Add(QuantityButton);
            ItemPanel.Controls.Add(QuantityTextBox);
            ItemPanel.Controls.Add(QuantityLabel);
            ItemPanel.Controls.Add(RiepilogoLabel);
            ItemPanel.Controls.Add(MenuLabel);
            ItemPanel.Controls.Add(OrdinaButton);
            ItemPanel.Controls.Add(RiepilogoGridView);
            ItemPanel.Controls.Add(AggiungiCarrelloButton);
            ItemPanel.Controls.Add(CategoriaLabel);
            ItemPanel.Controls.Add(ItemGridView);
            ItemPanel.Controls.Add(ClienteLabel);
            ItemPanel.Controls.Add(CategoriaDropDown);
            ItemPanel.Location = new Point(129, 21);
            ItemPanel.Name = "ItemPanel";
            ItemPanel.Size = new Size(1120, 680);
            ItemPanel.TabIndex = 3;
            ItemPanel.Paint += ItemPanel_Paint;
            // 
            // PrezzoTotaleLabel
            // 
            PrezzoTotaleLabel.AutoSize = true;
            PrezzoTotaleLabel.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PrezzoTotaleLabel.ForeColor = Color.MediumPurple;
            PrezzoTotaleLabel.Location = new Point(1015, 474);
            PrezzoTotaleLabel.Name = "PrezzoTotaleLabel";
            PrezzoTotaleLabel.Size = new Size(23, 27);
            PrezzoTotaleLabel.TabIndex = 23;
            PrezzoTotaleLabel.Text = "0";
            // 
            // TotaleLabel
            // 
            TotaleLabel.AutoSize = true;
            TotaleLabel.BackColor = Color.White;
            TotaleLabel.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TotaleLabel.ForeColor = Color.MediumPurple;
            TotaleLabel.Location = new Point(905, 474);
            TotaleLabel.Name = "TotaleLabel";
            TotaleLabel.Size = new Size(89, 27);
            TotaleLabel.TabIndex = 22;
            TotaleLabel.Text = "Totale €";
            // 
            // QuantityButton
            // 
            QuantityButton.BackColor = Color.White;
            QuantityButton.FlatStyle = FlatStyle.System;
            QuantityButton.Font = new Font("Garamond", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityButton.ForeColor = Color.MediumPurple;
            QuantityButton.Location = new Point(950, 160);
            QuantityButton.Name = "QuantityButton";
            QuantityButton.Size = new Size(38, 34);
            QuantityButton.TabIndex = 21;
            QuantityButton.Text = "+1";
            QuantityButton.UseVisualStyleBackColor = false;
            QuantityButton.Click += QuantityButton_Click;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityTextBox.ForeColor = Color.MediumPurple;
            QuantityTextBox.Location = new Point(1010, 160);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(88, 34);
            QuantityTextBox.TabIndex = 20;
            QuantityTextBox.Text = "0";
            QuantityTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.BackColor = Color.Transparent;
            QuantityLabel.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityLabel.ForeColor = Color.MediumPurple;
            QuantityLabel.Location = new Point(843, 163);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(95, 27);
            QuantityLabel.TabIndex = 16;
            QuantityLabel.Text = "Quantità";
            QuantityLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // RiepilogoLabel
            // 
            RiepilogoLabel.AutoSize = true;
            RiepilogoLabel.BackColor = Color.Transparent;
            RiepilogoLabel.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RiepilogoLabel.ForeColor = Color.MediumPurple;
            RiepilogoLabel.Location = new Point(386, 375);
            RiepilogoLabel.Name = "RiepilogoLabel";
            RiepilogoLabel.Size = new Size(102, 27);
            RiepilogoLabel.TabIndex = 15;
            RiepilogoLabel.Text = "Riepilogo";
            RiepilogoLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // MenuLabel
            // 
            MenuLabel.Anchor = AnchorStyles.Top;
            MenuLabel.AutoSize = true;
            MenuLabel.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point);
            MenuLabel.ForeColor = Color.MediumPurple;
            MenuLabel.Location = new Point(461, 9);
            MenuLabel.Name = "MenuLabel";
            MenuLabel.Size = new Size(158, 27);
            MenuLabel.TabIndex = 14;
            MenuLabel.Text = "Ordine Utente";
            // 
            // LogoutLinkLabel
            // 
            LogoutLinkLabel.AutoSize = true;
            LogoutLinkLabel.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutLinkLabel.LinkColor = SystemColors.Control;
            LogoutLinkLabel.Location = new Point(21, 674);
            LogoutLinkLabel.Name = "LogoutLinkLabel";
            LogoutLinkLabel.Size = new Size(80, 27);
            LogoutLinkLabel.TabIndex = 4;
            LogoutLinkLabel.TabStop = true;
            LogoutLinkLabel.Text = "Logout";
            LogoutLinkLabel.LinkClicked += LogoutLinkLabel_LinkClicked;
            // 
            // ArticoliButton
            // 
            ArticoliButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ArticoliButton.Cursor = Cursors.Hand;
            ArticoliButton.Font = new Font("Garamond", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ArticoliButton.ForeColor = Color.MediumPurple;
            ArticoliButton.Location = new Point(21, 95);
            ArticoliButton.Name = "ArticoliButton";
            ArticoliButton.Size = new Size(85, 40);
            ArticoliButton.TabIndex = 10;
            ArticoliButton.Text = "Articoli";
            ArticoliButton.UseVisualStyleBackColor = true;
            ArticoliButton.Click += ArticoliButton_Click;
            // 
            // QuitItemLabel
            // 
            QuitItemLabel.AutoSize = true;
            QuitItemLabel.BackColor = Color.Transparent;
            QuitItemLabel.Cursor = Cursors.Hand;
            QuitItemLabel.Font = new Font("Garamond", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            QuitItemLabel.Location = new Point(1253, 3);
            QuitItemLabel.Name = "QuitItemLabel";
            QuitItemLabel.Size = new Size(25, 24);
            QuitItemLabel.TabIndex = 2;
            QuitItemLabel.Text = "X";
            QuitItemLabel.Click += QuitItemLabel_Click;
            // 
            // UserOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1280, 720);
            Controls.Add(UtentiButton);
            Controls.Add(ArticoliButton);
            Controls.Add(QuitItemLabel);
            Controls.Add(LogoutLinkLabel);
            Controls.Add(ItemPanel);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserOrderForm";
            ((System.ComponentModel.ISupportInitialize)ItemGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)RiepilogoGridView).EndInit();
            ItemPanel.ResumeLayout(false);
            ItemPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UtentiButton;
        private ComboBox CategoriaDropDown;
        private Label ClienteLabel;
        private DataGridView ItemGridView;
        private Label CategoriaLabel;
        private Button AggiungiCarrelloButton;
        private DataGridView RiepilogoGridView;
        private Button OrdinaButton;
        private Panel ItemPanel;
        private LinkLabel LogoutLinkLabel;
        private Button ArticoliButton;
        private Label QuitItemLabel;
        private Label MenuLabel;
        private Label RiepilogoLabel;
        private Label QuantityLabel;
        private Button QuantityButton;
        private TextBox QuantityTextBox;
        private Label PrezzoTotaleLabel;
        private Label TotaleLabel;
    }
}