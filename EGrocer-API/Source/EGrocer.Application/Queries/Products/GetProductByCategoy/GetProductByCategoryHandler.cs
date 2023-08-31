using EGrocer.Core.Entities;
using EGrocer.Core.Repositories.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EGrocer.Application.Queries.Products.GetProductByCategoy;

public class GetProductByCategoryHandler : IRequestHandler<GetProductByCategory, IEnumerable<Product>>
{
    private readonly IProductQueryRepository _productQueryRepository;

    public GetProductByCategoryHandler(IProductQueryRepository productQueryRepository)
    {
        _productQueryRepository = productQueryRepository;
    }

    public async Task<IEnumerable<Product>> Handle(GetProductByCategory request, CancellationToken cancellationToken)
    {
        return await _productQueryRepository.GetAllProductsAsync()
                                            .Where(x => x.CategoryId == request.id)
                                            .ToListAsync();
    }
}
