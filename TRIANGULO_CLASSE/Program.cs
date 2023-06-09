// usa o System, que tem as principais classes usadas
using System;
// usa o System.Globalization, que tem várias informações "culturais"
using System.Globalization;

//cria um namespace chamado 'Couse'
namespace Couse
{

    //cria uma classe publica chamada Programa
    public class Program
    {
        //cria um principal para começar o programa
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

            //fala para o user o que estiver dentro das "" + o valor das variáveis
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //se o valor de areaX for maior que o valor de areaY, faz o que estiver dentre {}
            if (areaX > areaY)
            {
                //fala para o user o texto em ""
                Console.WriteLine("Maior área: X");
            }
            //se não
            else
            {   //fala para o user o texto em ""
                Console.WriteLine("Maior área: Y");
            }
            
            //cria uma variavel do tipo static double para ler as medidas do triangulo onde nomeTriangulo será usado para conter X e Y
            static double[] LerMedidasTriangulo(string nomeTriangulo)
            {   
                //cria uma variavel para as medidas onde tem uma matriz com 3 colunas para os valores de a b e c
                double[] medidas = new double[3];
                
                //fala para o user falar as medidas e logo depois fala o nome do triangulo sendo X ou Y
                Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":");
                
                //para i igual a 0 e sendo menor que 3, ele aumenta o valor de i em 1 e repete até chegar no seu valor máximo
                for (int i = 0; i < 3; i++)
                {
                    medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                //retorna o valor da variável 'medidas'
                return medidas;
            }
            
            //entra com a matriz das medidas
            static double CalcularAreaTriangulo(double[] medidas)
            {
                //cria variaveis tipo double seguido de sua função de medida (a b e c) fazendo parte de [i] coluna
                double a = medidas[0];
                double b = medidas[1];
                double c = medidas[2];
                
                //cria uma variavel para o calculo de soma das medidas para encontrar sua área
                double p = (a + b + c) / 2.0;
                //calcula a area do triangulo com base nas medidas dos lados
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                //retorna o valor da variável 'area'
                return area;
            }
        }
    }
}
