namespace spa
{
    partial class PersonalInformationForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.PersonalInformationLabel = new System.Windows.Forms.Label();
            this.InfOfNameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.ChangePassButton = new System.Windows.Forms.Button();
            this.TextBoxOfInfName = new System.Windows.Forms.TextBox();
            this.TextBoxOfPhoneNumber = new System.Windows.Forms.TextBox();
            this.TextBoxOfAdress = new System.Windows.Forms.TextBox();
            this.SaveInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(17, 15);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(130, 45);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PersonalInformationLabel
            // 
            this.PersonalInformationLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PersonalInformationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PersonalInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PersonalInformationLabel.Location = new System.Drawing.Point(227, 47);
            this.PersonalInformationLabel.Name = "PersonalInformationLabel";
            this.PersonalInformationLabel.Size = new System.Drawing.Size(353, 60);
            this.PersonalInformationLabel.TabIndex = 8;
            this.PersonalInformationLabel.Text = "Личные данные:";
            this.PersonalInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfOfNameLabel
            // 
            this.InfOfNameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InfOfNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfOfNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.InfOfNameLabel.Location = new System.Drawing.Point(17, 135);
            this.InfOfNameLabel.Name = "InfOfNameLabel";
            this.InfOfNameLabel.Size = new System.Drawing.Size(225, 52);
            this.InfOfNameLabel.TabIndex = 10;
            this.InfOfNameLabel.Text = "ФИО:";
            this.InfOfNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PhoneNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(17, 211);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(225, 52);
            this.PhoneNumberLabel.TabIndex = 11;
            this.PhoneNumberLabel.Text = "Номер телефона:";
            this.PhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdressLabel
            // 
            this.AdressLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AdressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AdressLabel.Location = new System.Drawing.Point(17, 285);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(225, 52);
            this.AdressLabel.TabIndex = 12;
            this.AdressLabel.Text = "Адрес:";
            this.AdressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangePassButton
            // 
            this.ChangePassButton.Location = new System.Drawing.Point(17, 370);
            this.ChangePassButton.Name = "ChangePassButton";
            this.ChangePassButton.Size = new System.Drawing.Size(225, 45);
            this.ChangePassButton.TabIndex = 13;
            this.ChangePassButton.Text = "Изменить пароль";
            this.ChangePassButton.UseVisualStyleBackColor = true;
            this.ChangePassButton.Click += new System.EventHandler(this.ChangePassButton_Click);
            // 
            // TextBoxOfInfName
            // 
            this.TextBoxOfInfName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TextBoxOfInfName.Location = new System.Drawing.Point(273, 135);
            this.TextBoxOfInfName.Multiline = true;
            this.TextBoxOfInfName.Name = "TextBoxOfInfName";
            this.TextBoxOfInfName.Size = new System.Drawing.Size(307, 50);
            this.TextBoxOfInfName.TabIndex = 14;
            // 
            // TextBoxOfPhoneNumber
            // 
            this.TextBoxOfPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TextBoxOfPhoneNumber.Location = new System.Drawing.Point(273, 211);
            this.TextBoxOfPhoneNumber.Multiline = true;
            this.TextBoxOfPhoneNumber.Name = "TextBoxOfPhoneNumber";
            this.TextBoxOfPhoneNumber.Size = new System.Drawing.Size(307, 52);
            this.TextBoxOfPhoneNumber.TabIndex = 15;
            // 
            // TextBoxOfAdress
            // 
            this.TextBoxOfAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TextBoxOfAdress.Location = new System.Drawing.Point(273, 285);
            this.TextBoxOfAdress.Multiline = true;
            this.TextBoxOfAdress.Name = "TextBoxOfAdress";
            this.TextBoxOfAdress.Size = new System.Drawing.Size(307, 52);
            this.TextBoxOfAdress.TabIndex = 16;
            // 
            // SaveInfoButton
            // 
            this.SaveInfoButton.Location = new System.Drawing.Point(273, 370);
            this.SaveInfoButton.Name = "SaveInfoButton";
            this.SaveInfoButton.Size = new System.Drawing.Size(225, 45);
            this.SaveInfoButton.TabIndex = 17;
            this.SaveInfoButton.Text = "Сохранить данные";
            this.SaveInfoButton.UseVisualStyleBackColor = true;
            this.SaveInfoButton.Click += new System.EventHandler(this.SaveInfoButton_Click);
            // 
            // PersonalInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveInfoButton);
            this.Controls.Add(this.TextBoxOfAdress);
            this.Controls.Add(this.TextBoxOfPhoneNumber);
            this.Controls.Add(this.TextBoxOfInfName);
            this.Controls.Add(this.ChangePassButton);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.InfOfNameLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PersonalInformationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PersonalInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPA";
            this.Load += new System.EventHandler(this.PersonalInformationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label PersonalInformationLabel;
        private System.Windows.Forms.Label InfOfNameLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.Button ChangePassButton;
        private System.Windows.Forms.TextBox TextBoxOfInfName;
        private System.Windows.Forms.TextBox TextBoxOfPhoneNumber;
        private System.Windows.Forms.TextBox TextBoxOfAdress;
        private System.Windows.Forms.Button SaveInfoButton;
    }
}