using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class BasketForm : Form
    {
        public BasketForm()
        {
            InitializeComponent();
        }

        private void BasketForm_Load(object sender, EventArgs e)
        {
            DBModel dBModel = new DBModel();
            List<string> productNames = (from p in dBModel.Products
                                        select p.ProductName).ToList();
            productNameField.DataSource = productNames;
        }

        private void productNameField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
