using CSharpFinalProject1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalProject1.Entities
{
    public class Customer
    {
        int customerId;
        string  customerName;
        string customerEmail;
        CustomerType custType;
        double totalAmount;
        double discountPcnt;
        double payAmount;
        public Customer()
        {
            
        }
        public Customer(int customerId, string customerName, string customerEmail, CustomerType custType, double totalAmount, double discountPcnt, double payAmount)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.custType = custType;
            this.totalAmount = totalAmount;
            this.discountPcnt = discountPcnt;
            this.payAmount = payAmount;
        }

        public int CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerEmail { get => customerEmail; set => customerEmail = value; }
        
        public double TotalAmount { get => totalAmount; set => totalAmount = value; }
        public double DiscountPcnt { get => discountPcnt; set => discountPcnt = value; }
        public double PayAmount { get => payAmount; set => payAmount = value; }
        public CustomerType CustType { get => custType; set => custType = value; }
    }
}
