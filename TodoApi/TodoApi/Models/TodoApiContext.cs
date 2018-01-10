using System;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoApiContext : DbContext
    {
        public TodoApiContext(DbContextOptions<TodoApiContext> options)
            : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
