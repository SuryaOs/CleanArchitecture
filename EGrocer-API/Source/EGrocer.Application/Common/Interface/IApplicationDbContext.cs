using EGrocer.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EGrocer.Core.Common.Interface;

public interface IApplicationDbContext
{
    DbSet<Category> Categories { get; }

    DbSet<Product> Products { get; }

    int SaveChanges();

}
