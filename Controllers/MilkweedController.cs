using Microsoft.AspNetCore.Mvc;

namespace GotMilkWeed.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MilkweedController : ControllerBase
    {
        private readonly IMilkweedRepository _repository;

        public MilkweedController(IMilkweedRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<IMilkweedRepository>>>
            {
                
            }
    }
}
