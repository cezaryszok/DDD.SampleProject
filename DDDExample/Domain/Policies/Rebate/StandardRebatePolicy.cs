using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Domain.Policy
{
    public class StandardRebatePolicy : IRebatePolicy
    {
        private readonly double _rebate;
        private readonly double _minimumQuantity;
        private readonly CustomerOrders _customerOrders;
        public StandardRebatePolicy(CustomerOrders customerOrders, int minimumQuantity, double rebate)
        {
            _rebate = rebate / 100;
            _minimumQuantity = minimumQuantity;
            _customerOrders = customerOrders;

        }
        public double CalculateRebate(double price, int amount)
        {
            if (_customerOrders.GetTotalAmount() > _minimumQuantity)
                return price * amount * _rebate;

            return price * amount;
        }
    }
}
