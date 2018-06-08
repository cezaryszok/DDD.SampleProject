using DDDExample.Base.DDD;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Domain
{
  public class Product : IEntity
  {
    public int Id { get; private set; }
    public string Name { get; private set; }

    public double Price { get; private set; }

    public ProductType Type { get; private set; }

    public bool IsAvailable { get; private set; }


  }
}
