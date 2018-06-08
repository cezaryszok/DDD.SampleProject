using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Base.Specification
{
    public class OrSpecification<T> : CompositeSpecification<T>
    {
        private readonly ISpecification<T> _a;
        private readonly ISpecification<T> _b;

        public OrSpecification(ISpecification<T> a, ISpecification<T> b)
        {
            _a = a;
            _b = b;
        }

        public override bool IsSatisfiedBy(T obj)
        {
            return _a.IsSatisfiedBy(obj) || _b.IsSatisfiedBy(obj);
        }
    }
}
