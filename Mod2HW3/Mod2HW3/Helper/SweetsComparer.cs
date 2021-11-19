using System.Collections;
using System.Collections.Generic;

namespace Mod2HW3.Helper
{
    public class SweetsComparer : IComparer<SweetStuff>
    {
        public int Compare(SweetStuff sweetStuff1, SweetStuff sweetStuff2)
        {
            if (sweetStuff1?.Weight.Value > sweetStuff2?.Weight.Value)
            {
                return 1;
            }
            else if (sweetStuff2?.Weight.Value > sweetStuff1?.Weight.Value)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}