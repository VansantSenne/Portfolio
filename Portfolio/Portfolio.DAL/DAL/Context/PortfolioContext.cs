using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public interface IPortfolioContext
    {
        DbSet<Project> Projects { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Framework> Frameworks { get; set; }

        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken token);

    }
    public class PortfolioContext : DbContext, IPortfolioContext
    {
    
        public PortfolioContext()
        {

            
        }
        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options) 
        { 
        
        
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Framework> Frameworks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
