using System;
using System.Globalization;
using System.Net.NetworkInformation;

class URI
{
    static void Main(string[] args)
    {
        string[] eixos1 = Console.ReadLine().Split(' ');
        double X1 = double.Parse(eixos1[0], CultureInfo.InvariantCulture);
        double Y1 = double.Parse(eixos1[1], CultureInfo.InvariantCulture);

        string[] eixos2 = Console.ReadLine().Split(' ');
        double X2 = double.Parse(eixos2[0], CultureInfo.InvariantCulture);
        double Y2 = double.Parse(eixos2[1], CultureInfo.InvariantCulture);

        double distancia = Math.Pow(X2-X1, 2) + Math.Pow(Y2-Y1, 2);
        distancia = Math.Sqrt(distancia);


        Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

        Console.ReadLine();

    }
}