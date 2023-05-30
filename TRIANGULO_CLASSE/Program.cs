

using System;
using System.Globalization;

namespace Couse
{

    public class Program
    {
        public static void Main(string[] args)
        {
            // cria uma variavel do tipo double que é igual à função "X" do LerMedidasTriangulo
            double[] medidasX = LerMedidasTriangulo("X");
            // cria uma variavel do tipo double que é igual à função "Y" do LerMedidasTriangulo
            double[] medidasY = LerMedidasTriangulo("Y");

            //cria uma variavel tipo double que é igual à função de CalcularAreaTriangulo com as medidas de X
            double areaX = CalcularAreaTriangulo(medidasX);
            //cria uma variavel tipo double que é igual à função de CalcularAreaTriangulo com as medidas de Y
            double areaY = CalcularAreaTriangulo(medidasY);

            //console write line fala para o user oq tiver dentro dos (). Fala exatamente o que estiver em "" + os valores das variáveis
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //se o valor de areaX for maior que o valor de areaY
            if (areaX > areaY)
            {
                //fala para o user o texto em ""
                Console.WriteLine("Maior área: X");
            }
            //se não
            else
            {   // fala para o user ""
                Console.WriteLine("Maior área: Y");
            }

            static double[] LerMedidasTriangulo(string nomeTriangulo)
            {
                double[] medidas = new double[3];

                Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":");
                for (int i = 0; i < 3; i++)
                {
                    medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                return medidas;
            }

            static double CalcularAreaTriangulo(double[] medidas)
            {
                double a = medidas[0];
                double b = medidas[1];
                double c = medidas[2];

                double p = (a + b + c) / 2.0;
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                return area;
            }
        }
    }
}
