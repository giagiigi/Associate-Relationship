namespace Bank_Account_App
{
    internal class Customer
    {
       
            public string Name { set; get; }
            public string Email { set; get; }
            public Account CustomerAccount { set; get; }

            public Customer(string name, string email)
            {
                Name = name;
                Email = email;
            }

            public Customer()
            {

            }
        
    }
}