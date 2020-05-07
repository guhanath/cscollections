using ConcoleColln.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcoleColln
{
    public class PenColors : IPens
    {
        private IEnumerable<IPens> _penColors;
        public PenColors(ICollection<IPens> penColors)
        {
            _penColors = penColors;

        }
        public IEnumerable<IPens> Filter(Func<IPens, bool> predicate)
        {
            return _penColors.Where(predicate);
        }
    }
}
