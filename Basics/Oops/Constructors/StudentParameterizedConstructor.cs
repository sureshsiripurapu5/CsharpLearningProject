using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearningProject.Basics.Oops.Constructors
{
     class StudentParameterizedConstructor
    {
        int studentId;
        string studentName;
        string collegeName;

        public StudentParameterizedConstructor(int studentId, string studentName, string collegeName)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.collegeName = collegeName;
        }

        public void ShowStudentDetails()
        {
            Console.WriteLine("The student id is:"+ studentId );
            Console.WriteLine("The student name is:"+ studentName );
            Console.WriteLine("The student clg name is:"+ collegeName );
        }

        public static void Main(string[] args) {
            StudentParameterizedConstructor student1 = new StudentParameterizedConstructor(101,"suresh","Klu");
            student1.ShowStudentDetails();
            StudentParameterizedConstructor student2 = new StudentParameterizedConstructor(102, "ramesh", "klu");
            student2.ShowStudentDetails();

                
        }

    }
}
