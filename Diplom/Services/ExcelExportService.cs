using ClosedXML.Excel;
using Diplom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Services
{
    public class ExcelExportService
    {
        public void ExportBookings(string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Бронирования");

                // Заголовки
                worksheet.Cell(1, 1).Value = "ID";
                worksheet.Cell(1, 2).Value = "Номер";
                worksheet.Cell(1, 3).Value = "Заезд";
                worksheet.Cell(1, 4).Value = "Выезд";
                worksheet.Cell(1, 5).Value = "Гостей";
                worksheet.Cell(1, 6).Value = "Цена";
                worksheet.Cell(1, 7).Value = "Источник";
                worksheet.Cell(1, 8).Value = "Статус";

                // Данные
                int row = 2;
                foreach (var b in DataStore.Bookings)
                {
                    var room = DataStore.Rooms.FirstOrDefault(r => r.RoomId == b.RoomId);
                    worksheet.Cell(row, 1).Value = b.BookingId;
                    worksheet.Cell(row, 2).Value = room?.RoomNumber ?? "—";
                    worksheet.Cell(row, 3).Value = b.CheckInDate.ToShortDateString();
                    worksheet.Cell(row, 4).Value = b.CheckOutDate.ToShortDateString();
                    worksheet.Cell(row, 5).Value = b.GuestCount;
                    worksheet.Cell(row, 6).Value = b.TotalPrice;
                    worksheet.Cell(row, 7).Value = b.BookingSource;
                    worksheet.Cell(row, 8).Value = b.Status;
                    row++;
                }

                // Красивое форматирование
                var range = worksheet.Range(1, 1, row - 1, 8);
                range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                worksheet.Row(1).Style.Font.Bold = true;
                worksheet.Columns().AdjustToContents();

                workbook.SaveAs(filePath);
            }
        }
    }
}
