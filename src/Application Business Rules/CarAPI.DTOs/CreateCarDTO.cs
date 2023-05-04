﻿namespace CarAPI.DTOs
{
    public class CreateCarDTO
    {
        public string Make { get; init; }
        public string Model { get; init; }
        public int Year { get; init; }
        public string Color { get; init; }
        public decimal Price { get; init; }

    }
}
