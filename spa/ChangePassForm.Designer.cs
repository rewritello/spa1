namespace spa
{
    partial class ChangePassForm
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
            this.ChangePassLabel = new System.Windows.Forms.Label();
            this.OldPassLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxOfOldPass = new System.Windows.Forms.TextBox();
            this.TextBoxOfNewPass = new System.Windows.Forms.TextBox();
            this.SaveNewPassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(16, 17);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(130, 45);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ChangePassLabel
            // 
            this.ChangePassLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChangePassLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChangePassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ChangePassLabel.Location = new System.Drawing.Point(226, 49);
            this.ChangePassLabel.Name = "ChangePassLabel";
            this.ChangePassLabel.Size = new System.Drawing.Size(353, 60);
            this.ChangePassLabel.TabIndex = 10;
            this.ChangePassLabel.Text = "Изменение пароля:";
            this.ChangePassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OldPassLabel
            // 
            this.OldPassLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OldPassLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OldPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.OldPassLabel.Location = new System.Drawing.Point(16, 147);
            this.OldPassLabel.Name = "OldPassLabel";
            this.OldPassLabel.Size = new System.Drawing.Size(259, 52);
            this.OldPassLabel.TabIndex = 12;
            this.OldPassLabel.Text = "Старый пароль:";
            this.OldPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(16, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 54);
            this.label1.TabIndex = 13;
            this.label1.Text = "Новый пароль:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxOfOldPass
            // 
            this.TextBoxOfOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TextBoxOfOldPass.Location = new System.Drawing.Point(309, 147);
            this.TextBoxOfOldPass.Multiline = true;
            this.TextBoxOfOldPass.Name = "TextBoxOfOldPass";
            this.TextBoxOfOldPass.Size = new System.Drawing.Size(307, 52);
            this.TextBoxOfOldPass.TabIndex = 15;
            // 
            // TextBoxOfNewPass
            // 
            this.TextBoxOfNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TextBoxOfNewPass.Location = new System.Drawing.Point(309, 232);
            this.TextBoxOfNewPass.Multiline = true;
            this.TextBoxOfNewPass.Name = "TextBoxOfNewPass";
            this.TextBoxOfNewPass.Size = new System.Drawing.Size(307, 54);
            this.TextBoxOfNewPass.TabIndex = 16;
            // 
            // SaveNewPassButton
            // 
            this.SaveNewPassButton.Location = new System.Drawing.Point(309, 377);
            this.SaveNewPassButton.Name = "SaveNewPassButton";
            this.SaveNewPassButton.Size = new System.Drawing.Size(180, 45);
            this.SaveNewPassButton.TabIndex = 17;
            this.SaveNewPassButton.Text = "Сохранить новый пароль";
            this.SaveNewPassButton.UseVisualStyleBackColor = true;
            this.SaveNewPassButton.Click += new System.EventHandler(this.SaveNewPassButton_Click);
            // 
            // ChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveNewPassButton);
            this.Controls.Add(this.TextBoxOfNewPass);
            this.Controls.Add(this.TextBoxOfOldPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OldPassLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ChangePassLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangePassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label ChangePassLabel;
        private System.Windows.Forms.Label OldPassLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxOfOldPass;
        private System.Windows.Forms.TextBox TextBoxOfNewPass;
        private System.Windows.Forms.Button SaveNewPassButton;
    }
}