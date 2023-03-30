using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service.Helpers
{
    public static class AdministrativeService
    {
        public static decimal GetNewRenewalAmount(int NumberOfGtins)
        {
            decimal amount = 0m;
            if (NumberOfGtins <= 5)
            {
                amount = 10000m;
            }
            else if (NumberOfGtins > 5 && NumberOfGtins <= 10)
            {
                amount = 10000m;
            }
            else if (NumberOfGtins > 10 && NumberOfGtins <= 20)
            {
                amount = 15000m;
            }
            else if (NumberOfGtins > 20 && NumberOfGtins <= 30)
            {
                amount = 25000m;
            }
            else if (NumberOfGtins > 30 && NumberOfGtins <= 40)
            {
                amount = 42000m;
            }
            else if (NumberOfGtins > 40 && NumberOfGtins <= 50)
            {
                amount = 54000m;
            }
            else if (NumberOfGtins > 50 && NumberOfGtins <= 60)
            {
                amount = 66000m;
            }
            else if (NumberOfGtins > 60 && NumberOfGtins <= 70)
            {
                amount = 90000m;
            }
            else if (NumberOfGtins > 70 && NumberOfGtins <= 80)
            {
                amount = 120000m;
            }
            else if (NumberOfGtins > 80 && NumberOfGtins <= 100)
            {
                amount = 150000m;
            }
            else if (NumberOfGtins > 100 && NumberOfGtins <= 150)
            {
                amount = 180000m;
            }
            else if (NumberOfGtins > 150 && NumberOfGtins <= 200)
            {
                amount = 210000m;
            }
            else if (NumberOfGtins > 200 && NumberOfGtins <= 300)
            {
                amount = 240000m;
            }
            else if (NumberOfGtins > 300 && NumberOfGtins <= 400)
            {
                amount = 270000m;
            }
            else if (NumberOfGtins > 400 && NumberOfGtins <= 1000)
            {
                amount = 300000m;
            }
            else if (NumberOfGtins > 1000)
            {
                amount = 400000m;
            }
            return amount;
        }

        public static decimal GetRenewalAmount(int NumberOfGtins)
        {
            decimal amount = 0m;
            if (NumberOfGtins <= 10)
            {
                amount = 10000m;
            }
            else if (NumberOfGtins > 10 && NumberOfGtins <= 20)
            {
                amount = 15000m;
            }
            else if (NumberOfGtins > 20 && NumberOfGtins <= 30)
            {
                amount = 25000m;
            }
            else if (NumberOfGtins > 30 && NumberOfGtins <= 40)
            {
                amount = 35000m;
            }
            else if (NumberOfGtins > 40 && NumberOfGtins <= 50)
            {
                amount = 45000m;
            }
            else if (NumberOfGtins > 50 && NumberOfGtins <= 60)
            {
                amount = 55000m;
            }
            else if (NumberOfGtins > 60 && NumberOfGtins <= 70)
            {
                amount = 75000m;
            }
            else if (NumberOfGtins > 70 && NumberOfGtins <= 80)
            {
                amount = 100000m;
            }
            else if (NumberOfGtins > 80 && NumberOfGtins <= 100)
            {
                amount = 125000m;
            }
            else if (NumberOfGtins > 100 && NumberOfGtins <= 150)
            {
                amount = 150000m;
            }
            else if (NumberOfGtins > 150 && NumberOfGtins <= 200)
            {
                amount = 175000m;
            }
            else if (NumberOfGtins > 200 && NumberOfGtins <= 300)
            {
                amount = 200000m;
            }
            else if (NumberOfGtins > 300 && NumberOfGtins <= 400)
            {
                amount = 225000m;
            }
            else if (NumberOfGtins > 400 && NumberOfGtins <= 500)
            {
                amount = 250000m;
            }
            else if (NumberOfGtins > 500)
            {
                amount = 250000m;
            }
            return amount;
        }
    }
}
