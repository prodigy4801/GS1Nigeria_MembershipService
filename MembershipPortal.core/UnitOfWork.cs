using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core.Repository;

namespace MembershipPortal.core
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _context;

        public UnitOfWork(ApplicationDBContext context)
        {
            this._context = context;
            BrandInformationRP = new BrandInformationRepo(_context);
            BrickCategoryRP = new BrickCategoryRepo(_context);
            GLNInformationRP = new GLNInformationRepo(_context);
            GTINInformationRP = new GTINInformationRepo(_context);
            ITFInformationRP = new ITFInformationRepo(_context);
            NetContentRP = new NetContentRepo(_context);
            PackageLevelRP = new PackageLevelRepo(_context);
            PackagingTypeRP = new PackagingTypeRepo(_context);
            ProductRP = new ProductRepo(_context);
            TargetMarketRP = new TargetMarketRepo(_context);
        }

        public IBrickCategoryRepo BrickCategoryRP { get; private set; }

        public IBrandInformationRepo BrandInformationRP { get; private set; }

        public IGLNInformationRepo GLNInformationRP { get; private set; }

        public IGTINInformationRepo GTINInformationRP { get; private set; }

        public IITFInformationRepo ITFInformationRP { get; private set; }

        public INetContentRepo NetContentRP { get; private set; }

        public IPackageLevelRepo PackageLevelRP { get; private set; }

        public IPackagingTypeRepo PackagingTypeRP { get; private set; }

        public IProductRepo ProductRP { get; private set; }

        public ITargetMarketRepo TargetMarketRP { get; private set; }

        public async Task<int> Complete()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
