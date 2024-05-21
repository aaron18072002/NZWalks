using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NZWalksAPI.Data;
using NZWalksAPI.Models.DTOs;

namespace NZWalksAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegionsController : Controller
    {
        private readonly NZWalksDBContext _dbContext;
        public RegionsController(NZWalksDBContext dBContext)
        {
            this._dbContext = dBContext;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAll()
        {
            var regions = await this._dbContext.Regions.ToListAsync();
            if (regions.Count == 0)
            {
                return NotFound();
            }
            var response = new List<RegionResponseDto>();
            foreach (var region in regions)
            {
                response.Add(region.ToRegionResponseDto());
            }          
            return Ok(regions);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetById
            ([FromRoute] Guid id)
        {
            var region = await this._dbContext.Regions
                .FirstOrDefaultAsync(r => r.Id == id);
            if (region == null)
            {
                return NotFound();
            }
            var response = region.ToRegionResponseDto();
            return Ok(region);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Create
            ([FromForm] RegionAddRequestDto regionAddRequest)
        {

        }
    }
}
