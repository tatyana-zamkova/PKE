using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PKE_1
{
    public class CompareBox: IComparer<Izm>
    {
        
            public int Compare(Izm x, Izm y)
            {
                if (x.UID.CompareTo(y.UID) != 0 )
                {
                    return x.UID.CompareTo(y.UID);
                }

                else
                {
                    return 0;
                }
            }
    }
}
