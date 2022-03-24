using System;
using System.ComponentModel;

namespace PeriodoAtras.ConsoleApp1
{
    public class Data
        {
          public  DateTime dateHoje;
           public DateTime dataInformada;

        public string Mensagen(TimeSpan dias)
        {
            if (dias.Days<7)
            {
                A dia = (A)dias.Days;
                return ($"{dia} dias se passaram");
            }
           else if (dias.Days >= 7&& dias.Days < 30)
            {
                A dia = (A)(dias.Days % 7);
                A semanas = (A)(dias.Days / 7);
                return ($"{semanas} semandas se passaram e {dia} dia(s)");
            }
              else if (dias.Days >= 30 && dias.Days < 360)
            {
                A dia = (A)(((dias.Days % 30) % 7));
                A semanas = (A)((dias.Days % 30) / 7);
                A meses = (A)(dias.Days / 30);
                return ($"{meses} meses se passaram e {semanas} semanas e {dia} dia(s)");
            }
            else if (dias.Days >= 360)
            {
                A dia = (A)(((dias.Days % 360) / 30 % 7));
                A semanas = (A)((dias.Days % 360) % 30 / 7);
                A meses = (A)(dias.Days % 360 / 30);
                A anos = (A)(dias.Days / 360);
                return ($"{dia} anos se passaram e {semanas} meses e {meses} semanas e {anos} dia(s)");
            }
            return "";
        }
    }
    public enum A 
    {
        [Description("zero")]
        zero = 0,
        [Description("um")]
        um = 1,
        [Description("dois")]
        dois = 2


    }
  
    
}


