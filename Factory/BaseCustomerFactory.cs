using CSharpFinalProject1.Entities;
using CSharpFinalProject1.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalProject1.Factory
{
    public abstract class BaseCustomerFactory
    {
        public abstract ICustomerManager Create();

        protected Customer _cust;
        protected BaseCustomerFactory(Customer cust)
        {
            _cust= cust;
        }
        public Customer ApplyDiscount()
        {
            ICustomerManager manager = this.Create();
            _cust .DiscountPcnt= manager.GetDiscount();
            _cust.PayAmount = _cust.TotalAmount - (_cust.TotalAmount * _cust.DiscountPcnt / 100);
            return _cust;
        }
    }
}
