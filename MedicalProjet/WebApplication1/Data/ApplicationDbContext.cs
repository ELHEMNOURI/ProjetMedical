using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Projet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
       
        public DbSet<Medecin> Medecins { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Admin> Admin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          optionsBuilder
                .UseMySql("server=localhost;port=3306;user=root;password=;database=MedicalDb");
              
         }

       
    }
}
