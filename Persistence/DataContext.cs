﻿using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {}

        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>().HasData(
                new Value { Id = 6, Name = "Value 101" },
                new Value { Id = 7, Name = "Value 102" },
                new Value { Id = 8, Name = "Value 103" },
                new Value { Id = 9, Name = "Value 104" },
                new Value { Id = 10, Name = "Value 105" }
            );
        }
    }
}
