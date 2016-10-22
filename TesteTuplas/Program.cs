using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTuplas
{
    class Program
    {
        private static (double tempCelsius, double tempKelvin) ConverterTemperaturas(
            double tempFahrenheit)
        {
            double retCelsius = Math.Round((tempFahrenheit - 32) / 1.8, 2);
            double retKelvin = retCelsius + +273.15;

            return (retCelsius, retKelvin);
            //return (tempCelsius: retCelsius, tempKelvin: retKelvin);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Conversão de temperaturas");

            double valorFahrenheit;
            
            valorFahrenheit = 86;
            var resultado1 = ConverterTemperaturas(valorFahrenheit);
            Console.WriteLine($"Fahrenheit = {valorFahrenheit} - " +
                              $"Celsius = {resultado1.tempCelsius} - " +
                              $"Kelvin = {resultado1.tempKelvin}");

            // Exemplo - Desconstrução
            valorFahrenheit = 32;
            (double resCelsius2, double resKelvin2) = ConverterTemperaturas(valorFahrenheit);
            Console.WriteLine($"Fahrenheit = {valorFahrenheit} - " +
                              $"Celsius = {resCelsius2} - " +
                              $"Kelvin = {resKelvin2}");

            // Outro exemplo
            var coordenadas = (latitude: "23.5505° S", longitude: "46.6333° W");
            Console.WriteLine($"São Paulo - " +
                              $"Latitude = {coordenadas.latitude} - " +
                              $"Longitude = {coordenadas.longitude}");

            Console.ReadKey();
        }
    }
}