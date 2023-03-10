// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcCSharp6.Models;

namespace MvcCSharp6.Migrations
{
    [DbContext(typeof(MovieDataContext))]
    [Migration("20230210065637_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("MvcCSharp6.Models.MovieModel", b =>
                {
                    b.Property<int>("movieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("lentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ushort>("year")
                        .HasColumnType("INTEGER");

                    b.HasKey("movieId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            movieId = 1,
                            category = "drama",
                            director = "John Lasseter",
                            edited = false,
                            notes = "super emotional",
                            rating = "G",
                            title = "Cars 2",
                            year = (ushort)2011
                        },
                        new
                        {
                            movieId = 2,
                            category = "comedy",
                            director = "Tom McGrath",
                            edited = false,
                            notes = "greatest movie ever made",
                            rating = "PG",
                            title = "Megamind",
                            year = (ushort)2010
                        },
                        new
                        {
                            movieId = 3,
                            category = "action",
                            director = "Steven Spielberg",
                            edited = false,
                            notes = "wow",
                            rating = "R",
                            title = "Saving Private Ryan",
                            year = (ushort)1998
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
