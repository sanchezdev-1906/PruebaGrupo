using System;
namespace myConsole
{
  class Program
  {
    static void CalcularCuadratica(double a, double b, double c, out double x1, out double x2)
    {
      double sq = Math.Sqrt(Math.Pow(b, 2) + 4 * a * c);
      if ((a == 0) || (sq < 0))
      {
        x1 = 0;
        x2 = 0;
      }
      else
      {
        x1 = (-b + sq) / (2 * a);
        x2 = (-b - sq) / (2 * a);
      }
    }
    static void Main()
    {
    }
  }
}