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

        public void ExportForecast(string filePath, double lambda, double mu, int c,
            double rho, double pReject, decimal revenue, string recommendations)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Прогноз");

                worksheet.Cell(1, 1).Value = "ОТЧЕТ ПО ПРОГНОЗУ";
                worksheet.Cell(1, 1).Style.Font.Bold = true;
                worksheet.Cell(1, 1).Style.Font.FontSize = 14;

                worksheet.Cell(3, 1).Value = "Параметр";
                worksheet.Cell(3, 2).Value = "Значение";
                worksheet.Row(3).Style.Font.Bold = true;

                worksheet.Cell(4, 1).Value = "Интенсивность спроса (λ)";
                worksheet.Cell(4, 2).Value = Math.Round(lambda, 4);

                worksheet.Cell(5, 1).Value = "Интенсивность обслуживания (μ)";
                worksheet.Cell(5, 2).Value = Math.Round(mu, 4);

                worksheet.Cell(6, 1).Value = "Количество номеров (c)";
                worksheet.Cell(6, 2).Value = c;

                worksheet.Cell(7, 1).Value = "Коэффициент загрузки (ρ)";
                worksheet.Cell(7, 2).Value = Math.Round(rho, 4);

                worksheet.Cell(8, 1).Value = "Вероятность отказа";
                worksheet.Cell(8, 2).Value = $"{Math.Round(pReject * 100, 2)}%";

                worksheet.Cell(9, 1).Value = "Прогноз выручки (мес.)";
                worksheet.Cell(9, 2).Value = revenue;

                worksheet.Cell(11, 1).Value = "РЕКОМЕНДАЦИИ:";
                worksheet.Cell(11, 1).Style.Font.Bold = true;
                worksheet.Cell(12, 1).Value = recommendations;
                worksheet.Cell(12, 1).Style.Alignment.WrapText = true;

                // Форматирование
                var range = worksheet.Range(3, 1, 9, 2);
                range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                worksheet.Column(1).Width = 35;
                worksheet.Column(2).Width = 25;

                workbook.SaveAs(filePath);
            }
        }
    }
}
