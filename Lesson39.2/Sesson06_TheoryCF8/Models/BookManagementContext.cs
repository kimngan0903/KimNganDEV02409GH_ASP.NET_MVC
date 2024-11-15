﻿using Microsoft.EntityFrameworkCore;
using Sesson06_TheoryCF8.Models;

namespace Sesson06.TheoryCF8.Models
{
    public class BookManagementContext : DbContext
    {
        public BookManagementContext(DbContextOptions<BookManagementContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}