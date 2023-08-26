using EGrocer.Core.Entities;

namespace EGrocer.Core.Repositories.Queries;

public interface IProductQueryRepository
{
    IQueryable<Product> GetAllProductsAsync();
    //Task<IEnumerable<Product>> GetAllProductsAsync();
    //Task<IEnumerable<Product>> GetProductsByCategory(int categoryId);
}
