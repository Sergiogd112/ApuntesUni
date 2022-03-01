using System;
using System.Collections.Generic;
using System.Text;

namespace FlightLib
{
    public class FligthPlanList
    {
        private int len = 0;
        const int maxLen = 100;
        private FlightPlan[] flights = new FlightPlan[maxLen];

        public int GetLen()
        {
            return len;
        }
        public FlightPlan GetFlightAtIndex(int index)
        {
            if (index < 0 || index >= len)
            {
                return null;
            }
            return flights[index];
        }
        public int AddFligthPlan(FlightPlan fligth)
        {
            if (len == maxLen)
            {
                return -1;
            }
            this.flights[len] = fligth;
            this.len++;
            return this.len;
        }
        public FlightPlan AddFromConsole()
        {
            string identificador;
            string linea;
            string[] trozos;
            double velocidad;
            double ix, iy;
            double fx, fy;
            Console.WriteLine("Escribe el identificador");
            //   string nombre = Console.ReadLine();
            identificador = Console.ReadLine();

            Console.WriteLine("Escribe la velocidad");
            try
            {
                velocidad = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error de formato");

                velocidad = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Escribe las coordenadas de la posición inicial, separadas por un blanco");
            linea = Console.ReadLine();
            trozos = linea.Split(' ');
            try
            {
                ix = Convert.ToDouble(trozos[0]);
                iy = Convert.ToDouble(trozos[1]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error de formato");

                linea = Console.ReadLine();
                trozos = linea.Split(' ');
                ix = Convert.ToDouble(trozos[0]);
                iy = Convert.ToDouble(trozos[1]);
            }

            Console.WriteLine("Escribe las coordenadas de la posición final, separadas por un blanco");
            try
            {
                linea = Console.ReadLine();
                trozos = linea.Split(' ');
                fx = Convert.ToDouble(trozos[0]);
                fy = Convert.ToDouble(trozos[1]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error de formato");

                linea = Console.ReadLine();
                trozos = linea.Split(' ');
                fx = Convert.ToDouble(trozos[0]);
                fy = Convert.ToDouble(trozos[1]);
            }
            FlightPlan fligth = new FlightPlan(identificador, ix, iy, fx, fy, velocidad);
            this.AddFligthPlan(fligth);
            return fligth;
        }
        public void MoveAll(int moves)
        {
            int i = 0;
            while (i < this.len)
            {
                this.flights[i].Mover(10);
                i++;
            }
        }
        public void WriteAll()
        {
            int i = 0;
            while (i < this.len)
            {
                this.flights[i].EscribeConsola();
                i++;
            }
        }
    }
}
