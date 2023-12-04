namespace WinFormsApp.Forms
{
    partial class AddEditStocks
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
            buttonStockCancel = new Button();
            buttonStockAccept = new Button();
            textBoxStockAddress = new TextBox();
            textBoxStockName = new TextBox();
            labelStockCategory = new Label();
            labelStockAddress = new Label();
            labelStockName = new Label();
            comboBoxCategory = new ComboBox();
            SuspendLayout();
            // 
            // buttonStockCancel
            // 
            buttonStockCancel.Location = new Point(317, 175);
            buttonStockCancel.Name = "buttonStockCancel";
            buttonStockCancel.Size = new Size(96, 31);
            buttonStockCancel.TabIndex = 9;
            buttonStockCancel.Text = "Отмена";
            buttonStockCancel.UseVisualStyleBackColor = true;
            buttonStockCancel.Click += buttonStockCancel_Click;
            // 
            // buttonStockAccept
            // 
            buttonStockAccept.Location = new Point(198, 175);
            buttonStockAccept.Name = "buttonStockAccept";
            buttonStockAccept.Size = new Size(96, 31);
            buttonStockAccept.TabIndex = 10;
            buttonStockAccept.Text = "Доб/Изм";
            buttonStockAccept.UseVisualStyleBackColor = true;
            buttonStockAccept.Click += buttonStockAccept_Click;
            // 
            // textBoxStockAddress
            // 
            textBoxStockAddress.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStockAddress.Location = new Point(176, 120);
            textBoxStockAddress.Name = "textBoxStockAddress";
            textBoxStockAddress.Size = new Size(237, 25);
            textBoxStockAddress.TabIndex = 6;
            // 
            // textBoxStockName
            // 
            textBoxStockName.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStockName.Location = new Point(176, 47);
            textBoxStockName.Name = "textBoxStockName";
            textBoxStockName.Size = new Size(237, 25);
            textBoxStockName.TabIndex = 8;
            // 
            // labelStockCategory
            // 
            labelStockCategory.AutoSize = true;
            labelStockCategory.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelStockCategory.Location = new Point(52, 87);
            labelStockCategory.Name = "labelStockCategory";
            labelStockCategory.Size = new Size(73, 18);
            labelStockCategory.TabIndex = 3;
            labelStockCategory.Text = "Категория";
            // 
            // labelStockAddress
            // 
            labelStockAddress.AutoSize = true;
            labelStockAddress.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelStockAddress.Location = new Point(52, 123);
            labelStockAddress.Name = "labelStockAddress";
            labelStockAddress.Size = new Size(44, 18);
            labelStockAddress.TabIndex = 4;
            labelStockAddress.Text = "Адрес";
            // 
            // labelStockName
            // 
            labelStockName.AutoSize = true;
            labelStockName.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelStockName.Location = new Point(52, 50);
            labelStockName.Name = "labelStockName";
            labelStockName.Size = new Size(103, 18);
            labelStockName.TabIndex = 5;
            labelStockName.Text = "Наименование";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "A", "B", "C", "D" });
            comboBoxCategory.Location = new Point(176, 83);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(81, 26);
            comboBoxCategory.TabIndex = 11;
            // 
            // AddEditStocks
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 235);
            Controls.Add(comboBoxCategory);
            Controls.Add(buttonStockCancel);
            Controls.Add(buttonStockAccept);
            Controls.Add(textBoxStockAddress);
            Controls.Add(textBoxStockName);
            Controls.Add(labelStockCategory);
            Controls.Add(labelStockAddress);
            Controls.Add(labelStockName);
            MaximumSize = new Size(490, 271);
            MinimumSize = new Size(490, 271);
            Name = "AddEditStocks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Склады";
            Load += AddEditStock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStockCancel;
        private Button buttonStockAccept;
        private TextBox textBoxStockAddress;
        private TextBox textBoxStockName;
        private Label labelStockCategory;
        private Label labelStockAddress;
        private Label labelStockName;
        private ComboBox comboBoxCategory;
    }
}