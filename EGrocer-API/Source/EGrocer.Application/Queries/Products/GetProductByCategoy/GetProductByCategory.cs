using EGrocer.Core.Entities;
using MediatR;

namespace EGrocer.Application.Queries.Products.GetProductByCategoy;

public class GetProductByCategory : IRequest<IEnumerable<Product>>
{
    public int id { get; private set; }

    public GetProductByCategory(int id)
    {
        this.id = id;
    }
}