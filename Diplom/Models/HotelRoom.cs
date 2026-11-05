using System;

namespace Diplom.Models
{
    public class HotelRoom
    {
        public int RoomId { get; set; }
        public string Category { get; set; } = string.Empty;
        public string RoomNumber { get; set; } = string.Empty;
        public decimal BasePricePerNight { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; } = "available";
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}