using System;
using System.Collections.Generic;
using System.Text;

namespace CPS1.Sygnaly
{
    public class Sygnal
    {
        public Random Random = new Random();

        #region Wspl

        public double Amplituda { get; set; } //A
        public double CzasPoczatkowy { get; set; } //Ts
        public double CzasKoncowy { get; set; } //Tf
        public double OkresPodstawowy { get; set; } //T
        public double Prawdopodobienstwo { get; set; } //P
        //public double Amplituda { get; set; }
        #endregion

       public double SzumJednostajny(double czas = 0)
        {
            return Random.NextDouble() * 2 * Amplituda - Amplituda;
        }

        public double SzumGaussowski(double czas)
        {
            double w1 = 1.0 - Random.NextDouble();
            double w2 = 1.0 - Random.NextDouble();
            return Math.Sqrt(-2.0 * Math.Log(w1)) * Math.Sin(2.0 * Math.PI * w2) * Amplituda / 3;
        }

        public double SygnalSinusoidalny(double czas)
        {
            return Amplituda * Math.Sin((2 * Math.PI / OkresPodstawowy) * (czas - CzasPoczatkowy));
        }
    }
}
