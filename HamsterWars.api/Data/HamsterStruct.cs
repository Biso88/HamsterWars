﻿namespace HamsterWars.api.Data;

using HamsterWars.data;

public struct HamsterStruct
{
    public Hamster[] Hamsters;
    public HamsterStruct()
    {
        Hamsters = new[]
      {
                new Hamster {Id = 1, Name = "Koko", Age = 1, FavFood = "Kyckling", Loves = "Camp Sport", Wins = 0, Losses = 0, ImgName = "hamster-1.jpg", Games = 0},
                new Hamster {Id = 2, Name = "Kiki", Age = 2, FavFood = "Kött", Loves = "Springa", Wins = 0, Losses = 0, ImgName = "hamster-2.jpg", Games = 0},
                new Hamster {Id = 3, Name = "Chris", Age = 3, FavFood = "Lammbiff", Loves = "Promonera", Wins = 0, Losses = 0, ImgName = "hamster-3.jpg", Games = 0},
                new Hamster {Id = 4, Name = "Kristian", Age = 1, FavFood = "KycklingSalad", Loves = "Jogga", Wins = 0, Losses = 0, ImgName = "hamster-4.jpg", Games = 0},
                new Hamster {Id = 5, Name = "Adam", Age = 4, FavFood = "Pasta", Loves = "Äta", Wins = 0, Losses = 0, ImgName = "hamster-5.jpg", Games = 0},
                new Hamster {Id = 6, Name = "Adiso", Age = 2, FavFood = "Ris", Loves = "Dricka alkohol", Wins = 0, Losses = 0, ImgName = "hamster-6.jpg", Games = 0},
                new Hamster {Id = 7, Name = "Biso", Age = 2, FavFood = "Grönsaker", Loves = "Spela PS5", Wins = 0, Losses = 0, ImgName = "hamster-7.jpg", Games = 0},
                new Hamster {Id = 8, Name = "Angelica", Age = 1, FavFood = "Räkor", Loves = "Spela WII", Wins = 0, Losses = 0, ImgName = "hamster-8.jpg", Games = 0},
                new Hamster {Id = 9, Name = "Angel", Age = 1, FavFood = "Räksalad", Loves = "Havet", Wins = 0, Losses = 0, ImgName = "hamster-9.jpg", Games = 0},
                new Hamster {Id = 10, Name = "Alice", Age = 1, FavFood = "Ägg", Loves = "Stränder", Wins = 0, Losses = 0, ImgName = "hamster-10.jpg", Games = 0},
                new Hamster {Id = 11, Name = "Cisi", Age = 1, FavFood = "Äggsalad", Loves = "Sol", Wins = 0, Losses = 0, ImgName = "hamster-11.jpg", Games = 0},
                new Hamster {Id = 12, Name = "Cicilia", Age = 3, FavFood = "Kebabrulle", Loves = "Regn", Wins = 0, Losses = 0, ImgName = "hamster-12.jpg", Games = 0},
                new Hamster {Id = 13, Name = "Josefine", Age = 3, FavFood = "Kebabtallrik", Loves = "Mysa", Wins = 0, Losses = 0, ImgName = "hamster-13.jpg", Games = 0},
                new Hamster {Id = 14, Name = "Josy", Age = 3, FavFood = "Kycklingrulle", Loves = "Kolla på TV", Wins = 0, Losses = 0, ImgName = "hamster-14.jpg", Games = 0},
                new Hamster {Id = 15, Name = "Samo", Age = 3, FavFood = "Pizza", Loves = "Cykla", Wins = 0, Losses = 0, ImgName = "hamster-15.jpg", Games = 0},
                new Hamster {Id = 16, Name = "Sam", Age = 4, FavFood = "Gurka", Loves = "Bilar", Wins = 0, Losses = 0, ImgName = "hamster-16.jpg", Games = 0},
                new Hamster {Id = 17, Name = "Jorgy", Age = 4, FavFood = "Tomater", Loves = "Formula One", Wins = 0, Losses = 0, ImgName = "hamster-17.jpg", Games = 0},
                new Hamster {Id = 18, Name = "Alex", Age = 4, FavFood = "Vattebmelon", Loves = "Lyssna på musik", Wins = 0, Losses = 0, ImgName = "hamster-18.jpg", Games = 0},
                new Hamster {Id = 19, Name = "Alexandra", Age = 4, FavFood = "Vindruvor", Loves = "Lyssna på Ljudböcker", Wins = 0, Losses = 0, ImgName = "hamster-19.jpg", Games = 0},
                new Hamster {Id = 20, Name = "Alexo", Age = 1, FavFood = "Äpple", Loves = "Programmera", Wins = 0, Losses = 0, ImgName = "hamster-20.jpg", Games = 0},
                new Hamster {Id = 21, Name = "Laly", Age = 1, FavFood = "Appelsin", Loves = "Spela datorspel", Wins = 0, Losses = 0, ImgName = "hamster-21.jpg", Games = 0},
                new Hamster {Id = 22, Name = "Lolo", Age = 1, FavFood = "Bananer", Loves = "Blommor", Wins = 0, Losses = 0, ImgName = "hamster-22.jpg", Games = 0},
                new Hamster {Id = 23, Name = "Lalito", Age = 1, FavFood = "Appelpaj", Loves = "Ha roligt", Wins = 0, Losses = 0, ImgName = "hamster-23.jpg", Games = 0},
                new Hamster {Id = 24, Name = "Lavlav", Age = 4, FavFood = "Nodler", Loves = "Samla pengar", Wins = 0, Losses = 0, ImgName = "hamster-24.jpg", Games = 0},
                new Hamster {Id = 25, Name = "Lavino", Age = 4, FavFood = "Skaldjur", Loves = "Jobba", Wins = 0, Losses = 0, ImgName = "hamster-25.jpg", Games = 0},
                new Hamster {Id = 26, Name = "Bobsy", Age = 2, FavFood = "Ost och skinka", Loves = "Resa", Wins = 0, Losses = 0, ImgName = "hamster-26.jpg", Games = 0},
                new Hamster {Id = 27, Name = "Babito", Age = 2, FavFood = "Potatis", Loves = "Boxning", Wins = 0, Losses = 0, ImgName = "hamster-27.jpg", Games = 0},
                new Hamster {Id = 28, Name = "Babos", Age = 2, FavFood = "Lök", Loves = "Att bli pilot", Wins = 0, Losses = 0, ImgName = "hamster-28.jpg", Games = 0},
                new Hamster {Id = 29, Name = "Rayan", Age = 2, FavFood = "Vitlök", Loves = "Att bli advokat", Wins = 0, Losses = 0, ImgName = "hamster-29.jpg", Games = 0},
                new Hamster {Id = 30, Name = "Royana", Age = 1, FavFood = "Stark sås", Loves = "Dansa", Wins = 0, Losses = 0, ImgName = "hamster-30.jpg", Games = 0},
                new Hamster {Id = 31, Name = "Simon", Age = 1, FavFood = "Isbergssallad", Loves = "spela Piano", Wins = 0, Losses = 0, ImgName = "hamster-31.jpg", Games = 0},
                new Hamster {Id = 32, Name = "Samona", Age = 1, FavFood = "Korv", Loves = "Rida häst", Wins = 0, Losses = 0, ImgName = "hamster-32.jpg", Games = 0},
                new Hamster {Id = 33, Name = "Samsam", Age = 1, FavFood = "Korv med potatismos", Loves = "Dansa", Wins = 0, Losses = 0, ImgName = "hamster-33.jpg", Games = 0},
                new Hamster {Id = 34, Name = "Johan", Age = 3, FavFood = "Potatismos", Loves = "Spela fotboll", Wins = 0, Losses = 0, ImgName = "hamster-34.jpg", Games = 0},
                new Hamster {Id = 35, Name = "Johansson", Age = 3, FavFood = "Ölkorv", Loves = "Spela tennis", Wins = 0, Losses = 0, ImgName = "hamster-35.jpg", Games = 0},
                new Hamster {Id = 36, Name = "Jonsson", Age = 3, FavFood = "Wine", Loves = "Bowla", Wins = 0, Losses = 0, ImgName = "hamster-36.jpg", Games = 0},
                new Hamster {Id = 37, Name = "Yossy", Age = 3, FavFood = "Whisky", Loves = "Spela biljard", Wins = 0, Losses = 0, ImgName = "hamster-37.jpg", Games = 0},
                new Hamster {Id = 38, Name = "Yossif", Age = 3, FavFood = "Öl", Loves = "Laga mat", Wins = 0, Losses = 0, ImgName = "hamster-38.jpg", Games = 0},
                new Hamster {Id = 39, Name = "Gigi", Age = 3, FavFood = "Gin", Loves = "Köra bil", Wins = 0, Losses = 0, ImgName = "hamster-39.jpg", Games = 0},
                new Hamster {Id = 40, Name = "Mårten", Age = 3, FavFood = "Vodka", Loves = "Motorcykel", Wins = 0, Losses = 0, ImgName = "hamster-40.jpg", Games = 0}
            };
    }
}