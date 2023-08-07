using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMangment
{
    public class MyProduct :BaseEntity
    {
          
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }


        
        public override bool Validate()
        {
            var isValid = true;
            if (String.IsNullOrWhiteSpace(Name)) isValid = false;
        

            return isValid;
        }

      
    }
}
