using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserService.Database.Entities;

namespace UserService.Database
{
    public class DataContext:DbContext
    {
      

        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-428R2CP\SQLEXPRESS;initial catalog=
            UserMicroService;persist security info=true;Integrated Security=True;");
        }
    }
}