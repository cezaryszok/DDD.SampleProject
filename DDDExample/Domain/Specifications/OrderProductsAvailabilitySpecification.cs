using System;
using System.Linq;
using DDDExample.Base.Specification;

namespace DDDExample.Domain.Specification
{
    public class OrderProductsAvailabilitySpecification : CompositeSpecification<Order>
    {
        private readonly IProductRepository _repository;
        public OrderProductsAvailabilitySpecification(IProductRepository repository)
        {
            _repository = repository;
        }
        public override bool IsSatisfiedBy(Order obj)
        {
            var products = _repository.GetProductsAvailabilityFromOrder(obj.Id);

            foreach (var line in obj.OrderLines)
            {
                var product = products.FirstOrDefault(p => p.ProductId == line.Product.Id);

                if (product == null)
                    throw new NullReferenceException("Product does not exist");

                if (line.Quantity > product.Quantity)
                    return false;
            }

            return true;
        }
    }
}
