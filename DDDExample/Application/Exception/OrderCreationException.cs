using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Application.Exception
{
  public class OrderCreationException : System.Exception
  {
    public OrderCreationException(string message) : base(message)
    {

    }
  }
}
