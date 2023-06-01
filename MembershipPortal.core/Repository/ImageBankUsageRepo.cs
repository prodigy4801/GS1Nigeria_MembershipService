using MembershipPortal.data;

namespace MembershipPortal.core.Repository
{
    public class ImageBankUsageRepo : GenericRepository<ImageBankUsage>, IImageBankUsageRepo
    {
        public ImageBankUsageRepo(ApplicationDBContext context) : base(context)
        {

        }
    }
}
