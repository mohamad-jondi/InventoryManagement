using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using InventoryMangment;

namespace InventoryMangment
{
    public sealed class ProductsRepo 
    {
        
            private ProductsRepo() { Products = new List<MyProduct>(); }
            private static ProductsRepo instance = null;
            public static ProductsRepo Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new ProductsRepo();
                    }
                    return instance;
                }
            }
        

        private List<MyProduct> Products;

        
        public void AddNewProduct(MyProduct product)
        {
            if (product.IsValid) { Products.Add(product); }
            else throw new Exception("something went wrong");
        }
        public List<MyProduct> GetProducts() => Products;


    }
}
