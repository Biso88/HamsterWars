using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWars.api.Data.Migrations
{
    public partial class initData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hamsters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    FavFood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Loves = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Losses = table.Column<int>(type: "int", nullable: false),
                    Games = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamsters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[,]
                {
                    { 1, 1, "Kyckling", 0, "hamster-1.jpg", 0, "Camp Sport", "Koko", 0 },
                    { 2, 2, "Kött", 0, "hamster-2.jpg", 0, "Springa", "Kiki", 0 },
                    { 3, 3, "Lammbiff", 0, "hamster-3.jpg", 0, "Promonera", "Chris", 0 },
                    { 4, 1, "KycklingSalad", 0, "hamster-4.jpg", 0, "Jogga", "Kristian", 0 },
                    { 5, 4, "Pasta", 0, "hamster-5.jpg", 0, "Äta", "Adam", 0 },
                    { 6, 2, "Ris", 0, "hamster-6.jpg", 0, "Dricka alkohol", "Adiso", 0 },
                    { 7, 2, "Grönsaker", 0, "hamster-7.jpg", 0, "Spela PS5", "Biso", 0 },
                    { 8, 1, "Räkor", 0, "hamster-8.jpg", 0, "Spela WII", "Angelica", 0 },
                    { 9, 1, "Räksalad", 0, "hamster-9.jpg", 0, "Havet", "Angel", 0 },
                    { 10, 1, "Ägg", 0, "hamster-10.jpg", 0, "Stränder", "Alice", 0 },
                    { 11, 1, "Äggsalad", 0, "hamster-11.jpg", 0, "Sol", "Cisi", 0 },
                    { 12, 3, "Kebabrulle", 0, "hamster-12.jpg", 0, "Regn", "Cicilia", 0 },
                    { 13, 3, "Kebabtallrik", 0, "hamster-13.jpg", 0, "Mysa", "Josefine", 0 },
                    { 14, 3, "Kycklingrulle", 0, "hamster-14.jpg", 0, "Kolla på TV", "Josy", 0 },
                    { 15, 3, "Pizza", 0, "hamster-15.jpg", 0, "Cykla", "Samo", 0 },
                    { 16, 4, "Gurka", 0, "hamster-16.jpg", 0, "Bilar", "Sam", 0 },
                    { 17, 4, "Tomater", 0, "hamster-17.jpg", 0, "Formula One", "Jorgy", 0 },
                    { 18, 4, "Vattebmelon", 0, "hamster-18.jpg", 0, "Lyssna på musik", "Alex", 0 },
                    { 19, 4, "Vindruvor", 0, "hamster-19.jpg", 0, "Lyssna på Ljudböcker", "Alexandra", 0 },
                    { 20, 1, "Äpple", 0, "hamster-20.jpg", 0, "Programmera", "Alexo", 0 },
                    { 21, 1, "Appelsin", 0, "hamster-21.jpg", 0, "Spela datorspel", "Laly", 0 },
                    { 22, 1, "Bananer", 0, "hamster-22.jpg", 0, "Blommor", "Lolo", 0 },
                    { 23, 1, "Appelpaj", 0, "hamster-23.jpg", 0, "Ha roligt", "Lalito", 0 },
                    { 24, 4, "Nodler", 0, "hamster-24.jpg", 0, "Samla pengar", "Lavlav", 0 },
                    { 25, 4, "Skaldjur", 0, "hamster-25.jpg", 0, "Jobba", "Lavino", 0 },
                    { 26, 2, "Ost och skinka", 0, "hamster-26.jpg", 0, "Resa", "Bobsy", 0 },
                    { 27, 2, "Potatis", 0, "hamster-27.jpg", 0, "Boxning", "Babito", 0 },
                    { 28, 2, "Lök", 0, "hamster-28.jpg", 0, "Att bli pilot", "Babos", 0 },
                    { 29, 2, "Vitlök", 0, "hamster-29.jpg", 0, "Att bli advokat", "Rayan", 0 },
                    { 30, 1, "Stark sås", 0, "hamster-30.jpg", 0, "Dansa", "Royana", 0 },
                    { 31, 1, "Isbergssallad", 0, "hamster-31.jpg", 0, "spela Piano", "Simon", 0 },
                    { 32, 1, "Korv", 0, "hamster-32.jpg", 0, "Rida häst", "Samona", 0 },
                    { 33, 1, "Korv med potatismos", 0, "hamster-33.jpg", 0, "Dansa", "Samsam", 0 },
                    { 34, 3, "Potatismos", 0, "hamster-34.jpg", 0, "Spela fotboll", "Johan", 0 },
                    { 35, 3, "Ölkorv", 0, "hamster-35.jpg", 0, "Spela tennis", "Johansson", 0 },
                    { 36, 3, "Wine", 0, "hamster-36.jpg", 0, "Bowla", "Jonsson", 0 },
                    { 37, 3, "Whisky", 0, "hamster-37.jpg", 0, "Spela biljard", "Yossy", 0 },
                    { 38, 3, "Öl", 0, "hamster-38.jpg", 0, "Laga mat", "Yossif", 0 },
                    { 39, 3, "Gin", 0, "hamster-39.jpg", 0, "Köra bil", "Gigi", 0 },
                    { 40, 3, "Vodka", 0, "hamster-40.jpg", 0, "Motorcykel", "Mårten", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hamsters");
        }
    }
}
