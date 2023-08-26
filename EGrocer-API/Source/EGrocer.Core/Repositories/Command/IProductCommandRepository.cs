using EGrocer.Core.Entities;

namespace EGrocer.Core.Repositories.Command;

public interface IProductCommandRepository
{
    Task<bool> UpdateProducts(IEnumerable<Product> products);
    Task<Product> AddProduct(Product product);
    Task<bool> DeleteProduct(int productId);

}
