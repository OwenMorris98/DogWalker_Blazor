using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DogWalker.Application.Data;
using DogWalker.Domain.Dogs;
using DogWalker.Domain.Customers;

namespace DogWalker_Blazor.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options), IApplicationDbContext
        
    {

        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        public int Save()
        {
            return base.SaveChanges();
        }
    }
}
