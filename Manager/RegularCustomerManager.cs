using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalProject1.Manager
{
    public class RegularCustomerManager : ICustomerManager
    {
        public double GetDiscount()
        {
            return 40.00;
        }
    }
}
