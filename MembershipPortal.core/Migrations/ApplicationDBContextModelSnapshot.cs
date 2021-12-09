﻿// <auto-generated />
using System;
using MembershipPortal.core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MembershipPortal.core.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MembershipPortal.data.BrickCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("brick")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("brick_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("createddate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("modifieddate")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("BrickCategories");
                });

            modelBuilder.Entity("MembershipPortal.data.GLNInformation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("companyprefix")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("createddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("gln")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("modifieddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("registrationid")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("GLNInformations");
                });

            modelBuilder.Entity("MembershipPortal.data.GTINInformation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("checksum")
                        .HasColumnType("int");

                    b.Property<string>("companyprefix")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("createddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("gtin")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("modifieddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("productcode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("registrationid")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("GTINInformations");
                });

            modelBuilder.Entity("MembershipPortal.data.ITFInformation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("companyprefix")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("createddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("itf14")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("modifieddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("registrationid")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("ITFInformations");
                });

            modelBuilder.Entity("MembershipPortal.data.NetContent", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("createddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("modifieddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("NetContents");
                });

            modelBuilder.Entity("MembershipPortal.data.PackageLevel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("createddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("level")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("modifieddate")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("PackageLevels");
                });

            modelBuilder.Entity("MembershipPortal.data.PackagingType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("createddate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("modifieddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("packagingname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("PackagingTypes");
                });

            modelBuilder.Entity("MembershipPortal.data.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("allergeninfo")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("backimage")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("brandname")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("brickcategory_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("consumerfirstavailabilitydate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("createddate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateoflisting")
                        .HasColumnType("datetime2");

                    b.Property<string>("directionofuse")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("frontimage")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<double>("grossweight")
                        .HasColumnType("float");

                    b.Property<string>("gtin")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("hasimage")
                        .HasColumnType("bit");

                    b.Property<string>("ingredients")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("iscompleted")
                        .HasColumnType("bit");

                    b.Property<int>("lifespan")
                        .HasColumnType("int");

                    b.Property<string>("lifespanunit")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("marketingmessage")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("modifieddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("nafdacnumber")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("netcontent_id")
                        .HasColumnType("int");

                    b.Property<double>("netweight")
                        .HasColumnType("float");

                    b.Property<int>("packaginglevel_id")
                        .HasColumnType("int");

                    b.Property<int>("packagingtype_id")
                        .HasColumnType("int");

                    b.Property<string>("productdescription")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("registrationid")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("storageinstruction")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("targetmarket_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("brickcategory_id");

                    b.HasIndex("netcontent_id");

                    b.HasIndex("packaginglevel_id");

                    b.HasIndex("packagingtype_id");

                    b.HasIndex("targetmarket_id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MembershipPortal.data.TargetMarket", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("id");

                    b.ToTable("TargetMarkets");
                });

            modelBuilder.Entity("MembershipPortal.data.Product", b =>
                {
                    b.HasOne("MembershipPortal.data.BrickCategory", "BrickCategory")
                        .WithMany("Products")
                        .HasForeignKey("brickcategory_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MembershipPortal.data.NetContent", "NetContent")
                        .WithMany("Products")
                        .HasForeignKey("netcontent_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MembershipPortal.data.PackageLevel", "PackageLevel")
                        .WithMany()
                        .HasForeignKey("packaginglevel_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MembershipPortal.data.PackagingType", "PackagingType")
                        .WithMany("Products")
                        .HasForeignKey("packagingtype_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MembershipPortal.data.TargetMarket", "TargetMarket")
                        .WithMany()
                        .HasForeignKey("targetmarket_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BrickCategory");

                    b.Navigation("NetContent");

                    b.Navigation("PackageLevel");

                    b.Navigation("PackagingType");

                    b.Navigation("TargetMarket");
                });

            modelBuilder.Entity("MembershipPortal.data.BrickCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("MembershipPortal.data.NetContent", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("MembershipPortal.data.PackagingType", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
