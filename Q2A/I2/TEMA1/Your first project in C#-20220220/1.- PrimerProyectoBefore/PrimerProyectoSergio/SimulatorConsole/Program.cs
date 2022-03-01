using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightLib;

namespace SimulatorConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            FligthPlanList fligthList = new FligthPlanList();

            Console.WriteLine("Escribe el numero de aviones");
            int naviones;
            try
            {
                naviones = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error de formato");

                naviones = Convert.ToInt32(Console.ReadLine());
            }
            int i = 0;
            while (i < naviones)
            {
                fligthList.AddFromConsole();
                i++;
            }


            Console.WriteLine("Escribe el numero de ciclos");
            int ciclos;
            try
            {
                ciclos = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error de formato");

                ciclos = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Escribe la distancia de seguridad");
            double distanciaSeguridad;
            try
            {
                distanciaSeguridad = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error de formato");

                distanciaSeguridad = Convert.ToDouble(Console.ReadLine());
            }

            int ciclo = 0;
            int j = 0;
            while (ciclo < ciclos)
            {
                fligthList.WriteAll();
                fligthList.MoveAll(10);

                i = 0;
                while (i < naviones)
                {
                    j = i;
                    while (j < naviones)
                    {
                        if (fligthList.GetFlightAtIndex(i).Conflicto(fligthList.GetFlightAtIndex(j), distanciaSeguridad))
                        {
                            Console.WriteLine("El avion {0} y {1} estan en conflicto", 
                                fligthList.GetFlightAtIndex(i).GetId(), 
                                fligthList.GetFlightAtIndex(j).GetId());
                        }
                        j++;
                    }
                    i++;
                }
                ciclo++;
            }


            Console.ReadLine();


        }
    }
}
