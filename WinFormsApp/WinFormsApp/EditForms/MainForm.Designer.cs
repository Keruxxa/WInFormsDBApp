namespace WinFormsApp
{
    partial class MainForm
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
			buttonAddSupply = new Button();
			labelAddSupply = new Label();
			labelGoods = new Label();
			buttonGoods = new Button();
			labelStocks = new Label();
			buttonStocks = new Button();
			labelProviders = new Label();
			button1 = new Button();
			textBoxSearch = new TextBox();
			dataGridSupplies = new DataGridView();
			labelDeleteSupply = new Label();
			buttonDeleteSupply = new Button();
			labelUser = new Label();
			labelSG = new Label();
			button2 = new Button();
			btnPrintSupplies = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridSupplies).BeginInit();
			SuspendLayout();
			// 
			// buttonAddSupply
			// 
			buttonAddSupply.BackColor = Color.Transparent;
			buttonAddSupply.FlatAppearance.BorderSize = 0;
			buttonAddSupply.FlatAppearance.MouseDownBackColor = Color.DarkGray;
			buttonAddSupply.FlatAppearance.MouseOverBackColor = Color.LightGray;
			buttonAddSupply.FlatStyle = FlatStyle.Flat;
			buttonAddSupply.Image = Properties.Resources.addIcon;
			buttonAddSupply.ImageAlign = ContentAlignment.TopCenter;
			buttonAddSupply.Location = new Point(0, 1);
			buttonAddSupply.Name = "buttonAddSupply";
			buttonAddSupply.Size = new Size(134, 57);
			buttonAddSupply.TabIndex = 0;
			buttonAddSupply.UseVisualStyleBackColor = false;
			buttonAddSupply.Click += buttonAddSupply_Click;
			buttonAddSupply.MouseDown += buttonAddSupply_MouseDown;
			buttonAddSupply.MouseEnter += buttonAddSupply_MouseEnter;
			buttonAddSupply.MouseLeave += buttonAddSupply_MouseLeave;
			buttonAddSupply.MouseUp += buttonAddSupply_MouseUp;
			// 
			// labelAddSupply
			// 
			labelAddSupply.BackColor = Color.Transparent;
			labelAddSupply.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelAddSupply.Location = new Point(32, 38);
			labelAddSupply.Name = "labelAddSupply";
			labelAddSupply.Size = new Size(70, 20);
			labelAddSupply.TabIndex = 1;
			labelAddSupply.Text = "Добавить поставку";
			// 
			// labelGoods
			// 
			labelGoods.AutoSize = true;
			labelGoods.BackColor = Color.Transparent;
			labelGoods.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelGoods.Location = new Point(299, 41);
			labelGoods.Name = "labelGoods";
			labelGoods.Size = new Size(57, 16);
			labelGoods.TabIndex = 3;
			labelGoods.Text = "Товары";
			// 
			// buttonGoods
			// 
			buttonGoods.BackColor = Color.Transparent;
			buttonGoods.FlatAppearance.BorderSize = 0;
			buttonGoods.FlatAppearance.MouseDownBackColor = Color.DarkGray;
			buttonGoods.FlatAppearance.MouseOverBackColor = Color.LightGray;
			buttonGoods.FlatStyle = FlatStyle.Flat;
			buttonGoods.Image = Properties.Resources.goods;
			buttonGoods.ImageAlign = ContentAlignment.TopCenter;
			buttonGoods.Location = new Point(277, 1);
			buttonGoods.Name = "buttonGoods";
			buttonGoods.Size = new Size(100, 57);
			buttonGoods.TabIndex = 2;
			buttonGoods.UseVisualStyleBackColor = false;
			buttonGoods.Click += buttonGoods_Click;
			buttonGoods.MouseDown += buttonGoods_MouseDown;
			buttonGoods.MouseEnter += buttonGoods_MouseEnter;
			buttonGoods.MouseLeave += buttonGoods_MouseLeave;
			buttonGoods.MouseUp += buttonGoods_MouseUp;
			// 
			// labelStocks
			// 
			labelStocks.AutoSize = true;
			labelStocks.BackColor = Color.Transparent;
			labelStocks.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelStocks.Location = new Point(405, 41);
			labelStocks.Name = "labelStocks";
			labelStocks.Size = new Size(56, 16);
			labelStocks.TabIndex = 5;
			labelStocks.Text = "Склады";
			// 
			// buttonStocks
			// 
			buttonStocks.BackColor = Color.Transparent;
			buttonStocks.FlatAppearance.BorderSize = 0;
			buttonStocks.FlatAppearance.MouseDownBackColor = Color.DarkGray;
			buttonStocks.FlatAppearance.MouseOverBackColor = Color.LightGray;
			buttonStocks.FlatStyle = FlatStyle.Flat;
			buttonStocks.Image = Properties.Resources.stock;
			buttonStocks.ImageAlign = ContentAlignment.TopCenter;
			buttonStocks.Location = new Point(383, 1);
			buttonStocks.Name = "buttonStocks";
			buttonStocks.Size = new Size(100, 57);
			buttonStocks.TabIndex = 4;
			buttonStocks.UseVisualStyleBackColor = false;
			buttonStocks.Click += buttonStocks_Click;
			buttonStocks.MouseDown += buttonStocks_MouseDown;
			buttonStocks.MouseEnter += buttonStocks_MouseEnter;
			buttonStocks.MouseLeave += buttonStocks_MouseLeave;
			buttonStocks.MouseUp += buttonStocks_MouseUp;
			// 
			// labelProviders
			// 
			labelProviders.AutoSize = true;
			labelProviders.BackColor = Color.Transparent;
			labelProviders.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelProviders.Location = new Point(496, 41);
			labelProviders.Name = "labelProviders";
			labelProviders.Size = new Size(87, 16);
			labelProviders.TabIndex = 7;
			labelProviders.Text = "Поставщики";
			// 
			// button1
			// 
			button1.BackColor = Color.Transparent;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatAppearance.MouseDownBackColor = Color.DarkGray;
			button1.FlatAppearance.MouseOverBackColor = Color.LightGray;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Image = Properties.Resources.provider;
			button1.ImageAlign = ContentAlignment.TopCenter;
			button1.Location = new Point(489, 1);
			button1.Name = "button1";
			button1.Size = new Size(100, 57);
			button1.TabIndex = 6;
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			button1.MouseDown += button1_MouseDown;
			button1.MouseEnter += button1_MouseEnter;
			button1.MouseLeave += button1_MouseLeave;
			button1.MouseUp += button1_MouseUp;
			// 
			// textBoxSearch
			// 
			textBoxSearch.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxSearch.Location = new Point(799, 19);
			textBoxSearch.Name = "textBoxSearch";
			textBoxSearch.Size = new Size(239, 22);
			textBoxSearch.TabIndex = 8;
			textBoxSearch.TextChanged += textBoxSearch_TextChanged;
			// 
			// dataGridSupplies
			// 
			dataGridSupplies.AllowUserToAddRows = false;
			dataGridSupplies.AllowUserToDeleteRows = false;
			dataGridSupplies.AllowUserToResizeColumns = false;
			dataGridSupplies.AllowUserToResizeRows = false;
			dataGridSupplies.BackgroundColor = SystemColors.ScrollBar;
			dataGridSupplies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridSupplies.EditMode = DataGridViewEditMode.EditProgrammatically;
			dataGridSupplies.Location = new Point(-1, 59);
			dataGridSupplies.Name = "dataGridSupplies";
			dataGridSupplies.RowTemplate.Height = 25;
			dataGridSupplies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridSupplies.Size = new Size(1052, 424);
			dataGridSupplies.TabIndex = 9;
			// 
			// labelDeleteSupply
			// 
			labelDeleteSupply.BackColor = Color.Transparent;
			labelDeleteSupply.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelDeleteSupply.Location = new Point(173, 38);
			labelDeleteSupply.Name = "labelDeleteSupply";
			labelDeleteSupply.Size = new Size(65, 20);
			labelDeleteSupply.TabIndex = 11;
			labelDeleteSupply.Text = "Удалить поставку";
			// 
			// buttonDeleteSupply
			// 
			buttonDeleteSupply.BackColor = Color.Transparent;
			buttonDeleteSupply.FlatAppearance.BorderSize = 0;
			buttonDeleteSupply.FlatAppearance.MouseDownBackColor = Color.DarkGray;
			buttonDeleteSupply.FlatAppearance.MouseOverBackColor = Color.LightGray;
			buttonDeleteSupply.FlatStyle = FlatStyle.Flat;
			buttonDeleteSupply.Image = Properties.Resources.remove;
			buttonDeleteSupply.ImageAlign = ContentAlignment.TopCenter;
			buttonDeleteSupply.Location = new Point(140, 1);
			buttonDeleteSupply.Name = "buttonDeleteSupply";
			buttonDeleteSupply.Size = new Size(131, 57);
			buttonDeleteSupply.TabIndex = 10;
			buttonDeleteSupply.UseVisualStyleBackColor = false;
			buttonDeleteSupply.Click += buttonDeleteSupply_Click;
			buttonDeleteSupply.MouseDown += buttonDeleteSupply_MouseDown;
			buttonDeleteSupply.MouseEnter += buttonDeleteSupply_MouseEnter;
			buttonDeleteSupply.MouseLeave += buttonDeleteSupply_MouseLeave;
			buttonDeleteSupply.MouseUp += buttonDeleteSupply_MouseUp;
			// 
			// labelUser
			// 
			labelUser.AutoSize = true;
			labelUser.Location = new Point(797, 44);
			labelUser.Name = "labelUser";
			labelUser.Size = new Size(84, 15);
			labelUser.TabIndex = 12;
			labelUser.Text = "Пользователь";
			// 
			// labelSG
			// 
			labelSG.AutoSize = true;
			labelSG.BackColor = Color.Transparent;
			labelSG.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelSG.Location = new Point(601, 41);
			labelSG.Name = "labelSG";
			labelSG.Size = new Size(131, 16);
			labelSG.TabIndex = 14;
			labelSG.Text = "Товары на складах";
			// 
			// button2
			// 
			button2.BackColor = Color.Transparent;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatAppearance.MouseDownBackColor = Color.DarkGray;
			button2.FlatAppearance.MouseOverBackColor = Color.LightGray;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Image = Properties.Resources.amount;
			button2.ImageAlign = ContentAlignment.TopCenter;
			button2.Location = new Point(595, 1);
			button2.Name = "button2";
			button2.Size = new Size(137, 57);
			button2.TabIndex = 13;
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			button2.MouseDown += button2_MouseDown;
			button2.MouseEnter += button2_MouseEnter;
			button2.MouseLeave += button2_MouseLeave;
			button2.MouseUp += button2_MouseUp;
			// 
			// btnPrintSupplies
			// 
			btnPrintSupplies.BackColor = Color.Transparent;
			btnPrintSupplies.FlatAppearance.BorderSize = 0;
			btnPrintSupplies.FlatAppearance.MouseDownBackColor = Color.DarkGray;
			btnPrintSupplies.FlatAppearance.MouseOverBackColor = Color.LightGray;
			btnPrintSupplies.FlatStyle = FlatStyle.Flat;
			btnPrintSupplies.Image = Properties.Resources.printer;
			btnPrintSupplies.ImageAlign = ContentAlignment.TopCenter;
			btnPrintSupplies.Location = new Point(743, 11);
			btnPrintSupplies.Name = "btnPrintSupplies";
			btnPrintSupplies.Size = new Size(40, 36);
			btnPrintSupplies.TabIndex = 15;
			btnPrintSupplies.UseVisualStyleBackColor = false;
			btnPrintSupplies.Click += btnPrintSupplies_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1050, 479);
			Controls.Add(btnPrintSupplies);
			Controls.Add(labelSG);
			Controls.Add(button2);
			Controls.Add(labelUser);
			Controls.Add(labelDeleteSupply);
			Controls.Add(buttonDeleteSupply);
			Controls.Add(dataGridSupplies);
			Controls.Add(textBoxSearch);
			Controls.Add(labelProviders);
			Controls.Add(button1);
			Controls.Add(labelStocks);
			Controls.Add(buttonStocks);
			Controls.Add(labelGoods);
			Controls.Add(buttonGoods);
			Controls.Add(labelAddSupply);
			Controls.Add(buttonAddSupply);
			MaximumSize = new Size(1066, 518);
			MinimumSize = new Size(1066, 518);
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Учет товаров";
			FormClosed += Form1_FormClosed;
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridSupplies).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonAddSupply;
        private Label labelAddSupply;
        private Label labelGoods;
        private Button buttonGoods;
        private Label labelStocks;
        private Button buttonStocks;
        private Label labelProviders;
        private Button button1;
        private TextBox textBoxSearch;
        private DataGridView dataGridSupplies;
        private Label labelDeleteSupply;
        private Button buttonDeleteSupply;
        private Label labelUser;
        private Label labelSG;
        private Button button2;
        private Button btnPrintSupplies;
    }
}