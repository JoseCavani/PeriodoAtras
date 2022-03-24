using System;

namespace PeriodoAtras.ConsoleApp1
{
    public class Data
    {
        public DateTime dateHoje;
        public DateTime dataInformada;

        public string Mensagen(TimeSpan dias)
        {
            if (dias.Days < 7)
            {
                return ($"{dias.Days} dias se passaram");
            }
            else if (dias.Days >= 7 && dias.Days < 30)
            {
                return ($"{dias.Days / 7} semandas se passaram e {dias.Days % 7} dia(s)");
            }
            else if (dias.Days >= 30 && dias.Days < 360)
            {
                return ($"{dias.Days / 30} meses se passaram e {(dias.Days % 30) / 7} semanas e {((dias.Days % 30) % 7)} dia(s)");
            }
            else if (dias.Days >= 360)
            {
                return ($"{dias.Days / 360} anos se passaram e {dias.Days % 360 / 30} meses e {(dias.Days % 360) % 30 / 7} semanas e {((dias.Days % 360) / 30 % 7)} dia(s)");
            }
            return "";
        }

        
    }
}