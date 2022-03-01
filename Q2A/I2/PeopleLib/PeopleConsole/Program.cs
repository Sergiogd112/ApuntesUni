using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleLib;

namespace PeopleConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two objects “p1” and “p2” 
            CPerson p1 = new CPerson(22, 165, "Ana");
            CPerson p2 = new CPerson(19, 180, "Juan");

            // Write a message showing who is the oldest one
            if (p1.IsOlderThan(p2))
            {
                Console.WriteLine(p1.GetName() + " is older than " +
                p2.GetName());
            }
            else
            {
                Console.WriteLine(p2.GetName() + " is older than " +
                p1.GetName());
            }
            // Copy the age value of “p2” into “p1” 
            p2.CopyAgeTo(p1);
            // Show the age of “p1” on the screen

            Console.WriteLine("p1 is " + p1.GetAge());
            // Copy the values of “p2” into “p1” 
            p1 = p2.GetCopy();
            // Show “p1” on the screen


            Console.WriteLine(p1.GetName() + " is " + p1.GetAge());
        }
    }
}
