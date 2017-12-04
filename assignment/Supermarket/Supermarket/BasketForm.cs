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

        // Initialize DB
        private static DBModel dBModel = new DBModel();

        // Instantiate the basket
        //private static List<Offer> offers = (from o in dBModel.Offers select o).ToList();
        private ShoppingBasket basket = new ShoppingBasket();

        private void BasketForm_Load(object sender, EventArgs e)
        {
            // Get the collections of products
            var productNames = (from p in dBModel.Products
                                select p).ToList();

            // Set the UI with correct information
            productNameComboBox.DataSource = productNames;
            SetCurrentProduct((Product)productNameComboBox.SelectedItem);
            basketDataGridView.DataSource = basket;
            basketDataGridView.Columns["ProductID"].HeaderText = "Product ID";
            basketDataGridView.Columns["ProductID"].DisplayIndex = 0;
            basketDataGridView.Columns["UnitPrice"].HeaderText = "Unit Price";
            basketDataGridView.Columns["UnitPrice"].DefaultCellStyle.Format = "c2";
            basketDataGridView.Columns["UnitPrice"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");
            basketDataGridView.Columns["TotalPrice"].HeaderText = "Total Price";
            basketDataGridView.Columns["TotalPrice"].DefaultCellStyle.Format = "c2";
            basketDataGridView.Columns["TotalPrice"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");
        }

        private void SetCurrentProduct(Product currentSelection)
        {
            // Update the Latest Price
            decimal currentSelectionPrice = Math.Round(currentSelection.UnitPrice, 2);
            latestPriceTextBox.Text = "£" + currentSelectionPrice.ToString();
            quantityNumericUpDown.Value = 1.0M;
            // Update the available offer;
            if (currentSelection.Offer == null)
                offerTextBox.Text = "No offer available";
            else if (string.IsNullOrEmpty(currentSelection.Offer.OfferDescription))
                offerTextBox.Text = "There is no description for this offer!";
            else
                offerTextBox.Text = currentSelection.Offer.OfferDescription;
        }

        private void ProductNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product currentSelection = (Product)productNameComboBox.SelectedItem;
            SetCurrentProduct(currentSelection);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Product product = (Product)productNameComboBox.SelectedItem;
            int quantity = Convert.ToInt32(quantityNumericUpDown.Value);
            // Create a basket item with the correct offer
            BasketItem item = new BasketItem(product, quantity);
            // Add it to Shopping basket object
            basket.Add(item);
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            // Update the basketDataGridView
            basketDataGridView.DataBindings.Clear();
            basketDataGridView.DataSource = basket.ToList();
            basketDataGridView.AutoResizeColumns();
            basketDataGridView.ClearSelection();
            // Update the offerDataGridView
            offersAppliedDataGridView.DataBindings.Clear();
            offersAppliedDataGridView.DataSource = basket.OfferList.ToList();
            offersAppliedDataGridView.AutoResizeColumns();
            // Update the totals
            noItemsTextBox.Text = basket.NumberItems.ToString();
            totalTextBox.Text = "£"+basket.Total.ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in basketDataGridView.SelectedRows)
            {
                basket.Remove((BasketItem)item.DataBoundItem);
            }
            UpdateDataGridView();
        }

        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            basket.Clear();
            UpdateDataGridView();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
