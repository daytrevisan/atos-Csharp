/*
Desenvolva um aplicativo que converta a temperatura de Celsius para Fahrenheit e vice-versa. Use uma estrutura switch para perguntar ao usuário se ele deseja converter de Celsius para Fahrenheit ou de Fahrenheit para Celsius, e então realize o cálculo apropriado.
*/

using System;

namespace ConversorDeTemperatura {

    public class Program {

        public static void Main(string[] args) {
        
            double temp = 0;
            double tempConvertida = 0;

            Console.Write("Informe a conversão que deseja: ºC (Celsius) ou ºF (Fahrenheit): ");
            char unidade = char.ToUpper(Console.ReadLine()[0]);

            switch (unidade) {
                case 'C':
                    Console.Write("Informe a temperatura em Fahrenheit: ");
                    temp = double.Parse(Console.ReadLine());
                    tempConvertida = (temp - 32) / 1.8;
                    Console.WriteLine($"A temperatura {temp}ºF equivale a {tempConvertida:F2}ºC");
                    break;
                case 'F':
                    Console.Write("Informe a temperatura em Celsius: ");
                    temp = double.Parse(Console.ReadLine());
                    tempConvertida = (temp * 1.8) + 32;
                    Console.WriteLine($"A temperatura {temp}ºC é {tempConvertida:F2}ºF");
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Por favor, informe 'C' ou 'F'.");
                    break;
            }

        }

    }
}