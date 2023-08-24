using Microsoft.AspNetCore.Mvc;

namespace EGrocer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string Method()
        {
            return "Surya";
        }

    }
}
