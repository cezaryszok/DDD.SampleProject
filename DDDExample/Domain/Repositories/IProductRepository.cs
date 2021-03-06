﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Domain
{
    public interface IProductRepository
    {
        IEnumerable<AvailableProduct> GetProductsAvailabilityFromOrder(int orderId);
    }
}
