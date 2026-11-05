using System;
using Diplom.Models;

namespace Diplom.Services
{
    public class MmcCalculator
    {
        public QueueModel Calculate(QueueModel input)
        {
            var result = new QueueModel
            {
                Lambda = input.Lambda,
                Mu = input.Mu,
                C = input.C
            };

            double lambda = input.Lambda;
            double mu = input.Mu;
            int c = input.C;

            double a = lambda / mu;         
            result.Rho = lambda / (c * mu); 

            if (result.Rho >= 1)
            {
                result.IsStable = false;
                result.P0 = 0;
                result.L = 0;
                result.W = 0;
                result.Lq = 0;
                result.Wq = 0;
                result.P_reject = 0; 
                return result;
            }

            result.IsStable = true;

            double sumSeries = 0;
            for (int n = 0; n < c; n++)
            {
                sumSeries += Math.Exp(n * Math.Log(a) - LogFactorial(n));
            }

            double lastTerm = Math.Exp(c * Math.Log(a) - LogFactorial(c))
                              / (1 - result.Rho);

            result.P0 = 1.0 / (sumSeries + lastTerm);

            double C_erlang = lastTerm * result.P0;
            result.P_reject = C_erlang;

            result.Lq = C_erlang * result.Rho / (1 - result.Rho);

            result.L = result.Lq + a;
            result.Wq = (lambda > 0) ? result.Lq / lambda : 0;
            result.W = (lambda > 0) ? result.L / lambda : 0;

            result.Rho = Math.Round(result.Rho, 6);
            result.P0 = Math.Round(result.P0, 6);
            result.L = Math.Round(result.L, 6);
            result.W = Math.Round(result.W, 6);
            result.Lq = Math.Round(result.Lq, 6);
            result.Wq = Math.Round(result.Wq, 6);
            result.P_reject = Math.Round(result.P_reject, 6);

            return result;
        }

        private double LogFactorial(int n)
        {
            if (n <= 1) return 0;
            double res = 0;
            for (int i = 2; i <= n; i++)
                res += Math.Log(i);
            return res;
        }
    }
}