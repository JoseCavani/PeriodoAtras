using System;

namespace PeriodoAtras.ConsoleApp1
{
    public partial class Data
    {
        public DateTime dateHoje;
        public DateTime dataInformada;

        public string Mensagen(TimeSpan dias)
        {
            if (dias.Days < 7)
            {
                IntParaStringDias dia = (IntParaStringDias)dias.Days;
                if (dias.Days > 1)
                {
                    return ($"{dia} dia se passaram");
                }
                else
                    return ($"{dia} dias se passaram");
            }
            else if (dias.Days >= 7 && dias.Days < 30)
            {
                IntParaStringDias semanas;
                IntParaStringDias dia = (IntParaStringDias)(dias.Days % 7);
                if (dias.Days / 7 == 2)
                    semanas = (IntParaStringDias)Enum.Parse(typeof(IntParaStringDias), "duas");

                else
                    semanas = (IntParaStringDias)(dias.Days / 7);

                if (dias.Days / 7 == 0)
                {
                    return ($" se passaram {semanas} semana(s)");
                }
                return ($"se passaram {semanas} semana(s) e {dia} dia(s)");
            }
            else if (dias.Days >= 30 && dias.Days < 360)
            {
                IntParaStringDias dia = (IntParaStringDias)(((dias.Days % 30) % 7));
                IntParaStringDias semanas;
                IntParaStringDias meses = (IntParaStringDias)(dias.Days / 30);


                if ((dias.Days % 30) / 7 == 2)
                    semanas = (IntParaStringDias)Enum.Parse(typeof(IntParaStringDias), "duas");

                else
                    semanas = (IntParaStringDias)(dias.Days / 7);


                if ((dias.Days % 30) / 7 == 0)
                {
                    if ((dias.Days % 30) / 7 == 0)
                    {
                        return ($"se passaram {meses} mes(es)");
                    }
                    return ($"se passaram {meses} mes(es) e {semanas} semana(s)");
                }


                return ($"{meses} mese(s) se passaram e {semanas} semana(s) e {dia} dia(s)");
            }
            else if (dias.Days >= 360)
            {
                IntParaStringDias dia = (IntParaStringDias)(((dias.Days % 360) / 30 % 7));
                IntParaStringDias semanas = (IntParaStringDias)((dias.Days % 360) % 30 / 7);
                IntParaStringDias meses = (IntParaStringDias)(dias.Days % 360 / 30);
                IntParaStringDias anos = (IntParaStringDias)(dias.Days / 360);

                if ((dias.Days % 360) % 30 / 7 == 2)
                    semanas = (IntParaStringDias)Enum.Parse(typeof(IntParaStringDias), "duas");

                else
                    semanas = (IntParaStringDias)((dias.Days % 360) % 30 / 7);




                if ((dias.Days % 360) / 30 % 7 == 0 && (dias.Days % 360) % 30 / 7 == 0 && (dias.Days % 360 / 30) == 0)

                    return ($" se passaram {anos} ano(s)");

                else if ((dias.Days % 360) / 30 % 7 == 0 && (dias.Days % 360) % 30 / 7 == 0)
                    return ($" se passaram {anos} ano(s) e {meses} mese(s)");
                else if ((dias.Days % 360) / 30 % 7 == 0)
                    return ($"se passaram {dia} ano(s) e {meses} mese(s) e {semanas} semana(s)");

                return ($"se passaram {anos} ano(s) e {meses} mese(s) e {semanas} semana(s) e {dia} dia(s)");
            }
            return "";
        }
    }


}


