using Diplom.Models;
using Diplom.Services;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Diplom.Forms
{
    public partial class ChartsForm : Form
    {
        private MmcCalculator _calculator;
        private DatabaseService _db;
        private double _realLambda;
        private double _realMu;
        private int _realC;
        private decimal _avgPrice;
        private decimal _avgCost;

        public ChartsForm()
        {
            InitializeComponent();
            _calculator = new MmcCalculator();
            _db = new DatabaseService();

            LoadRealData();
            LoadCharts();
        }

        private void LoadRealData()
        {
            _realLambda = _db.CalculateRealLambda(DateTime.Now.AddDays(-30), DateTime.Now);
            if (_realLambda <= 0) _realLambda = 5.87;

            _realMu = _db.CalculateRealMu();
            if (_realMu <= 0) _realMu = 0.5;

            _realC = _db.GetRealRoomCount();
            if (_realC <= 0) _realC = 10;

            var rooms = _db.GetAllRooms();
            _avgPrice = rooms.Count > 0 ? rooms.Average(r => r.BasePricePerNight) : 4000m;
            _avgCost = rooms.Count > 0 ? rooms.Average(r => r.MaintenanceCost) : 1500m;

            this.Text = $"Аналитика — Графики (λ={_realLambda:F2}, μ={_realMu:F2}, c={_realC})";
        }

        private void LoadCharts()
        {
            PlotLvsC();
            PlotPRejectVsC();
            PlotWvsLambda();
            PlotProfitVsC();
        }

        private void PlotLvsC()
        {
            var model = new PlotModel();
            model.Title = "Зависимость среднего числа заявок (L) от количества номеров (c)";
            model.Background = OxyColor.FromRgb(255, 255, 255);

            var series = new LineSeries();
            series.Title = "L(c)";
            series.MarkerType = MarkerType.Circle;
            series.MarkerSize = 4;
            series.StrokeThickness = 2;
            series.Color = OxyColor.FromRgb(0, 0, 255);

            for (int c = 1; c <= 30; c++)
            {
                double rho = _realLambda / (c * _realMu);
                if (rho >= 1) continue;

                var input = new QueueModel { Lambda = _realLambda, Mu = _realMu, C = c };
                var result = _calculator.Calculate(input);
                series.Points.Add(new DataPoint(c, result.L));
            }

            model.Series.Add(series);

            // Ось X с сеткой
            var xAxis = new LinearAxis();
            xAxis.Position = AxisPosition.Bottom;
            xAxis.Title = "Количество номеров (c)";
            xAxis.Minimum = 0;
            xAxis.Maximum = 30;
            xAxis.MajorGridlineStyle = LineStyle.Solid;
            xAxis.MajorGridlineColor = OxyColor.FromRgb(200, 200, 200);
            xAxis.MinorGridlineStyle = LineStyle.Dot;
            xAxis.MinorGridlineColor = OxyColor.FromRgb(230, 230, 230);

            // Ось Y с сеткой
            var yAxis = new LinearAxis();
            yAxis.Position = AxisPosition.Left;
            yAxis.Title = "Среднее число заявок (L)";
            yAxis.Minimum = 0;
            yAxis.MajorGridlineStyle = LineStyle.Solid;
            yAxis.MajorGridlineColor = OxyColor.FromRgb(200, 200, 200);
            yAxis.MinorGridlineStyle = LineStyle.Dot;
            yAxis.MinorGridlineColor = OxyColor.FromRgb(230, 230, 230);

            model.Axes.Add(xAxis);
            model.Axes.Add(yAxis);

            plotLvsC.Model = model;
        }

        private void PlotPRejectVsC()
        {
            var model = new PlotModel();
            model.Title = "Зависимость вероятности отказа (Pотк) от количества номеров (c)";
            model.Background = OxyColor.FromRgb(255, 255, 255);

            var series = new LineSeries();
            series.Title = "Pотк(c)";
            series.MarkerType = MarkerType.Circle;
            series.MarkerSize = 4;
            series.StrokeThickness = 2;
            series.Color = OxyColor.FromRgb(255, 0, 0);

            for (int c = 1; c <= 30; c++)
            {
                double rho = _realLambda / (c * _realMu);
                if (rho >= 1) continue;

                var input = new QueueModel { Lambda = _realLambda, Mu = _realMu, C = c };
                var result = _calculator.Calculate(input);
                series.Points.Add(new DataPoint(c, result.P_reject * 100));
            }

            model.Series.Add(series);

            var xAxis = new LinearAxis();
            xAxis.Position = AxisPosition.Bottom;
            xAxis.Title = "Количество номеров (c)";
            xAxis.Minimum = 0;
            xAxis.Maximum = 30;
            xAxis.MajorGridlineStyle = LineStyle.Solid;
            xAxis.MajorGridlineColor = OxyColor.FromRgb(200, 200, 200);
            xAxis.MinorGridlineStyle = LineStyle.Dot;
            xAxis.MinorGridlineColor = OxyColor.FromRgb(230, 230, 230);

            var yAxis = new LinearAxis();
            yAxis.Position = AxisPosition.Left;
            yAxis.Title = "Вероятность отказа Pотк (%)";
            yAxis.Minimum = 0;
            yAxis.Maximum = 100;
            yAxis.MajorGridlineStyle = LineStyle.Solid;
            yAxis.MajorGridlineColor = OxyColor.FromRgb(200, 200, 200);
            yAxis.MinorGridlineStyle = LineStyle.Dot;
            yAxis.MinorGridlineColor = OxyColor.FromRgb(230, 230, 230);

            model.Axes.Add(xAxis);
            model.Axes.Add(yAxis);

            plotPRejectVsC.Model = model;
        }

        private void PlotWvsLambda()
        {
            var model = new PlotModel();
            model.Title = "Зависимость времени в системе (W) от интенсивности бронирований (λ)";
            model.Background = OxyColor.FromRgb(255, 255, 255);

            var series = new LineSeries();
            series.Title = "W(λ)";
            series.MarkerType = MarkerType.Circle;
            series.MarkerSize = 4;
            series.StrokeThickness = 2;
            series.Color = OxyColor.FromRgb(0, 128, 0);

            for (double lambda = 1; lambda <= 15; lambda += 0.5)
            {
                double rho = lambda / (_realC * _realMu);
                if (rho >= 1) continue;

                var input = new QueueModel { Lambda = lambda, Mu = _realMu, C = _realC };
                var result = _calculator.Calculate(input);
                series.Points.Add(new DataPoint(lambda, result.W * 24));
            }

            model.Series.Add(series);

            var xAxis = new LinearAxis();
            xAxis.Position = AxisPosition.Bottom;
            xAxis.Title = "Интенсивность бронирований λ (заявок/день)";
            xAxis.Minimum = 0;
            xAxis.Maximum = 15;
            xAxis.MajorGridlineStyle = LineStyle.Solid;
            xAxis.MajorGridlineColor = OxyColor.FromRgb(200, 200, 200);
            xAxis.MinorGridlineStyle = LineStyle.Dot;
            xAxis.MinorGridlineColor = OxyColor.FromRgb(230, 230, 230);

            var yAxis = new LinearAxis();
            yAxis.Position = AxisPosition.Left;
            yAxis.Title = "Среднее время в системе W (часы)";
            yAxis.Minimum = 0;
            yAxis.Maximum = 100;
            yAxis.MajorGridlineStyle = LineStyle.Solid;
            yAxis.MajorGridlineColor = OxyColor.FromRgb(200, 200, 200);
            yAxis.MinorGridlineStyle = LineStyle.Dot;
            yAxis.MinorGridlineColor = OxyColor.FromRgb(230, 230, 230);

            model.Axes.Add(xAxis);
            model.Axes.Add(yAxis);

            plotWvsLambda.Model = model;
        }

        private void PlotProfitVsC()
        {
            var model = new PlotModel
            {
                Title = "Зависимость прибыли от количества номеров (за 30 дней)",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                Background = OxyColor.FromRgb(253, 245, 230),
                PlotAreaBorderColor = OxyColor.FromRgb(210, 180, 140)
            };

            var series = new LineSeries
            {
                Title = "Прибыль (руб.)",
                MarkerType = MarkerType.Circle,
                MarkerSize = 3,
                StrokeThickness = 3,
                Color = OxyColor.FromRgb(34, 139, 34) // Зеленый (деньги)
            };

            var calculator = new MmcCalculator();
            double bestProfit = double.MinValue;
            int bestC = -1;

            // Перебираем количество номеров от 1 до 100
            for (int c = 1; c <= 100; c++)
            {
                double rho = _realLambda / (c * _realMu);
                if (rho >= 1) continue;

                var input = new QueueModel { Lambda = _realLambda, Mu = _realMu, C = c };
                var result = calculator.Calculate(input);

                // Считаем прибыль за 30 дней
                double occupiedRooms = c * result.Rho;
                double revenue = occupiedRooms * (double)_avgPrice * 30;
                double costs = c * (double)_avgCost * 30;
                double profit = revenue - costs;

                series.Points.Add(new DataPoint(c, profit));

                if (profit > bestProfit)
                {
                    bestProfit = profit;
                    bestC = c;
                }
            }

            model.Series.Add(series);

            // Добавляем точку максимальной прибыли (золотая)
            var peakPoint = new ScatterSeries
            {
                Title = "Максимум прибыли",
                MarkerType = MarkerType.Diamond,
                MarkerSize = 8,
                MarkerFill = OxyColors.Gold
            };
            peakPoint.Points.Add(new ScatterPoint(bestC, bestProfit));
            model.Series.Add(peakPoint);

            // Линия текущего состояния
            var currentLine = new LineAnnotation
            {
                Type = LineAnnotationType.Vertical,
                X = _realC,
                Color = OxyColors.IndianRed,
                LineStyle = LineStyle.Dash,
                StrokeThickness = 2,
                Text = $"Текущее c = {_realC}",
                TextHorizontalAlignment = OxyPlot.HorizontalAlignment.Right
            };
            model.Annotations.Add(currentLine);

            var xAxis = new LinearAxis { Position = AxisPosition.Bottom, Title = "Количество номеров (c)", Minimum = 0 };
            xAxis.MajorGridlineStyle = LineStyle.Solid;
            xAxis.MajorGridlineColor = OxyColor.FromRgb(220, 220, 220);

            var yAxis = new LinearAxis { Position = AxisPosition.Left, Title = "Прибыль за 30 дней (руб.)" };
            yAxis.MajorGridlineStyle = LineStyle.Solid;
            yAxis.MajorGridlineColor = OxyColor.FromRgb(220, 220, 220);

            model.Axes.Add(xAxis);
            model.Axes.Add(yAxis);

            plotProfitVsC.Model = model;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}