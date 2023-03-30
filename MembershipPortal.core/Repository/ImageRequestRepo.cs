using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.core.Repository
{
    public class ImageRequestRepo : GenericRepository<ImageRequest>, IImageRequestRepo
    {
        public ImageRequestRepo(ApplicationDBContext context) : base(context)
        {

        }
    }
}
