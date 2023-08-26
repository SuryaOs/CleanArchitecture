using EGrocer.Core.Common.Interface;
using EGrocer.Core.Entities;
using EGrocer.Core.Repositories.Queries;
using EGrocer.Infrastructure.Repositories.Queries;
using Microsoft.AspNetCore.Mvc;

namespace EGrocer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IProductQueryRepository _productQueryRepository;
        public ValuesController(IProductQueryRepository productQueryRepository) {
            _productQueryRepository = productQueryRepository;
        }
        [HttpGet]
        public List<Product> Method()
        {
            var result = _productQueryRepository.GetAllProductsAsync();
            return result.ToList();
        }

    }
}
