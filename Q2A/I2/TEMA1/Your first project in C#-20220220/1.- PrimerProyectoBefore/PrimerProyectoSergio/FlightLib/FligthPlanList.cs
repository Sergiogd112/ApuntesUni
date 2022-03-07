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
        private bool[,] interactions = new bool[maxLen, maxLen];
        private double[,] mind = new double[maxLen, maxLen];
        private bool[,] conflicts = new bool[maxLen, maxLen];
        private double[,] confd = new double[maxLen, maxLen];
        private double distanciaSeguridad = 0.0;

        /// <summary>
        /// Leer el numero de FligthPlans añadidos a la lista
        /// </summary>
        /// <returns></returns>
        public int GetLen()
        {
            return len;
        }
        /// <summary>
        /// Leer la distancia de seguridad
        /// </summary>
        /// <returns></returns>
        public double GetDistanciaSeguridad()
        {
            return this.distanciaSeguridad;
        }
        /// <summary>
        /// Modificar la distancia de seguridad. Usa el valor absoluto
        /// </summary>
        /// <param name="d"></param>
        public void SetDistanciaSeguridad(double d)
        {

            this.distanciaSeguridad = Math.Abs(d);
        }
        /// <summary>
        /// Leer el FligthPlan en un indice
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public FlightPlan GetFlightAtIndex(int index)
        {
            if (index < 0 || index >= len)
            {
                return null;
            }
            return flights[index];
        }
        /// <summary>
        /// Añadir un FligthPlan
        /// </summary>
        /// <param name="fligth"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Añadir un FligthPlan desde consola
        /// </summary>
        /// <param name="checkInteractions"></param>
        /// <returns></returns>
        public FlightPlan AddFromConsole(bool checkInteractions = true)
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
            if (checkInteractions)
            {
                this.CheckInteractions();
            }
            return fligth;
        }
        /// <summary>
        /// Añade n FligthPlans desde consola
        /// </summary>
        /// <param name="nAviones"></param>
        public void AddNConsole(int nAviones)
        {
            int i = 0;
            while (i < nAviones)
            {
                this.AddFromConsole(false);
                i++;
            }
            this.CheckInteractions();
        }
        /// <summary>
        /// Comprueva las minimas distancias posibles entre aviones(independiente de velocidad)
        /// para determinar si la modificacion de la velocidad de uno puede generar un conflicto.
        /// Guarda 2 tablas:
        ///     * interactions: tabla booleana con las interacciones.
        ///     * mind: tabla de distancias minimas possibles (para no tener que recalcular en caso 
        ///       de modificar la distancia de seguridad).
        /// </summary>
        public void CheckInteractions()
        {
            int i = 0;
            int j = 0;
            double[] data = new double[2];
            while (i < len)
            {
                j = i;
                while (j < len)
                {
                    data = this.flights[i].Interaction(this.flights[j], this.distanciaSeguridad);
                    this.interactions[i, j] = Convert.ToBoolean(data[1]);
                    this.interactions[j, i] = this.interactions[i, j];
                    this.mind[i, j] = data[0];
                    this.mind[j, i] = data[0];
                    j++;
                }
                i++;
            }
        }
        /// <summary>
        /// Mueve todos los aviones n moves
        /// </summary>
        /// <param name="moves"></param>
        public void MoveAll(int moves)
        {
            int i = 0;
            while (i < this.len)
            {
                this.flights[i].Mover(10);
                i++;
            }
        }
        /// <summary>
        /// Escribe todos los FligthPlans por consola
        /// </summary>
        public void WriteFligthPlans()
        {
            int i = 0;
            while (i < this.len)
            {
                this.flights[i].EscribeConsola();
                i++;
            }
        }
        /// <summary>
        /// Escribe la tabla de interacciones en la consola
        /// </summary>
        public void WriteInteractions()
        {
            int i = 0;
            int j;
            string row, separator;
            while (i < this.len)
            {
                j = 1;
                if (interactions[i, 0])
                {
                    row = "T";
                }
                else
                {
                    row = "F";
                }

                separator = "-";
                while (j < this.len)
                {

                    if (interactions[i, j])
                    {
                        row += "T";
                    }
                    else
                    {
                        row += "F";
                    }
                    separator += "+-";
                    j++;
                }
                Console.WriteLine(row);
                Console.WriteLine(separator);
                i++;
            }
        }
        /// <summary>
        /// Escribe toda la informacion del objeto FligthList
        /// </summary>
        public void WriteAll()
        {
            Console.WriteLine("Distancia de seguridad: {0}", this.distanciaSeguridad);
            Console.WriteLine("Numero de aviones: {0}", this.len);
            this.WriteFligthPlans();
            this.WriteInteractions();
        }
    }
}
