using CSharpFinalProject1.Entities;
using CSharpFinalProject1.Enums;
using CSharpFinalProject1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalProject1.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
      

        private List<Customer> customerList;
        public CustomerRepo()
        {
            customerList = new List<Customer>()
            {
                new Customer() 
                { CustomerId = 1,
                    CustomerName = "Jannat",
                    CustomerEmail = "jf13@gmail.com",
                    CustType = CustomerType.Regular,
                    TotalAmount = 1000,
                    PayAmount = 600,
                    DiscountPcnt = 40
                },
                new Customer()
                { CustomerId = 2,
                    CustomerName = "Jui",
                    CustomerEmail = "jf13@gmail.com",
                    CustType = CustomerType.NewCustomer,
                    TotalAmount = 1000,
                    PayAmount = 1000,
                    DiscountPcnt = 0
                }
            };
        }
        public Customer DeleteCustomer(int id)
        {
           var deleteCust = GetCustomerById(id);
            if (deleteCust != null)
            {
                customerList.Remove(deleteCust);
            }
            return deleteCust; 
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return from custs in customerList select custs;
        }

        public Customer GetCustomerById(int id)
        {
            var cust = (from c in customerList where c.CustomerId== id select c).FirstOrDefault();
            return cust;
        }

        public Customer SaveCustomer(Customer customer)
        {
            Customer cust = (from c in customerList orderby c.CustomerId  descending select c).FirstOrDefault();
            customer.CustomerId = cust.CustomerId + 1;
            customer.PayAmount = customer.TotalAmount - (customer.TotalAmount * customer.DiscountPcnt / 100);
            customerList.Add(customer);
            return customer;

        }        

        public Customer UpdateCustomer(Customer upcustomer)
        {
            Customer cust = GetCustomerById(upcustomer.CustomerId);
            cust.CustomerName = upcustomer.CustomerName;
            cust.CustomerEmail = upcustomer.CustomerEmail;
            cust.CustType = upcustomer.CustType;
            cust.TotalAmount = upcustomer.TotalAmount;
            cust.DiscountPcnt = upcustomer.DiscountPcnt;
            cust.PayAmount = upcustomer.TotalAmount-(upcustomer.TotalAmount*upcustomer.DiscountPcnt / 100);
            cust.CustomerId = upcustomer.CustomerId;
                return upcustomer;
        }
    }
}
