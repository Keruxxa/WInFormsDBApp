namespace WinFormsApp
{
    public partial class ProvidersForm
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
            textBoxSearchProvider = new TextBox();
            labelDeleteProvider = new Label();
            buttonDeleteProvider = new Button();
            labelAddProvider = new Label();
            buttonAddProvider = new Button();
            dataGridProviders = new DataGridView();
            buttonEditProvider = new Button();
            labelEditProvider = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridProviders).BeginInit();
            SuspendLayout();
            // 
            // textBoxSearchProvider
            // 
            textBoxSearchProvider.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchProvider.Location = new Point(555, 20);
            textBoxSearchProvider.Name = "textBoxSearchProvider";
            textBoxSearchProvider.Size = new Size(229, 25);
            textBoxSearchProvider.TabIndex = 20;
            textBoxSearchProvider.TextChanged += textBoxSearchProvider_TextChanged;
            // 
            // labelDeleteProvider
            // 
            labelDeleteProvider.AutoSize = true;
            labelDeleteProvider.BackColor = Color.Transparent;
            labelDeleteProvider.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDeleteProvider.Location = new Point(143, 40);
            labelDeleteProvider.Name = "labelDeleteProvider";
            labelDeleteProvider.Size = new Size(59, 18);
            labelDeleteProvider.TabIndex = 19;
            labelDeleteProvider.Text = "Удалить";
            // 
            // buttonDeleteProvider
            // 
            buttonDeleteProvider.BackColor = Color.Transparent;
            buttonDeleteProvider.FlatAppearance.BorderSize = 0;
            buttonDeleteProvider.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            buttonDeleteProvider.FlatAppearance.MouseOverBackColor = Color.LightGray;
            buttonDeleteProvider.FlatStyle = FlatStyle.Flat;
            buttonDeleteProvider.Image = Properties.Resources.remove;
            buttonDeleteProvider.ImageAlign = ContentAlignment.TopCenter;
            buttonDeleteProvider.Location = new Point(117, 0);
            buttonDeleteProvider.Name = "buttonDeleteProvider";
            buttonDeleteProvider.Size = new Size(110, 65);
            buttonDeleteProvider.TabIndex = 18;
            buttonDeleteProvider.UseVisualStyleBackColor = false;
            buttonDeleteProvider.Click += buttonDeleteProvider_Click;
            buttonDeleteProvider.MouseDown += buttonDeleteProvider_MouseDown;
            buttonDeleteProvider.MouseEnter += buttonDeleteProvider_MouseEnter;
            buttonDeleteProvider.MouseLeave += buttonDeleteProvider_MouseLeave;
            buttonDeleteProvider.MouseUp += buttonDeleteProvider_MouseUp;
            // 
            // labelAddProvider
            // 
            labelAddProvider.AutoSize = true;
            labelAddProvider.BackColor = Color.Transparent;
            labelAddProvider.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddProvider.Location = new Point(22, 40);
            labelAddProvider.Name = "labelAddProvider";
            labelAddProvider.Size = new Size(69, 18);
            labelAddProvider.TabIndex = 17;
            labelAddProvider.Text = "Добавить";
            // 
            // buttonAddProvider
            // 
            buttonAddProvider.BackColor = Color.Transparent;
            buttonAddProvider.FlatAppearance.BorderSize = 0;
            buttonAddProvider.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            buttonAddProvider.FlatAppearance.MouseOverBackColor = Color.LightGray;
            buttonAddProvider.FlatStyle = FlatStyle.Flat;
            buttonAddProvider.Image = Properties.Resources.addIcon;
            buttonAddProvider.ImageAlign = ContentAlignment.TopCenter;
            buttonAddProvider.Location = new Point(1, 0);
            buttonAddProvider.Name = "buttonAddProvider";
            buttonAddProvider.Size = new Size(110, 65);
            buttonAddProvider.TabIndex = 16;
            buttonAddProvider.UseVisualStyleBackColor = false;
            buttonAddProvider.Click += buttonAddProvider_Click;
            buttonAddProvider.MouseDown += buttonAddProvider_MouseDown;
            buttonAddProvider.MouseEnter += buttonAddProvider_MouseEnter;
            buttonAddProvider.MouseLeave += buttonAddProvider_MouseLeave;
            buttonAddProvider.MouseUp += buttonAddProvider_MouseUp;
            // 
            // dataGridProviders
            // 
            dataGridProviders.AllowUserToAddRows = false;
            dataGridProviders.AllowUserToDeleteRows = false;
            dataGridProviders.AllowUserToOrderColumns = true;
            dataGridProviders.AllowUserToResizeColumns = false;
            dataGridProviders.AllowUserToResizeRows = false;
            dataGridProviders.BackgroundColor = SystemColors.ScrollBar;
            dataGridProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProviders.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridProviders.Location = new Point(-1, 67);
            dataGridProviders.Name = "dataGridProviders";
            dataGridProviders.RowTemplate.Height = 25;
            dataGridProviders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProviders.Size = new Size(798, 371);
            dataGridProviders.TabIndex = 15;
            // 
            // buttonEditProvider
            // 
            buttonEditProvider.BackColor = Color.Transparent;
            buttonEditProvider.FlatAppearance.BorderSize = 0;
            buttonEditProvider.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            buttonEditProvider.FlatAppearance.MouseOverBackColor = Color.LightGray;
            buttonEditProvider.FlatStyle = FlatStyle.Flat;
            buttonEditProvider.Image = Properties.Resources.edit;
            buttonEditProvider.ImageAlign = ContentAlignment.TopCenter;
            buttonEditProvider.Location = new Point(233, 0);
            buttonEditProvider.Name = "buttonEditProvider";
            buttonEditProvider.Size = new Size(110, 65);
            buttonEditProvider.TabIndex = 18;
            buttonEditProvider.UseVisualStyleBackColor = false;
            buttonEditProvider.Click += buttonEditProvider_Click;
            buttonEditProvider.MouseDown += buttonEditProvider_MouseDown;
            buttonEditProvider.MouseEnter += buttonEditProvider_MouseEnter;
            buttonEditProvider.MouseLeave += buttonEditProvider_MouseLeave;
            buttonEditProvider.MouseUp += buttonEditProvider_MouseUp;
            // 
            // labelEditProvider
            // 
            labelEditProvider.AutoSize = true;
            labelEditProvider.BackColor = Color.Transparent;
            labelEditProvider.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditProvider.Location = new Point(253, 40);
            labelEditProvider.Name = "labelEditProvider";
            labelEditProvider.Size = new Size(71, 18);
            labelEditProvider.TabIndex = 19;
            labelEditProvider.Text = "Изменить";
            // 
            // ProvidersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 437);
            Controls.Add(textBoxSearchProvider);
            Controls.Add(labelEditProvider);
            Controls.Add(labelDeleteProvider);
            Controls.Add(buttonEditProvider);
            Controls.Add(buttonDeleteProvider);
            Controls.Add(labelAddProvider);
            Controls.Add(buttonAddProvider);
            Controls.Add(dataGridProviders);
            MaximumSize = new Size(812, 473);
            MinimumSize = new Size(812, 473);
            Name = "ProvidersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поставщики";
            FormClosing += ProvidersForm_FormClosing;
            Load += ProvidersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridProviders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearchProvider;
        private Label labelDeleteProvider;
        private Button buttonDeleteProvider;
        private Label labelAddProvider;
        private Button buttonAddProvider;
        private DataGridView dataGridProviders;
        private Button buttonEditProvider;
        private Label labelEditProvider;
    }
}