using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service.Helpers
{
    public static class StringManipulation
    {
        public static int StripZeroFirst(string val)
        {
            var stripped = val.ToCharArray()[0] == '0' ? val.Remove(0, 1) : val;

            return Convert.ToInt32(stripped);
        }
    }
}
