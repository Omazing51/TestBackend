﻿namespace TestBackend.MODEL.Entities
{
    public class Location
    {
        public int locationId {  get; set; }
        public int cityId { get; set; }
        public string? postalCode { get; set; }
        public string locationDescription { get; set; } 

    }
}