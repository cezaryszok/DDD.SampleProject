using DDDExample.Base.DDD;
using System.Collections.Generic;


namespace DDDExample.Domain
{
    public class Invoice : IAggregateRoot
    {
        public List<InvoiceLine> Lines { get; private set; }
        public Customer Customer { get; set; }
        public double NetAmount { get; private set; }
        public double GrossAmount { get; private set; }


        public Invoice(Customer customer)
        {
            Customer = customer;
            Lines = new List<InvoiceLine>();
        }
        public void AddLine(InvoiceLine line)
        {
            Lines.Add(line);
            NetAmount += line.NetAmount;
            GrossAmount += line.GrossAmount;
        }
    }
}
