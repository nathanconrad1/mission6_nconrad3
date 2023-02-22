﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mission6_nconrad3.Models;

namespace mission6_nconrad3.Migrations
{
    [DbContext(typeof(MovieInfoContext))]
    [Migration("20230221212035_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("mission6_nconrad3.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApplicationID");

                    b.HasIndex("CategoryID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            ApplicationID = 1,
                            CategoryID = 2,
                            Director = "Mike Mitchell",
                            Edited = false,
                            LentTo = "Dave",
                            Notes = "Great Movie",
                            Rating = "PG",
                            Title = "Sky High",
                            Year = 2005
                        },
                        new
                        {
                            ApplicationID = 2,
                            CategoryID = 1,
                            Director = "John Stevenson",
                            Edited = false,
                            LentTo = "Dave",
                            Notes = "Great Movie",
                            Rating = "PG",
                            Title = "Kung Fu Panda",
                            Year = 2008
                        },
                        new
                        {
                            ApplicationID = 3,
                            CategoryID = 1,
                            Director = "Vicky Jenson",
                            Edited = false,
                            LentTo = "Dave",
                            Notes = "Best Movie",
                            Rating = "PG",
                            Title = "Shrek",
                            Year = 2001
                        });
                });

            modelBuilder.Entity("mission6_nconrad3.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Adventure"
                        });
                });

            modelBuilder.Entity("mission6_nconrad3.Models.ApplicationResponse", b =>
                {
                    b.HasOne("mission6_nconrad3.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
