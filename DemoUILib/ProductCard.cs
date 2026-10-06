using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoLib;
using DemoLib.Models;
using DemoLib.Presenters;
using DemoLib.Views;


namespace DemoUILib
{
    public partial class MainUserControl: UserControl, IProductsView
    {
        public Product Product { get; set; }
        public MainUserControl(Product product)
        {
            InitializeComponent();
            Product = product;
        }
        public void Show(Product product)
        {

        }

        private void MainUserControl_Load(object sender, EventArgs e)
        {
            NameLabel.Text = Product.Name;
            SupplierLabel.Text = Product.Supplier;
            CategoryLabel.Text = Product.Category;
            QuantityLabel.Text = Product.Count.ToString();
            PriceLabel.Text = Product.Price.ToString();
            if ((Product.ImagePath != null) && (Product.ImagePath != ""))
            {
                MainPictureBox.ImageLocation = Product.ImagePath;
            }
        }
    }
}
