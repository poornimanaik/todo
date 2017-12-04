using System;

using Microsoft.EntityFrameworkCore;

namespace ToDo.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }

    }
}
