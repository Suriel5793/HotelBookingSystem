using System;
using System.Windows.Forms;
using Diplom.Forms;
using Diplom.Models;
using Diplom.Services;

namespace Diplom
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var db = new DatabaseService();
            db.InitializeDatabase();
            db.LoadAllDataToStore();

            if (DataStore.Rooms.Count == 0)
            {
                DataStore.InitTestData();
                foreach (var room in DataStore.Rooms)
                    db.AddRoomAndGetId(room);
                foreach (var booking in DataStore.Bookings)
                    db.AddBookingAndGetId(booking);
                db.LoadAllDataToStore();
            }

            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm());
                }
            }
        }
    }
}