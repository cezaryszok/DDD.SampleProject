using DDDExample.Application.Exception;
using DDDExample.Domain.Policy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Domain
{
  public class OrderFactory
  {
    private readonly IRebatePolicy _rebatePolicy;
    private readonly Customer _customer;

    public OrderFactory(Customer customer, IRebatePolicy rebatePolicy)
    {
      _rebatePolicy = rebatePolicy;
      _customer = customer;
    }
    public Order CreateOrder()
    {
      CheckIfOrderCanBeCreatedForCustomer();
      
      Order order = new Order();
      order.SetCustomer(_customer);
      order.SetRebatePolicy(_rebatePolicy);

      return order;
    }

    private void CheckIfOrderCanBeCreatedForCustomer()
    {
      if (!_customer.IsActive)
        throw new OrderCreationException("Order cannot be created, customer is not active");


    }

  }
}
