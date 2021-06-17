﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuggestMovieDataBase;

namespace SuggestMovieDataBase.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210215111636_SuggestMovieMig")]
    partial class SuggestMovieMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SuggestMovieDomain.SuggestMovie", b =>
                {
                    b.Property<string>("Type_S")
                        .HasColumnType("TEXT");

                    b.Property<int>("Selected")
                        .HasColumnType("INTEGER");

                    b.HasKey("Type_S");

                    b.ToTable("SuggestMovies");

                    b.HasData(
                        new
                        {
                            Type_S = "mas vista",
                            Selected = 1
                        },
                        new
                        {
                            Type_S = "mas gustada",
                            Selected = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
