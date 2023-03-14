using System;

namespace CustomerAccount
{
    class Customer_Account
    {
        public string? bank_name;
        long customer_accountno;
        string customer_name;

        //parameterized customer account constructor   
        public Customer_Account(long accountNo, string customerName)
        {
            this.customer_accountno = accountNo;
            this.customer_name= customerName;
        }

        /// <summary>
        /// The method displays the details of the customer. 
        /// </summary>
        /// <returns>void</returns>
        public void Printinfo()
        {
            Console.WriteLine("Bank : {0}", this.bank_name);
            Console.WriteLine("Customer Account Number : {0}", this.customer_accountno);
            Console.WriteLine("Customer Name : {0}", this.customer_name);  
        }

        public static void Main()
        {
            Customer_Account customer = new Customer_Account(123456789987654, "Suman Jha");
            customer.bank_name = "Apna Bank Limited";
            customer.Printinfo();
        }
    }

}