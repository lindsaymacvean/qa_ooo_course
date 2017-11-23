using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWindowsForms {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void btnOK_Click(object sender, EventArgs e) {
      MessageBox.Show("Hello " + txtName.Text, "My App");
    }

    private void radRed_CheckedChanged(object sender, EventArgs e) {
      this.BackColor = Color.Red;
    }
    private void radGreen_CheckedChanged(object sender, EventArgs e) {
      this.BackColor = Color.Green;
    }
    private void radBlue_CheckedChanged(object sender, EventArgs e) {
      this.BackColor = Color.Blue;
    }


  }
}
