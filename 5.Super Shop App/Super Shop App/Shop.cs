using System.Collections.Generic;

namespace Super_Shop_App
{
    internal class Shop
    {
        public string Name { get; private set; }
        public string Address { get; private set; }

    //  private Product Aproduct;
        public Dictionary<string, Product> Products { get; private set; }
        

        public  Shop(string name, string address):this()
        {
            Name = name;
            Address = address;
           
        }

        public Shop()
        {
            Products=new Dictionary<string, Product>();
        }

        public string Calculation(Product productObj)
        {
            string key = productObj.ProductId;
          int value;
            foreach (var product in Products)
            {
                if (product.Key==key)
                {
                    value = product.Value.Quantity;
                    value+= productObj.Quantity;
                    Products.Remove(key);
                    productObj.Quantity = value;
                    Products.Add(key, productObj);
                    return "item girl saved"; 
                }
                
            }

            Products.Add(key,productObj);
            return "item girl saved";
        }


    }
}