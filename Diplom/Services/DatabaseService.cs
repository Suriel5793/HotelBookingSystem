using System;
using System.Collections.Generic;
using System.Linq;
using Npgsql;
using Diplom.Models;

namespace Diplom.Services
{
    public class DatabaseService
    {
        private string _host = "localhost";
        private int _port = 5432;
        private string _username = "postgres";
        private string _password = "nixneris5";
        private string _databaseName = "HotelDB";

        private string MasterConnectionString => $"Host={_host};Port={_port};Username={_username};Password={_password};Database=postgres";
        private string DbConnectionString => $"Host={_host};Port={_port};Username={_username};Password={_password};Database={_databaseName}";


        public bool DatabaseExists()
        {
            try
            {
                using (var conn = new NpgsqlConnection(MasterConnectionString))
                {
                    conn.Open();
                    string sql = "SELECT 1 FROM pg_database WHERE datname = @dbname";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@dbname", _databaseName);
                        return cmd.ExecuteScalar() != null;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public void CreateDatabase()
        {
            using (var conn = new NpgsqlConnection(MasterConnectionString))
            {
                conn.Open();
                string sql = $"CREATE DATABASE {_databaseName}";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool TablesExist()
        {
            try
            {
                using (var conn = new NpgsqlConnection(DbConnectionString))
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = 'public' AND table_name = 'hotel_rooms'";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        return (long)cmd.ExecuteScalar() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public void CreateTables()
        {
            string sql = @"
CREATE TABLE IF NOT EXISTS Hotel_Rooms (
    room_id SERIAL PRIMARY KEY,
    category VARCHAR(50) NOT NULL,
    room_number VARCHAR(10) UNIQUE NOT NULL,
    base_price_per_night DECIMAL(10, 2) NOT NULL CHECK (base_price_per_night >= 0),
    capacity INTEGER NOT NULL CHECK (capacity > 0 AND capacity <= 10),
    status VARCHAR(20) DEFAULT 'свободен' CHECK (status IN ('свободен', 'занят', 'ремонт', 'забронирован')),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS Bookings (
    booking_id SERIAL PRIMARY KEY,
    room_id INTEGER NOT NULL,
    check_in_date DATE NOT NULL,
    check_out_date DATE NOT NULL,
    guest_count INTEGER NOT NULL CHECK (guest_count > 0),
    total_price DECIMAL(10, 2) NOT NULL CHECK (total_price >= 0),
    booking_source VARCHAR(50) NOT NULL CHECK (booking_source IN ('Яндекс.Путешествия', 'Туту.ру', 'Прямой звонок', 'Сайт отеля', 'Booking.com', 'Другое')),
    status VARCHAR(20) DEFAULT 'подтверждено' CHECK (status IN ('подтверждено', 'отменено', 'завершено', 'не заехал')),
    customer_email VARCHAR(255),
    customer_phone VARCHAR(20),
    notes TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    
    CONSTRAINT valid_dates CHECK (check_out_date > check_in_date),
    CONSTRAINT fk_room FOREIGN KEY (room_id) REFERENCES Hotel_Rooms(room_id) ON DELETE RESTRICT
);

CREATE TABLE IF NOT EXISTS External_Factors (
    factor_id SERIAL PRIMARY KEY,
    type VARCHAR(50) NOT NULL,
    date DATE NOT NULL,
    value VARCHAR(500) NOT NULL,
    impact_coefficient DECIMAL(5, 3) DEFAULT 1.000,
    description TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS Users (
    user_id SERIAL PRIMARY KEY,
    login VARCHAR(50) UNIQUE NOT NULL,
    password_hash VARCHAR(255) NOT NULL,
    role VARCHAR(20) NOT NULL CHECK (role IN ('admin', 'manager')),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO Users (login, password_hash, role) 
VALUES ('admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 'admin')
ON CONFLICT (login) DO NOTHING;

CREATE INDEX IF NOT EXISTS idx_rooms_category ON Hotel_Rooms(category);
CREATE INDEX IF NOT EXISTS idx_rooms_status ON Hotel_Rooms(status);
CREATE INDEX IF NOT EXISTS idx_bookings_room_id ON Bookings(room_id);
CREATE INDEX IF NOT EXISTS idx_bookings_dates ON Bookings(check_in_date, check_out_date);
CREATE INDEX IF NOT EXISTS idx_bookings_status ON Bookings(status);
CREATE INDEX IF NOT EXISTS idx_factors_date ON External_Factors(date);
CREATE INDEX IF NOT EXISTS idx_factors_type ON External_Factors(type);

CREATE OR REPLACE FUNCTION update_updated_at_column()
RETURNS TRIGGER AS $$
BEGIN
    NEW.updated_at = CURRENT_TIMESTAMP;
    RETURN NEW;
END;
$$ language 'plpgsql';

DROP TRIGGER IF EXISTS update_hotel_rooms_updated_at ON Hotel_Rooms;
CREATE TRIGGER update_hotel_rooms_updated_at 
    BEFORE UPDATE ON Hotel_Rooms
    FOR EACH ROW
    EXECUTE FUNCTION update_updated_at_column();

DROP TRIGGER IF EXISTS update_bookings_updated_at ON Bookings;
CREATE TRIGGER update_bookings_updated_at 
    BEFORE UPDATE ON Bookings
    FOR EACH ROW
    EXECUTE FUNCTION update_updated_at_column();
";

            using (var conn = new NpgsqlConnection(DbConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void InitializeDatabase()
        {
            if (!DatabaseExists())
            {
                CreateDatabase();
                System.Threading.Thread.Sleep(500);
            }
            CreateTables();
        }

        public bool TestConnection()
        {
            try
            {
                using (var conn = new NpgsqlConnection(DbConnectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public List<HotelRoom> GetAllRooms()
        {
            var rooms = new List<HotelRoom>();
            string sql = "SELECT room_id, category, room_number, base_price_per_night, capacity, status, created_at, updated_at FROM Hotel_Rooms";

            using (var conn = new NpgsqlConnection(DbConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rooms.Add(new HotelRoom
                        {
                            RoomId = reader.GetInt32(0),
                            Category = reader.GetString(1),
                            RoomNumber = reader.GetString(2),
                            BasePricePerNight = reader.GetDecimal(3),
                            Capacity = reader.GetInt32(4),
                            Status = reader.GetString(5),
                            CreatedAt = reader.GetDateTime(6),
                            UpdatedAt = reader.GetDateTime(7)
                        });
                    }
                }
            }
            return rooms;
        }

        public HotelRoom GetRoomById(int roomId)
        {
            string sql = "SELECT room_id, category, room_number, base_price_per_night, capacity, status, created_at, updated_at FROM Hotel_Rooms WHERE room_id = @id";

            using (var conn = new NpgsqlConnection(DbConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", roomId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new HotelRoom
                            {
                                RoomId = reader.GetInt32(0),
                                Category = reader.GetString(1),
                                RoomNumber = reader.GetString(2),
                                BasePricePerNight = reader.GetDecimal(3),
                                Capacity = reader.GetInt32(4),
                                Status = reader.GetString(5),
                                CreatedAt = reader.GetDateTime(6),
                                UpdatedAt = reader.GetDateTime(7)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public int AddRoomAndGetId(HotelRoom room)
        {
            string sql = @"INSERT INTO Hotel_Rooms (category, room_number, base_price_per_night, capacity, status, created_at, updated_at) 
                           VALUES (@category, @room_number, @price, @capacity, @status, @created_at, @updated_at)
                           RETURNING room_id";

            using (var conn = new NpgsqlConnection(DbConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@category", room.Category);
                    cmd.Parameters.AddWithValue("@room_number", room.RoomNumber);
                    cmd.Parameters.AddWithValue("@price", room.BasePricePerNight);
                    cmd.Parameters.AddWithValue("@capacity", room.Capacity);
                    cmd.Parameters.AddWithValue("@status", room.Status);
                    cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                    cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public void UpdateRoom(HotelRoom room)
        {
            string sql = @"UPDATE Hotel_Rooms SET 
                           category = @category,
                           room_number = @room_number,
                           base_price_per_night = @price,
                           capacity = @capacity,
                           status = @status,
                           updated_at = @updated_at
                           WHERE room_id = @room_id";

            using (var conn = new NpgsqlConnection(DbConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@room_id", room.RoomId);
                    cmd.Parameters.AddWithValue("@category", room.Category);
                    cmd.Parameters.AddWithValue("@room_number", room.RoomNumber);
                    cmd.Parameters.AddWithValue("@price", room.BasePricePerNight);
                    cmd.Parameters.AddWithValue("@capacity", room.Capacity);
                    cmd.Parameters.AddWithValue("@status", room.Status);
                    cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRoom(int roomId)
        {
            string sql = "DELETE FROM Hotel_Rooms WHERE room_id = @room_id";

            using (var conn = new NpgsqlConnection(DbConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@room_id", roomId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Booking> GetAllBookings()
        {
            var bookings = new List<Booking>();
            string sql = "SELECT booking_id, room_id, check_in_date, check_out_date, guest_count, total_price, booking_source, status, customer_email, customer_phone, notes FROM Bookings";

            using (var conn = new NpgsqlConnection(DbConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookings.Add(new Booking
                        {
                            BookingId = reader.GetInt32(0),
                            RoomId = reader.GetInt32(1),
                            CheckInDate = reader.GetDateTime(2),
                            CheckOutDate = reader.GetDateTime(3),
                            GuestCount = reader.GetInt32(4),
                            TotalPrice = reader.GetDecimal(5),
                            BookingSource = reader.GetString(6),
                            Status = reader.GetString(7),
                            CustomerEmail = reader.IsDBNull(8) ? "" : reader.GetString(8),
                            CustomerPhone = reader.IsDBNull(9) ? "" : reader.GetString(9),
                            Notes = reader.IsDBNull(10) ? "" : reader.GetString(10)
                        });
                    }
                }
            }
            return bookings;
        }

        public int AddBookingAndGetId(Booking booking)
        {
            var room = GetRoomById(booking.RoomId);
            if (room == null)
                throw new Exception("Номер не найден");
            if (booking.GuestCount > room.Capacity)
                throw new Exception($"Номер {room.RoomNumber} вмещает только {room.Capacity} гостей");

            string sql = @"INSERT INTO Bookings (room_id, check_in_date, check_out_date, guest_count, total_price, booking_source, status, customer_email, customer_phone, notes) 
                           VALUES (@room_id, @check_in, @check_out, @guest_count, @total_price, @source, @status, @email, @phone, @notes)
                           RETURNING booking_id";

            using (var conn = new NpgsqlConnection(DbConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@room_id", booking.RoomId);
                    cmd.Parameters.AddWithValue("@check_in", booking.CheckInDate);
                    cmd.Parameters.AddWithValue("@check_out", booking.CheckOutDate);
                    cmd.Parameters.AddWithValue("@guest_count", booking.GuestCount);
                    cmd.Parameters.AddWithValue("@total_price", booking.TotalPrice);
                    cmd.Parameters.AddWithValue("@source", booking.BookingSource);
                    cmd.Parameters.AddWithValue("@status", booking.Status);
                    cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(booking.CustomerEmail) ? (object)DBNull.Value : booking.CustomerEmail);
                    cmd.Parameters.AddWithValue("@phone", string.IsNullOrEmpty(booking.CustomerPhone) ? (object)DBNull.Value : booking.CustomerPhone);
                    cmd.Parameters.AddWithValue("@notes", string.IsNullOrEmpty(booking.Notes) ? (object)DBNull.Value : booking.Notes);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public void UpdateBooking(Booking booking)
        {
            var room = GetRoomById(booking.RoomId);
            if (room == null)
                throw new Exception("Номер не найден");
            if (booking.GuestCount > room.Capacity)
                throw new Exception($"Номер {room.RoomNumber} вмещает только {room.Capacity} гостей");

            string sql = @"UPDATE Bookings SET 
                           room_id = @room_id,
                           check_in_date = @check_in,
                           check_out_date = @check_out,
                           guest_count = @guest_count,
                           total_price = @total_price,
                           booking_source = @source,
                           status = @status,
                           customer_email = @email,
                           customer_phone = @phone,
                           notes = @notes
                           WHERE booking_id = @booking_id";

            using (var conn = new NpgsqlConnection(DbConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@booking_id", booking.BookingId);
                    cmd.Parameters.AddWithValue("@room_id", booking.RoomId);
                    cmd.Parameters.AddWithValue("@check_in", booking.CheckInDate);
                    cmd.Parameters.AddWithValue("@check_out", booking.CheckOutDate);
                    cmd.Parameters.AddWithValue("@guest_count", booking.GuestCount);
                    cmd.Parameters.AddWithValue("@total_price", booking.TotalPrice);
                    cmd.Parameters.AddWithValue("@source", booking.BookingSource);
                    cmd.Parameters.AddWithValue("@status", booking.Status);
                    cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(booking.CustomerEmail) ? (object)DBNull.Value : booking.CustomerEmail);
                    cmd.Parameters.AddWithValue("@phone", string.IsNullOrEmpty(booking.CustomerPhone) ? (object)DBNull.Value : booking.CustomerPhone);
                    cmd.Parameters.AddWithValue("@notes", string.IsNullOrEmpty(booking.Notes) ? (object)DBNull.Value : booking.Notes);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteBooking(int bookingId)
        {
            string sql = "DELETE FROM Bookings WHERE booking_id = @booking_id";

            using (var conn = new NpgsqlConnection(DbConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@booking_id", bookingId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ExternalFactor> GetAllFactors()
        {
            var factors = new List<ExternalFactor>();
            string sql = "SELECT factor_id, type, date, value, impact_coefficient, description FROM External_Factors ORDER BY date DESC";

            using (var conn = new NpgsqlConnection(DbConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        factors.Add(new ExternalFactor
                        {
                            FactorId = reader.GetInt32(0),
                            Type = reader.GetString(1),
                            Date = reader.GetDateTime(2),
                            Value = reader.GetString(3),
                            ImpactCoefficient = reader.GetDecimal(4),
                            Description = reader.IsDBNull(5) ? "" : reader.GetString(5)
                        });
                    }
                }
            }
            return factors;
        }

        public void AddFactor(ExternalFactor factor)
        {
            string sql = @"INSERT INTO External_Factors (type, date, value, impact_coefficient, description) 
                           VALUES (@type, @date, @value, @impact, @desc)";

            using (var conn = new NpgsqlConnection(DbConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@type", factor.Type);
                    cmd.Parameters.AddWithValue("@date", factor.Date);
                    cmd.Parameters.AddWithValue("@value", factor.Value);
                    cmd.Parameters.AddWithValue("@impact", factor.ImpactCoefficient);
                    cmd.Parameters.AddWithValue("@desc", string.IsNullOrEmpty(factor.Description) ? DBNull.Value : (object)factor.Description);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateFactor(ExternalFactor factor)
        {
            string sql = @"UPDATE External_Factors SET 
                           type = @type, date = @date, value = @value, 
                           impact_coefficient = @impact, description = @desc
                           WHERE factor_id = @id";

            using (var conn = new NpgsqlConnection(DbConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", factor.FactorId);
                    cmd.Parameters.AddWithValue("@type", factor.Type);
                    cmd.Parameters.AddWithValue("@date", factor.Date);
                    cmd.Parameters.AddWithValue("@value", factor.Value);
                    cmd.Parameters.AddWithValue("@impact", factor.ImpactCoefficient);
                    cmd.Parameters.AddWithValue("@desc", string.IsNullOrEmpty(factor.Description) ? DBNull.Value : (object)factor.Description);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteFactor(int factorId)
        {
            string sql = "DELETE FROM External_Factors WHERE factor_id = @id";

            using (var conn = new NpgsqlConnection(DbConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", factorId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public double CalculateRealLambda(DateTime startDate, DateTime endDate)
        {
            try
            {
                string sql = @"
                    SELECT COUNT(*) * 1.0 / (EXTRACT(DAY FROM ($2 - $1)) + 1)
                    FROM Bookings 
                    WHERE created_at BETWEEN @start AND @end
                    AND status != 'отменено'";

                using (var conn = new NpgsqlConnection(DbConnectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@start", startDate);
                        cmd.Parameters.AddWithValue("@end", endDate);
                        var result = cmd.ExecuteScalar();
                        if (result == DBNull.Value) return DataStore.LastLambda;
                        double val = Convert.ToDouble(result);
                        return val > 0 ? val : DataStore.LastLambda;
                    }
                }
            }
            catch
            {
                return DataStore.LastLambda;
            }
        }

        public double CalculateRealMu()
        {
            try
            {
                string sql = @"
                    SELECT AVG(EXTRACT(DAY FROM (check_out_date - check_in_date)))
                    FROM Bookings 
                    WHERE status = 'завершено' OR status = 'подтверждено'";

                using (var conn = new NpgsqlConnection(DbConnectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        var result = cmd.ExecuteScalar();
                        if (result == DBNull.Value) return DataStore.LastMu;
                        double avgDays = Convert.ToDouble(result);
                        if (avgDays <= 0) return DataStore.LastMu;
                        double mu = 1.0 / avgDays;
                        return mu > 0 ? mu : DataStore.LastMu;
                    }
                }
            }
            catch
            {
                return DataStore.LastMu;
            }
        }

        public int GetRealRoomCount()
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM Hotel_Rooms WHERE status != 'ремонт'";

                using (var conn = new NpgsqlConnection(DbConnectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0 ? count : DataStore.LastC;
                    }
                }
            }
            catch
            {
                return DataStore.LastC;
            }
        }

        public double GetRealOccupancyRate(DateTime date)
        {
            try
            {
                string sql = @"
                    SELECT COUNT(DISTINCT b.room_id) * 100.0 / NULLIF((SELECT COUNT(*) FROM Hotel_Rooms WHERE status != 'ремонт'), 0)
                    FROM Bookings b
                    WHERE @date BETWEEN b.check_in_date AND b.check_out_date
                    AND b.status != 'отменено'";

                using (var conn = new NpgsqlConnection(DbConnectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", date);
                        var result = cmd.ExecuteScalar();
                        return result == DBNull.Value ? 0 : Convert.ToDouble(result);
                    }
                }
            }
            catch
            {
                return 0;
            }
        }

        public double GetFactorsImpact(DateTime date)
        {
            string sql = @"
        SELECT COALESCE(SUM(impact_coefficient - 1), 0)
        FROM External_Factors 
        WHERE date <= @date AND date >= @date - INTERVAL '7 days'";

            using (var conn = new NpgsqlConnection(DbConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@date", date);
                    var result = cmd.ExecuteScalar();
                    double sum = result == DBNull.Value ? 0 : Convert.ToDouble(result);
                    return 1.0 + sum; // базовый коэффициент 1 + сумма отклонений
                }
            }
        }

        public List<ExternalFactor> GetActiveFactors(DateTime date)
        {
            var factors = new List<ExternalFactor>();
            string sql = @"
        SELECT factor_id, type, date, value, impact_coefficient, description
        FROM External_Factors 
        WHERE date <= @date AND date >= @date - INTERVAL '7 days'
        ORDER BY impact_coefficient DESC";

            using (var conn = new NpgsqlConnection(DbConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@date", date);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            factors.Add(new ExternalFactor
                            {
                                FactorId = reader.GetInt32(0),
                                Type = reader.GetString(1),
                                Date = reader.GetDateTime(2),
                                Value = reader.GetString(3),
                                ImpactCoefficient = reader.GetDecimal(4),
                                Description = reader.IsDBNull(5) ? "" : reader.GetString(5)
                            });
                        }
                    }
                }
            }
            return factors;
        }

        public void LoadAllDataToStore()
        {
            DataStore.Rooms = GetAllRooms();
            DataStore.Bookings = GetAllBookings();

            if (DataStore.Rooms.Count > 0)
                DataStore.NextRoomId = DataStore.Rooms.Max(r => r.RoomId) + 1;
            if (DataStore.Bookings.Count > 0)
                DataStore.NextBookingId = DataStore.Bookings.Max(b => b.BookingId) + 1;
        }

        public User AuthenticateUser(string login, string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                string passwordHash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                string sql = "SELECT user_id, login, role FROM Users WHERE login = @login AND password_hash = @hash";

                using (var conn = new NpgsqlConnection(DbConnectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@hash", passwordHash);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    UserId = reader.GetInt32(0),
                                    Login = reader.GetString(1),
                                    Role = reader.GetString(2)
                                };
                            }
                        }
                    }
                }
            }
            return null;
        }
    }
}