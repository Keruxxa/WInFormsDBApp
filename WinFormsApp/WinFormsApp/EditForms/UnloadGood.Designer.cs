namespace WinFormsApp.Forms
{
    partial class UnloadGood
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
            numeric = new NumericUpDown();
            buttonCalcel = new Button();
            buttonAccept = new Button();
            ((System.ComponentModel.ISupportInitialize)numeric).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 34);
            label1.Name = "label1";
            label1.Size = new Size(173, 18);
            label1.TabIndex = 0;
            label1.Text = "Отгрузить товар со склада\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 89);
            label2.Name = "label2";
            label2.Size = new Size(89, 18);
            label2.TabIndex = 9;
            label2.Text = "в количестве";
            // 
            // numeric
            // 
            numeric.Location = new Point(137, 87);
            numeric.Name = "numeric";
            numeric.Size = new Size(107, 23);
            numeric.TabIndex = 8;
            // 
            // buttonCalcel
            // 
            buttonCalcel.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalcel.Location = new Point(137, 138);
            buttonCalcel.Name = "buttonCalcel";
            buttonCalcel.Size = new Size(107, 31);
            buttonCalcel.TabIndex = 6;
            buttonCalcel.Text = "Отмена";
            buttonCalcel.UseVisualStyleBackColor = true;
            buttonCalcel.Click += buttonCalcel_Click;
            // 
            // buttonAccept
            // 
            buttonAccept.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAccept.Location = new Point(24, 138);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(107, 31);
            buttonAccept.TabIndex = 7;
            buttonAccept.Text = "Подтвердить";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // UnloadGood
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 206);
            Controls.Add(label2);
            Controls.Add(numeric);
            Controls.Add(buttonCalcel);
            Controls.Add(buttonAccept);
            Controls.Add(label1);
            MinimumSize = new Size(258, 242);
            Name = "UnloadGood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Отгрузить товар";
            FormClosed += UnloadGood_FormClosed;
            Load += UnloadGood_Load;
            ((System.ComponentModel.ISupportInitialize)numeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numeric;
        private Button buttonCalcel;
        private Button buttonAccept;
    }
}