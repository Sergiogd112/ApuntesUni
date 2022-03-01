using System;
using System.Collections.Generic;
using System.Text;

namespace FlightLib
{
    public class FlightPlan
    {
        // Atributos

        string id; // identificador
        Position currentPosition; // posicion actual
        Position finalPosition; // posicion final
        double velocidad;

        // Constructures
        public FlightPlan()
        {
            this.id = "";
            this.currentPosition = new Position(0, 0);
            this.finalPosition = new Position(0, 0);
            this.velocidad = 0;
        }
        public FlightPlan(string id, double cpx, double cpy, double fpx, double fpy, double velocidad)
        {
            this.id = id;
            this.currentPosition = new Position(cpx, cpy);
            this.finalPosition = new Position(fpx, fpy);
            this.velocidad = velocidad;
        }
        public string GetId()
        {
            return this.id;
        }
        // Metodos
        public void SetVelocidad(double velocidad)
        // setter del atributo velocidad
        { this.velocidad = velocidad;  }

        public void Mover(double tiempo)
        // Mueve el vuelo a la posición correspondiente a viajar durante el tiempo que se recibe como parámetro
        {
            //Calculamos la distancia recorrida en el tiempo dado
            double distancia = tiempo * this.velocidad / 60;

            //Calculamos las razones trigonométricas
            double hipotenusa = Math.Sqrt((finalPosition.GetX() - currentPosition.GetX()) * (finalPosition.GetX() - currentPosition.GetX()) + (finalPosition.GetY() - currentPosition.GetY()) * (finalPosition.GetY() - currentPosition.GetY()));
            double coseno = (finalPosition.GetX() - currentPosition.GetX()) / hipotenusa;
            double seno = (finalPosition.GetY() - currentPosition.GetY()) / hipotenusa;

            //Caculamos la nueva posición del vuelo
            double x = currentPosition.GetX() + distancia * coseno;
            double y = currentPosition.GetY() + distancia * seno;

            Position nextPosition = new Position(x, y);
            if (this.currentPosition.Distancia(nextPosition) < hipotenusa)
            {
                this.currentPosition = nextPosition;
            }
            else
            {
                this.currentPosition = this.finalPosition;
            }
        }
        public bool EstaDestino()
        {
            return this.currentPosition == this.finalPosition;
        }
        public bool Conflicto(FlightPlan b,double distanciaSeguridad)
        {
            return this.currentPosition.Distancia(b.currentPosition) >= distanciaSeguridad;
        }
        public void EscribeConsola()
        // escribe en consola los datos del plan de vuelo
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Datos del vuelo: ");
            Console.WriteLine("Identificador: {0}", id);
            Console.WriteLine("Velocidad: {0:F2}", velocidad);
            Console.WriteLine("Posición actual: ({0:F2};{1:F2})", currentPosition.GetX(), currentPosition.GetY());
            if (this.EstaDestino())
            {
                Console.WriteLine("Ha llegado a su destino");
            }
            else
            {
                Console.WriteLine("No ha llegado a su destino");
            }
            Console.WriteLine("******************************");
        }
        
    }
}
