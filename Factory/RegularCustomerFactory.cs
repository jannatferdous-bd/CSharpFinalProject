using CSharpFinalProject1.Entities;
using CSharpFinalProject1.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalProject1.Factory
{
    public class RegularCustomerFactory : BaseCustomerFactory
    {
        public RegularCustomerFactory(Customer cust) : base(cust)
        {
        }

        public override ICustomerManager Create()
        {
            RegularCustomerManager manager = new RegularCustomerManager();
            return manager;
        }
        
    }
}
