﻿namespace BookApi.Models.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public int PageCount { get; set; }
    }
}