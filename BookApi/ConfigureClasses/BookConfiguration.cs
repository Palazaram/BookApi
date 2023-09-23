using BookApi.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApi.ConfigureClasses
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Title).IsRequired().HasColumnType("NVARCHAR(100)");
            builder.Property(b => b.CreatedAt).IsRequired().HasColumnType("DATE");
            builder.Property(b => b.Description).IsRequired().HasColumnType("NVARCHAR(450)");
            builder.Property(b => b.PageCount).IsRequired().HasColumnType("INT");

            builder.HasData(
                new Book 
                {
                    Id = 1,
                    Title = "Гарри Поттер",
                    CreatedAt = new DateTime(2023, 9, 12),
                    Description = "Гарри Поттер",
                    PageCount = 1000,
                },
                new Book
                {
                    Id = 2,
                    Title = "Властелин колец",
                    CreatedAt = new DateTime(2023, 3, 21),
                    Description = "Властелин колец",
                    PageCount = 600,
                },
                new Book
                {
                    Id = 3,
                    Title = "Тёмные началар",
                    CreatedAt = new DateTime(2023, 6, 17),
                    Description = "Тёмные начала",
                    PageCount = 320,
                },
                new Book
                {
                    Id = 4,
                    Title = "Убить пересмешника",
                    CreatedAt = new DateTime(2023, 1, 31),
                    Description = "Убить пересмешника",
                    PageCount = 225,
                },
                new Book
                {
                    Id = 5,
                    Title = "Винни Пух",
                    CreatedAt = new DateTime(2022, 1, 31),
                    Description = "Винни Пух",
                    PageCount = 100,
                },
                new Book
                {
                    Id = 6,
                    Title = "1984",
                    CreatedAt = new DateTime(2022, 2, 10),
                    Description = "1984",
                    PageCount = 300,
                },
                new Book
                {
                    Id = 7,
                    Title = "Джейн Эйр",
                    CreatedAt = new DateTime(2022, 3, 11),
                    Description = "Джейн Эйр",
                    PageCount = 400,
                },
                new Book
                {
                    Id = 8,
                    Title = "Уловка-22",
                    CreatedAt = new DateTime(2022, 5, 13),
                    Description = "Уловка-22",
                    PageCount = 400,
                },
                new Book
                {
                    Id = 9,
                    Title = "Ребекка",
                    CreatedAt = new DateTime(2021, 8, 13),
                    Description = "Ребекка",
                    PageCount = 410,
                },
                new Book
                {
                    Id = 10,
                    Title = "Ветер в ивах",
                    CreatedAt = new DateTime(2021, 11, 20),
                    Description = "Ветер в ивах",
                    PageCount = 440,
                },
                new Book
                {
                    Id = 11,
                    Title = "Война и мир",
                    CreatedAt = new DateTime(2021, 12, 25),
                    Description = "Война и мир",
                    PageCount = 1100,
                },
                new Book
                {
                    Id = 12,
                    Title = "Унесённые ветром",
                    CreatedAt = new DateTime(2021, 12, 25),
                    Description = "Унесённые ветром",
                    PageCount = 550,
                },
                new Book
                {
                    Id = 13,
                    Title = "Эмма",
                    CreatedAt = new DateTime(2018, 8, 14),
                    Description = "Эмма",
                    PageCount = 330,
                },
                new Book
                {
                    Id = 14,
                    Title = "Матильда",
                    CreatedAt = new DateTime(2023, 9, 23),
                    Description = "Матильда",
                    PageCount = 430,
                },
                new Book
                {
                    Id = 15,
                    Title = "Холодный дом",
                    CreatedAt = new DateTime(2023, 9, 21),
                    Description = "Холодный дом",
                    PageCount = 530,
                },
                new Book
                {
                    Id = 16,
                    Title = "Автостопом по галактике",
                    CreatedAt = new DateTime(2018, 1, 15),
                    Description = "Автостопом по галактике",
                    PageCount = 730,
                },
                new Book
                {
                    Id = 17,
                    Title = "Дюна",
                    CreatedAt = new DateTime(2002, 1, 31),
                    Description = "Дюна",
                    PageCount = 445,
                }
            );
        }
    }
}
