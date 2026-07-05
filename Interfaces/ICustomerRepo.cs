using CSharpFinalProject1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalProject1.Interfaces
{
    public interface ICustomerRepo
    {
        IEnumerable<Customer>GetAllCustomers();
        Customer GetCustomerById(int id);
        Customer SaveCustomer (Customer customer);
        Customer UpdateCustomer (Customer upcustomer);
        Customer DeleteCustomer (int id);

    }
}
