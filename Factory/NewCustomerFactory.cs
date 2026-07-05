using CSharpFinalProject1.Entities;
using CSharpFinalProject1.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalProject1.Factory
{
    public class NewCustomerFactory : BaseCustomerFactory
    {
        public NewCustomerFactory(Customer cust) : base(cust)
        {
        }

        public override ICustomerManager Create()
        {
            NewCustomerManager manager = new NewCustomerManager();
            return manager;
            
        
        }
    }
}
