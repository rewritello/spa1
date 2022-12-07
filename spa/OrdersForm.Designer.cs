namespace spa
{
    partial class OrdersForm
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
            this.OrdersLabel = new System.Windows.Forms.Label();
            this.NextElementOrdersButton = new System.Windows.Forms.Button();
            this.PreviousElementOrdersButton = new System.Windows.Forms.Button();
            this.PriceTypeLabel = new System.Windows.Forms.Label();
            this.ModelTypeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(25, 25);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(130, 45);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrdersLabel
            // 
            this.OrdersLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrdersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.OrdersLabel.Location = new System.Drawing.Point(235, 57);
            this.OrdersLabel.Name = "OrdersLabel";
            this.OrdersLabel.Size = new System.Drawing.Size(353, 60);
            this.OrdersLabel.TabIndex = 4;
            this.OrdersLabel.Text = "Мои заказы:";
            this.OrdersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextElementOrdersButton
            // 
            this.NextElementOrdersButton.Location = new System.Drawing.Point(545, 378);
            this.NextElementOrdersButton.Name = "NextElementOrdersButton";
            this.NextElementOrdersButton.Size = new System.Drawing.Size(209, 44);
            this.NextElementOrdersButton.TabIndex = 31;
            this.NextElementOrdersButton.Text = "Следующий заказ";
            this.NextElementOrdersButton.UseVisualStyleBackColor = true;
            this.NextElementOrdersButton.Click += new System.EventHandler(this.NextElementOrdersButton_Click);
            // 
            // PreviousElementOrdersButton
            // 
            this.PreviousElementOrdersButton.Location = new System.Drawing.Point(30, 378);
            this.PreviousElementOrdersButton.Name = "PreviousElementOrdersButton";
            this.PreviousElementOrdersButton.Size = new System.Drawing.Size(209, 44);
            this.PreviousElementOrdersButton.TabIndex = 30;
            this.PreviousElementOrdersButton.Text = "Предыдущий заказ";
            this.PreviousElementOrdersButton.UseVisualStyleBackColor = true;
            this.PreviousElementOrdersButton.Click += new System.EventHandler(this.PreviousElementOrdersButton_Click);
            // 
            // PriceTypeLabel
            // 
            this.PriceTypeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PriceTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PriceTypeLabel.Location = new System.Drawing.Point(285, 233);
            this.PriceTypeLabel.Name = "PriceTypeLabel";
            this.PriceTypeLabel.Size = new System.Drawing.Size(315, 52);
            this.PriceTypeLabel.TabIndex = 28;
            this.PriceTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelTypeLabel
            // 
            this.ModelTypeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModelTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ModelTypeLabel.Location = new System.Drawing.Point(285, 160);
            this.ModelTypeLabel.Name = "ModelTypeLabel";
            this.ModelTypeLabel.Size = new System.Drawing.Size(315, 52);
            this.ModelTypeLabel.TabIndex = 27;
            this.ModelTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PriceLabel.Location = new System.Drawing.Point(30, 233);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(225, 52);
            this.PriceLabel.TabIndex = 26;
            this.PriceLabel.Text = "Цена:";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelLabel
            // 
            this.ModelLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ModelLabel.Location = new System.Drawing.Point(30, 160);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(225, 52);
            this.ModelLabel.TabIndex = 25;
            this.ModelLabel.Text = "Модель:";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextElementOrdersButton);
            this.Controls.Add(this.PreviousElementOrdersButton);
            this.Controls.Add(this.PriceTypeLabel);
            this.Controls.Add(this.ModelTypeLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OrdersLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPA";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label OrdersLabel;
        private System.Windows.Forms.Button NextElementOrdersButton;
        private System.Windows.Forms.Button PreviousElementOrdersButton;
        private System.Windows.Forms.Label PriceTypeLabel;
        private System.Windows.Forms.Label ModelTypeLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ModelLabel;
    }
}