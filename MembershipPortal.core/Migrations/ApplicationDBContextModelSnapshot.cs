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
                .HasDefaultSchema("dbo")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);



            modelBuilder.Entity("MembershipPortal.data.GTINRequest", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("approvaldate")
                        .HasColumnType("datetime2");

                    b.Property<string>("approvedby")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("assignedby")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("assigneddate")
                        .HasColumnType("datetime2");

                    b.Property<int>("company_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdon")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateofrequest")
                        .HasColumnType("datetime2");

                    b.Property<int>("gtincount")
                        .HasColumnType("int");

                    b.Property<int>("gtinfee_id")
                        .HasColumnType("int");

                    b.Property<int?>("imagerequest_id")
                        .HasColumnType("int");

                    b.Property<bool>("isapproved")
                        .HasColumnType("bit");

                    b.Property<bool>("isgcpassigned")
                        .HasColumnType("bit");

                    b.Property<string>("registrationid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("requesttype")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("totalcost")
                        .HasColumnType("float");

                    b.Property<DateTime?>("updatedon")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("company_id");

                    b.HasIndex("gtinfee_id");

                    b.ToTable("GTINRequests");
                });



            modelBuilder.Entity("MembershipPortal.data.GTINRequest", b =>
                {
                    b.HasOne("MembershipPortal.data.ExternalEntries.Models.CompanyModel", "Companies")
                        .WithMany()
                        .HasForeignKey("company_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MembershipPortal.data.GTINFee", "GTINFee")
                        .WithMany()
                        .HasForeignKey("gtinfee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companies");

                    b.Navigation("GTINFee");
                });
#pragma warning restore 612, 618
        }
    }
}
