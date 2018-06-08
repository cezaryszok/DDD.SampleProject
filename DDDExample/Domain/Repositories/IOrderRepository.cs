using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Domain
{
  public interface IOrderRepository
  {
    CustomerOrders GetCustomerOrders(int customerId);
    IEnumerable<Order> GetAcceptedOrdersToday();

    Order Get(int orderId);

    void Save(Order order);

  }
}
