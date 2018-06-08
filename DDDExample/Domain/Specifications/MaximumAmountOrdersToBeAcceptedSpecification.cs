using DDDExample.Base.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Domain.Specifications
{
  public class MaximumAmountOrdersToBeAcceptedSpecification : CompositeSpecification<Order>
  {
    private readonly IOrderRepository _orderRepository;
    private readonly int _maxCountAcceptedOrders = 50;
    public MaximumAmountOrdersToBeAcceptedSpecification(IOrderRepository orderRepository)
    {
      _orderRepository = orderRepository;
    }
    public override bool IsSatisfiedBy(Order obj)
    {
      var acceptedOrders = _orderRepository.GetAcceptedOrdersToday();

      if (acceptedOrders.Count() > _maxCountAcceptedOrders)
      {
        return false;

      }

      return true;

    }
  }
}
