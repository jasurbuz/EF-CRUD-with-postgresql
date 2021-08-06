using ConsoleApp21.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21.DataLayer
{
    class DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Constants.ConnectionString);
        }
        public DbSet<Student> Students { get; set; }
    }
}
