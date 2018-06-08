using DDDExample.Base.DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Domain
{
    public class InvoiceLine : IEntity
    {
        public Product Product { get; }
        public int Quantity { get; }
        public double NetAmount { get; }
        public double GrossAmount { get; }
        public Tax Tax { get; }


        public InvoiceLine(Product product, int quantity, double netAmount, Tax tax)
        {
            Product = product;
            Quantity = quantity;
            NetAmount = netAmount;
            Tax = tax;
            GrossAmount = netAmount + tax.Amount;
        }
    }
}
