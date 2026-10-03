using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Models
{
    public interface IProductsModel
    {
        List<Product> Load();

        int GetCountProducts();
    }
}
