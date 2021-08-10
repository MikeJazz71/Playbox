using System;
using System.Collections.Generic;
using System.Xml.Xsl;

namespace Playbox
{

   
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;  }

       
        

        public List<Order> Orders; 
        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int a) : this()
        {
            this.CustomerID = a; 
        }



        public Customer(int a, string b) : this(a)
        {
            this.CustomerID = a;
            this.FirstName = b; 

        }

        public Customer(int customerId, string firstName, string lastName) :this()
        {
            this.CustomerID = CustomerID;
            this.FirstName = firstName;
            this.LastName = lastName; 
        }

        public void IntroduceCustomer(string a, string b)
        {
            Console.WriteLine("Hello! My name is " + a + " " + b);
        }

    }
}