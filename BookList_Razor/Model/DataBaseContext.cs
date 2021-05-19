using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookList_Razor.Model
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
    }
}
