using DDDExample.Domain;
using DDDExample.Domain.Policies;
using DDDExample.Domain.Services;

namespace DDDExample.Application.CommandHandler
{
  public class IssueInvoiceCommandHandler
  {
    private readonly IOrderRepository _orderRepository;
    private readonly InvoiceService _invoiceService;

    public IssueInvoiceCommandHandler(IOrderRepository orderRepository)
    {
      _orderRepository = orderRepository;
    }

    public void Handle()
    {
      int orderId = 1234;

      Order order = _orderRepository.Get(orderId);


      TaxPolicyFactory policyFactory = new TaxPolicyFactory();
      ITaxPolicy taxPolicy = policyFactory.CreateTaxPolicy(order.Customer);

      Invoice invoice = _invoiceService.CreateInvoice(order, taxPolicy);

      //TODO: Save repository into the store
    }
  }
}
