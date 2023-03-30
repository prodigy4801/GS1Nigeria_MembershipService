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
            CompanyRP = new CompanyRepo(_context);
            ExternalUnifiedModelRP = new ExternalUnifiedModelRepo(_context);
            GCPInformationRP = new GCPInformationRepo(_context);
            GLNInformationRP = new GLNInformationRepo(_context);
            GTINFeeRP = new GTINFeeRepo(_context);
            GTINInformationRP = new GTINInformationRepo(_context);
            GTINRequestRP = new GTINRequestRepo(_context);
            ImageBankRP = new ImageBankRepo(_context);
            ImageRequestRP = new ImageRequestRepo(_context);
            ITFInformationRP = new ITFInformationRepo(_context);
            NetContentRP = new NetContentRepo(_context);
            PackageLevelRP = new PackageLevelRepo(_context);
            PackagingTypeRP = new PackagingTypeRepo(_context);
            PharmaceuticalInformationRP = new PharmaceuticalInformationRepo(_context);
            ProductRP = new ProductRepo(_context);
            ProductTargetMarketRP = new ProductTargetMarketRepo(_context);
            TargetMarketRP = new TargetMarketRepo(_context);
        }

        public IBrickCategoryRepo BrickCategoryRP { get; private set; }

        public IBrandInformationRepo BrandInformationRP { get; private set; }

        public ICompanyRepo CompanyRP { get; private set; }

        public IExternalUnifiedModelRepo ExternalUnifiedModelRP { get; set; }

        public IGCPInformationRepo GCPInformationRP { get; set; }

        public IGLNInformationRepo GLNInformationRP { get; private set; }

        public IGTINFeeRepo GTINFeeRP { get; private set; }

        public IGTINInformationRepo GTINInformationRP { get; private set; }
        public IGTINRequestRepo GTINRequestRP { get; private set; }

        public IImageBankRepo ImageBankRP { get; private set; }

        public IImageRequestRepo ImageRequestRP { get; private set; }

        public IITFInformationRepo ITFInformationRP { get; private set; }

        public INetContentRepo NetContentRP { get; private set; }

        public IPackageLevelRepo PackageLevelRP { get; private set; }

        public IPackagingTypeRepo PackagingTypeRP { get; private set; }

        public IPharmaceuticalInformationRepo PharmaceuticalInformationRP { get; private set; }

        public IProductRepo ProductRP { get; private set; }

        public IProductTargetMarketRepo ProductTargetMarketRP { get; private set; }

        public ITargetMarketRepo TargetMarketRP { get; private set; }

        public async Task<int> Complete()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
