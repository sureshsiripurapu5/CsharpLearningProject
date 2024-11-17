using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearningProject.Basics.ControlStatements
{
     class IfElse
    {
        int x = 10;
         int y = 11;

        public void SimpleIFStatement()
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
        }

        public void IfElseStatement()
        {
            if(y % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
        }


        public void IfElseIfLadderStatement()
        {
            Console.WriteLine("Enter a number");
            int x=int.Parse(Console.ReadLine());

            if (x < 0 || x > 100)
                Console.WriteLine("Invalid");

            else if (x >= 90 && x <= 100)
                Console.WriteLine("A grade");
            else if (x >= 80 && x < 90)
                Console.WriteLine("B grade");
            else if (x >= 70 && x < 80)
                Console.WriteLine("C grade");
            else if (x >= 60 && x < 70)
                Console.WriteLine("D grade");
            

        }
        public static void Main(string[] args)
        {
            IfElse ifElse = new IfElse();
            ifElse.SimpleIFStatement();
            ifElse.IfElseStatement();
            ifElse.IfElseIfLadderStatement();
        }
       
    }
}
