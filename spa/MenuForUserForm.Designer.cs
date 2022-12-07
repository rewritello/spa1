namespace spa
{
    partial class MenuForUserForm
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
            this.MenuLabel = new System.Windows.Forms.Label();
            this.CatalogButton = new System.Windows.Forms.Button();
            this.BacketButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.PersonalInfoButton = new System.Windows.Forms.Button();
            this.LeaveFromAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MenuLabel
            // 
            this.MenuLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MenuLabel.Location = new System.Drawing.Point(243, 25);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(333, 56);
            this.MenuLabel.TabIndex = 1;
            this.MenuLabel.Text = "Меню";
            this.MenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CatalogButton
            // 
            this.CatalogButton.Location = new System.Drawing.Point(296, 105);
            this.CatalogButton.Name = "CatalogButton";
            this.CatalogButton.Size = new System.Drawing.Size(236, 67);
            this.CatalogButton.TabIndex = 2;
            this.CatalogButton.Text = "Каталог";
            this.CatalogButton.UseVisualStyleBackColor = true;
            this.CatalogButton.Click += new System.EventHandler(this.CatalogButton_Click);
            // 
            // BacketButton
            // 
            this.BacketButton.Location = new System.Drawing.Point(296, 190);
            this.BacketButton.Name = "BacketButton";
            this.BacketButton.Size = new System.Drawing.Size(236, 67);
            this.BacketButton.TabIndex = 3;
            this.BacketButton.Text = "Корзина";
            this.BacketButton.UseVisualStyleBackColor = true;
            this.BacketButton.Click += new System.EventHandler(this.BacketButton_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(296, 274);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(236, 67);
            this.OrderButton.TabIndex = 4;
            this.OrderButton.Text = "Заказы";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // PersonalInfoButton
            // 
            this.PersonalInfoButton.Location = new System.Drawing.Point(296, 362);
            this.PersonalInfoButton.Name = "PersonalInfoButton";
            this.PersonalInfoButton.Size = new System.Drawing.Size(236, 67);
            this.PersonalInfoButton.TabIndex = 5;
            this.PersonalInfoButton.Text = "Личные данные";
            this.PersonalInfoButton.UseVisualStyleBackColor = true;
            this.PersonalInfoButton.Click += new System.EventHandler(this.PersonalInfoButton_Click);
            // 
            // LeaveFromAccountButton
            // 
            this.LeaveFromAccountButton.Location = new System.Drawing.Point(12, 25);
            this.LeaveFromAccountButton.Name = "LeaveFromAccountButton";
            this.LeaveFromAccountButton.Size = new System.Drawing.Size(130, 45);
            this.LeaveFromAccountButton.TabIndex = 19;
            this.LeaveFromAccountButton.Text = "Выйти из аккаунта";
            this.LeaveFromAccountButton.UseVisualStyleBackColor = true;
            this.LeaveFromAccountButton.Click += new System.EventHandler(this.LeaveFromAccountButton_Click);
            // 
            // MenuForUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LeaveFromAccountButton);
            this.Controls.Add(this.PersonalInfoButton);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.BacketButton);
            this.Controls.Add(this.CatalogButton);
            this.Controls.Add(this.MenuLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuForUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPA";
            this.Load += new System.EventHandler(this.MenuForUserForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Button CatalogButton;
        private System.Windows.Forms.Button BacketButton;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Button PersonalInfoButton;
        private System.Windows.Forms.Button LeaveFromAccountButton;
    }
}