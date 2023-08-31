using EGrocer.Application.Queries.Products;
using EGrocer.Application.Queries.Products.GetProductByCategoy;
using EGrocer.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EGrocer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ValuesController(IMediator mediator) {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _mediator.Send(new GetProduct());
        }
        [HttpGet("categoryId")]
        public async Task<IEnumerable<Product>> GetProducts(int categoryId)
        {
            return await _mediator.Send(new GetProductByCategory(categoryId));
        }


    }
}
