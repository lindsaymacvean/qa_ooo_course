using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalesFigures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalesFigures_Click(object sender, EventArgs e)
        {
            lstSalesFigures.Items.Clear();

            int numberOfSalesFigures = 0;
            if (int.TryParse(txtNumberOfSalesFigures.Text, out numberOfSalesFigures))
            {
                int[] salesFigures = new int[numberOfSalesFigures];
                for (int i = 0; i < salesFigures.Length; i++)
                {
                    salesFigures[i] = (i+1) * 10;
                    lstSalesFigures.Items.Add(salesFigures[i]);
                }
            }
            else
            {
                MessageBox.Show("The contents of the number of sales figures text box must be numeric");
            }
        }

        private void btnMonthlySalesFigs_Click(object sender, EventArgs e)
        {
           lstSalesFigures.Items.Clear();

           int[,] monthlySalesFigs = new int[12, 5];

            for (int monthNum = 0; monthNum <= monthlySalesFigs.GetUpperBound(0); monthNum++)
            {
                lstSalesFigures.Items.Add(System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.MonthNames[monthNum]);

                for (int salesArea = 0; salesArea <= monthlySalesFigs.GetUpperBound(1); salesArea++)
                {
                    monthlySalesFigs[monthNum, salesArea] = ((monthNum + 1) * 11) / (salesArea + 1);
                    lstSalesFigures.Items.Add(string.Format("\t{0}", monthlySalesFigs[monthNum, salesArea]));
                }
            }
        }
    }
}
