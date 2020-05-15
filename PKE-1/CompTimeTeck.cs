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
            if (x.TimeTek.CompareTo(y.TimeTek) != 0)
            {
                return x.TimeTek.CompareTo(y.TimeTek);
            }

            else
            {
                return 0;
            }
        }
    }
}
