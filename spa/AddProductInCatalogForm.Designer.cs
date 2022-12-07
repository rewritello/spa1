namespace spa
{
    partial class AddProductInCatalogForm
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
            this.AddProductLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.TextBoxOfModelProduct = new System.Windows.Forms.TextBox();
            this.ModelOfProductLabel = new System.Windows.Forms.Label();
            this.PriceOfProductLabel = new System.Windows.Forms.Label();
            this.TextBoxOfPriceProduct = new System.Windows.Forms.TextBox();
            this.AddProductInCatalogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddProductLabel
            // 
            this.AddProductLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddProductLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddProductLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AddProductLabel.Location = new System.Drawing.Point(241, 12);
            this.AddProductLabel.Name = "AddProductLabel";
            this.AddProductLabel.Size = new System.Drawing.Size(351, 56);
            this.AddProductLabel.TabIndex = 7;
            this.AddProductLabel.Text = "Добавление товара";
            this.AddProductLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(130, 45);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TextBoxOfModelProduct
            // 
            this.TextBoxOfModelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxOfModelProduct.Location = new System.Drawing.Point(313, 132);
            this.TextBoxOfModelProduct.Multiline = true;
            this.TextBoxOfModelProduct.Name = "TextBoxOfModelProduct";
            this.TextBoxOfModelProduct.Size = new System.Drawing.Size(236, 56);
            this.TextBoxOfModelProduct.TabIndex = 16;
            // 
            // ModelOfProductLabel
            // 
            this.ModelOfProductLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModelOfProductLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelOfProductLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ModelOfProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ModelOfProductLabel.Location = new System.Drawing.Point(26, 132);
            this.ModelOfProductLabel.Name = "ModelOfProductLabel";
            this.ModelOfProductLabel.Size = new System.Drawing.Size(263, 56);
            this.ModelOfProductLabel.TabIndex = 17;
            this.ModelOfProductLabel.Text = "Модель товара";
            this.ModelOfProductLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceOfProductLabel
            // 
            this.PriceOfProductLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PriceOfProductLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceOfProductLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PriceOfProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PriceOfProductLabel.Location = new System.Drawing.Point(26, 212);
            this.PriceOfProductLabel.Name = "PriceOfProductLabel";
            this.PriceOfProductLabel.Size = new System.Drawing.Size(263, 56);
            this.PriceOfProductLabel.TabIndex = 18;
            this.PriceOfProductLabel.Text = "Цена товара";
            this.PriceOfProductLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxOfPriceProduct
            // 
            this.TextBoxOfPriceProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxOfPriceProduct.Location = new System.Drawing.Point(313, 212);
            this.TextBoxOfPriceProduct.Multiline = true;
            this.TextBoxOfPriceProduct.Name = "TextBoxOfPriceProduct";
            this.TextBoxOfPriceProduct.Size = new System.Drawing.Size(236, 56);
            this.TextBoxOfPriceProduct.TabIndex = 19;
            // 
            // AddProductInCatalogButton
            // 
            this.AddProductInCatalogButton.Location = new System.Drawing.Point(342, 365);
            this.AddProductInCatalogButton.Name = "AddProductInCatalogButton";
            this.AddProductInCatalogButton.Size = new System.Drawing.Size(155, 45);
            this.AddProductInCatalogButton.TabIndex = 20;
            this.AddProductInCatalogButton.Text = "Добавить товар";
            this.AddProductInCatalogButton.UseVisualStyleBackColor = true;
            this.AddProductInCatalogButton.Click += new System.EventHandler(this.AddProductInCatalogButton_Click);
            // 
            // AddProductInCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddProductInCatalogButton);
            this.Controls.Add(this.TextBoxOfPriceProduct);
            this.Controls.Add(this.PriceOfProductLabel);
            this.Controls.Add(this.ModelOfProductLabel);
            this.Controls.Add(this.TextBoxOfModelProduct);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddProductLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddProductInCatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProductLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox TextBoxOfModelProduct;
        private System.Windows.Forms.Label ModelOfProductLabel;
        private System.Windows.Forms.Label PriceOfProductLabel;
        private System.Windows.Forms.TextBox TextBoxOfPriceProduct;
        private System.Windows.Forms.Button AddProductInCatalogButton;
    }
}