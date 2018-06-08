using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Base.Specification
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public abstract bool IsSatisfiedBy(T obj);

        public ISpecification<T> And(ISpecification<T> otherObj)
        {
            return new AndSpecification<T>(this, otherObj);
        }

        public ISpecification<T> Or(ISpecification<T> otherObj)
        {
            return new OrSpecification<T>(this, otherObj);
        }

    }
}
