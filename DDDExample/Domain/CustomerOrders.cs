using DDDExample.Base.DDD;
using System.Collections.Generic;
using System.Linq;

namespace DDDExample.Domain
{
    public class CustomerOrders : IValueObject
    {
        public int CustomerId { get; private set; }
        public IList<Order> Orders { get; private set; }

        public CustomerOrders(IList<Order> orders)
        {
            Orders = orders;
        }

        public double GetTotalAmount()
        {
            return Orders.Sum(x => x.TotalGrossAmount);
        }
    }
}
