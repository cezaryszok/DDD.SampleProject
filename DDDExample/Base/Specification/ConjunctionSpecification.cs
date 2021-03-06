﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Base.Specification
{
  public class ConjunctionSpecification<T> : CompositeSpecification<T>
  {
    private readonly ISpecification<T>[] _conjunction;

    public ConjunctionSpecification(params ISpecification<T>[] conjunction)
    {
      _conjunction = conjunction;
    }

    public override bool IsSatisfiedBy(T candidate)
    {
      return _conjunction.All(spec => spec.IsSatisfiedBy(candidate));
    }
  }
}
