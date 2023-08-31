using EGrocer.Core.Entities;

namespace EGrocer.Core.Repositories.Queries;

public interface IProductQueryRepository
{
    IQueryable<Product> GetAllProductsAsync();
}
