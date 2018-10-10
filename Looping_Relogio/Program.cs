using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Looping_Relogio
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes, dia, hora, min, seg;

            for (mes = 0; mes < 12; mes++)
            {
                for (dia = 0; dia < 30; dia++)
                {
                    for (hora = 0; hora < 24; hora++)
                    {
                        for (min = 0; min < 60; min++)
                        {
                            for (seg = 0; seg < 60; seg++)
                            {
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.WriteLine("Mês: {0} Dia: {1} Time {2}:{3}:{4}", mes, dia, hora, min, seg);
                               
                            }
                        }
                    }
                }
            }
               
                Console.ReadKey();
        }
    }
}
