using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Domain.Policies
{
  public class AbroadTaxPolicy : ITaxPolicy
  {
    private double _defaultTax = 0.1;
    public Tax CalculateTax(Product product, double price)
    {
      var abroadTaxAmount = price * _defaultTax;
      return new Tax(abroadTaxAmount, "Abroad tax");
    }
  }
}
