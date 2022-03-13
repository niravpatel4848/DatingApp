using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}