using Microsoft.EntityFrameworkCore;
using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace MembershipPortal.core
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public virtual DbSet<BrickCategory> BrickCategories { get; set; }
        public virtual DbSet<GLNInformation> GLNInformations { get; set; }
        public virtual DbSet<GTINInformation> GTINInformations { get; set; }
        public virtual DbSet<ITFInformation> ITFInformations { get; set; }
        public virtual DbSet<NetContent> NetContents { get; set; }
        public virtual DbSet<PackageLevel> PackageLevels { get; set; }
        public virtual DbSet<PackagingType> PackagingTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<PharmaceuticalInformation> PharmaceuticalInformations { get; set; }
        public virtual DbSet<TargetMarket> TargetMarkets { get; set; }
        public virtual DbSet<GCPInformation> GCPInformations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");

            modelBuilder.Entity<BrickCategory>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<GLNInformation>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<GTINInformation>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<ITFInformation>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<NetContent>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<PackageLevel>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<PackagingType>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
                entity.HasIndex(u => u.gtin).IsUnique();
            });

            modelBuilder.Entity<TargetMarket>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PharmaceuticalInformation>()
                .HasOne(p => p.Product)
                .WithOne(ph => ph.PharmaceuticalInformation)
                .IsRequired(false);

                
            //modelBuilder.Entity<Role>()
            //    .HasData(
            //        new Role { id = 1, name = "Member" },
            //        new Role { id = 2, name = "Admin" },
            //        new Role { id = 3, name = "SuperAdmin" }
            //    );
            //RegistrationBackend.core.Seed.EntitySeeder.Seed<ApplicationDBContext>();
            // modelBuilder.Entity<BrickCategory>().HasData(SeedBrickCategoryData());
            // modelBuilder.Entity<NetContent>().HasData(SeedNetContentData());
            // modelBuilder.Entity<PackageLevel>().HasData(SeedPackagingLevelData());
            // modelBuilder.Entity<PackagingType>().HasData(SeedPackagingTypeData());
            // modelBuilder.Entity<TargetMarket>().HasData(SeedTargetMarketData());

        }

        public List<NetContent> SeedNetContentData()
        {
            var netcontents = new List<NetContent>();
            using (StreamReader r = new StreamReader(@"Seed/netcontents.json"))
            {
                string json = r.ReadToEnd();
                netcontents = JsonConvert.DeserializeObject<List<NetContent>>(json);
            }
            return netcontents;
        }
        public List<BrickCategory> SeedBrickCategoryData()
        {
            var brickCategories = new List<BrickCategory>();
            using (StreamReader r = new StreamReader(@"Seed/brickcategory.json"))
            {
                string json = r.ReadToEnd();
                brickCategories = JsonConvert.DeserializeObject<List<BrickCategory>>(json);
            }
            return brickCategories;
        }
        public List<PackageLevel> SeedPackagingLevelData()
        {
            var packageLevels = new List<PackageLevel>();
            using (StreamReader r = new StreamReader(@"Seed/packaginglevel.json"))
            {
                string json = r.ReadToEnd();
                packageLevels = JsonConvert.DeserializeObject<List<PackageLevel>>(json);
            }
            return packageLevels;
        }
        public List<PackagingType> SeedPackagingTypeData()
        {
            var packageTypes = new List<PackagingType>();
            using (StreamReader r = new StreamReader(@"Seed/packagingtype.json"))
            {
                string json = r.ReadToEnd();
                packageTypes = JsonConvert.DeserializeObject<List<PackagingType>>(json);
            }
            return packageTypes;
        }
        public List<TargetMarket> SeedTargetMarketData()
        {
            var targetMarkets = new List<TargetMarket>();
            using (StreamReader r = new StreamReader(@"Seed/targetMarket.json"))
            {
                string json = r.ReadToEnd();
                targetMarkets = JsonConvert.DeserializeObject<List<TargetMarket>>(json);
            }
            return targetMarkets;
        }

        //public List<LocalGovt> SeedLocalGovtData()
        //{
        //    var lga = new List<LocalGovt>();
        //    using (StreamReader r = new StreamReader(@"Seed/localgovts.json"))
        //    {
        //        string json = r.ReadToEnd();
        //        lga = JsonConvert.DeserializeObject<List<LocalGovt>>(json);
        //    }
        //    return lga.Select(l => new LocalGovt() { id = l.id, name = l.name, state_id = l.state_id, }).ToList();
        //}
    }
}
