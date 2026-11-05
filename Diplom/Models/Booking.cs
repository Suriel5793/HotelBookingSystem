using System;

namespace Diplom.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int GuestCount { get; set; }
        public decimal TotalPrice { get; set; }
        public string BookingSource { get; set; } = string.Empty;
        public string Status { get; set; } = "confirmed";
        public string CustomerEmail { get; set; } = string.Empty;
        public string CustomerPhone { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}