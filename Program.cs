using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Abtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car1 = new Vehicle();
            //Corsa car2 = new Corsa();
            Console.WriteLine(car1.wheels);

            Console.ReadLine();
        }
    }
    abstract class Corsa
    {
        public int wheels = 4;
    }
    class Vehicle : Corsa
    {
        public int sparewheels = 1;
    }




}  

