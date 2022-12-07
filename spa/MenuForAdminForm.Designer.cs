namespace spa
{
    partial class MenuForAdminForm
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
            this.OrderListOfUsersButton = new System.Windows.Forms.Button();
            this.ListOfUsersButton = new System.Windows.Forms.Button();
            this.ChooseCatalogButton = new System.Windows.Forms.Button();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.LeaveFromAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderListOfUsersButton
            // 
            this.OrderListOfUsersButton.Location = new System.Drawing.Point(287, 272);
            this.OrderListOfUsersButton.Name = "OrderListOfUsersButton";
            this.OrderListOfUsersButton.Size = new System.Drawing.Size(236, 67);
            this.OrderListOfUsersButton.TabIndex = 9;
            this.OrderListOfUsersButton.Text = "Список заказов пользователей";
            this.OrderListOfUsersButton.UseVisualStyleBackColor = true;
            this.OrderListOfUsersButton.Click += new System.EventHandler(this.OrderListOfUsersButton_Click);
            // 
            // ListOfUsersButton
            // 
            this.ListOfUsersButton.Location = new System.Drawing.Point(287, 188);
            this.ListOfUsersButton.Name = "ListOfUsersButton";
            this.ListOfUsersButton.Size = new System.Drawing.Size(236, 67);
            this.ListOfUsersButton.TabIndex = 8;
            this.ListOfUsersButton.Text = "Список пользователей";
            this.ListOfUsersButton.UseVisualStyleBackColor = true;
            this.ListOfUsersButton.Click += new System.EventHandler(this.ListOfUsersButton_Click);
            // 
            // ChooseCatalogButton
            // 
            this.ChooseCatalogButton.Location = new System.Drawing.Point(287, 103);
            this.ChooseCatalogButton.Name = "ChooseCatalogButton";
            this.ChooseCatalogButton.Size = new System.Drawing.Size(236, 67);
            this.ChooseCatalogButton.TabIndex = 7;
            this.ChooseCatalogButton.Text = "Каталог";
            this.ChooseCatalogButton.UseVisualStyleBackColor = true;
            this.ChooseCatalogButton.Click += new System.EventHandler(this.ChooseCatalogButton_Click);
            // 
            // MenuLabel
            // 
            this.MenuLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MenuLabel.Location = new System.Drawing.Point(234, 23);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(333, 56);
            this.MenuLabel.TabIndex = 6;
            this.MenuLabel.Text = "Меню";
            this.MenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeaveFromAccountButton
            // 
            this.LeaveFromAccountButton.Location = new System.Drawing.Point(12, 23);
            this.LeaveFromAccountButton.Name = "LeaveFromAccountButton";
            this.LeaveFromAccountButton.Size = new System.Drawing.Size(130, 45);
            this.LeaveFromAccountButton.TabIndex = 19;
            this.LeaveFromAccountButton.Text = "Выйти из аккаунта";
            this.LeaveFromAccountButton.UseVisualStyleBackColor = true;
            this.LeaveFromAccountButton.Click += new System.EventHandler(this.LeaveFromAccountButton_Click);
            // 
            // MenuForAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LeaveFromAccountButton);
            this.Controls.Add(this.OrderListOfUsersButton);
            this.Controls.Add(this.ListOfUsersButton);
            this.Controls.Add(this.ChooseCatalogButton);
            this.Controls.Add(this.MenuLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuForAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPA";
            this.Load += new System.EventHandler(this.MenuForAdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OrderListOfUsersButton;
        private System.Windows.Forms.Button ListOfUsersButton;
        private System.Windows.Forms.Button ChooseCatalogButton;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Button LeaveFromAccountButton;
    }
}