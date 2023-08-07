using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using InventoryMangment;

namespace InventoryMangment
{
    public class InventoryManger 
    {

        private List<MyProduct> Products;

        public InventoryManger()
        {
            Products = new List<MyProduct>();
        }

        public void AddNewProduct(MyProduct product)
        {
            if (product.IsValid) { Products.Add(product); }
            else throw new Exception("something went wrong");
        }
        public List<MyProduct> GetProducts() => Products;


    }
}
