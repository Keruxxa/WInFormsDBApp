namespace WinFormsApp.Forms
{
    partial class MoveGood
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
            buttonAccept = new Button();
            button2 = new Button();
            comboBoxStocks = new ComboBox();
            numeric = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numeric).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 23);
            label1.Name = "label1";
            label1.Size = new Size(190, 18);
            label1.TabIndex = 1;
            label1.Text = "Переместить товар со склада\r\n";
            // 
            // buttonAccept
            // 
            buttonAccept.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAccept.Location = new Point(11, 154);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(107, 31);
            buttonAccept.TabIndex = 2;
            buttonAccept.Text = "Подтвердить";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(124, 154);
            button2.Name = "button2";
            button2.Size = new Size(107, 31);
            button2.TabIndex = 2;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBoxStocks
            // 
            comboBoxStocks.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStocks.FormattingEnabled = true;
            comboBoxStocks.Location = new Point(15, 71);
            comboBoxStocks.Name = "comboBoxStocks";
            comboBoxStocks.Size = new Size(215, 26);
            comboBoxStocks.TabIndex = 3;
            // 
            // numeric
            // 
            numeric.Location = new Point(124, 103);
            numeric.Name = "numeric";
            numeric.Size = new Size(107, 23);
            numeric.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 105);
            label2.Name = "label2";
            label2.Size = new Size(89, 18);
            label2.TabIndex = 5;
            label2.Text = "в количестве";
            // 
            // MoveGood
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 206);
            Controls.Add(label2);
            Controls.Add(numeric);
            Controls.Add(comboBoxStocks);
            Controls.Add(button2);
            Controls.Add(buttonAccept);
            Controls.Add(label1);
            Name = "MoveGood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MoveGood";
            Load += MoveGood_Load;
            ((System.ComponentModel.ISupportInitialize)numeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonAccept;
        private Button button2;
        private ComboBox comboBoxStocks;
        private NumericUpDown numeric;
        private Label label2;
    }
}