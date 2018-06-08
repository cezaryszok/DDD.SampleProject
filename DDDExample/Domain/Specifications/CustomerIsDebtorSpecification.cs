using DDDExample.Base.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Domain.Specifications
{
  public class CustomerIsDebtorSpecification : CompositeSpecification<Order>
  {
    public override bool IsSatisfiedBy(Order obj)
    {
      if (!obj.Customer.IsDebtor)
      {
        return false;
      }

      return true;
    }
  }
}
