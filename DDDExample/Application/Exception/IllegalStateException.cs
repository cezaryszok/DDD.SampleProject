using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Application.Exception
{
    public class IllegalStateException : System.Exception
    {
        public IllegalStateException(string message) : base(message)
        {

        }
    }
}
