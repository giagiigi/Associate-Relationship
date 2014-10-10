using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Shop_App
{
    public partial class SuperShopUI : Form
    {
        private Shop aShop;
        private Product aProduct;
        public SuperShopUI()
        {
            InitializeComponent();
        }

        private void saveShopButton_Click(object sender, EventArgs e)
        {
            aShop=new Shop(nameTextBox.Text,addressTextBox.Text);
        }

        private void saveProductButton_Click(object sender, EventArgs e)
        {
            aProduct=new Product(productIdTextBox.Text,Convert.ToInt32(quantityTextBox.Text));
           // aShop.Aproduct = aProduct;
            string msg = aShop.Calculation(aProduct);
             MessageBox.Show(msg);
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            string msg = aShop.Name + " " + aShop.Address + "\nProduct Id\tQuantity\n";
            foreach (var product in aShop.Products)
            {
                msg += product.Value.ProductId + "\t" + product.Value.Quantity+"\n";
            }
            MessageBox.Show(msg);
        }
    }
}
