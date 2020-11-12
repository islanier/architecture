using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infra.Data
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}
