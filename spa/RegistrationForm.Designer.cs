namespace spa
{
    partial class RegistrationForm
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
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.TextBoxOfLogin = new System.Windows.Forms.TextBox();
            this.TextBoxOfPassword = new System.Windows.Forms.TextBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegistrationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegistrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.RegistrationLabel.Location = new System.Drawing.Point(217, 65);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(381, 80);
            this.RegistrationLabel.TabIndex = 0;
            this.RegistrationLabel.Text = "Регистрация:";
            this.RegistrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginLabel
            // 
            this.LoginLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LoginLabel.Location = new System.Drawing.Point(150, 207);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(188, 54);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Логин:";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PasswordLabel.Location = new System.Drawing.Point(153, 292);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(184, 54);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Пароль:";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(23, 20);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(130, 45);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TextBoxOfLogin
            // 
            this.TextBoxOfLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxOfLogin.Location = new System.Drawing.Point(361, 207);
            this.TextBoxOfLogin.Multiline = true;
            this.TextBoxOfLogin.Name = "TextBoxOfLogin";
            this.TextBoxOfLogin.Size = new System.Drawing.Size(236, 54);
            this.TextBoxOfLogin.TabIndex = 4;
            // 
            // TextBoxOfPassword
            // 
            this.TextBoxOfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxOfPassword.Location = new System.Drawing.Point(361, 292);
            this.TextBoxOfPassword.Multiline = true;
            this.TextBoxOfPassword.Name = "TextBoxOfPassword";
            this.TextBoxOfPassword.Size = new System.Drawing.Size(236, 54);
            this.TextBoxOfPassword.TabIndex = 5;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(306, 380);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(222, 45);
            this.RegistrationButton.TabIndex = 6;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.TextBoxOfPassword);
            this.Controls.Add(this.TextBoxOfLogin);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.RegistrationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPA";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox TextBoxOfLogin;
        private System.Windows.Forms.TextBox TextBoxOfPassword;
        private System.Windows.Forms.Button RegistrationButton;
    }
}