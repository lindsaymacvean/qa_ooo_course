using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Supermarket
{
    public partial class BasketForm : Form
    {
        public BasketForm()
        {
            InitializeComponent();
        }

        // There is only one basket so setting this as a class property
        private ShoppingBasket basket = new ShoppingBasket();

        private void BasketForm_Load(object sender, EventArgs e)
        {
            // Get the collections of products and offers
            DBModel dBModel = new DBModel();
            var productNames = (from p in dBModel.Products
                                select p).ToList();
            var offers = (from o in dBModel.Offers select o).ToList();

            // Set the UI with correct information
            productNameComboBox.DataSource = productNames;
            //offerLabel.Text = (Product)productNameComboBox.SelectedItem.Offer.OfferDescription;
            SetCurrentProduct((Product)productNameComboBox.SelectedItem);
            basketDataGridView.DataSource = basket.Items;
            basketDataGridView.Columns[1].DefaultCellStyle.Format = "c2";
            basketDataGridView.Columns[1].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");
            basketDataGridView.Columns[4].DefaultCellStyle.Format = "c2";
            basketDataGridView.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");


        }

        private void SetCurrentProduct(Product currentSelection)
        {
            // Update the Latest Price
            decimal currentSelectionPrice = Math.Round(currentSelection.UnitPrice, 2);
            latestPriceTextBox.Text = "£" + currentSelectionPrice.ToString();
            //string description = currentSelection.Offer.OfferDescription;
            // Update the available offer
            //offerCheckBox.Text = string.IsNullOrEmpty(description) ? description : "No offer available";
            //offerCheckBox.Enabled = string.IsNullOrEmpty(description) ? true : false;
            
        }

        private void productNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product currentSelection = (Product)productNameComboBox.SelectedItem;
            SetCurrentProduct(currentSelection);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Product product = (Product)productNameComboBox.SelectedItem;
            bool offer = offerCheckBox.Checked;
            decimal quantity = quantityNumericUpDown.Value;
            // Create a basket item with the correct offer
            BasketItem item = new BasketItem(product, quantity, offer);
            // Add it to Shopping basket object
            basket.Items.Add(item);
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            // Update the DataGridView
            basketDataGridView.DataBindings.Clear();
            basketDataGridView.DataSource = basket.Items.ToList();
            basketDataGridView.AutoResizeColumns();
            // Update the totals
            noItemsTextBox.Text = basket.NumberItems.ToString();
            totalTextBox.Text = basket.Total.ToString();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in basketDataGridView.SelectedRows)
            {
                basket.Items.Remove((BasketItem)item.DataBoundItem);
            }
            UpdateDataGridView();
        }

        private void removeAllButton_Click(object sender, EventArgs e)
        {
            basket.Items.Clear();
            UpdateDataGridView();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
