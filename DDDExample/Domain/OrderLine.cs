using DDDExample.Base.DDD;
using DDDExample.Domain.Policy;

namespace DDDExample.Domain
{
    public class OrderLine : IEntity
    {
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public double TotalRegularPrice { get; private set; }
        public double TotalEffectivePrice { get; private set; }


        public OrderLine(Product product, IRebatePolicy rebatePolicy)
        {
            Product = product;
            Recalculate(rebatePolicy);
        }

        public void IncreaseQuantity(IRebatePolicy rebatePolicy)
        {
            Quantity++;
            Recalculate(rebatePolicy);
        }

        private void Recalculate(IRebatePolicy rebatePolicy)
        {
            TotalRegularPrice = Product.Price * Quantity;

            if (HasAnyRebates(rebatePolicy))
                TotalEffectivePrice = rebatePolicy.CalculateRebate(Product.Price, Quantity);
            else
                TotalEffectivePrice = TotalRegularPrice;
        }

        private bool HasAnyRebates(IRebatePolicy rebatePolicy)
        {
            return rebatePolicy != null;
        }
    }
}
