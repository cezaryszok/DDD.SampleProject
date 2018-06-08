using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Domain.Policy
{
    public class CustomerVipRebatePolicy : IRebatePolicy
    {
        private double _rebate;

        public CustomerVipRebatePolicy(double rebate)
        {
            _rebate = rebate;
        }

        public double CalculateRebate(double price, int amount)
        {
            return price * amount * _rebate;
        }
    }
}
