﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Application.Exception
{
  public class OrderAcceptationExcpetion : System.Exception
  {
    public OrderAcceptationExcpetion(string message) : base(message)
    {

    }
  }
}
