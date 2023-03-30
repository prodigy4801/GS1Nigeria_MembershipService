using MembershipPortal.data;

namespace MembershipPortal.core.Repository
{
    public class ImageBankRepo : GenericRepository<ImageBank>, IImageBankRepo
    {
        public ImageBankRepo(ApplicationDBContext context) : base(context)
        {

        }
    }
}
