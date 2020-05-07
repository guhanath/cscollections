using ConcoleColln.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcoleColln
{
    public class Pens : IPens
    {
        private IEnumerable<IPens> _allPens;

        public Pens(ICollection<IPens> pens)
        {
            this._allPens = pens.ToList();

        }

        public IEnumerable<IPens> Filter(Func<IPens, bool> predicate)
        {
            return _allPens.Where(predicate);
        }
    }
}
