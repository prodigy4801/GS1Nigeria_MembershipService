using MembershipPortal.data;

namespace MembershipPortal.core.Repository
{
    public class GTINRequestRepo : GenericRepository<GTINRequest>, IGTINRequestRepo
    {
        public GTINRequestRepo(ApplicationDBContext context) : base(context)
        {

        }
    }
}
