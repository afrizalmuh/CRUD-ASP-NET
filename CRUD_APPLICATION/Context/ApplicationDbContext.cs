using CRUD_APPLICATION.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CRUD_APPLICATION.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
            
        }

        public DbSet<Person> Persons { get; set; }
    }
}
