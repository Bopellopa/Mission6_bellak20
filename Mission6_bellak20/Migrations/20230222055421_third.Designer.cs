﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6_bellak20.Models;

namespace Mission6_bellak20.Migrations
{
    [DbContext(typeof(MoviesEntryContext))]
    [Migration("20230222055421_third")]
    partial class third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6_bellak20.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryCode = 0,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryCode = 0,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryCode = 0,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryCode = 0,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryCode = 0,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryCode = 0,
                            CategoryName = "Micellaneous"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryCode = 0,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryCode = 0,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("Mission6_bellak20.Models.MovieResponse", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
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

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ApplicationId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            ApplicationId = 1,
                            CategoryId = 1,
                            Director = "Who Knows",
                            Edited = false,
                            Rating = "PG",
                            Title = "Gremlins",
                            Year = "1989"
                        },
                        new
                        {
                            ApplicationId = 2,
                            CategoryId = 2,
                            Director = "Who Knows",
                            Edited = false,
                            Rating = "PG",
                            Title = "Gremlins",
                            Year = "1989"
                        },
                        new
                        {
                            ApplicationId = 3,
                            CategoryId = 3,
                            Director = "Who Knows",
                            Edited = false,
                            Rating = "PG",
                            Title = "Gremlins",
                            Year = "1989"
                        });
                });

            modelBuilder.Entity("Mission6_bellak20.Models.MovieResponse", b =>
                {
                    b.HasOne("Mission6_bellak20.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
