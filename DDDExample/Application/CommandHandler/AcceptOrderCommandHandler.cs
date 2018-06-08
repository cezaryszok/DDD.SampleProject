
using DDDExample.Application.Exception;
using DDDExample.Base.Specification;
using DDDExample.Domain;
using DDDExample.Domain.Specification;
using DDDExample.Domain.Specifications;

namespace DDDExample.Application.CommandHandler
{
  public class AcceptOrderCommandHandler
  {
    private readonly IOrderRepository _orderRepository;
    private readonly IProductRepository _productRepository;
    public AcceptOrderCommandHandler(IOrderRepository orderRepository, IProductRepository productRepository)
    {
      _orderRepository = orderRepository;
      _productRepository = productRepository;
    }

    public void Handle()
    {
      int orderId = 1254;
      Order order = _orderRepository.Get(orderId);

      ISpecification<Order> orderSpecification = GetOrdersSpecification();

      if (!orderSpecification.IsSatisfiedBy(order))
        throw new OrderAcceptationExcpetion("Order doesn't meet specification");

      order.AcceptOrder();

      _orderRepository.Save(order);

    }

    private ISpecification<Order> GetOrdersSpecification()
    {
      ISpecification<Order> specification = new ConjunctionSpecification<Order>(new OrderProductsAvailabilitySpecification(_productRepository),
                                                                                new MaximumAmountOrdersToBeAcceptedSpecification(_orderRepository),
                                                                                new CustomerIsDebtorSpecification()
                                                                                );

      return specification;
    }
  }

}
