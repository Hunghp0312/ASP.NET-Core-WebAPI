using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "BirthPlace", "DateOfBirth", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { new Guid("12aa065d-a0d8-4591-999e-e8c1ba1fb900"), "Phoenix", new DateTime(1990, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matthew", 0, "Anderson" },
                    { new Guid("1bb593dc-7119-475a-9cb9-51deba8ef12c"), "Miami", new DateTime(1987, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", 0, "Harris" },
                    { new Guid("1f859c82-7d62-4d9a-8cd6-81e470c9a14b"), "Boston", new DateTime(1997, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ryan", 0, "Jackson" },
                    { new Guid("2a8c80b4-6b68-4574-8647-b4debe7699f6"), "Denver", new DateTime(1982, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lily", 1, "White" },
                    { new Guid("3711ada9-cd02-47da-8d48-c0a864218d40"), "Chicago", new DateTime(1992, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alex", 2, "Brown" },
                    { new Guid("3b273f6a-4710-4059-bd97-c5891fc5ab5b"), "Los Angeles", new DateTime(1985, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", 1, "Johnson" },
                    { new Guid("3be9998c-d61e-49dd-8a9b-79f3339e41df"), "San Francisco", new DateTime(1991, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sophia", 1, "Martin" },
                    { new Guid("44451e65-302c-4292-94b9-50f523f4858c"), "Los Angeles", new DateTime(1996, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olivia", 1, "Johnson" },
                    { new Guid("4d7fc689-e9e2-4560-abb0-c1e0bc84fb20"), "Houston", new DateTime(1988, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily", 1, "Taylor" },
                    { new Guid("5df21aa4-5369-4572-b8f7-6efab0fce33b"), "Chicago", new DateTime(1984, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", 0, "Brown" },
                    { new Guid("7a623450-2827-4068-8a8a-3dc0c14b0dfd"), "New York", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", 0, "Smith" },
                    { new Guid("83c00f3a-b23b-4bfa-8122-b2890c0125c5"), "Boston", new DateTime(1979, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", 0, "Jackson" },
                    { new Guid("ab852f0f-402a-4ac1-a224-1d856d85ad9f"), "Seattle", new DateTime(1983, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", 1, "Thomas" },
                    { new Guid("b53ba950-3443-495e-9582-cecf00814035"), "Denver", new DateTime(1993, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", 1, "White" },
                    { new Guid("ba511023-2db1-48a3-9b06-cd95cf0cc0b1"), "Seattle", new DateTime(1994, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zoe", 1, "Thomas" },
                    { new Guid("c8292d8e-86f1-4182-b6b4-fa39d513aa32"), "Houston", new DateTime(1986, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grace", 1, "Taylor" },
                    { new Guid("ced53c45-36c0-429e-98c5-32931c262bba"), "New York", new DateTime(1980, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", 0, "Smith" },
                    { new Guid("d3f44ab1-eb31-41f6-867f-7ec9f659207a"), "San Francisco", new DateTime(1998, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chloe", 1, "Martin" },
                    { new Guid("e8f55c70-ad1d-4191-a3d8-0d044150fca1"), "Miami", new DateTime(1981, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew", 0, "Harris" },
                    { new Guid("faf5dabb-ad59-4167-ae41-f6170e93cf9f"), "Phoenix", new DateTime(1995, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chris", 0, "Anderson" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
