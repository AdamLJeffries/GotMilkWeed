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
        public async Task<ActionResult<List<MilkweedVariety>>> GetAllAsync()
        {
            var varieties = await _repository.GetAllAsync();
            return Ok(varieties);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MilkweedVariety>> GetByIdAsync(int id)
        {
            var variety = await _repository.GetByIdAsync(id);
            if (variety == null)
            {
                return NotFound();
            }
            return Ok(variety);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync(MilkweedVariety variety)
        {
            await _repository.CreateAsync(variety);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = variety.Id }, variety);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(int id, MilkweedVariety variety)
        {
            if (id != variety.Id)
            {
                return BadRequest();
            }
            await _repository.UpdateAsync(variety);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var variety = await _repository.GetByIdAsync(id);
            if (variety == null)
            {
                return NotFound();
            }
            await _repository.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("region/{region}")]
        public async Task<ActionResult<List<MilkweedVariety>>> GetByRegionAsync(string region)
        {
            var varieties = await _repository.GetAllAsync();
            var filteredVarieties = varieties.Where(v => v.Region.ToLower() == region.ToLower()).ToList();
            return Ok(filteredVarieties);
        }

        [HttpGet("toxic/{isToxic}")]
        public async Task<ActionResult<List<MilkweedVariety>>> GetByToxicityAsync(bool isToxic)
        {
            var varieties = await _repository.GetAllAsync();
            var filteredVarieties = varieties.Where(v => v.IsToxicToMonarchs == isToxic).ToList();
            return Ok(filteredVarieties);
        }

        [HttpGet("region/{region}/toxic/{isToxic}")]
        public async Task<ActionResult<List<MilkweedVariety>>> GetByRegionAndToxicityAsync(string region, bool isToxic)
        {
            var varieties = await _repository.GetAllAsync();
            var filteredVarieties = varieties.Where(v => v.Region.ToLower() == region.ToLower() && v.IsToxicToMonarchs == isToxic).ToList();
            return Ok(filteredVarieties);
        }

        [HttpGet("regions")]
        public ActionResult<Dictionary<string, List<MilkweedVariety>>> GetRegionsAndVarieties()
        {
            var varieties = _repository.GetAllAsync().Result;
            var regions = new Dictionary<string, List<MilkweedVariety>>();
            foreach (var variety in varieties)
            {
                if (!regions.ContainsKey(variety.Region))
                {
                    regions.Add(variety.Region, new List<MilkweedVariety>());
                }
                regions[variety.Region].Add(variety);
            }
            return Ok(regions);
        }
    }

}
