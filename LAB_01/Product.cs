using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_01
{
    public class Product
    {
        // PROPERTIES
        public string ProdName { get; }
        public int ProdPrice { get; }
        public string ProdCode { get; }

        // CONSTRUCTOR
        public Product(string prodName, int prodPrice, string prodCode) 
        {
            ProdName = prodName;
            ProdPrice = prodPrice;
            ProdCode = prodCode;    
        }
    }
}
