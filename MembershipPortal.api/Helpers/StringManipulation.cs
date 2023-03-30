using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.api.Helpers
{
    public static class StringManipulation
    {
        public static int StripZeroFirst(string val)
        {
            var stripped = val.ToCharArray()[0] == '0' ? val.Remove(0, 1) : val;

            return Convert.ToInt32(stripped);
        }

        public static string CalculateChecksum(string code)
        {
            int sum = 0;
            code = code.Trim();
            for (int i = 0; i < 12; i++)
            {
                int v;
                if (!int.TryParse(code[i].ToString(), out v))
                    throw new ArgumentException("Invalid character encountered in specified code.");
                sum += (i % 2 == 0 ? v : v * 3);
            }
            int check = 10 - (sum % 10);
            var checksum = check % 10;
            return checksum.ToString();
        }
    }
}
