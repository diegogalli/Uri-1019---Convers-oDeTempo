using System;
using System.Globalization;


namespace ConversaoDeTempo
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, Horas, Resto, minutos, segundos;

            N = int.Parse(Console.ReadLine());
            Horas = N / 3600;
            Resto = N % 3600; // % mod = recebe o resto da divisão
            minutos = Resto / 60;
            segundos = Resto % 60;

            Console.WriteLine(Horas + ":" + minutos + ":" + segundos);

          
        }
    }
}
