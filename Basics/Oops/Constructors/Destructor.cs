using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearningProject.Basics.Oops.Constructors
{
     class Destructor
    {
        public Destructor() {
            Console.WriteLine("Default constructor");

        }

         ~Destructor() {
            Console.WriteLine("The destructor is also invoked implicitly,which is used to destroy the objects");
        }

        public static void Main(string[] args) { 
            Destructor destructor = new Destructor();
            Destructor destructor1 = new Destructor();
           /* destructor = null;
            destructor1 = null;
            GC.Collect();
            GC.WaitForPendingFinalizers(); */
           
        }
    }
}
