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
            this.productNameComboBox = new System.Windows.Forms.ComboBox();
            this.latestPriceTextBox = new System.Windows.Forms.TextBox();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.removeAllButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.noItemsTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.basketDataGridView = new System.Windows.Forms.DataGridView();
            this.offerCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketDataGridView)).BeginInit();
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
            this.latestPriceLabel.Location = new System.Drawing.Point(241, 24);
            this.latestPriceLabel.Name = "latestPriceLabel";
            this.latestPriceLabel.Size = new System.Drawing.Size(66, 13);
            this.latestPriceLabel.TabIndex = 1;
            this.latestPriceLabel.Text = "Latest Price:";
            // 
            // offerLabel
            // 
            this.offerLabel.AutoSize = true;
            this.offerLabel.Location = new System.Drawing.Point(339, 26);
            this.offerLabel.Name = "offerLabel";
            this.offerLabel.Size = new System.Drawing.Size(79, 13);
            this.offerLabel.TabIndex = 2;
            this.offerLabel.Text = "Available Offer:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(629, 23);
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
            this.totalLabel.Location = new System.Drawing.Point(225, 404);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "Total:";
            // 
            // noItemsLabel
            // 
            this.noItemsLabel.AutoSize = true;
            this.noItemsLabel.Location = new System.Drawing.Point(33, 404);
            this.noItemsLabel.Name = "noItemsLabel";
            this.noItemsLabel.Size = new System.Drawing.Size(55, 13);
            this.noItemsLabel.TabIndex = 6;
            this.noItemsLabel.Text = "No. Items:";
            // 
            // productNameComboBox
            // 
            this.productNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.Location = new System.Drawing.Point(36, 45);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(186, 21);
            this.productNameComboBox.TabIndex = 7;
            this.productNameComboBox.SelectedIndexChanged += new System.EventHandler(this.productNameComboBox_SelectedIndexChanged);
            // 
            // latestPriceTextBox
            // 
            this.latestPriceTextBox.Location = new System.Drawing.Point(244, 46);
            this.latestPriceTextBox.Name = "latestPriceTextBox";
            this.latestPriceTextBox.ReadOnly = true;
            this.latestPriceTextBox.Size = new System.Drawing.Size(77, 20);
            this.latestPriceTextBox.TabIndex = 8;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(632, 45);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.quantityNumericUpDown.TabIndex = 10;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(750, 45);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.AccessibleDescription = "";
            this.removeButton.Location = new System.Drawing.Point(750, 143);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeAllButton
            // 
            this.removeAllButton.Location = new System.Drawing.Point(750, 172);
            this.removeAllButton.Name = "removeAllButton";
            this.removeAllButton.Size = new System.Drawing.Size(75, 23);
            this.removeAllButton.TabIndex = 14;
            this.removeAllButton.Text = "Remove All";
            this.removeAllButton.UseVisualStyleBackColor = true;
            this.removeAllButton.Click += new System.EventHandler(this.removeAllButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(750, 398);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // noItemsTextBox
            // 
            this.noItemsTextBox.Location = new System.Drawing.Point(94, 401);
            this.noItemsTextBox.Name = "noItemsTextBox";
            this.noItemsTextBox.ReadOnly = true;
            this.noItemsTextBox.Size = new System.Drawing.Size(100, 20);
            this.noItemsTextBox.TabIndex = 16;
            this.noItemsTextBox.Text = "0";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(265, 401);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 17;
            this.totalTextBox.Text = "£0.00";
            // 
            // basketDataGridView
            // 
            this.basketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basketDataGridView.Location = new System.Drawing.Point(36, 143);
            this.basketDataGridView.Name = "basketDataGridView";
            this.basketDataGridView.ReadOnly = true;
            this.basketDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.basketDataGridView.Size = new System.Drawing.Size(708, 252);
            this.basketDataGridView.TabIndex = 18;
            // 
            // offerCheckBox
            // 
            this.offerCheckBox.AutoSize = true;
            this.offerCheckBox.Location = new System.Drawing.Point(342, 48);
            this.offerCheckBox.Name = "offerCheckBox";
            this.offerCheckBox.Size = new System.Drawing.Size(80, 17);
            this.offerCheckBox.TabIndex = 20;
            this.offerCheckBox.Text = "checkBox1";
            this.offerCheckBox.UseVisualStyleBackColor = true;
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 426);
            this.Controls.Add(this.offerCheckBox);
            this.Controls.Add(this.basketDataGridView);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.noItemsTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.removeAllButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.latestPriceTextBox);
            this.Controls.Add(this.productNameComboBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketDataGridView)).EndInit();
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
        private System.Windows.Forms.ComboBox productNameComboBox;
        private System.Windows.Forms.TextBox latestPriceTextBox;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button removeAllButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox noItemsTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.DataGridView basketDataGridView;
        private System.Windows.Forms.CheckBox offerCheckBox;
    }
}

