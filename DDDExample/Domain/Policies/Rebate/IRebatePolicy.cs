﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Domain.Policy
{
    public interface IRebatePolicy
    {
        double CalculateRebate(double price, int amount);
    }
}
