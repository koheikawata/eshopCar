using Microsoft.EntityFrameworkCore.Migrations;

namespace eshopCar.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 1, null, "Sedan" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 2, null, "SUV" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 3, null, "Small" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "CategoryId", "Description", "ImageThumbNailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "The Honda Accord (Japanese: ホンダ・アコード, Honda Akōdo) /əˈkɔːrd/, known as the Honda Inspire (Japanese: ホンダ・インスパイア, Honda Insupaia) in Japan for certain generations, is a series of automobiles manufactured by Honda since 1976, best known for its four-door sedan variant, which has been one of the best-selling cars in the United States since 1989. The Accord nameplate has been applied to a variety of vehicles worldwide, including coupes, station wagons, hatchbacks and a Honda Crosstour crossover.", "/Images/accord-small.jpg", "/Images/accord.jpg", true, false, "Accord", 3.5m },
                    { 3, 1, "The Honda Civic (Japanese: ホンダ・シビック, Honda Shibikku) is a line of cars manufactured by Honda. Originally a subcompact, the Civic has gone through several generational changes, becoming both larger and more upscale, moving into the compact car segment. EPA guidelines for vehicle size class stipulate a car having combined passenger and cargo room of 110 to 119.9 cubic feet (3,110 to 3,400 L) is considered a mid-size car, and as such the tenth generation Civic sedan is technically a small-end mid-size car, although it still competes in the compact class. The Civic coupé is still considered a compact car. The Civic currently falls between the Honda City and Honda Accord.", "/Images/civic-small.jpg", "/Images/civic.jpg", true, false, "Civic", 2.5m },
                    { 2, 2, "The Honda CR-V is a compact crossover SUV manufactured by Japanese automaker Honda since 1995 and introduced in the North American market in 1997.[1][2] It uses the Honda Civic platform with an SUV body design. The CR-V is Honda's mid-range utility vehicle, slotting between the smaller Honda HR-V and the larger North American market Honda Pilot. Honda states CR - V stands for Comfortable Runabout Vehicle, while the term Compact Recreational Vehicle is used in a British car review article that was republished by Honda.", "/Images/crv-small.jpg", "/Images/crv.jpg", true, true, "CRV", 4.5m },
                    { 4, 3, "The Honda Fit (Japanese: ホンダ・フィット, Hepburn: Honda Fitto), also marketed as Honda Jazz, is a five-door B-segment supermini or subcompact car manufactured and marketed by Honda since 2001 and now in its fourth generation. Marketed worldwide and manufactured at ten plants in eight countries, sales reached almost 5 million by mid-2013.", "/Images/fit-small.jpg", "/Images/fit.jpg", true, false, "Fit", 1.5m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
