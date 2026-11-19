using Diplom.Models;
using Diplom.Services;
using System.Collections.Generic;

namespace Diplom.Models
{
    public static class DataStore
    {
        public static List<HotelRoom> Rooms { get; set; } = new List<HotelRoom>();

        public static List<Booking> Bookings { get; set; } = new List<Booking>();

        public static int NextRoomId { get; set; } = 1;

        public static int NextBookingId { get; set; } = 1;

        public static double LastLambda { get; set; } = 45;
        public static double LastMu { get; set; } = 0.5;
        public static int LastC { get; set; } = 100;
        public static User CurrentUser { get; set; }

        public static void InitTestData()
        {
            if (Rooms.Count == 0)
            {
                Rooms.Add(new HotelRoom
                {
                    RoomId = NextRoomId++,
                    RoomNumber = "101",
                    Category = "Стандарт",
                    BasePricePerNight = 3000,
                    Capacity = 2,
                    Status = "свободен",
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                });

                Rooms.Add(new HotelRoom
                {
                    RoomId = NextRoomId++,
                    RoomNumber = "102",
                    Category = "Стандарт",
                    BasePricePerNight = 3000,
                    Capacity = 2,
                    Status = "свободен",
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                });

                Rooms.Add(new HotelRoom
                {
                    RoomId = NextRoomId++,
                    RoomNumber = "201",
                    Category = "Люкс",
                    BasePricePerNight = 8000,
                    Capacity = 4,
                    Status = "свободен",
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                });
            }
        }

        public static void LoadFromDatabase()
        {
            var db = new DatabaseService();
            if (db.TestConnection())
            {
                db.LoadAllDataToStore();
            }
        }
    }
}