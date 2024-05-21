﻿// <auto-generated />
using System;
using DomainDrivenDesign.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DomainDrivenDesign.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240521184410_mg1")]
    partial class mg1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DomainDrivenDesign.Domain.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailConfirmCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DomainDrivenDesign.Domain.Users.User", b =>
                {
                    b.OwnsOne("DomainDrivenDesign.Domain.Users.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("varchar(50)")
                                .HasColumnName("City");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("varchar(50)")
                                .HasColumnName("Country");

                            b1.Property<string>("FullAddress")
                                .IsRequired()
                                .HasColumnType("varchar(250)")
                                .HasColumnName("FullAddress");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("varchar(50)")
                                .HasColumnName("Street");

                            b1.Property<string>("Town")
                                .IsRequired()
                                .HasColumnType("varchar(50)")
                                .HasColumnName("Town");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
