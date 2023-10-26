namespace mycafe.Forms
{
    partial class OrdersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersList));
            ListOfOrderLabel = new Label();
            CloseButton = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ListOrdiniGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ListOrdiniGridView).BeginInit();
            SuspendLayout();
            // 
            // ListOfOrderLabel
            // 
            ListOfOrderLabel.AutoSize = true;
            ListOfOrderLabel.BackColor = Color.Transparent;
            ListOfOrderLabel.Font = new Font("Garamond", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            ListOfOrderLabel.ForeColor = Color.White;
            ListOfOrderLabel.Location = new Point(262, 9);
            ListOfOrderLabel.Name = "ListOfOrderLabel";
            ListOfOrderLabel.Size = new Size(199, 39);
            ListOfOrderLabel.TabIndex = 3;
            ListOfOrderLabel.Text = "Lista Ordini";
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.ForeColor = Color.MediumPurple;
            CloseButton.Location = new Point(262, 1018);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(199, 37);
            CloseButton.TabIndex = 8;
            CloseButton.Text = "Chiudi";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // ListOrdiniGridView
            // 
            ListOrdiniGridView.BackgroundColor = Color.White;
            ListOrdiniGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListOrdiniGridView.Location = new Point(47, 109);
            ListOrdiniGridView.Name = "ListOrdiniGridView";
            ListOrdiniGridView.RowTemplate.Height = 25;
            ListOrdiniGridView.Size = new Size(620, 880);
            ListOrdiniGridView.TabIndex = 9;
            ListOrdiniGridView.CellContentClick += ListOrdiniGridView_CellContentClick;
            // 
            // OrdersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(720, 1080);
            Controls.Add(ListOrdiniGridView);
            Controls.Add(CloseButton);
            Controls.Add(ListOfOrderLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrdersList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrdersList";
            ((System.ComponentModel.ISupportInitialize)ListOrdiniGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ListOfOrderLabel;
        private Button CloseButton;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridView ListOrdiniGridView;
    }
}