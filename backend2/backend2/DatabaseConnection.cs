using backend2.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend2
{
    public class DatabaseConnection
    {
        public static AlbumDBContext Db()
        {
            var services = new ServiceCollection();
            services.AddDbContext<AlbumDBContext>(factory =>
            {
                var connectionString = @"Data Source=album.db";
                factory.UseSqlite(connectionString);
            });

            var provider = services.BuildServiceProvider();
            var db = provider.GetService<AlbumDBContext>();
            return db;

        }
    }
}
