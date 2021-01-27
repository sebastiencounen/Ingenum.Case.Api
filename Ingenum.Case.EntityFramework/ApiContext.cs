﻿namespace Ingenum.Case.EntityFramework
{
    using Ingenum.Case.Model.Database;

    using Microsoft.EntityFrameworkCore;

    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public DbSet<Table> Tables { get; set; }

        public DbSet<TodoTask> Tasks { get; set; }
    }
}