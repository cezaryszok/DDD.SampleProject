using DDDExample.Domain.Policies;

namespace DDDExample.Domain.Services
{
  public class InvoiceService
  {

    //Prefer to have factory here. Followed by DDD rules about domain service definition. 
    //Should be used when one aggregate is being transformed to another one.
    public Invoice CreateInvoice(Order order, ITaxPolicy taxPolicy)
    {
      Invoice invoice = new Invoice(order.Customer);

      foreach (var orderLine in order.OrderLines)
      {
        Tax tax = taxPolicy.CalculateTax(orderLine.Product, orderLine.TotalEffectivePrice);
        InvoiceLine line = new InvoiceLine(orderLine.Product, orderLine.Quantity, orderLine.TotalEffectivePrice, tax);

        invoice.AddLine(line);
      }

      return invoice;
    }
  }
}
