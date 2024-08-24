using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vangti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayVangti(decimal diff)
        {
            if (diff >= 1000)
            {
                lstBox.Items.Add(((int)diff / 1000).ToString() + " Thousand Taka Note(s)");
                diff -= ((int)diff / 1000) * 1000;
            }
            if (diff >= 500)
            {
                lstBox.Items.Add(((int)diff / 500).ToString() + " 500 Taka Note(s)");
                diff -= ((int)diff / 500) * 500;
            }
            if (diff >= 200)
            {
                lstBox.Items.Add(((int)diff / 200).ToString() + " 200 Taka Note(s)");
                diff -= ((int)diff / 200) * 200;
            }
            if (diff >= 100)
            {
                lstBox.Items.Add(((int)diff / 100).ToString() + " 100 Taka Note(s)");
                diff -= ((int)diff / 100) * 100;
            }
            if (diff >= 50)
            {
                lstBox.Items.Add(((int)diff / 50).ToString() + " 50 Taka Note(s)");
                diff -= ((int)diff / 50) * 50;
            }
            if (diff >= 20)
            {
                lstBox.Items.Add(((int)diff / 20).ToString() + " 20 Taka Note(s)");
                diff -= ((int)diff / 20) * 20;
            }
            if (diff >= 10)
            {
                lstBox.Items.Add(((int)diff / 10).ToString() + " 10 Taka Note(s)");
                diff -= ((int)diff / 10) * 10;
            }
            if (diff >= 5)
            {
                lstBox.Items.Add(((int)diff / 5).ToString() + " 5 Taka Note(s)/Coin(s)");
                diff -= ((int)diff / 5) * 5;
            }
            if (diff >= 2)
            {
                lstBox.Items.Add(((int)diff / 2m).ToString() + " 2 Taka Coin(s)");
                diff -= ((int)diff / 2m) * 2m;
            }
            if (diff >= 1)
            {
                lstBox.Items.Add(((int)diff / 1m).ToString() + " 1 Taka Coin(s)");
                diff -= ((int)diff / 1m) * 1m;
            }

            if (diff != 0)
            {
                lstBox.Items.Add(diff.ToString());  // Handle any remaining fractional amount, if needed.
            }
        }

        private void btnVangti_Click(object sender, EventArgs e)
        {
            try
            {
                decimal cost = decimal.Parse(txtTotalCost.Text);
                decimal moneyPresented = decimal.Parse(txtMoneyPresented.Text);

                lstBox.Items.Clear();

                if (cost > moneyPresented)
                {
                    MessageBox.Show("You need more money", "Vangti");
                }

                else
                {
                    decimal diff = Math.Abs(moneyPresented - cost);
                    DisplayVangti(diff);

                }
            }
            catch
            {
                txtTotalCost.Text = "";
                txtMoneyPresented.Text = "";
                txtTotalCost.Focus();
            }

        }
    }
}
