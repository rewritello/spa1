namespace spa
{
    partial class StartForm
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
            this.AutorisationButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.CheckCatalogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AutorisationButton
            // 
            this.AutorisationButton.Location = new System.Drawing.Point(203, 93);
            this.AutorisationButton.Name = "AutorisationButton";
            this.AutorisationButton.Size = new System.Drawing.Size(372, 89);
            this.AutorisationButton.TabIndex = 0;
            this.AutorisationButton.Text = "Авторизироваться";
            this.AutorisationButton.UseVisualStyleBackColor = true;
            this.AutorisationButton.Click += new System.EventHandler(this.AutorisationButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(202, 208);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(372, 83);
            this.RegistrationButton.TabIndex = 1;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // CheckCatalogButton
            // 
            this.CheckCatalogButton.Location = new System.Drawing.Point(203, 323);
            this.CheckCatalogButton.Name = "CheckCatalogButton";
            this.CheckCatalogButton.Size = new System.Drawing.Size(370, 89);
            this.CheckCatalogButton.TabIndex = 2;
            this.CheckCatalogButton.Text = "Просмотреть каталог";
            this.CheckCatalogButton.UseVisualStyleBackColor = true;
            this.CheckCatalogButton.Click += new System.EventHandler(this.CheckCatalogButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckCatalogButton);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.AutorisationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AutorisationButton;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button CheckCatalogButton;
    }
}