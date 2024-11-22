using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearningProject.Basics.Arrays
{
    internal class SampleArray
    {
        public static void Main(string[] args)
        {
            int[] arrayName = new int[5];  //declaration
            arrayName[0] = 1;  //initiliazation
            arrayName[1] = 2;
            arrayName[2] = 3;
            arrayName[3] = 4;
            arrayName[4] = 5;
            //The array size is 5, so if we try to store the value over than 5 it will give exception
            //arrayName[5] = 6;
            //System.IndexOutOfRangeException


            //traversing the array using traditional for loop
            for(int i = 0; i < arrayName.Length; i++) 
                Console.WriteLine(arrayName[i]);
        }
    }
}
