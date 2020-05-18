using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PKE_1
{
    class CompTimeTeck : IComparer<Cxema>
    {
        public int Compare(Cxema x, Cxema y)
        {
            if (x.Subordinate[1].CompareTo(y.Subordinate[1]) != 0)
            {
                return x.Subordinate[1].CompareTo(y.Subordinate[1]);
            }

            else
            {
                return 0;
            }
        }
    }
}
