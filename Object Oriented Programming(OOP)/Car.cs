using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Object_Oriented_Programming_OOP_
{
    internal class Car
    {
        // Constructor
        private string _name; // private field trypically used for storing data.
        private int _hp;
        private string color;

        public Car(string name, int hp = 0, string color = "black") 
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _color = color;
        }
        public void Drive() { 
            Console.WriteLine( "Car is driving"); 
        }

        public void Stop() {
            Console.WriteLine( "Car stopped !");
        }

        public void Details()
        {
            Console.WriteLine("The " + + _color +  "car" + _name + "has" + _hp + " hp.");
        }
    }
}
