using backend2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend2.Context
{
    public class AlbumDBContext : DbContext
    {
        public AlbumDBContext(DbContextOptions options) : base(options)
        {

        }

        public AlbumDBContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().ToTable("Albums");
            modelBuilder.Entity<Album>().HasKey(pk => pk.Id);
        }

        public DbSet<backend2.Models.Album> Album { get; set; }
    }
}
