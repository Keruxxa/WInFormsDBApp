namespace WinFormsApp.Forms
{
    partial class AddEditProviders
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
            buttonProvidersCancel = new Button();
            buttonProvidersAccept = new Button();
            textBoxProviderPhone = new TextBox();
            textBoxProviderAddress = new TextBox();
            textBoxProviderName = new TextBox();
            labelProviderAddress = new Label();
            labelProviderPhone = new Label();
            labelProviderName = new Label();
            SuspendLayout();
            // 
            // buttonProvidersCancel
            // 
            buttonProvidersCancel.Location = new Point(314, 173);
            buttonProvidersCancel.Name = "buttonProvidersCancel";
            buttonProvidersCancel.Size = new Size(96, 31);
            buttonProvidersCancel.TabIndex = 9;
            buttonProvidersCancel.Text = "Отмена";
            buttonProvidersCancel.UseVisualStyleBackColor = true;
            buttonProvidersCancel.Click += buttonProvidersCancel_Click;
            // 
            // buttonProvidersAccept
            // 
            buttonProvidersAccept.Location = new Point(195, 173);
            buttonProvidersAccept.Name = "buttonProvidersAccept";
            buttonProvidersAccept.Size = new Size(96, 31);
            buttonProvidersAccept.TabIndex = 10;
            buttonProvidersAccept.Text = "Доб/Изм";
            buttonProvidersAccept.UseVisualStyleBackColor = true;
            buttonProvidersAccept.Click += buttonProvidersAccept_Click;
            // 
            // textBoxProviderPhone
            // 
            textBoxProviderPhone.Location = new Point(173, 118);
            textBoxProviderPhone.Name = "textBoxProviderPhone";
            textBoxProviderPhone.Size = new Size(237, 23);
            textBoxProviderPhone.TabIndex = 6;
            // 
            // textBoxProviderAddress
            // 
            textBoxProviderAddress.Location = new Point(173, 81);
            textBoxProviderAddress.Name = "textBoxProviderAddress";
            textBoxProviderAddress.Size = new Size(237, 23);
            textBoxProviderAddress.TabIndex = 7;
            // 
            // textBoxProviderName
            // 
            textBoxProviderName.Location = new Point(173, 45);
            textBoxProviderName.Name = "textBoxProviderName";
            textBoxProviderName.Size = new Size(237, 23);
            textBoxProviderName.TabIndex = 8;
            // 
            // labelProviderAddress
            // 
            labelProviderAddress.AutoSize = true;
            labelProviderAddress.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelProviderAddress.Location = new Point(49, 83);
            labelProviderAddress.Name = "labelProviderAddress";
            labelProviderAddress.Size = new Size(44, 18);
            labelProviderAddress.TabIndex = 3;
            labelProviderAddress.Text = "Адрес";
            // 
            // labelProviderPhone
            // 
            labelProviderPhone.AutoSize = true;
            labelProviderPhone.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelProviderPhone.Location = new Point(49, 120);
            labelProviderPhone.Name = "labelProviderPhone";
            labelProviderPhone.Size = new Size(61, 18);
            labelProviderPhone.TabIndex = 4;
            labelProviderPhone.Text = "Телефон";
            // 
            // labelProviderName
            // 
            labelProviderName.AutoSize = true;
            labelProviderName.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelProviderName.Location = new Point(49, 47);
            labelProviderName.Name = "labelProviderName";
            labelProviderName.Size = new Size(103, 18);
            labelProviderName.TabIndex = 5;
            labelProviderName.Text = "Наименование";
            // 
            // AddEditProviders
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 235);
            Controls.Add(buttonProvidersCancel);
            Controls.Add(buttonProvidersAccept);
            Controls.Add(textBoxProviderPhone);
            Controls.Add(textBoxProviderAddress);
            Controls.Add(textBoxProviderName);
            Controls.Add(labelProviderAddress);
            Controls.Add(labelProviderPhone);
            Controls.Add(labelProviderName);
            MaximumSize = new Size(490, 271);
            MinimumSize = new Size(490, 271);
            Name = "AddEditProviders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поставщики";
            Load += AddEditProviders_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonProvidersCancel;
        private Button buttonProvidersAccept;
        private TextBox textBoxProviderPhone;
        private TextBox textBoxProviderAddress;
        private TextBox textBoxProviderName;
        private Label labelProviderAddress;
        private Label labelProviderPhone;
        private Label labelProviderName;
    }
}