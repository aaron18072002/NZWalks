using NZWalksAPI.Models.Domain;

namespace NZWalksAPI.Models.DTOs
{
    public class RegionAddRequestDto
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? RegionImageUrl { get; set; }
        public Region ToRegion()
        {
            return new Region()
            {
                Name = this.Name,
                Code = this.Code,
                RegionImageUrl = this.RegionImageUrl,
            };
        }
    }
}
