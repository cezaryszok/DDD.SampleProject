using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Domain.Policies
{
  public class DefaultTaxPolicy : ITaxPolicy
  {
    private double _defaultTax = 0.1;
    private double _alcoholTax = 0.15;

    public Tax CalculateTax(Product product, double price)
    {
      if (product.Type == ProductType.Alcohol)
      {
        var alcoholTaxAmount = price * _alcoholTax;
        return new Tax(alcoholTaxAmount, "Alcohol tax");
      }

      var standardTaxAmount = price * _defaultTax;
      return new Tax(standardTaxAmount, "Standard tax");
    }
  }
}
