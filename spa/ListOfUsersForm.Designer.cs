namespace spa
{
    partial class ListOfUsersForm
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
            this.ListOfUsersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(16, 15);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(130, 45);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ListOfUsersLabel
            // 
            this.ListOfUsersLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ListOfUsersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListOfUsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ListOfUsersLabel.Location = new System.Drawing.Point(152, 43);
            this.ListOfUsersLabel.Name = "ListOfUsersLabel";
            this.ListOfUsersLabel.Size = new System.Drawing.Size(554, 60);
            this.ListOfUsersLabel.TabIndex = 8;
            this.ListOfUsersLabel.Text = "Список пользователей:";
            this.ListOfUsersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListOfUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ListOfUsersLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListOfUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label ListOfUsersLabel;
    }
}