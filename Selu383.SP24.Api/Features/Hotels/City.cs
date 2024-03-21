﻿namespace Selu383.SP24.Api.Features.Hotels
{
    public class City
    {
        public int Id { get; set; }
        public string? Location { get; set; }
        public virtual ICollection<Hotel>? Hotel { get; set; }
    }
}
