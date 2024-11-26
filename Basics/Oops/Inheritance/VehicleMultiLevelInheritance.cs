using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearningProject.Basics.Oops.Inheritance
{
     class VehicleMultiLevelInheritance
    {
        public void Color()
        {
            Console.WriteLine("The color of the vehicle is red");
        }
    }

    class Car : VehicleMultiLevelInheritance
    {
        public void CarMakesSound()
        {
            Console.WriteLine("sound");
        }
    }

    class Bike : Car { 
        public void BikeSpeed()
        {
            Console.WriteLine("bike speedometer");
        }
       /* public static void Main(string[] args)
        {
            Bike bike = new Bike();
            bike.Color();
            bike.CarMakesSound();
            bike.BikeSpeed();

        } */
    }


    
}
