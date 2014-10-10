namespace Super_Shop_App
{
    internal class Product
    {
        public string ProductId { get; private set; }
        public int Quantity { get; set; }
      //public Shop aShop;


        public Product(string productId, int quantity)
       {
         //  Product aProduct = null;
            ProductId = productId;
            Quantity = quantity;

            
       }
    }
}