namespace WinFormsApp
{
    partial class AddSupply
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
            comboBoxGoodName = new ComboBox();
            labelGoodName = new Label();
            labelProviderName = new Label();
            comboBoxProviderName = new ComboBox();
            comboBoxStockName = new ComboBox();
            labelStockName = new Label();
            labelGoodAmount = new Label();
            numericGoodAmount = new NumericUpDown();
            buttonCancel = new Button();
            buttonAccept = new Button();
            ((System.ComponentModel.ISupportInitialize)numericGoodAmount).BeginInit();
            SuspendLayout();
            // 
            // comboBoxGoodName
            // 
            comboBoxGoodName.FormattingEnabled = true;
            comboBoxGoodName.Location = new Point(163, 31);
            comboBoxGoodName.Name = "comboBoxGoodName";
            comboBoxGoodName.Size = new Size(194, 25);
            comboBoxGoodName.TabIndex = 0;
            // 
            // labelGoodName
            // 
            labelGoodName.AutoSize = true;
            labelGoodName.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelGoodName.Location = new Point(67, 34);
            labelGoodName.Name = "labelGoodName";
            labelGoodName.Size = new Size(45, 18);
            labelGoodName.TabIndex = 1;
            labelGoodName.Text = "Товар";
            // 
            // labelProviderName
            // 
            labelProviderName.AutoSize = true;
            labelProviderName.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelProviderName.Location = new Point(67, 70);
            labelProviderName.Name = "labelProviderName";
            labelProviderName.Size = new Size(78, 18);
            labelProviderName.TabIndex = 1;
            labelProviderName.Text = "Поставщик";
            // 
            // comboBoxProviderName
            // 
            comboBoxProviderName.FormattingEnabled = true;
            comboBoxProviderName.Location = new Point(163, 67);
            comboBoxProviderName.Name = "comboBoxProviderName";
            comboBoxProviderName.Size = new Size(194, 25);
            comboBoxProviderName.TabIndex = 0;
            // 
            // comboBoxStockName
            // 
            comboBoxStockName.FormattingEnabled = true;
            comboBoxStockName.Location = new Point(163, 103);
            comboBoxStockName.Name = "comboBoxStockName";
            comboBoxStockName.Size = new Size(194, 25);
            comboBoxStockName.TabIndex = 0;
            // 
            // labelStockName
            // 
            labelStockName.AutoSize = true;
            labelStockName.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelStockName.Location = new Point(67, 106);
            labelStockName.Name = "labelStockName";
            labelStockName.Size = new Size(44, 18);
            labelStockName.TabIndex = 1;
            labelStockName.Text = "Склад";
            // 
            // labelGoodAmount
            // 
            labelGoodAmount.AutoSize = true;
            labelGoodAmount.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelGoodAmount.Location = new Point(67, 142);
            labelGoodAmount.Name = "labelGoodAmount";
            labelGoodAmount.Size = new Size(81, 18);
            labelGoodAmount.TabIndex = 1;
            labelGoodAmount.Text = "Количество";
            // 
            // numericGoodAmount
            // 
            numericGoodAmount.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numericGoodAmount.Location = new Point(237, 139);
            numericGoodAmount.Name = "numericGoodAmount";
            numericGoodAmount.Size = new Size(120, 25);
            numericGoodAmount.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(261, 203);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(96, 31);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAccept
            // 
            buttonAccept.Location = new Point(147, 203);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(96, 31);
            buttonAccept.TabIndex = 3;
            buttonAccept.Text = "Добавить";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // AddSupply
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 252);
            Controls.Add(buttonAccept);
            Controls.Add(buttonCancel);
            Controls.Add(numericGoodAmount);
            Controls.Add(labelGoodAmount);
            Controls.Add(labelStockName);
            Controls.Add(labelProviderName);
            Controls.Add(labelGoodName);
            Controls.Add(comboBoxStockName);
            Controls.Add(comboBoxProviderName);
            Controls.Add(comboBoxGoodName);
            MaximumSize = new Size(426, 288);
            MinimumSize = new Size(426, 288);
            Name = "AddSupply";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление поставки";
            ((System.ComponentModel.ISupportInitialize)numericGoodAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGoodName;
        private Label labelGoodName;
        private Label labelProviderName;
        private ComboBox comboBoxProviderName;
        private ComboBox comboBoxStockName;
        private Label labelStockName;
        private Label labelGoodAmount;
        private NumericUpDown numericGoodAmount;
        private Button buttonCancel;
        private Button buttonAccept;
    }
}