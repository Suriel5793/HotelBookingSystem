using System;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using Diplom.Models;
using Diplom.Services;

namespace Diplom.Forms
{
    public partial class ChartsForm : Form
    {
        private MmcCalculator _calculator;
        private DatabaseService _db;
        private double _realLambda;
        private double _realMu;
        private int _realC;

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
        }

        private void LoadCharts()
        {
            PlotLvsC();
            PlotPRejectVsC();
            PlotWvsLambda();
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}