﻿using NZWalksAPI.Models.DTOs;

namespace NZWalksAPI.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? RegionImageUrl { get; set; }
        public RegionResponseDto ToRegionResponseDto()
        {
            return new RegionResponseDto()
            {
                Id = this.Id,
                Name = this.Name,
                Code = this.Code,
                RegionImageUrl = this.RegionImageUrl,
            };
        }
    }
}
