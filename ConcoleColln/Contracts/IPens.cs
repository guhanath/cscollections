using System;
using System.Collections.Generic;

namespace ConcoleColln.Contracts
{
    public interface IPens
    {
        IEnumerable<IPens> Filter(Func<IPens, bool> predicate);
    }
}
