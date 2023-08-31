using EGrocer.Core.Entities;
using MediatR;

namespace EGrocer.Application.Queries.Products;

public class GetProduct : IRequest<IEnumerable<Product>>
{
}
