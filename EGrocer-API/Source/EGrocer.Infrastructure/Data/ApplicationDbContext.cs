using EGrocer.Core.Common.Interface;
using EGrocer.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EGrocer.Infrastructure.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

}
