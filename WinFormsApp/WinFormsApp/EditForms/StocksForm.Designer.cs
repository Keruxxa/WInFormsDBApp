namespace WinFormsApp
{
    partial class StocksForm
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
            dataGridStocks = new DataGridView();
            textBoxSearchStocks = new TextBox();
            labelDeleteStock = new Label();
            buttonDeleteStock = new Button();
            labelAddStock = new Label();
            buttonAddStock = new Button();
            labelEditStock = new Label();
            buttonEditStock = new Button();
            btnPrintStocks = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridStocks).BeginInit();
            SuspendLayout();
            // 
            // dataGridStocks
            // 
            dataGridStocks.AllowUserToAddRows = false;
            dataGridStocks.AllowUserToDeleteRows = false;
            dataGridStocks.AllowUserToOrderColumns = true;
            dataGridStocks.AllowUserToResizeColumns = false;
            dataGridStocks.AllowUserToResizeRows = false;
            dataGridStocks.BackgroundColor = SystemColors.ScrollBar;
            dataGridStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStocks.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridStocks.Location = new Point(-1, 67);
            dataGridStocks.Name = "dataGridStocks";
            dataGridStocks.RowTemplate.Height = 25;
            dataGridStocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridStocks.Size = new Size(798, 371);
            dataGridStocks.TabIndex = 9;
            // 
            // textBoxSearchStocks
            // 
            textBoxSearchStocks.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchStocks.Location = new Point(555, 20);
            textBoxSearchStocks.Name = "textBoxSearchStocks";
            textBoxSearchStocks.Size = new Size(229, 25);
            textBoxSearchStocks.TabIndex = 14;
            textBoxSearchStocks.TextChanged += textBoxSearchStocks_TextChanged;
            // 
            // labelDeleteStock
            // 
            labelDeleteStock.AutoSize = true;
            labelDeleteStock.BackColor = Color.Transparent;
            labelDeleteStock.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDeleteStock.Location = new Point(143, 40);
            labelDeleteStock.Name = "labelDeleteStock";
            labelDeleteStock.Size = new Size(59, 18);
            labelDeleteStock.TabIndex = 13;
            labelDeleteStock.Text = "Удалить";
            // 
            // buttonDeleteStock
            // 
            buttonDeleteStock.BackColor = Color.Transparent;
            buttonDeleteStock.FlatAppearance.BorderSize = 0;
            buttonDeleteStock.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            buttonDeleteStock.FlatAppearance.MouseOverBackColor = Color.LightGray;
            buttonDeleteStock.FlatStyle = FlatStyle.Flat;
            buttonDeleteStock.Image = Properties.Resources.remove;
            buttonDeleteStock.ImageAlign = ContentAlignment.TopCenter;
            buttonDeleteStock.Location = new Point(117, 0);
            buttonDeleteStock.Name = "buttonDeleteStock";
            buttonDeleteStock.Size = new Size(110, 65);
            buttonDeleteStock.TabIndex = 12;
            buttonDeleteStock.UseVisualStyleBackColor = false;
            buttonDeleteStock.Click += buttonDeleteStock_Click;
            buttonDeleteStock.MouseDown += buttonDeleteStock_MouseDown;
            buttonDeleteStock.MouseEnter += buttonDeleteStock_MouseEnter;
            buttonDeleteStock.MouseLeave += buttonDeleteStock_MouseLeave;
            buttonDeleteStock.MouseUp += buttonDeleteStock_MouseUp;
            // 
            // labelAddStock
            // 
            labelAddStock.AutoSize = true;
            labelAddStock.BackColor = Color.Transparent;
            labelAddStock.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddStock.Location = new Point(22, 40);
            labelAddStock.Name = "labelAddStock";
            labelAddStock.Size = new Size(69, 18);
            labelAddStock.TabIndex = 11;
            labelAddStock.Text = "Добавить";
            // 
            // buttonAddStock
            // 
            buttonAddStock.BackColor = Color.Transparent;
            buttonAddStock.FlatAppearance.BorderSize = 0;
            buttonAddStock.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            buttonAddStock.FlatAppearance.MouseOverBackColor = Color.LightGray;
            buttonAddStock.FlatStyle = FlatStyle.Flat;
            buttonAddStock.Image = Properties.Resources.addIcon;
            buttonAddStock.ImageAlign = ContentAlignment.TopCenter;
            buttonAddStock.Location = new Point(1, 0);
            buttonAddStock.Name = "buttonAddStock";
            buttonAddStock.Size = new Size(110, 65);
            buttonAddStock.TabIndex = 10;
            buttonAddStock.UseVisualStyleBackColor = false;
            buttonAddStock.Click += buttonAddStock_Click;
            buttonAddStock.MouseDown += buttonAddStock_MouseDown;
            buttonAddStock.MouseEnter += buttonAddStock_MouseEnter;
            buttonAddStock.MouseLeave += buttonAddStock_MouseLeave;
            buttonAddStock.MouseUp += buttonAddStock_MouseUp;
            // 
            // labelEditStock
            // 
            labelEditStock.AutoSize = true;
            labelEditStock.BackColor = Color.Transparent;
            labelEditStock.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditStock.Location = new Point(253, 40);
            labelEditStock.Name = "labelEditStock";
            labelEditStock.Size = new Size(71, 18);
            labelEditStock.TabIndex = 16;
            labelEditStock.Text = "Изменить";
            // 
            // buttonEditStock
            // 
            buttonEditStock.BackColor = Color.Transparent;
            buttonEditStock.FlatAppearance.BorderSize = 0;
            buttonEditStock.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            buttonEditStock.FlatAppearance.MouseOverBackColor = Color.LightGray;
            buttonEditStock.FlatStyle = FlatStyle.Flat;
            buttonEditStock.Image = Properties.Resources.edit;
            buttonEditStock.ImageAlign = ContentAlignment.TopCenter;
            buttonEditStock.Location = new Point(233, 0);
            buttonEditStock.Name = "buttonEditStock";
            buttonEditStock.Size = new Size(110, 65);
            buttonEditStock.TabIndex = 15;
            buttonEditStock.UseVisualStyleBackColor = false;
            buttonEditStock.Click += buttonEditStock_Click;
            buttonEditStock.MouseDown += buttonEditStock_MouseDown;
            buttonEditStock.MouseEnter += buttonEditStock_MouseEnter;
            buttonEditStock.MouseLeave += buttonEditStock_MouseLeave;
            buttonEditStock.MouseUp += buttonEditStock_MouseUp;
            // 
            // btnPrintStocks
            // 
            btnPrintStocks.BackColor = Color.Transparent;
            btnPrintStocks.FlatAppearance.BorderSize = 0;
            btnPrintStocks.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnPrintStocks.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnPrintStocks.FlatStyle = FlatStyle.Flat;
            btnPrintStocks.Image = Properties.Resources.printer;
            btnPrintStocks.ImageAlign = ContentAlignment.TopCenter;
            btnPrintStocks.Location = new Point(501, 12);
            btnPrintStocks.Name = "btnPrintStocks";
            btnPrintStocks.Size = new Size(40, 41);
            btnPrintStocks.TabIndex = 17;
            btnPrintStocks.UseVisualStyleBackColor = false;
            btnPrintStocks.Click += btnPrintStocks_Click;
            // 
            // StocksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 437);
            Controls.Add(btnPrintStocks);
            Controls.Add(labelEditStock);
            Controls.Add(buttonEditStock);
            Controls.Add(textBoxSearchStocks);
            Controls.Add(labelDeleteStock);
            Controls.Add(buttonDeleteStock);
            Controls.Add(labelAddStock);
            Controls.Add(buttonAddStock);
            Controls.Add(dataGridStocks);
            MaximumSize = new Size(812, 473);
            MinimumSize = new Size(812, 473);
            Name = "StocksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Склады";
            FormClosed += StocksForm_FormClosed;
            Load += StocksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridStocks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridStocks;
        private TextBox textBoxSearchStocks;
        private Label labelDeleteStock;
        private Button buttonDeleteStock;
        private Label labelAddStock;
        private Button buttonAddStock;
        private Label labelEditStock;
        private Button buttonEditStock;
        private Button btnPrintStocks;
    }
}