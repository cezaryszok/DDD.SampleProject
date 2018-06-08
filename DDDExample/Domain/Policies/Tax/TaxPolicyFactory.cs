using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Domain.Policies
{
  public class TaxPolicyFactory
  {
    public TaxPolicyFactory()
    {

    }

    public ITaxPolicy CreateTaxPolicy(Customer customer)
    {
      if (customer.IsForeigner)
        return new AbroadTaxPolicy();


      return new DefaultTaxPolicy();
    }
  }
}
