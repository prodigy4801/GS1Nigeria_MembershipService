using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.api.Models
{
    public class RecordPaginationModel
    {
        const int maxPageSize = 10000;
        public int PageNumber { get; set; } = 1;

        private int _pagesize = 50;
        public int PageSize
        {
            get { return _pagesize; }
            set
            {
                _pagesize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
