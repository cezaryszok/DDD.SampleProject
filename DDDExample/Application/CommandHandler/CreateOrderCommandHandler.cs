using DDDExample.Domain;
using DDDExample.Domain.Policy;

namespace DDDExample.Application.CommandHandler
{
  public class CreateOrderCommandHandler
  {
    private readonly IOrderRepository _orderRepository;
    private readonly ICustomerRepository _customerRepository;

    public CreateOrderCommandHandler()
    {
    }

    public void Handle()
    {
      int customerId = 12;
      Customer customer = _customerRepository.GetCustomer(customerId);

      RebatePolicyFactory rebatePolicyFactory = new RebatePolicyFactory(_orderRepository, customer);
      IRebatePolicy rebatePolicy = rebatePolicyFactory.CreateRebatePolicy();

      OrderFactory orderFactory = new OrderFactory(customer, rebatePolicy);

      Order order = orderFactory.CreateOrder();

      //TODO: Save order into the store

    }
  }
}
