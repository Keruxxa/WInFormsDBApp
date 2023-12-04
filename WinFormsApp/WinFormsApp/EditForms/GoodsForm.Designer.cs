namespace WinFormsApp
{
    public partial class GoodsForm : Form
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
            labelAddGoods = new Label();
            buttonAddGood = new Button();
            labelDeleteGoods = new Label();
            buttonDeleteGood = new Button();
            dataGridGoods = new DataGridView();
            textBoxSearchGoods = new TextBox();
            buttonEditGood = new Button();
            labelEditGoods = new Label();
            btnPrintGoods = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridGoods).BeginInit();
            SuspendLayout();
            // 
            // labelAddGoods
            // 
            labelAddGoods.AutoSize = true;
            labelAddGoods.BackColor = Color.Transparent;
            labelAddGoods.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddGoods.Location = new Point(22, 40);
            labelAddGoods.Name = "labelAddGoods";
            labelAddGoods.Size = new Size(69, 18);
            labelAddGoods.TabIndex = 5;
            labelAddGoods.Text = "Добавить";
            // 
            // buttonAddGood
            // 
            buttonAddGood.BackColor = Color.Transparent;
            buttonAddGood.FlatAppearance.BorderSize = 0;
            buttonAddGood.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            buttonAddGood.FlatAppearance.MouseOverBackColor = Color.LightGray;
            buttonAddGood.FlatStyle = FlatStyle.Flat;
            buttonAddGood.Image = Properties.Resources.addIcon;
            buttonAddGood.ImageAlign = ContentAlignment.TopCenter;
            buttonAddGood.Location = new Point(1, 0);
            buttonAddGood.Name = "buttonAddGood";
            buttonAddGood.Size = new Size(110, 65);
            buttonAddGood.TabIndex = 4;
            buttonAddGood.UseVisualStyleBackColor = false;
            buttonAddGood.Click += buttonAddGood_Click;
            buttonAddGood.MouseDown += buttonAddGood_MouseDown;
            buttonAddGood.MouseEnter += buttonAddGood_MouseEnter;
            buttonAddGood.MouseLeave += buttonAddGood_MouseLeave;
            buttonAddGood.MouseUp += buttonAddGood_MouseUp;
            // 
            // labelDeleteGoods
            // 
            labelDeleteGoods.AutoSize = true;
            labelDeleteGoods.BackColor = Color.Transparent;
            labelDeleteGoods.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDeleteGoods.Location = new Point(143, 40);
            labelDeleteGoods.Name = "labelDeleteGoods";
            labelDeleteGoods.Size = new Size(59, 18);
            labelDeleteGoods.TabIndex = 7;
            labelDeleteGoods.Text = "Удалить";
            // 
            // buttonDeleteGood
            // 
            buttonDeleteGood.BackColor = Color.Transparent;
            buttonDeleteGood.FlatAppearance.BorderSize = 0;
            buttonDeleteGood.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            buttonDeleteGood.FlatAppearance.MouseOverBackColor = Color.LightGray;
            buttonDeleteGood.FlatStyle = FlatStyle.Flat;
            buttonDeleteGood.Image = Properties.Resources.remove;
            buttonDeleteGood.ImageAlign = ContentAlignment.TopCenter;
            buttonDeleteGood.Location = new Point(117, 0);
            buttonDeleteGood.Name = "buttonDeleteGood";
            buttonDeleteGood.Size = new Size(110, 65);
            buttonDeleteGood.TabIndex = 6;
            buttonDeleteGood.UseVisualStyleBackColor = false;
            buttonDeleteGood.Click += buttonDeleteGood_Click;
            buttonDeleteGood.MouseDown += buttonDeleteGood_MouseDown;
            buttonDeleteGood.MouseEnter += buttonDeleteGood_MouseEnter;
            buttonDeleteGood.MouseLeave += buttonDeleteGood_MouseLeave;
            buttonDeleteGood.MouseUp += buttonDeleteGood_MouseUp;
            // 
            // dataGridGoods
            // 
            dataGridGoods.AllowUserToAddRows = false;
            dataGridGoods.AllowUserToDeleteRows = false;
            dataGridGoods.AllowUserToOrderColumns = true;
            dataGridGoods.AllowUserToResizeColumns = false;
            dataGridGoods.AllowUserToResizeRows = false;
            dataGridGoods.BackgroundColor = SystemColors.ScrollBar;
            dataGridGoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridGoods.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridGoods.Location = new Point(-1, 67);
            dataGridGoods.Name = "dataGridGoods";
            dataGridGoods.RowTemplate.Height = 25;
            dataGridGoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridGoods.Size = new Size(798, 371);
            dataGridGoods.TabIndex = 8;
            // 
            // textBoxSearchGoods
            // 
            textBoxSearchGoods.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchGoods.Location = new Point(555, 20);
            textBoxSearchGoods.Name = "textBoxSearchGoods";
            textBoxSearchGoods.Size = new Size(229, 25);
            textBoxSearchGoods.TabIndex = 9;
            textBoxSearchGoods.TextChanged += textBoxSearchGoods_TextChanged;
            // 
            // buttonEditGood
            // 
            buttonEditGood.BackColor = Color.Transparent;
            buttonEditGood.FlatAppearance.BorderSize = 0;
            buttonEditGood.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            buttonEditGood.FlatAppearance.MouseOverBackColor = Color.LightGray;
            buttonEditGood.FlatStyle = FlatStyle.Flat;
            buttonEditGood.Image = Properties.Resources.edit;
            buttonEditGood.ImageAlign = ContentAlignment.TopCenter;
            buttonEditGood.Location = new Point(233, 0);
            buttonEditGood.Name = "buttonEditGood";
            buttonEditGood.Size = new Size(110, 65);
            buttonEditGood.TabIndex = 6;
            buttonEditGood.UseVisualStyleBackColor = false;
            buttonEditGood.Click += buttonEditGood_Click;
            buttonEditGood.MouseDown += buttonEditGood_MouseDown;
            buttonEditGood.MouseEnter += buttonEditGood_MouseEnter;
            buttonEditGood.MouseLeave += buttonEditGood_MouseLeave;
            buttonEditGood.MouseUp += buttonEditGood_MouseUp;
            // 
            // labelEditGoods
            // 
            labelEditGoods.AutoSize = true;
            labelEditGoods.BackColor = Color.Transparent;
            labelEditGoods.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditGoods.Location = new Point(253, 40);
            labelEditGoods.Name = "labelEditGoods";
            labelEditGoods.Size = new Size(71, 18);
            labelEditGoods.TabIndex = 7;
            labelEditGoods.Text = "Изменить";
            // 
            // btnPrintGoods
            // 
            btnPrintGoods.BackColor = Color.Transparent;
            btnPrintGoods.FlatAppearance.BorderSize = 0;
            btnPrintGoods.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnPrintGoods.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnPrintGoods.FlatStyle = FlatStyle.Flat;
            btnPrintGoods.Image = Properties.Resources.printer;
            btnPrintGoods.ImageAlign = ContentAlignment.TopCenter;
            btnPrintGoods.Location = new Point(501, 12);
            btnPrintGoods.Name = "btnPrintGoods";
            btnPrintGoods.Size = new Size(40, 41);
            btnPrintGoods.TabIndex = 16;
            btnPrintGoods.UseVisualStyleBackColor = false;
            btnPrintGoods.Click += btnPrintGoods_Click;
            // 
            // GoodsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 437);
            Controls.Add(btnPrintGoods);
            Controls.Add(textBoxSearchGoods);
            Controls.Add(dataGridGoods);
            Controls.Add(labelEditGoods);
            Controls.Add(labelDeleteGoods);
            Controls.Add(buttonEditGood);
            Controls.Add(buttonDeleteGood);
            Controls.Add(labelAddGoods);
            Controls.Add(buttonAddGood);
            MaximumSize = new Size(812, 473);
            MinimumSize = new Size(812, 473);
            Name = "GoodsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Товары";
            FormClosed += GoodsForm_FormClosed;
            Load += GoodsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridGoods).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddGoods;
        private Button buttonAddGood;
        private Label labelDeleteGoods;
        private Button buttonDeleteGood;
        private DataGridView dataGridGoods;
        private TextBox textBoxSearchGoods;
        private Button buttonEditGood;
        private Label labelEditGoods;
        private Button btnPrintGoods;
    }
}