using ConcoleColln.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcoleColln
{
    public class PenTypes : IPens
    {
        private IEnumerable<IPens> _penTypes;
        public PenTypes(ICollection<IPens> penTypes)
        {
            _penTypes = penTypes;

        }
        public IEnumerable<IPens> Filter(Func<IPens, bool> predicate)
        {
            return _penTypes.Where(predicate);
        }
    }
}
