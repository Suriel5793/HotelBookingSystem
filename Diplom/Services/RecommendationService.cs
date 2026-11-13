using System;
using System.Collections.Generic;
using Diplom.Models;

namespace Diplom.Services
{
    public class RecommendationService
    {
        public List<string> GenerateRecommendations(QueueModel result, double lambda, double mu, int c)
        {
            var recommendations = new List<string>();

            if (!result.IsStable)
            {
                recommendations.Add("СИСТЕМА НЕСТАБИЛЬНА (ρ ≥ 1)");
                recommendations.Add("Увеличьте количество номеров (c) минимум до " + Math.Ceiling(lambda / mu + 1));
                recommendations.Add("Повысьте цены в пиковые периоды для снижения спроса");
                recommendations.Add("Рассмотрите возможность добавления новых категорий номеров");
                return recommendations;
            }

            if (result.P_reject > 0.1)
            {
                recommendations.Add($"Высокая вероятность отказа: {result.P_reject * 100:F1}%");
                recommendations.Add($"Рекомендуется увеличить количество номеров до {FindMinCForPReject(lambda, mu, 0.05)}");
                recommendations.Add("Внедрите систему overbooking (перебронирование) с компенсациями");
            }
            else if (result.P_reject > 0.05)
            {
                recommendations.Add($"Средняя вероятность отказа: {result.P_reject * 100:F1}%");
                recommendations.Add("Увеличьте количество номеров на 5-10%");
                recommendations.Add("Рассмотрите динамическое ценообразование");
            }
            else if (result.P_reject < 0.01)
            {
                recommendations.Add($"Очень низкая вероятность отказа: {result.P_reject * 100:F2}%");
                recommendations.Add("Количество номеров может быть избыточно");
                recommendations.Add("Рассмотрите временное переоборудование части номеров под другие цели");
            }

            if (result.Wq * 24 > 4)
            {
                recommendations.Add($"Большое время ожидания: {result.Wq * 24:F1} часов");
                recommendations.Add("Увеличьте количество номеров");
                recommendations.Add("Внедрите систему предварительного онлайн-заселения");
            }
            else if (result.Wq * 24 > 1)
            {
                recommendations.Add($"Среднее время ожидания: {result.Wq * 24:F1} часов");
                recommendations.Add("Рассмотрите возможность экспресс-заселения");
            }

            if (result.Rho > 0.85)
            {
                recommendations.Add($"Высокая загрузка: {result.Rho * 100:F1}%");
                recommendations.Add("Повысьте цены в выходные дни");
                recommendations.Add("Внедрите программы лояльности для постоянных клиентов");
            }
            else if (result.Rho < 0.4)
            {
                recommendations.Add($"Низкая загрузка: {result.Rho * 100:F1}%");
                recommendations.Add("Снизьте цены или запустите акции");
                recommendations.Add("Увеличьте маркетинговый бюджет");
                recommendations.Add("Добавьте дополнительные услуги");
            }
            else
            {
                recommendations.Add($"✓ Оптимальная загрузка: {result.Rho * 100:F1}%");
            }

            if (result.P_reject < 0.05 && result.Rho < 0.7)
            {
                recommendations.Add("Резерв свободных номеров можно использовать для:");
                recommendations.Add("Долгосрочных контрактов с корпоративными клиентами");
                recommendations.Add("Проведения специальных мероприятий");
            }

            double avgLambda = 45;
            if (lambda > avgLambda * 1.3)
            {
                recommendations.Add("Высокий сезон: временно повысьте цены на 15-20%");
            }
            else if (lambda < avgLambda * 0.7)
            {
                recommendations.Add("Низкий сезон: запустите специальные предложения и скидки");
            }

            if (recommendations.Count == 0)
            {
                recommendations.Add("Система работает оптимально. Продолжайте в том же духе!");
            }

            return recommendations;
        }
        public int FindMinCForPReject(double lambda, double mu, double maxPReject)
        {
            var calculator = new MmcCalculator();

            for (int c = 1; c <= 500; c++)
            {
                double rho = lambda / (c * mu);
                if (rho >= 1) continue;

                var input = new QueueModel { Lambda = lambda, Mu = mu, C = c };
                var result = calculator.Calculate(input);

                if (result.P_reject <= maxPReject)
                {
                    return c;
                }
            }

            return -1;
        }

        public decimal CalculateOptimalPrice(decimal basePrice, double rho)
        {
            if (rho > 0.85)
                return basePrice * 1.3m;
            else if (rho > 0.7)
                return basePrice * 1.1m;
            else if (rho < 0.4)
                return basePrice * 0.8m;
            else
                return basePrice;
        }

        public decimal ForecastRevenue(double lambda, double pReject, decimal avgPrice, int days = 30)
        {
            double acceptedBookings = lambda * (1 - pReject);
            return (decimal)(acceptedBookings * days) * avgPrice;
        }
    }
}