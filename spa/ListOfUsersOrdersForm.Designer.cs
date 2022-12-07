namespace spa
{
    partial class ListOfUsersOrdersForm
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
            this.ListOfUsersOrdersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(20, 18);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(130, 45);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ListOfUsersOrdersLabel
            // 
            this.ListOfUsersOrdersLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ListOfUsersOrdersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListOfUsersOrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ListOfUsersOrdersLabel.Location = new System.Drawing.Point(156, 46);
            this.ListOfUsersOrdersLabel.Name = "ListOfUsersOrdersLabel";
            this.ListOfUsersOrdersLabel.Size = new System.Drawing.Size(545, 64);
            this.ListOfUsersOrdersLabel.TabIndex = 6;
            this.ListOfUsersOrdersLabel.Text = "Список заказов пользователей:";
            this.ListOfUsersOrdersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListOfUsersOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ListOfUsersOrdersLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListOfUsersOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label ListOfUsersOrdersLabel;
    }
}