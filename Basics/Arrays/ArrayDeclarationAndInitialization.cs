using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearningProject.Basics.Arrays
{
    internal class ArrayDeclarationAndInitialization
    {
        public static void Main(string[] args)
        {
            int[] arrayName = { 1, 2, 3, 4, 5 };

            //traversingg the array
            for (int i = 0; i < arrayName.Length; i++)
            {
                Console.WriteLine(arrayName[i]);
            }

            //traversiong using for each loop
            foreach (int item in arrayName)
                { Console.WriteLine(item); }
            
                
            
        }
    }
}
