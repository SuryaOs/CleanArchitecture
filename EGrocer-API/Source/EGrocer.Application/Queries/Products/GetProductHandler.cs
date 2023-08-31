using EGrocer.Core.Entities;
using EGrocer.Core.Repositories.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EGrocer.Application.Queries.Products;

public class GetProductHandler : IRequestHandler<GetProduct, IEnumerable<Product>>
{
    private readonly IProductQueryRepository _productQueryRepository;

    public GetProductHandler(IProductQueryRepository productQueryRepository)
    {
        _productQueryRepository = productQueryRepository ?? throw new ArgumentNullException(nameof(productQueryRepository));
    }

    public async Task<IEnumerable<Product>> Handle(GetProduct request, CancellationToken cancellationToken)
    {
        return await _productQueryRepository.GetAllProductsAsync().ToListAsync();
    }
}
