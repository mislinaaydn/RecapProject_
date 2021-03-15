using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Concrete.EntityFramework
{
    public class CarDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =(localdb)\mssqllocaldb;Database=CarData;Trusted_Connection=true");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<User> Users { get; set; }// buranin tamami senin veritabani tablolarinla ayni olmali
        public DbSet<Customer> Customers { get; set; }// yani bu data contexi hepsinde kullanabiliriz
        public DbSet<Rental> Rentals { get; set; }//car data context yerine projecontext yazsan kafan karismazdi
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OperationClaim> OperationClaims{get ; set;}
    }
}
