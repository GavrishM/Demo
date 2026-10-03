using DemoLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Views
{
    public interface IProductsView
    {
        void Show(Product product);
    }
}
