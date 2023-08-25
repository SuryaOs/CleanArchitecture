using EGrocer.Core.Common.Interface;
using EGrocer.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EGrocer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IApplicationDbContext _dbContext;
        public ValuesController(IApplicationDbContext dbContext) { 
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<Product> Method()
        {
            var result = _dbContext.Products.ToList();
            return result;
        }

    }
}
