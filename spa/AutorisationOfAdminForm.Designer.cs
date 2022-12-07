namespace spa
{
    partial class AutorisationOfAdminForm
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
            this.AutorisationLabel = new System.Windows.Forms.Label();
            this.TextBoxOfPassword = new System.Windows.Forms.TextBox();
            this.TextBoxOfLogin = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AutorisationLabel
            // 
            this.AutorisationLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AutorisationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AutorisationLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.AutorisationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AutorisationLabel.Location = new System.Drawing.Point(220, 68);
            this.AutorisationLabel.Name = "AutorisationLabel";
            this.AutorisationLabel.Size = new System.Drawing.Size(386, 82);
            this.AutorisationLabel.TabIndex = 1;
            this.AutorisationLabel.Text = "Вход, как администратор:";
            this.AutorisationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxOfPassword
            // 
            this.TextBoxOfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxOfPassword.Location = new System.Drawing.Point(381, 287);
            this.TextBoxOfPassword.Multiline = true;
            this.TextBoxOfPassword.Name = "TextBoxOfPassword";
            this.TextBoxOfPassword.Size = new System.Drawing.Size(236, 54);
            this.TextBoxOfPassword.TabIndex = 9;
            // 
            // TextBoxOfLogin
            // 
            this.TextBoxOfLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxOfLogin.Location = new System.Drawing.Point(381, 202);
            this.TextBoxOfLogin.Multiline = true;
            this.TextBoxOfLogin.Name = "TextBoxOfLogin";
            this.TextBoxOfLogin.Size = new System.Drawing.Size(236, 54);
            this.TextBoxOfLogin.TabIndex = 8;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PasswordLabel.Location = new System.Drawing.Point(173, 287);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(184, 54);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Пароль:";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginLabel
            // 
            this.LoginLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LoginLabel.Location = new System.Drawing.Point(170, 202);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(188, 54);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Логин:";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(304, 371);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(222, 45);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(24, 28);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(130, 45);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AutorisationOfAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.TextBoxOfPassword);
            this.Controls.Add(this.TextBoxOfLogin);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.AutorisationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AutorisationOfAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPA";
            this.Load += new System.EventHandler(this.AutorisationOfAdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AutorisationLabel;
        private System.Windows.Forms.TextBox TextBoxOfPassword;
        private System.Windows.Forms.TextBox TextBoxOfLogin;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button BackButton;
    }
}