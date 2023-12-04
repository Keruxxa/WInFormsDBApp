namespace WinFormsApp
{
    partial class LoginForm
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
            labelLogin = new Label();
            labelPassword = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogIn = new Button();
            buttonCancel = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.Location = new Point(114, 28);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(47, 18);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(114, 62);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(55, 18);
            labelPassword.TabIndex = 0;
            labelPassword.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(199, 23);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(208, 25);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(199, 57);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '●';
            textBoxPassword.Size = new Size(208, 25);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonLogIn
            // 
            buttonLogIn.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogIn.Location = new Point(199, 134);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(101, 32);
            buttonLogIn.TabIndex = 2;
            buttonLogIn.Text = "Войти";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(306, 134);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(101, 32);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.logIn;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 183);
            Controls.Add(pictureBox1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogIn);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            MaximumSize = new Size(442, 219);
            MinimumSize = new Size(442, 219);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonLogIn;
        private Button buttonCancel;
        private PictureBox pictureBox1;
    }
}