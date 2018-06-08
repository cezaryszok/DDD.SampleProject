using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Application.Exception
{
    public class ProductNotAvailableException : System.Exception
    {
        public ProductNotAvailableException(string message) : base(message)
        {

        }
    }
}
