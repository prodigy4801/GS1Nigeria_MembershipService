using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.core.Repository
{
    public class ProductRepo : GenericRepository<Product>, IProductRepo
    {
        public ProductRepo(ApplicationDBContext context) : base(context)
        {

        }
        public ApplicationDBContext ApplicationDBContext
        {
            get { return _context as ApplicationDBContext; }
        }

        public async Task<bool> IsExists(Product profile)
        {
            Product response = null;
            try
            {
                response = await ApplicationDBContext.Products.FirstOrDefaultAsync<Product>(m => m.brandname == profile.brandname);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return response != null ? true : false;
        }
    }
}
