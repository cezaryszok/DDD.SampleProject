using DDDExample.Domain;
using DDDExample.Domain.Policy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Application.CommandHandler
{
  public class AddProductToOrderCommandHandler
  {
    private readonly IOrderRepository _orderRepository;

    public void Handle()
    {
      Order order = _orderRepository.Get(14);


      RebatePolicyFactory rebatePolicyFactory = new RebatePolicyFactory(_orderRepository, order.Customer);
      IRebatePolicy rebatePolicy = rebatePolicyFactory.CreateRebatePolicy();

      order.SetRebatePolicy(rebatePolicy);
      order.AddProduct(new Product());

    }
  }
}
