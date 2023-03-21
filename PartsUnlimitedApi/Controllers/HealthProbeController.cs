using Microsoft.AspNetCore.Mvc;
using PartsUnlimitedApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PartsUnlimitedApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthProbeController : ControllerBase
    {

        private readonly PartsUnlimitedContext _context;

        public HealthProbeController(PartsUnlimitedContext context)
        {
            _context = context;
        }

        // GET: api/<HealthProbeController>
        [HttpGet]
        public HealthProbeModel Get()
        {
            try
            {
                var p = _context.Products.FirstOrDefault();
                return new HealthProbeModel(true);
            }
            catch (Exception ex)
            {
                return new HealthProbeModel(false);
            }
        }
    }
}
