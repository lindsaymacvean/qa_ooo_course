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

            // Set the basket datagridview
            basketDataGridView.AutoGenerateColumns = false;
            basketDataGridView.ColumnCount = 6;
            basketDataGridView.Columns[0].HeaderText = "Product ID";
            basketDataGridView.Columns[0].DataPropertyName = "ProductID";
            basketDataGridView.Columns[1].HeaderText = "Name";
            basketDataGridView.Columns[1].DataPropertyName = "Name";
            basketDataGridView.Columns[2].HeaderText = "Unit Price";
            basketDataGridView.Columns[2].DataPropertyName = "UnitPrice";
            basketDataGridView.Columns[2].Name = "UnitPrice";
            basketDataGridView.Columns[3].HeaderText = "Quantity";
            basketDataGridView.Columns[3].DataPropertyName = "Quantity";
            basketDataGridView.Columns[4].HeaderText = "Total Price";
            basketDataGridView.Columns[4].DataPropertyName = "TotalPrice";
            basketDataGridView.Columns[4].Name = "TotalPrice";
            basketDataGridView.Columns[5].HeaderText = "Offer Shortcode";
            basketDataGridView.Columns[5].DataPropertyName = "OfferShortDescription";
            // The Offershortcode to be taken from the associated Offer in UpdateDataGridViews() 
            basketDataGridView.Columns["UnitPrice"].DefaultCellStyle.Format = "c2";
            basketDataGridView.Columns["UnitPrice"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");
            basketDataGridView.Columns["TotalPrice"].DefaultCellStyle.Format = "c2";
            basketDataGridView.Columns["TotalPrice"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");

            // Set explicit columns on Offers datagridview
            offersAppliedDataGridView.AutoGenerateColumns = false;
            offersAppliedDataGridView.ColumnCount = 4;
            offersAppliedDataGridView.Columns[0].HeaderText = "Offer Description";
            offersAppliedDataGridView.Columns[0].DataPropertyName = "OfferDescription";
            offersAppliedDataGridView.Columns[1].HeaderText = "Quantity";
            offersAppliedDataGridView.Columns[1].DataPropertyName = "Quantity";
            offersAppliedDataGridView.Columns[2].HeaderText = "Discount Percentage";
            offersAppliedDataGridView.Columns[2].DataPropertyName = "DiscountPercentage";
            offersAppliedDataGridView.Columns[3].HeaderText = "Discount Amount";
            offersAppliedDataGridView.Columns[3].DataPropertyName = "DiscountAmount";
            offersAppliedDataGridView.Columns[3].Name = "DiscountAmount";
            offersAppliedDataGridView.Columns["DiscountAmount"].DefaultCellStyle.Format = "c2";
            offersAppliedDataGridView.Columns["DiscountAmount"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");
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
            UpdateDataGridViews();
        }

        private void UpdateDataGridViews()
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
            offersAppliedDataGridView.ClearSelection();
            // Update the totals
            noItemsTextBox.Text = basket.NumberItems.ToString();
            totalTextBox.Text = "£"+basket.Total.ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in basketDataGridView.SelectedRows)
            {
                basket.Remove((BasketItem)row.DataBoundItem);
            }
            UpdateDataGridViews();
        }

        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            basket.OfferList.Clear();
            basket.Clear();
            UpdateDataGridViews();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
