using System;

namespace PeriodoAtras.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data datas = new();
            TimeSpan dias = new TimeSpan();
           datas.dateHoje = DateTime.Now;
            datas.dataInformada = DateTime.Parse("10/03/2022");
            dias = datas.dateHoje - datas.dataInformada;
           Console.WriteLine(datas.Mensagen(dias));
            Console.ReadKey();
        }
    }
}