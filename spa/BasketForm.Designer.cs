namespace spa
{
    partial class BasketForm
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
            this.BasketLabel = new System.Windows.Forms.Label();
            this.PriceTypeLabel = new System.Windows.Forms.Label();
            this.ModelTypeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.NextElementBasketButton = new System.Windows.Forms.Button();
            this.PreviousElementBasketButton = new System.Windows.Forms.Button();
            this.AddElementToOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(17, 17);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(130, 45);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BasketLabel
            // 
            this.BasketLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BasketLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BasketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BasketLabel.Location = new System.Drawing.Point(227, 49);
            this.BasketLabel.Name = "BasketLabel";
            this.BasketLabel.Size = new System.Drawing.Size(353, 60);
            this.BasketLabel.TabIndex = 6;
            this.BasketLabel.Text = "Моя корзина:";
            this.BasketLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BasketLabel.Click += new System.EventHandler(this.OrdersLabel_Click);
            // 
            // PriceTypeLabel
            // 
            this.PriceTypeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PriceTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PriceTypeLabel.Location = new System.Drawing.Point(272, 223);
            this.PriceTypeLabel.Name = "PriceTypeLabel";
            this.PriceTypeLabel.Size = new System.Drawing.Size(315, 52);
            this.PriceTypeLabel.TabIndex = 21;
            this.PriceTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelTypeLabel
            // 
            this.ModelTypeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModelTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ModelTypeLabel.Location = new System.Drawing.Point(272, 150);
            this.ModelTypeLabel.Name = "ModelTypeLabel";
            this.ModelTypeLabel.Size = new System.Drawing.Size(315, 52);
            this.ModelTypeLabel.TabIndex = 20;
            this.ModelTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PriceLabel.Location = new System.Drawing.Point(17, 223);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(225, 52);
            this.PriceLabel.TabIndex = 19;
            this.PriceLabel.Text = "Цена:";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelLabel
            // 
            this.ModelLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ModelLabel.Location = new System.Drawing.Point(17, 150);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(225, 52);
            this.ModelLabel.TabIndex = 18;
            this.ModelLabel.Text = "Модель:";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextElementBasketButton
            // 
            this.NextElementBasketButton.Location = new System.Drawing.Point(532, 368);
            this.NextElementBasketButton.Name = "NextElementBasketButton";
            this.NextElementBasketButton.Size = new System.Drawing.Size(209, 44);
            this.NextElementBasketButton.TabIndex = 24;
            this.NextElementBasketButton.Text = "Следующий элемент корзины";
            this.NextElementBasketButton.UseVisualStyleBackColor = true;
            this.NextElementBasketButton.Click += new System.EventHandler(this.NextElementBasketButton_Click);
            // 
            // PreviousElementBasketButton
            // 
            this.PreviousElementBasketButton.Location = new System.Drawing.Point(17, 368);
            this.PreviousElementBasketButton.Name = "PreviousElementBasketButton";
            this.PreviousElementBasketButton.Size = new System.Drawing.Size(209, 44);
            this.PreviousElementBasketButton.TabIndex = 23;
            this.PreviousElementBasketButton.Text = "Предыдущий элемент корзины";
            this.PreviousElementBasketButton.UseVisualStyleBackColor = true;
            this.PreviousElementBasketButton.Click += new System.EventHandler(this.PreviousElementBasketButton_Click);
            // 
            // AddElementToOrderButton
            // 
            this.AddElementToOrderButton.Location = new System.Drawing.Point(272, 368);
            this.AddElementToOrderButton.Name = "AddElementToOrderButton";
            this.AddElementToOrderButton.Size = new System.Drawing.Size(209, 44);
            this.AddElementToOrderButton.TabIndex = 22;
            this.AddElementToOrderButton.Text = "Оформить заказ";
            this.AddElementToOrderButton.UseVisualStyleBackColor = true;
            this.AddElementToOrderButton.Click += new System.EventHandler(this.AddElementToOrderButton_Click);
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextElementBasketButton);
            this.Controls.Add(this.PreviousElementBasketButton);
            this.Controls.Add(this.AddElementToOrderButton);
            this.Controls.Add(this.PriceTypeLabel);
            this.Controls.Add(this.ModelTypeLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BasketLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BasketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label BasketLabel;
        private System.Windows.Forms.Label PriceTypeLabel;
        private System.Windows.Forms.Label ModelTypeLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Button NextElementBasketButton;
        private System.Windows.Forms.Button PreviousElementBasketButton;
        private System.Windows.Forms.Button AddElementToOrderButton;
    }
}