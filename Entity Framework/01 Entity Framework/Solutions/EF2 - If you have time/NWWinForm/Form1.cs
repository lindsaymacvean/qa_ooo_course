using Northwind;
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

        NorthwindEntities ctx;
        private void Form1_Load(object sender, EventArgs e) {
            ctx = new NorthwindEntities();
            //var query = ctx.Customers;
            var query = ctx.Customers.Where(c => c.Orders.Any(o => o.ShipCity.StartsWith("B")));
            customerBindingSource.DataSource = query.ToList();

            var query2 = ctx.Customers.Except(query);
            customerBindingSource1.DataSource = query2.ToList();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            ctx.SaveChanges();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            ctx.Dispose();
        }
    }
}
