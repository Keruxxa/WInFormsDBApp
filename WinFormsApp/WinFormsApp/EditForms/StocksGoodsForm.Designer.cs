namespace WinFormsApp
{
    partial class StocksGoodsForm
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
            dataGridSG = new DataGridView();
            textBoxSearch = new TextBox();
            labelSum = new Label();
            labelMove = new Label();
            labelUnload = new Label();
            buttonMove = new Button();
            unloadGood = new Button();
            btnPrintSG = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridSG).BeginInit();
            SuspendLayout();
            // 
            // dataGridSG
            // 
            dataGridSG.AllowUserToAddRows = false;
            dataGridSG.AllowUserToDeleteRows = false;
            dataGridSG.AllowUserToResizeColumns = false;
            dataGridSG.AllowUserToResizeRows = false;
            dataGridSG.BackgroundColor = SystemColors.ScrollBar;
            dataGridSG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSG.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridSG.Location = new Point(-1, 69);
            dataGridSG.Name = "dataGridSG";
            dataGridSG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridSG.RowTemplate.Height = 25;
            dataGridSG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSG.Size = new Size(920, 318);
            dataGridSG.TabIndex = 4;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(677, 22);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(229, 25);
            textBoxSearch.TabIndex = 10;
            textBoxSearch.TextChanged += textBoxSearchGoods_TextChanged;
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelSum.Location = new Point(4, 390);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(179, 18);
            labelSum.TabIndex = 11;
            labelSum.Text = "Сумма товаров на складах: ";
            // 
            // labelMove
            // 
            labelMove.AutoSize = true;
            labelMove.BackColor = Color.Transparent;
            labelMove.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMove.Location = new Point(120, 42);
            labelMove.Name = "labelMove";
            labelMove.Size = new Size(129, 18);
            labelMove.TabIndex = 14;
            labelMove.Text = "Переместить товар";
            // 
            // labelUnload
            // 
            labelUnload.AutoSize = true;
            labelUnload.BackColor = Color.Transparent;
            labelUnload.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelUnload.Location = new Point(0, 42);
            labelUnload.Name = "labelUnload";
            labelUnload.Size = new Size(112, 18);
            labelUnload.TabIndex = 15;
            labelUnload.Text = "Отгрузить товар";
            // 
            // buttonMove
            // 
            buttonMove.BackColor = Color.Transparent;
            buttonMove.FlatAppearance.BorderSize = 0;
            buttonMove.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            buttonMove.FlatAppearance.MouseOverBackColor = Color.LightGray;
            buttonMove.FlatStyle = FlatStyle.Flat;
            buttonMove.Image = Properties.Resources.move;
            buttonMove.ImageAlign = ContentAlignment.TopCenter;
            buttonMove.Location = new Point(120, 2);
            buttonMove.Name = "buttonMove";
            buttonMove.Size = new Size(129, 65);
            buttonMove.TabIndex = 12;
            buttonMove.UseVisualStyleBackColor = false;
            buttonMove.Click += buttonMove_Click;
            buttonMove.MouseDown += buttonMove_MouseDown;
            buttonMove.MouseEnter += buttonMove_MouseEnter;
            buttonMove.MouseLeave += buttonMove_MouseLeave;
            buttonMove.MouseUp += buttonMove_MouseUp;
            // 
            // unloadGood
            // 
            unloadGood.BackColor = Color.Transparent;
            unloadGood.FlatAppearance.BorderSize = 0;
            unloadGood.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            unloadGood.FlatAppearance.MouseOverBackColor = Color.LightGray;
            unloadGood.FlatStyle = FlatStyle.Flat;
            unloadGood.Image = Properties.Resources.unload;
            unloadGood.ImageAlign = ContentAlignment.TopCenter;
            unloadGood.Location = new Point(-1, 2);
            unloadGood.Name = "unloadGood";
            unloadGood.Size = new Size(115, 65);
            unloadGood.TabIndex = 13;
            unloadGood.UseVisualStyleBackColor = false;
            unloadGood.Click += unloadGood_Click;
            unloadGood.MouseDown += unloadGood_MouseDown;
            unloadGood.MouseEnter += unloadGood_MouseEnter;
            unloadGood.MouseLeave += unloadGood_MouseLeave;
            unloadGood.MouseUp += unloadGood_MouseUp;
            // 
            // btnPrintSG
            // 
            btnPrintSG.BackColor = Color.Transparent;
            btnPrintSG.FlatAppearance.BorderSize = 0;
            btnPrintSG.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnPrintSG.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnPrintSG.FlatStyle = FlatStyle.Flat;
            btnPrintSG.Image = Properties.Resources.printer;
            btnPrintSG.ImageAlign = ContentAlignment.TopCenter;
            btnPrintSG.Location = new Point(622, 14);
            btnPrintSG.Name = "btnPrintSG";
            btnPrintSG.Size = new Size(40, 41);
            btnPrintSG.TabIndex = 16;
            btnPrintSG.UseVisualStyleBackColor = false;
            btnPrintSG.Click += btnPrintSG_Click;
            // 
            // StocksGoodsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 419);
            Controls.Add(btnPrintSG);
            Controls.Add(labelMove);
            Controls.Add(labelUnload);
            Controls.Add(buttonMove);
            Controls.Add(unloadGood);
            Controls.Add(labelSum);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridSG);
            MaximumSize = new Size(934, 455);
            MinimumSize = new Size(934, 455);
            Name = "StocksGoodsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Товары на складах";
            FormClosed += StocksGoodsForm_FormClosed;
            Load += StocksGoodsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridSG;
        private TextBox textBoxSearch;
        private Label labelSum;
        private Label labelMove;
        private Label labelUnload;
        private Button buttonMove;
        private Button unloadGood;
        private Button btnPrintSG;
    }
}