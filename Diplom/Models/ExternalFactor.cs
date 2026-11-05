using System;

namespace Diplom.Models
{
    public class ExternalFactor
    {
        public int FactorId { get; set; }
        public string Type { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Value { get; set; } = string.Empty;
        public decimal ImpactCoefficient { get; set; } = 1.000m;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}