using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.core.Repository
{
    public class ExternalUnifiedModelRepo : GenericRepository<ExternalUnifiedModel>, IExternalUnifiedModelRepo
    {
        public ExternalUnifiedModelRepo(ApplicationDBContext context) : base(context)
        {

        }
        public ApplicationDBContext ApplicationDBContext
        {
            get { return _context as ApplicationDBContext; }
        }

        public async Task<bool> IsExists(ExternalUnifiedModel profile)
        {
            ExternalUnifiedModel response = null;
            try
            {
                response = await ApplicationDBContext.ExternalUnifiedModels.FirstOrDefaultAsync<ExternalUnifiedModel>(m => m.product_id == profile.product_id);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return response != null ? true : false;
        }

        public async Task<IEnumerable<ExternalUnifiedModel>> GetAllDependencies()
        {
            IEnumerable<ExternalUnifiedModel> response = null;
            try
            {
                response = await ApplicationDBContext.ExternalUnifiedModels.Include(x => x.Product).ToListAsync();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return response;
        }

        public async Task<ExternalUnifiedModel> GetByIDDependencies(int id)
        {
            ExternalUnifiedModel response = null;
            try
            {
                response = await ApplicationDBContext.ExternalUnifiedModels.Include(x => x.Product).FirstOrDefaultAsync<ExternalUnifiedModel>(m => m.id == id);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return response;
        }
    }
}
