namespace spa
{
    partial class AutorisationForm
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
            this.ChooseAdminButton = new System.Windows.Forms.Button();
            this.ChooseUserButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AutorisationLabel
            // 
            this.AutorisationLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AutorisationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AutorisationLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.AutorisationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AutorisationLabel.Location = new System.Drawing.Point(226, 63);
            this.AutorisationLabel.Name = "AutorisationLabel";
            this.AutorisationLabel.Size = new System.Drawing.Size(386, 82);
            this.AutorisationLabel.TabIndex = 0;
            this.AutorisationLabel.Text = "Войти как:";
            this.AutorisationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseAdminButton
            // 
            this.ChooseAdminButton.Location = new System.Drawing.Point(171, 201);
            this.ChooseAdminButton.Name = "ChooseAdminButton";
            this.ChooseAdminButton.Size = new System.Drawing.Size(236, 82);
            this.ChooseAdminButton.TabIndex = 1;
            this.ChooseAdminButton.Text = "Администратор";
            this.ChooseAdminButton.UseVisualStyleBackColor = true;
            this.ChooseAdminButton.Click += new System.EventHandler(this.ChooseAdminButton_Click);
            // 
            // ChooseUserButton
            // 
            this.ChooseUserButton.Location = new System.Drawing.Point(457, 201);
            this.ChooseUserButton.Name = "ChooseUserButton";
            this.ChooseUserButton.Size = new System.Drawing.Size(229, 81);
            this.ChooseUserButton.TabIndex = 2;
            this.ChooseUserButton.Text = "Пользователь";
            this.ChooseUserButton.UseVisualStyleBackColor = true;
            this.ChooseUserButton.Click += new System.EventHandler(this.ChooseUserButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(25, 28);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(130, 45);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AutorisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ChooseUserButton);
            this.Controls.Add(this.ChooseAdminButton);
            this.Controls.Add(this.AutorisationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AutorisationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPA";
            this.Load += new System.EventHandler(this.AutorisationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AutorisationLabel;
        private System.Windows.Forms.Button ChooseAdminButton;
        private System.Windows.Forms.Button ChooseUserButton;
        private System.Windows.Forms.Button BackButton;
    }
}