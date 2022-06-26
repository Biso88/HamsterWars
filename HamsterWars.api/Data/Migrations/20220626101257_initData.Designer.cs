﻿// <auto-generated />
using HamsterWars.api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HamsterWars.api.Data.Migrations
{
    [DbContext(typeof(HamsterDbContext))]
    [Migration("20220626101257_initData")]
    partial class initData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HamsterWars.data.Hamster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FavFood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Games")
                        .HasColumnType("int");

                    b.Property<string>("ImgName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Losses")
                        .HasColumnType("int");

                    b.Property<string>("Loves")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hamsters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 1,
                            FavFood = "Kyckling",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Losses = 0,
                            Loves = "Camp Sport",
                            Name = "Koko",
                            Wins = 0
                        },
                        new
                        {
                            Id = 2,
                            Age = 2,
                            FavFood = "Kött",
                            Games = 0,
                            ImgName = "hamster-2.jpg",
                            Losses = 0,
                            Loves = "Springa",
                            Name = "Kiki",
                            Wins = 0
                        },
                        new
                        {
                            Id = 3,
                            Age = 3,
                            FavFood = "Lammbiff",
                            Games = 0,
                            ImgName = "hamster-3.jpg",
                            Losses = 0,
                            Loves = "Promonera",
                            Name = "Chris",
                            Wins = 0
                        },
                        new
                        {
                            Id = 4,
                            Age = 1,
                            FavFood = "KycklingSalad",
                            Games = 0,
                            ImgName = "hamster-4.jpg",
                            Losses = 0,
                            Loves = "Jogga",
                            Name = "Kristian",
                            Wins = 0
                        },
                        new
                        {
                            Id = 5,
                            Age = 4,
                            FavFood = "Pasta",
                            Games = 0,
                            ImgName = "hamster-5.jpg",
                            Losses = 0,
                            Loves = "Äta",
                            Name = "Adam",
                            Wins = 0
                        },
                        new
                        {
                            Id = 6,
                            Age = 2,
                            FavFood = "Ris",
                            Games = 0,
                            ImgName = "hamster-6.jpg",
                            Losses = 0,
                            Loves = "Dricka alkohol",
                            Name = "Adiso",
                            Wins = 0
                        },
                        new
                        {
                            Id = 7,
                            Age = 2,
                            FavFood = "Grönsaker",
                            Games = 0,
                            ImgName = "hamster-7.jpg",
                            Losses = 0,
                            Loves = "Spela PS5",
                            Name = "Biso",
                            Wins = 0
                        },
                        new
                        {
                            Id = 8,
                            Age = 1,
                            FavFood = "Räkor",
                            Games = 0,
                            ImgName = "hamster-8.jpg",
                            Losses = 0,
                            Loves = "Spela WII",
                            Name = "Angelica",
                            Wins = 0
                        },
                        new
                        {
                            Id = 9,
                            Age = 1,
                            FavFood = "Räksalad",
                            Games = 0,
                            ImgName = "hamster-9.jpg",
                            Losses = 0,
                            Loves = "Havet",
                            Name = "Angel",
                            Wins = 0
                        },
                        new
                        {
                            Id = 10,
                            Age = 1,
                            FavFood = "Ägg",
                            Games = 0,
                            ImgName = "hamster-10.jpg",
                            Losses = 0,
                            Loves = "Stränder",
                            Name = "Alice",
                            Wins = 0
                        },
                        new
                        {
                            Id = 11,
                            Age = 1,
                            FavFood = "Äggsalad",
                            Games = 0,
                            ImgName = "hamster-11.jpg",
                            Losses = 0,
                            Loves = "Sol",
                            Name = "Cisi",
                            Wins = 0
                        },
                        new
                        {
                            Id = 12,
                            Age = 3,
                            FavFood = "Kebabrulle",
                            Games = 0,
                            ImgName = "hamster-12.jpg",
                            Losses = 0,
                            Loves = "Regn",
                            Name = "Cicilia",
                            Wins = 0
                        },
                        new
                        {
                            Id = 13,
                            Age = 3,
                            FavFood = "Kebabtallrik",
                            Games = 0,
                            ImgName = "hamster-13.jpg",
                            Losses = 0,
                            Loves = "Mysa",
                            Name = "Josefine",
                            Wins = 0
                        },
                        new
                        {
                            Id = 14,
                            Age = 3,
                            FavFood = "Kycklingrulle",
                            Games = 0,
                            ImgName = "hamster-14.jpg",
                            Losses = 0,
                            Loves = "Kolla på TV",
                            Name = "Josy",
                            Wins = 0
                        },
                        new
                        {
                            Id = 15,
                            Age = 3,
                            FavFood = "Pizza",
                            Games = 0,
                            ImgName = "hamster-15.jpg",
                            Losses = 0,
                            Loves = "Cykla",
                            Name = "Samo",
                            Wins = 0
                        },
                        new
                        {
                            Id = 16,
                            Age = 4,
                            FavFood = "Gurka",
                            Games = 0,
                            ImgName = "hamster-16.jpg",
                            Losses = 0,
                            Loves = "Bilar",
                            Name = "Sam",
                            Wins = 0
                        },
                        new
                        {
                            Id = 17,
                            Age = 4,
                            FavFood = "Tomater",
                            Games = 0,
                            ImgName = "hamster-17.jpg",
                            Losses = 0,
                            Loves = "Formula One",
                            Name = "Jorgy",
                            Wins = 0
                        },
                        new
                        {
                            Id = 18,
                            Age = 4,
                            FavFood = "Vattebmelon",
                            Games = 0,
                            ImgName = "hamster-18.jpg",
                            Losses = 0,
                            Loves = "Lyssna på musik",
                            Name = "Alex",
                            Wins = 0
                        },
                        new
                        {
                            Id = 19,
                            Age = 4,
                            FavFood = "Vindruvor",
                            Games = 0,
                            ImgName = "hamster-19.jpg",
                            Losses = 0,
                            Loves = "Lyssna på Ljudböcker",
                            Name = "Alexandra",
                            Wins = 0
                        },
                        new
                        {
                            Id = 20,
                            Age = 1,
                            FavFood = "Äpple",
                            Games = 0,
                            ImgName = "hamster-20.jpg",
                            Losses = 0,
                            Loves = "Programmera",
                            Name = "Alexo",
                            Wins = 0
                        },
                        new
                        {
                            Id = 21,
                            Age = 1,
                            FavFood = "Appelsin",
                            Games = 0,
                            ImgName = "hamster-21.jpg",
                            Losses = 0,
                            Loves = "Spela datorspel",
                            Name = "Laly",
                            Wins = 0
                        },
                        new
                        {
                            Id = 22,
                            Age = 1,
                            FavFood = "Bananer",
                            Games = 0,
                            ImgName = "hamster-22.jpg",
                            Losses = 0,
                            Loves = "Blommor",
                            Name = "Lolo",
                            Wins = 0
                        },
                        new
                        {
                            Id = 23,
                            Age = 1,
                            FavFood = "Appelpaj",
                            Games = 0,
                            ImgName = "hamster-23.jpg",
                            Losses = 0,
                            Loves = "Ha roligt",
                            Name = "Lalito",
                            Wins = 0
                        },
                        new
                        {
                            Id = 24,
                            Age = 4,
                            FavFood = "Nodler",
                            Games = 0,
                            ImgName = "hamster-24.jpg",
                            Losses = 0,
                            Loves = "Samla pengar",
                            Name = "Lavlav",
                            Wins = 0
                        },
                        new
                        {
                            Id = 25,
                            Age = 4,
                            FavFood = "Skaldjur",
                            Games = 0,
                            ImgName = "hamster-25.jpg",
                            Losses = 0,
                            Loves = "Jobba",
                            Name = "Lavino",
                            Wins = 0
                        },
                        new
                        {
                            Id = 26,
                            Age = 2,
                            FavFood = "Ost och skinka",
                            Games = 0,
                            ImgName = "hamster-26.jpg",
                            Losses = 0,
                            Loves = "Resa",
                            Name = "Bobsy",
                            Wins = 0
                        },
                        new
                        {
                            Id = 27,
                            Age = 2,
                            FavFood = "Potatis",
                            Games = 0,
                            ImgName = "hamster-27.jpg",
                            Losses = 0,
                            Loves = "Boxning",
                            Name = "Babito",
                            Wins = 0
                        },
                        new
                        {
                            Id = 28,
                            Age = 2,
                            FavFood = "Lök",
                            Games = 0,
                            ImgName = "hamster-28.jpg",
                            Losses = 0,
                            Loves = "Att bli pilot",
                            Name = "Babos",
                            Wins = 0
                        },
                        new
                        {
                            Id = 29,
                            Age = 2,
                            FavFood = "Vitlök",
                            Games = 0,
                            ImgName = "hamster-29.jpg",
                            Losses = 0,
                            Loves = "Att bli advokat",
                            Name = "Rayan",
                            Wins = 0
                        },
                        new
                        {
                            Id = 30,
                            Age = 1,
                            FavFood = "Stark sås",
                            Games = 0,
                            ImgName = "hamster-30.jpg",
                            Losses = 0,
                            Loves = "Dansa",
                            Name = "Royana",
                            Wins = 0
                        },
                        new
                        {
                            Id = 31,
                            Age = 1,
                            FavFood = "Isbergssallad",
                            Games = 0,
                            ImgName = "hamster-31.jpg",
                            Losses = 0,
                            Loves = "spela Piano",
                            Name = "Simon",
                            Wins = 0
                        },
                        new
                        {
                            Id = 32,
                            Age = 1,
                            FavFood = "Korv",
                            Games = 0,
                            ImgName = "hamster-32.jpg",
                            Losses = 0,
                            Loves = "Rida häst",
                            Name = "Samona",
                            Wins = 0
                        },
                        new
                        {
                            Id = 33,
                            Age = 1,
                            FavFood = "Korv med potatismos",
                            Games = 0,
                            ImgName = "hamster-33.jpg",
                            Losses = 0,
                            Loves = "Dansa",
                            Name = "Samsam",
                            Wins = 0
                        },
                        new
                        {
                            Id = 34,
                            Age = 3,
                            FavFood = "Potatismos",
                            Games = 0,
                            ImgName = "hamster-34.jpg",
                            Losses = 0,
                            Loves = "Spela fotboll",
                            Name = "Johan",
                            Wins = 0
                        },
                        new
                        {
                            Id = 35,
                            Age = 3,
                            FavFood = "Ölkorv",
                            Games = 0,
                            ImgName = "hamster-35.jpg",
                            Losses = 0,
                            Loves = "Spela tennis",
                            Name = "Johansson",
                            Wins = 0
                        },
                        new
                        {
                            Id = 36,
                            Age = 3,
                            FavFood = "Wine",
                            Games = 0,
                            ImgName = "hamster-36.jpg",
                            Losses = 0,
                            Loves = "Bowla",
                            Name = "Jonsson",
                            Wins = 0
                        },
                        new
                        {
                            Id = 37,
                            Age = 3,
                            FavFood = "Whisky",
                            Games = 0,
                            ImgName = "hamster-37.jpg",
                            Losses = 0,
                            Loves = "Spela biljard",
                            Name = "Yossy",
                            Wins = 0
                        },
                        new
                        {
                            Id = 38,
                            Age = 3,
                            FavFood = "Öl",
                            Games = 0,
                            ImgName = "hamster-38.jpg",
                            Losses = 0,
                            Loves = "Laga mat",
                            Name = "Yossif",
                            Wins = 0
                        },
                        new
                        {
                            Id = 39,
                            Age = 3,
                            FavFood = "Gin",
                            Games = 0,
                            ImgName = "hamster-39.jpg",
                            Losses = 0,
                            Loves = "Köra bil",
                            Name = "Gigi",
                            Wins = 0
                        },
                        new
                        {
                            Id = 40,
                            Age = 3,
                            FavFood = "Vodka",
                            Games = 0,
                            ImgName = "hamster-40.jpg",
                            Losses = 0,
                            Loves = "Motorcykel",
                            Name = "Mårten",
                            Wins = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
