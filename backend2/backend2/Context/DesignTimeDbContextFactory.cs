using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend2.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AlbumDBContext>
    {
        public AlbumDBContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AlbumDBContext>();
            var connectionString = @"Data Source=album.db";
            builder.UseSqlite(connectionString);
            return new AlbumDBContext(builder.Options);
        }
    }
}
