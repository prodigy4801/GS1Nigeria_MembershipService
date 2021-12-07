using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.core.Repository
{
    public class BrickCategoryRepo : GenericRepository<BrickCategory>, IBrickCategoryRepo
    {
        public BrickCategoryRepo(ApplicationDBContext context) : base(context)
        {

        }
        public ApplicationDBContext ApplicationDBContext
        {
            get { return _context as ApplicationDBContext; }
        }

        public async Task<bool> IsExists(BrickCategory profile)
        {
            BrickCategory response = null;
            try
            {
                response = await ApplicationDBContext.BrickCategories.FirstOrDefaultAsync<BrickCategory>(m => m.brick == profile.brick);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return response != null ? true : false;
        }
    }
}
