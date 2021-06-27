using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace LongtextIssue
{
    public class MyDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionsBuilder.UseMySql("Server=localhost; port=3306; Database=test_database;",
                opt => opt.CharSetBehavior(CharSetBehavior.NeverAppend));

            return new MyDbContext(optionsBuilder.Options);
        }
    }
}
