using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Base.Specification
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T obj);

        ISpecification<T> And(ISpecification<T> otherObj);
        ISpecification<T> Or(ISpecification<T> otherObj);
    }
}
