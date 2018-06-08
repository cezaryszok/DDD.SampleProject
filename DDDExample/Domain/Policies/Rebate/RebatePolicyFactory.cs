using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Domain.Policy
{
    public class RebatePolicyFactory
    {
        private readonly IOrderRepository _repository;
        private readonly Customer _customer;

        public RebatePolicyFactory(IOrderRepository repository, Customer customer)
        {
            _repository = repository;
            _customer = customer;
        }

        public IRebatePolicy CreateRebatePolicy()
        {
            IRebatePolicy rebatePolicy;

            if (_customer.IsVip)
            {
                rebatePolicy = new CustomerVipRebatePolicy(10);
            }
            else
            {
                var customerOrders = _repository.GetCustomerOrders(_customer.Id);
                rebatePolicy = new StandardRebatePolicy(customerOrders, 1000, 5);
            }

            return rebatePolicy;

        }
    }
}

