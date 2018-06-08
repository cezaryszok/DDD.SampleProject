using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using DDDExample.Application.Exception;
using DDDExample.Base.DDD;
using DDDExample.Domain.Policy;

namespace DDDExample.Domain
{
  public class Order : IAggregateRoot
  {
    public int Id { get; private set; }

    private IRebatePolicy _rebatePolicy;
    public Customer Customer { get; private set; }
    public IList<OrderLine> OrderLines { get; private set; }
    public OrderStatus Status { get; private set; }

    public DateTime? AcceptedDate { get; private set; }

    public double TotalGrossAmount
    {
      get
      {
        if (OrderLines == null) return 0;
        return OrderLines.Sum(x => x.TotalEffectivePrice);
      }
    }

    public void SetRebatePolicy(IRebatePolicy rebatePolicy)
    {
      if (_rebatePolicy != null)
        throw new IllegalStateException("Rebate policy has been already set");

      _rebatePolicy = rebatePolicy;
    }

    public void AddProduct(Product product)
    {
      OrderLine orderLine = OrderLines.FirstOrDefault(x => x.Product.Equals(product));

      if (orderLine == null)
      {
        OrderLines.Add(new OrderLine(product, _rebatePolicy));
      }
      else
      {
        orderLine.IncreaseQuantity(_rebatePolicy);
      }
    }

    public void SetCustomer(Customer customer)
    {
      Customer = customer;
    }

    public void AcceptOrder()
    {
      Status = OrderStatus.Accepted;
      AcceptedDate = DateTime.Now;
    }
  }
}
