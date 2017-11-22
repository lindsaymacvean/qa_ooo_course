using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NWWinForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        Northwind.Northwind ctx;
        private void Form1_Load(object sender, EventArgs e) {
            ctx = new Northwind.Northwind();
            var query = ctx.Customers;
            customerBindingSource.DataSource = query.ToList();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            ctx.SaveChanges();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            if (ctx != null) {
                ctx.Dispose();
            }
        }
    }
}
