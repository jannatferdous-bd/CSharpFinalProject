using CSharpFinalProject1.Entities;
using CSharpFinalProject1.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalProject1.Manager
{
    public class CustomerManagerFactory
    {
        public BaseCustomerFactory CreateFactory(Customer cust)
        {
            BaseCustomerFactory returnValue = null;
            if (cust.CustType == Enums.CustomerType.NewCustomer)
            {
                returnValue = new Factory.NewCustomerFactory(cust);

            }
            else if (cust.CustType == Enums.CustomerType.Regular)
            {
                returnValue = new Factory.RegularCustomerFactory(cust);
            }
            return returnValue;
        }
    }

}
