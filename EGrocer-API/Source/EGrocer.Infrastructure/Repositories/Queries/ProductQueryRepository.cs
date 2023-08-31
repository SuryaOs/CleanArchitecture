using EGrocer.Core.Common.Interface;
using EGrocer.Core.Entities;
using EGrocer.Core.Repositories.Queries;
using Microsoft.EntityFrameworkCore;

namespace EGrocer.Infrastructure.Repositories.Queries;

public class ProductQueryRepository : IProductQueryRepository
{
    private readonly IApplicationDbContext _applicationDbContext;

    public ProductQueryRepository(IApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public IQueryable<Product> GetAllProductsAsync()
    {
        return _applicationDbContext.Products.AsNoTracking();
    }

    //public async Task<IEnumerable<Product>> GetProductsByCategory(int categoryId)
    //{
    //    return await _applicationDbContext.Products.Where(x => x.CategoryId == categoryId).ToListAsync();
    //}
}
