﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

#nullable disable

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    [Migration("20240922070533_Updating_the_database")]
    partial class Updating_the_database
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DestinationName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OverallRating")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            City = "Lagos",
                            Country = "Nigeria",
                            DestinationName = "Silicon Valley",
                            OverallRating = 5,
                            Review = "The place is a great place for startups to thrive in",
                            UserName = "Dynasty"
                        },
                        new
                        {
                            DestinationId = 2,
                            City = "Acrra",
                            Country = "Ghana",
                            DestinationName = "Boston",
                            OverallRating = 3,
                            Review = "Boston is a very very cold city in the United States of America",
                            UserName = "Daniel"
                        },
                        new
                        {
                            DestinationId = 3,
                            City = "Brocklyn",
                            Country = "USA",
                            DestinationName = "Michighan",
                            OverallRating = 4,
                            Review = "A Nice place to be in with a loved one... Its a peaceful place to be in",
                            UserName = "Mike"
                        },
                        new
                        {
                            DestinationId = 4,
                            City = "Southampton",
                            Country = "United Kingdom",
                            DestinationName = "Manchester",
                            OverallRating = 5,
                            Review = "Great Weather in Manchester, and its the home to my beloved club Manchester United",
                            UserName = "Taylor"
                        },
                        new
                        {
                            DestinationId = 5,
                            City = "Alberta",
                            Country = "Canada",
                            DestinationName = "Toronto",
                            OverallRating = 5,
                            Review = "Ontario has got to be one of the best States in the country Canada, not only is Toronto the capital of the Country but it is also a great place to travel to",
                            UserName = "Dynasty"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
