using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMangment  
{
    internal class InventoryManger 
    {
        private List<Product> Products= new List<Product>();

        public void AddNewProduct(Product product)
        {
            if (product.IsValid) { Products.Add(product); }
            else throw new Exception("something went wrong");
        }


    }
}
