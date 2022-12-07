namespace spa
{
    partial class CatalogForAdminForm
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
            this.CatalogLabel = new System.Windows.Forms.Label();
            this.AddProductInCatalogButton = new System.Windows.Forms.Button();
            this.NextModelButton = new System.Windows.Forms.Button();
            this.PreviousModelButton = new System.Windows.Forms.Button();
            this.PriceTypeLabel = new System.Windows.Forms.Label();
            this.ModelTypeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(19, 18);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(130, 45);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CatalogLabel
            // 
            this.CatalogLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CatalogLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CatalogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CatalogLabel.Location = new System.Drawing.Point(228, 41);
            this.CatalogLabel.Name = "CatalogLabel";
            this.CatalogLabel.Size = new System.Drawing.Size(395, 60);
            this.CatalogLabel.TabIndex = 14;
            this.CatalogLabel.Text = "Каталог:";
            this.CatalogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddProductInCatalogButton
            // 
            this.AddProductInCatalogButton.Location = new System.Drawing.Point(284, 360);
            this.AddProductInCatalogButton.Name = "AddProductInCatalogButton";
            this.AddProductInCatalogButton.Size = new System.Drawing.Size(211, 44);
            this.AddProductInCatalogButton.TabIndex = 16;
            this.AddProductInCatalogButton.Text = "Добавить товар в каталог";
            this.AddProductInCatalogButton.UseVisualStyleBackColor = true;
            this.AddProductInCatalogButton.Click += new System.EventHandler(this.AddProductInCatalogButton_Click);
            // 
            // NextModelButton
            // 
            this.NextModelButton.Location = new System.Drawing.Point(535, 360);
            this.NextModelButton.Name = "NextModelButton";
            this.NextModelButton.Size = new System.Drawing.Size(209, 44);
            this.NextModelButton.TabIndex = 27;
            this.NextModelButton.Text = "Следующая модель";
            this.NextModelButton.UseVisualStyleBackColor = true;
            this.NextModelButton.Click += new System.EventHandler(this.NextModelButton_Click);
            // 
            // PreviousModelButton
            // 
            this.PreviousModelButton.Location = new System.Drawing.Point(29, 360);
            this.PreviousModelButton.Name = "PreviousModelButton";
            this.PreviousModelButton.Size = new System.Drawing.Size(209, 44);
            this.PreviousModelButton.TabIndex = 26;
            this.PreviousModelButton.Text = "Предыдущая модель";
            this.PreviousModelButton.UseVisualStyleBackColor = true;
            this.PreviousModelButton.Click += new System.EventHandler(this.PreviousModelButton_Click);
            // 
            // PriceTypeLabel
            // 
            this.PriceTypeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PriceTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PriceTypeLabel.Location = new System.Drawing.Point(284, 211);
            this.PriceTypeLabel.Name = "PriceTypeLabel";
            this.PriceTypeLabel.Size = new System.Drawing.Size(315, 52);
            this.PriceTypeLabel.TabIndex = 24;
            this.PriceTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelTypeLabel
            // 
            this.ModelTypeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModelTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ModelTypeLabel.Location = new System.Drawing.Point(284, 138);
            this.ModelTypeLabel.Name = "ModelTypeLabel";
            this.ModelTypeLabel.Size = new System.Drawing.Size(315, 52);
            this.ModelTypeLabel.TabIndex = 23;
            this.ModelTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PriceLabel.Location = new System.Drawing.Point(29, 211);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(225, 52);
            this.PriceLabel.TabIndex = 22;
            this.PriceLabel.Text = "Цена:";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelLabel
            // 
            this.ModelLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ModelLabel.Location = new System.Drawing.Point(29, 138);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(225, 52);
            this.ModelLabel.TabIndex = 21;
            this.ModelLabel.Text = "Модель:";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CatalogForAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextModelButton);
            this.Controls.Add(this.PreviousModelButton);
            this.Controls.Add(this.PriceTypeLabel);
            this.Controls.Add(this.ModelTypeLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.AddProductInCatalogButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CatalogLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CatalogForAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPA";
            this.Load += new System.EventHandler(this.CatalogForAdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label CatalogLabel;
        private System.Windows.Forms.Button AddProductInCatalogButton;
        private System.Windows.Forms.Button NextModelButton;
        private System.Windows.Forms.Button PreviousModelButton;
        private System.Windows.Forms.Label PriceTypeLabel;
        private System.Windows.Forms.Label ModelTypeLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ModelLabel;
    }
}