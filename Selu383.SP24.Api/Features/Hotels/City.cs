﻿namespace Selu383.SP24.Api.Features.Hotels
{
    public class City
    {
        public int Id { get; set; }
        public required string Location { get; set; }
        public ICollection<Hotel>? Hotel { get; set; }
    }
}
