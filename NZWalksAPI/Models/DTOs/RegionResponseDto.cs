﻿namespace NZWalksAPI.Models.DTOs
{
    public class RegionResponseDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
