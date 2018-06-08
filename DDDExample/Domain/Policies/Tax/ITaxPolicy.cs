using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Domain.Policies
{
    public interface ITaxPolicy
    {
        Tax CalculateTax(Product product, double price);
    }
}
