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
          this.lstSalesFigures = new System.Windows.Forms.ListBox();
          this.btnMonthlySalesFigures = new System.Windows.Forms.Button();
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
          // 
          // lstSalesFigures
          // 
          this.lstSalesFigures.FormattingEnabled = true;
          this.lstSalesFigures.Location = new System.Drawing.Point(46, 127);
          this.lstSalesFigures.Name = "lstSalesFigures";
          this.lstSalesFigures.Size = new System.Drawing.Size(269, 147);
          this.lstSalesFigures.TabIndex = 3;
          // 
          // btnMonthlySalesFigures
          // 
          this.btnMonthlySalesFigures.Location = new System.Drawing.Point(163, 55);
          this.btnMonthlySalesFigures.Name = "btnMonthlySalesFigures";
          this.btnMonthlySalesFigures.Size = new System.Drawing.Size(152, 23);
          this.btnMonthlySalesFigures.TabIndex = 4;
          this.btnMonthlySalesFigures.Text = "Monthly Sales Figures";
          this.btnMonthlySalesFigures.UseVisualStyleBackColor = true;
          // 
          // Form1
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(392, 298);
          this.Controls.Add(this.btnMonthlySalesFigures);
          this.Controls.Add(this.lstSalesFigures);
          this.Controls.Add(this.btnSalesFigures);
          this.Name = "Form1";
          this.Text = "Form1";
          this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalesFigures;
        private System.Windows.Forms.ListBox lstSalesFigures;
        private System.Windows.Forms.Button btnMonthlySalesFigures;
    }
}

