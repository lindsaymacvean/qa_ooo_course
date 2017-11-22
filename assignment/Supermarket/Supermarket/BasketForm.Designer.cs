namespace Supermarket
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
            this.productNameLabel = new System.Windows.Forms.Label();
            this.latestPriceLabel = new System.Windows.Forms.Label();
            this.offerLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.basketLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.noItemsLabel = new System.Windows.Forms.Label();
            this.productNameField = new System.Windows.Forms.ComboBox();
            this.latestPriceField = new System.Windows.Forms.TextBox();
            this.offerField = new System.Windows.Forms.ListBox();
            this.quantityField = new System.Windows.Forms.NumericUpDown();
            this.basketField = new System.Windows.Forms.ListView();
            this.addButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.removeAllButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.noItemsField = new System.Windows.Forms.TextBox();
            this.totalField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityField)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(33, 25);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(78, 13);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Product Name:";
            // 
            // latestPriceLabel
            // 
            this.latestPriceLabel.AutoSize = true;
            this.latestPriceLabel.Location = new System.Drawing.Point(170, 25);
            this.latestPriceLabel.Name = "latestPriceLabel";
            this.latestPriceLabel.Size = new System.Drawing.Size(66, 13);
            this.latestPriceLabel.TabIndex = 1;
            this.latestPriceLabel.Text = "Latest Price:";
            // 
            // offerLabel
            // 
            this.offerLabel.AutoSize = true;
            this.offerLabel.Location = new System.Drawing.Point(287, 25);
            this.offerLabel.Name = "offerLabel";
            this.offerLabel.Size = new System.Drawing.Size(33, 13);
            this.offerLabel.TabIndex = 2;
            this.offerLabel.Text = "Offer:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(439, 25);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Quantity:";
            // 
            // basketLabel
            // 
            this.basketLabel.AutoSize = true;
            this.basketLabel.Location = new System.Drawing.Point(33, 127);
            this.basketLabel.Name = "basketLabel";
            this.basketLabel.Size = new System.Drawing.Size(43, 13);
            this.basketLabel.TabIndex = 4;
            this.basketLabel.Text = "Basket:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(287, 263);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "Total:";
            // 
            // noItemsLabel
            // 
            this.noItemsLabel.AutoSize = true;
            this.noItemsLabel.Location = new System.Drawing.Point(33, 263);
            this.noItemsLabel.Name = "noItemsLabel";
            this.noItemsLabel.Size = new System.Drawing.Size(55, 13);
            this.noItemsLabel.TabIndex = 6;
            this.noItemsLabel.Text = "No. Items:";
            // 
            // productNameField
            // 
            this.productNameField.FormattingEnabled = true;
            this.productNameField.Location = new System.Drawing.Point(36, 45);
            this.productNameField.Name = "productNameField";
            this.productNameField.Size = new System.Drawing.Size(121, 21);
            this.productNameField.TabIndex = 7;
            this.productNameField.SelectedIndexChanged += new System.EventHandler(this.productNameField_SelectedIndexChanged);
            // 
            // latestPriceField
            // 
            this.latestPriceField.Location = new System.Drawing.Point(173, 46);
            this.latestPriceField.Name = "latestPriceField";
            this.latestPriceField.ReadOnly = true;
            this.latestPriceField.Size = new System.Drawing.Size(100, 20);
            this.latestPriceField.TabIndex = 8;
            // 
            // offerField
            // 
            this.offerField.FormattingEnabled = true;
            this.offerField.Location = new System.Drawing.Point(290, 46);
            this.offerField.Name = "offerField";
            this.offerField.Size = new System.Drawing.Size(133, 69);
            this.offerField.TabIndex = 9;
            // 
            // quantityField
            // 
            this.quantityField.Location = new System.Drawing.Point(442, 47);
            this.quantityField.Name = "quantityField";
            this.quantityField.Size = new System.Drawing.Size(75, 20);
            this.quantityField.TabIndex = 10;
            // 
            // basketField
            // 
            this.basketField.Location = new System.Drawing.Point(36, 143);
            this.basketField.Name = "basketField";
            this.basketField.Size = new System.Drawing.Size(481, 97);
            this.basketField.TabIndex = 11;
            this.basketField.UseCompatibleStateImageBehavior = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(665, 36);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "removeButton";
            this.button2.Location = new System.Drawing.Point(523, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // removeAllButton
            // 
            this.removeAllButton.Location = new System.Drawing.Point(523, 172);
            this.removeAllButton.Name = "removeAllButton";
            this.removeAllButton.Size = new System.Drawing.Size(75, 23);
            this.removeAllButton.TabIndex = 14;
            this.removeAllButton.Text = "Remove All";
            this.removeAllButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(665, 253);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // noItemsField
            // 
            this.noItemsField.Location = new System.Drawing.Point(94, 260);
            this.noItemsField.Name = "noItemsField";
            this.noItemsField.ReadOnly = true;
            this.noItemsField.Size = new System.Drawing.Size(100, 20);
            this.noItemsField.TabIndex = 16;
            // 
            // totalField
            // 
            this.totalField.Location = new System.Drawing.Point(327, 260);
            this.totalField.Name = "totalField";
            this.totalField.ReadOnly = true;
            this.totalField.Size = new System.Drawing.Size(100, 20);
            this.totalField.TabIndex = 17;
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 301);
            this.Controls.Add(this.totalField);
            this.Controls.Add(this.noItemsField);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.removeAllButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.basketField);
            this.Controls.Add(this.quantityField);
            this.Controls.Add(this.offerField);
            this.Controls.Add(this.latestPriceField);
            this.Controls.Add(this.productNameField);
            this.Controls.Add(this.noItemsLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.basketLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.offerLabel);
            this.Controls.Add(this.latestPriceLabel);
            this.Controls.Add(this.productNameLabel);
            this.Name = "BasketForm";
            this.Text = "Shopping Basket";
            this.Load += new System.EventHandler(this.BasketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label latestPriceLabel;
        private System.Windows.Forms.Label offerLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label basketLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label noItemsLabel;
        private System.Windows.Forms.ComboBox productNameField;
        private System.Windows.Forms.TextBox latestPriceField;
        private System.Windows.Forms.ListBox offerField;
        private System.Windows.Forms.NumericUpDown quantityField;
        private System.Windows.Forms.ListView basketField;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button removeAllButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox noItemsField;
        private System.Windows.Forms.TextBox totalField;
    }
}

