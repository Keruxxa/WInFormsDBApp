namespace WinFormsApp
{
    partial class AddEditGoods
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxGoodName = new TextBox();
            textBoxGoodCategory = new TextBox();
            textBoxGoodDesc = new TextBox();
            buttonGoodAccept = new Button();
            buttonGoodCancel = new Button();
            numericPrice = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 30);
            label1.Name = "label1";
            label1.Size = new Size(103, 18);
            label1.TabIndex = 0;
            label1.Text = "Наименование";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 103);
            label2.Name = "label2";
            label2.Size = new Size(70, 18);
            label2.TabIndex = 0;
            label2.Text = "Описание";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 66);
            label3.Name = "label3";
            label3.Size = new Size(73, 18);
            label3.TabIndex = 0;
            label3.Text = "Категория";
            // 
            // textBoxGoodName
            // 
            textBoxGoodName.Location = new Point(176, 28);
            textBoxGoodName.Name = "textBoxGoodName";
            textBoxGoodName.Size = new Size(237, 23);
            textBoxGoodName.TabIndex = 1;
            // 
            // textBoxGoodCategory
            // 
            textBoxGoodCategory.Location = new Point(176, 64);
            textBoxGoodCategory.Name = "textBoxGoodCategory";
            textBoxGoodCategory.Size = new Size(237, 23);
            textBoxGoodCategory.TabIndex = 1;
            // 
            // textBoxGoodDesc
            // 
            textBoxGoodDesc.Location = new Point(176, 101);
            textBoxGoodDesc.Name = "textBoxGoodDesc";
            textBoxGoodDesc.Size = new Size(237, 23);
            textBoxGoodDesc.TabIndex = 1;
            // 
            // buttonGoodAccept
            // 
            buttonGoodAccept.Location = new Point(198, 175);
            buttonGoodAccept.Name = "buttonGoodAccept";
            buttonGoodAccept.Size = new Size(96, 31);
            buttonGoodAccept.TabIndex = 2;
            buttonGoodAccept.Text = "Доб/Изм";
            buttonGoodAccept.UseVisualStyleBackColor = true;
            buttonGoodAccept.Click += buttonGoodAccept_Click;
            // 
            // buttonGoodCancel
            // 
            buttonGoodCancel.Location = new Point(317, 175);
            buttonGoodCancel.Name = "buttonGoodCancel";
            buttonGoodCancel.Size = new Size(96, 31);
            buttonGoodCancel.TabIndex = 2;
            buttonGoodCancel.Text = "Отмена";
            buttonGoodCancel.UseVisualStyleBackColor = true;
            buttonGoodCancel.Click += buttonGoodCancel_Click;
            // 
            // numericPrice
            // 
            numericPrice.Location = new Point(176, 137);
            numericPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericPrice.Name = "numericPrice";
            numericPrice.Size = new Size(120, 23);
            numericPrice.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(52, 137);
            label4.Name = "label4";
            label4.Size = new Size(40, 18);
            label4.TabIndex = 0;
            label4.Text = "Цена";
            // 
            // AddEditGoods
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 235);
            Controls.Add(numericPrice);
            Controls.Add(buttonGoodCancel);
            Controls.Add(buttonGoodAccept);
            Controls.Add(textBoxGoodDesc);
            Controls.Add(textBoxGoodCategory);
            Controls.Add(textBoxGoodName);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(490, 271);
            MinimumSize = new Size(490, 271);
            Name = "AddEditGoods";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEdirGoods";
            Load += AddEdirGoodsForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxGoodName;
        private TextBox textBoxGoodCategory;
        private TextBox textBoxGoodDesc;
        private Button buttonGoodAccept;
        private Button buttonGoodCancel;
        private NumericUpDown numericPrice;
        private Label label4;
    }
}