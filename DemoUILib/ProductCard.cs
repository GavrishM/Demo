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
        private Product product_;

        private Color normalColor_ = ColorTranslator.FromHtml("#D2F6E7");
        private Color enteringColor_ = ColorTranslator.FromHtml("#70B2AF");
        private Color deficitColor_ = ColorTranslator.FromHtml("#FF8080");

        public MainUserControl(Product product)
        {
            InitializeComponent();
            product_ = product; foreach (Control c in Controls)
            {
                c.MouseMove += ProductCard_MouseMove;
                c.MouseLeave += ProductCard_MouseLeave;
            }
        }

        public MainUserControl()
        {
            InitializeComponent();
            foreach (Control c in Controls)
            {
                c.MouseMove += ProductCard_MouseMove;
                c.MouseLeave += ProductCard_MouseLeave;
            }
        }

        private string CountText()
        {
            if (product_.Count > 5)
            {
                return product_.Count.ToString() + " (много)";
            }

            return product_.Count.ToString() + " (мало)";
        }

        private string ImagePath()
        {
            if (product_.ImagePath == "" || product_.ImagePath == null)
            {
                return "..\\..\\..\\Images\\picture.png";
            }

            return product_.ImagePath;
        }

        private Color GetColor()
        {
            if (product_.Count <= 3)
            {
                return deficitColor_;
            }

            return normalColor_;
        }

        public void Show(Product product)
        {
            product_ = product;

            CategoryLabel.Text = product.Category;

            QuantityLabel.Text = CountText();

            PartsLabel.Text = product.Parts;
            PriceLabel.Text = product.Price.ToString() + " руб.";
            SupplierLabel.Text = product.Supplier + " | " + product.Name;

            MainPictureBox.ImageLocation = ImagePath();

            BackColor = GetColor();

        }

        private void ProductCard_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = enteringColor_;
        }

        private void ProductCard_MouseLeave(object sender, System.EventArgs e)
        {
            BackColor = GetColor();

        }

        private void MainUserControl_Load(object sender, EventArgs e)
        {
            NameLabel.Text = product_.Name;
            SupplierLabel.Text = product_.Supplier;
            CategoryLabel.Text = product_.Category;
            QuantityLabel.Text = product_.Count.ToString();
            PriceLabel.Text = product_.Price.ToString();
            if ((product_.ImagePath != null) && (product_.ImagePath != ""))
            {
                MainPictureBox.ImageLocation = product_.ImagePath;
            }
        }
    }
}
