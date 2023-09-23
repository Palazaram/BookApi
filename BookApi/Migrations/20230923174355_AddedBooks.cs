using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "CreatedAt", "Description", "PageCount", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Гарри Поттер", 1000, "Гарри Поттер" },
                    { 2, new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Властелин колец", 600, "Властелин колец" },
                    { 3, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Тёмные начала", 320, "Тёмные началар" },
                    { 4, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Убить пересмешника", 225, "Убить пересмешника" },
                    { 5, new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Винни Пух", 100, "Винни Пух" },
                    { 6, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "1984", 300, "1984" },
                    { 7, new DateTime(2022, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Джейн Эйр", 400, "Джейн Эйр" },
                    { 8, new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Уловка-22", 400, "Уловка-22" },
                    { 9, new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ребекка", 410, "Ребекка" },
                    { 10, new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ветер в ивах", 440, "Ветер в ивах" },
                    { 11, new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Война и мир", 1100, "Война и мир" },
                    { 12, new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Унесённые ветром", 550, "Унесённые ветром" },
                    { 13, new DateTime(2018, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Эмма", 330, "Эмма" },
                    { 14, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Матильда", 430, "Матильда" },
                    { 15, new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Холодный дом", 530, "Холодный дом" },
                    { 16, new DateTime(2018, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Автостопом по галактике", 730, "Автостопом по галактике" },
                    { 17, new DateTime(2002, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Дюна", 445, "Дюна" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
