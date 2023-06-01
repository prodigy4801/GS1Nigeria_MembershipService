using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Threading;
using MembershipPortal.data.ExternalEntries.Models;

namespace MembershipPortal.core
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public virtual DbSet<BrickCategory> BrickCategories { get; set; }
        public virtual DbSet<BrandInformation> BrandInformations { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanySectorCategory> CompanySectorCategories { get; set; }
        public virtual DbSet<CompanySectorType> CompanySectorTypes { get; set; }
        public virtual DbSet<ContactInformation> ContactInformations { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<ExternalUnifiedModel> ExternalUnifiedModels { get; set; }
        public virtual DbSet<GCPInformation> GCPInformations { get; set; }
        public virtual DbSet<GLNInformation> GLNInformations { get; set; }
        public virtual DbSet<GTINFee> GTINFees { get; set; }
        public virtual DbSet<GTINRequest> GTINRequests { get; set; }
        public virtual DbSet<GTINInformation> GTINInformations { get; set; }
        public virtual DbSet<HeardAboutUs> HeardAboutUs { get; set; }
        public virtual DbSet<ImageBank> ImageBanks { get; set; }
        public virtual DbSet<ImageBankUsage> ImageBankUsages { get; set; }
        public virtual DbSet<ImageRequest> ImageRequests { get; set; }
        public virtual DbSet<ITFInformation> ITFInformations { get; set; }
        public virtual DbSet<LocalGovt> LocalGovts { get; set; }
        public virtual DbSet<NetContent> NetContents { get; set; }
        public virtual DbSet<PackageLevel> PackageLevels { get; set; }
        public virtual DbSet<PackagingType> PackagingTypes { get; set; }
        public virtual DbSet<PharmaceuticalInformation> PharmaceuticalInformations { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductTargetMarket> ProductTargetMarkets { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<TargetMarket> TargetMarkets { get; set; }

        public virtual DbSet<SegmentCategory> SegmentCategories { get; set; }
        public virtual DbSet<FamilyCategory> FamilyCategories { get; set; }
        public virtual DbSet<ClassCategory> ClassCategories { get; set; }
        public virtual DbSet<RoleModel> Roles { get; set; }
        public virtual DbSet<UserModel> Users { get; set; }
        public virtual DbSet<UserValidationTokenModel> UserValidationTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");

            modelBuilder.Entity<BrickCategory>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<BrandInformation>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
                entity.HasIndex(u => u.brandname).IsUnique();
            });
            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
                entity.HasIndex(u => u.registrationid).IsUnique();
                // entity.HasIndex(u => u.email).IsUnique();
            });
            modelBuilder.Entity<CompanySectorCategory>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<CompanySectorType>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<ContactInformation>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
                entity.HasIndex(u => u.registrationId).IsUnique();
            });
            modelBuilder.Entity<ExternalUnifiedModel>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
                entity.HasIndex(u => u.product_id).IsUnique();
            });
            modelBuilder.Entity<GLNInformation>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<GCPInformation>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<GTINFee>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<GTINInformation>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<ImageBank>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
                entity.HasIndex(u => u.registrationid).IsUnique();
            });
            modelBuilder.Entity<ImageBankUsage>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
                entity.HasIndex(u => u.gtin).IsUnique();
            });
            modelBuilder.Entity<ImageRequest>(entity =>
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

            modelBuilder.Entity<PharmaceuticalInformation>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
                entity.HasIndex(e => e.ProductID).IsUnique();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
                entity.HasIndex(u => u.gtin).IsUnique();
            });
            modelBuilder.Entity<ProductTargetMarket>(entity =>
            {
                entity.HasKey(e => new { e.id, e.product_id, e.targetmarket_id });
                entity.Property(e => e.id).ValueGeneratedOnAdd();
                entity.HasOne(e => e.Product).WithMany(f => f.ProductTargetMarket).HasForeignKey(g => g.product_id);
                entity.HasOne(e => e.TargetMarket).WithMany(f => f.ProductTargetMarket).HasForeignKey(g => g.targetmarket_id);
            });

            modelBuilder.Entity<TargetMarket>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });


            modelBuilder.Entity<SegmentCategory>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
                entity.HasIndex(u => u.SegmentCode).IsUnique();
            });
            modelBuilder.Entity<FamilyCategory>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
                entity.HasIndex(u => u.FamilyCode).IsUnique();
            });
            modelBuilder.Entity<ClassCategory>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
                entity.HasIndex(u => u.ClassCode).IsUnique();
            });
            //modelBuilder.Entity<PharmaceuticalInformation>()
            //    .HasOne(p => p.Product)
            //    .
            //    .WithOne(ph => ph.PharmaceuticalInformation)
            //    .IsRequired(false);


            modelBuilder.Entity<RoleModel>()
                .HasData(
                    new RoleModel { id = 1, name = "Member" },
                    new RoleModel { id = 2, name = "Admin" },
                    new RoleModel { id = 3, name = "SuperAdmin" }
                );
            //RegistrationBackend.core.Seed.EntitySeeder.Seed<ApplicationDBContext>();
            modelBuilder.Entity<BrickCategory>().HasData(SeedBrickCategoryData());
            modelBuilder.Entity<NetContent>().HasData(SeedNetContentData());
            modelBuilder.Entity<PackageLevel>().HasData(SeedPackagingLevelData());
            modelBuilder.Entity<PackagingType>().HasData(SeedPackagingTypeData());
            modelBuilder.Entity<TargetMarket>().HasData(SeedTargetMarketData());
            modelBuilder.Entity<SegmentCategory>().HasData(SeedSegmentCategoryData());
            modelBuilder.Entity<FamilyCategory>().HasData(SeedFamilyCategoryData());

            modelBuilder.Entity<Country>().HasData(SeedCountriesData());
            modelBuilder.Entity<State>().HasData(SeedStatesData());
            modelBuilder.Entity<LocalGovt>().HasData(SeedLocalGovtData());
            modelBuilder.Entity<GTINFee>().HasData(SeedGTINFeeData());
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

        public List<SegmentCategory> SeedSegmentCategoryData()
        {
            var segmentcategories = new List<SegmentCategory>();
            using (StreamReader r = new StreamReader(@"Seed/segmentcategory.json"))
            {
                string json = r.ReadToEnd();
                segmentcategories = JsonConvert.DeserializeObject<List<SegmentCategory>>(json);
            }
            return segmentcategories;
        }

        public List<FamilyCategory> SeedFamilyCategoryData()
        {
            var familycategories = new List<FamilyCategory>();
            using (StreamReader r = new StreamReader(@"Seed/familycategory.json"))
            {
                string json = r.ReadToEnd();
                familycategories = JsonConvert.DeserializeObject<List<FamilyCategory>>(json);
            }
            return familycategories;
        }

        public List<Country> SeedCountriesData()
        {
            var countrycategories = new List<Country>();
            using (StreamReader r = new StreamReader(@"Seed/countries.json"))
            {
                string json = r.ReadToEnd();
                countrycategories = JsonConvert.DeserializeObject<List<Country>>(json);
            }
            return countrycategories;
        }

        public List<State> SeedStatesData()
        {
            var states = new List<State>();
            using (StreamReader r = new StreamReader(@"Seed/countries.json"))
            {
                string json = r.ReadToEnd();
                states = JsonConvert.DeserializeObject<List<State>>(json);
            }
            return states;
        }

        public List<LocalGovt> SeedLocalGovtData()
        {
            var localgovts = new List<LocalGovt>();
            using (StreamReader r = new StreamReader(@"Seed/countries.json"))
            {
                string json = r.ReadToEnd();
                localgovts = JsonConvert.DeserializeObject<List<LocalGovt>>(json);
            }
            return localgovts;
        }

        public List<GTINFee> SeedGTINFeeData()
        {
            var gtinfees = new List<GTINFee>();
            using (StreamReader r = new StreamReader(@"Seed/gtinfee.json"))
            {
                string json = r.ReadToEnd();
                gtinfees = JsonConvert.DeserializeObject<List<GTINFee>>(json);
            }
            return gtinfees;
        }
    }
}
