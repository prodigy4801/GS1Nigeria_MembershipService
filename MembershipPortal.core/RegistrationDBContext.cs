using Microsoft.EntityFrameworkCore;
using RegistrationBackend.data.Models;

namespace MembershipPortal.core
{
    public class RegistrationDBContext: DbContext{
        public RegistrationDBContext(DbContextOptions<RegistrationDBContext> options) : base(options){

        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<GLNRequest> GLNRequests { get; set; }
    }
}