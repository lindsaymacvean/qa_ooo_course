namespace SalesFigures
{
    partial class Form1
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
            this.btnSalesFigures = new System.Windows.Forms.Button();
            this.lblNumberOfSalesFigures = new System.Windows.Forms.Label();
            this.txtNumberOfSalesFigures = new System.Windows.Forms.TextBox();
            this.lstSalesFigures = new System.Windows.Forms.ListBox();
            this.btnMonthlySalesFigs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalesFigures
            // 
            this.btnSalesFigures.Location = new System.Drawing.Point(46, 55);
            this.btnSalesFigures.Name = "btnSalesFigures";
            this.btnSalesFigures.Size = new System.Drawing.Size(100, 23);
            this.btnSalesFigures.TabIndex = 0;
            this.btnSalesFigures.Text = "Sales Figures";
            this.btnSalesFigures.UseVisualStyleBackColor = true;
            this.btnSalesFigures.Click += new System.EventHandler(this.btnSalesFigures_Click);
            // 
            // lblNumberOfSalesFigures
            // 
            this.lblNumberOfSalesFigures.AutoSize = true;
            this.lblNumberOfSalesFigures.Location = new System.Drawing.Point(43, 22);
            this.lblNumberOfSalesFigures.Name = "lblNumberOfSalesFigures";
            this.lblNumberOfSalesFigures.Size = new System.Drawing.Size(127, 13);
            this.lblNumberOfSalesFigures.TabIndex = 1;
            this.lblNumberOfSalesFigures.Text = "Number Of Sales Figures:";
            // 
            // txtNumberOfSalesFigures
            // 
            this.txtNumberOfSalesFigures.Location = new System.Drawing.Point(172, 19);
            this.txtNumberOfSalesFigures.Name = "txtNumberOfSalesFigures";
            this.txtNumberOfSalesFigures.Size = new System.Drawing.Size(26, 20);
            this.txtNumberOfSalesFigures.TabIndex = 2;
            this.txtNumberOfSalesFigures.Text = "0";
            // 
            // lstSalesFigures
            // 
            this.lstSalesFigures.FormattingEnabled = true;
            this.lstSalesFigures.Location = new System.Drawing.Point(46, 127);
            this.lstSalesFigures.Name = "lstSalesFigures";
            this.lstSalesFigures.Size = new System.Drawing.Size(185, 147);
            this.lstSalesFigures.TabIndex = 3;
            // 
            // btnMonthlySalesFigs
            // 
            this.btnMonthlySalesFigs.Location = new System.Drawing.Point(46, 85);
            this.btnMonthlySalesFigs.Name = "btnMonthlySalesFigs";
            this.btnMonthlySalesFigs.Size = new System.Drawing.Size(136, 23);
            this.btnMonthlySalesFigs.TabIndex = 4;
            this.btnMonthlySalesFigs.Text = "Monthly Sales Figures";
            this.btnMonthlySalesFigs.UseVisualStyleBackColor = true;
            this.btnMonthlySalesFigs.Click += new System.EventHandler(this.btnMonthlySalesFigs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 298);
            this.Controls.Add(this.btnMonthlySalesFigs);
            this.Controls.Add(this.lstSalesFigures);
            this.Controls.Add(this.txtNumberOfSalesFigures);
            this.Controls.Add(this.lblNumberOfSalesFigures);
            this.Controls.Add(this.btnSalesFigures);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalesFigures;
        private System.Windows.Forms.Label lblNumberOfSalesFigures;
        private System.Windows.Forms.TextBox txtNumberOfSalesFigures;
        private System.Windows.Forms.ListBox lstSalesFigures;
        private System.Windows.Forms.Button btnMonthlySalesFigs;
    }
}

