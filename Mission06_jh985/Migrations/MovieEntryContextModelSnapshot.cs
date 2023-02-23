﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_jh985.Models;

namespace Mission06_jh985.Migrations
{
    [DbContext(typeof(MovieEntryContext))]
    partial class MovieEntryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_jh985.Models.Category", b =>
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
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Sports"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Fantasy"
                        });
                });

            modelBuilder.Entity("Mission06_jh985.Models.MovieEntryModel", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
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

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            CategoryID = 3,
                            Director = "Joseph B. Worthin",
                            Edited = true,
                            Lent = "David A Bednar",
                            Notes = "Best Movie created babe",
                            Rating = "PG-13",
                            Title = "The Proposal",
                            Year = 1980
                        },
                        new
                        {
                            MovieID = 2,
                            CategoryID = 5,
                            Director = "JK Rowling",
                            Edited = false,
                            Lent = "Pooh Bear",
                            Notes = "pretty good movie babe",
                            Rating = "PG-13",
                            Title = "Harry Potter",
                            Year = 2007
                        },
                        new
                        {
                            MovieID = 3,
                            CategoryID = 4,
                            Director = "Kevin Holt",
                            Edited = true,
                            Lent = "Dee Dee Holt",
                            Notes = "Motivated me to win the state champtionship",
                            Rating = "R",
                            Title = "Forever Strong",
                            Year = 2013
                        });
                });

            modelBuilder.Entity("Mission06_jh985.Models.MovieEntryModel", b =>
                {
                    b.HasOne("Mission06_jh985.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
