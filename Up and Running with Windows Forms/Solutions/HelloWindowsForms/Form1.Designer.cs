namespace HelloWindowsForms
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
          this.btnOK = new System.Windows.Forms.Button();
          this.lblName = new System.Windows.Forms.Label();
          this.txtName = new System.Windows.Forms.TextBox();
          this.grpColours = new System.Windows.Forms.GroupBox();
          this.radBlue = new System.Windows.Forms.RadioButton();
          this.radGreen = new System.Windows.Forms.RadioButton();
          this.radRed = new System.Windows.Forms.RadioButton();
          this.grpColours.SuspendLayout();
          this.SuspendLayout();
          // 
          // btnOK
          // 
          this.btnOK.Location = new System.Drawing.Point(197, 227);
          this.btnOK.Name = "btnOK";
          this.btnOK.Size = new System.Drawing.Size(75, 23);
          this.btnOK.TabIndex = 0;
          this.btnOK.Text = "OK";
          this.btnOK.UseVisualStyleBackColor = true;
          this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
          // 
          // lblName
          // 
          this.lblName.AutoSize = true;
          this.lblName.Location = new System.Drawing.Point(51, 29);
          this.lblName.Name = "lblName";
          this.lblName.Size = new System.Drawing.Size(38, 13);
          this.lblName.TabIndex = 1;
          this.lblName.Text = "Name:";
          // 
          // txtName
          // 
          this.txtName.Location = new System.Drawing.Point(106, 29);
          this.txtName.Name = "txtName";
          this.txtName.Size = new System.Drawing.Size(133, 20);
          this.txtName.TabIndex = 2;
          // 
          // grpColours
          // 
          this.grpColours.Controls.Add(this.radBlue);
          this.grpColours.Controls.Add(this.radGreen);
          this.grpColours.Controls.Add(this.radRed);
          this.grpColours.Location = new System.Drawing.Point(13, 70);
          this.grpColours.Name = "grpColours";
          this.grpColours.Size = new System.Drawing.Size(259, 100);
          this.grpColours.TabIndex = 3;
          this.grpColours.TabStop = false;
          this.grpColours.Text = "Colours";
          // 
          // radBlue
          // 
          this.radBlue.AutoSize = true;
          this.radBlue.Location = new System.Drawing.Point(7, 68);
          this.radBlue.Name = "radBlue";
          this.radBlue.Size = new System.Drawing.Size(46, 17);
          this.radBlue.TabIndex = 2;
          this.radBlue.TabStop = true;
          this.radBlue.Text = "Blue";
          this.radBlue.UseVisualStyleBackColor = true;
          this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
          // 
          // radGreen
          // 
          this.radGreen.AutoSize = true;
          this.radGreen.Location = new System.Drawing.Point(7, 44);
          this.radGreen.Name = "radGreen";
          this.radGreen.Size = new System.Drawing.Size(54, 17);
          this.radGreen.TabIndex = 1;
          this.radGreen.TabStop = true;
          this.radGreen.Text = "Green";
          this.radGreen.UseVisualStyleBackColor = true;
          this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
          // 
          // radRed
          // 
          this.radRed.AutoSize = true;
          this.radRed.Location = new System.Drawing.Point(7, 20);
          this.radRed.Name = "radRed";
          this.radRed.Size = new System.Drawing.Size(45, 17);
          this.radRed.TabIndex = 0;
          this.radRed.TabStop = true;
          this.radRed.Text = "Red";
          this.radRed.UseVisualStyleBackColor = true;
          this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
          // 
          // Form1
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(284, 262);
          this.Controls.Add(this.grpColours);
          this.Controls.Add(this.txtName);
          this.Controls.Add(this.lblName);
          this.Controls.Add(this.btnOK);
          this.Name = "Form1";
          this.Text = "Form1";
          this.grpColours.ResumeLayout(false);
          this.grpColours.PerformLayout();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpColours;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
    }
}

