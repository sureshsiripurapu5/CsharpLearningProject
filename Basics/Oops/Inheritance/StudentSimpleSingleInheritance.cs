using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearningProject.Basics.Oops.Inheritance
{
     public class StudentSimpleSingleInheritance
    {
        int id;
        string name;

        public StudentSimpleSingleInheritance(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void StudentDetails()
        {
            Console.WriteLine("The student id is:"+ id +" "+"and student name is:"+name );
        }




    }

    public class Library : StudentSimpleSingleInheritance 
    {
        int libraryId;
        string bookName;

        public Library(int id,string name, int libraryId, string bookName) :base(id,name)
        {
            
            this.libraryId = libraryId;
            this.bookName = bookName;
        }

        public void LibraryDetails() { 
            Console.WriteLine("The birary id is:"+ libraryId +" "+"and bookname is:"+bookName );
        }

        public static void Main(string[] args) {
            StudentSimpleSingleInheritance student = new StudentSimpleSingleInheritance(101,"suresh");
            student.StudentDetails();

            Library library = new Library(101,"suresh",1011,"harrypotter");
            library.StudentDetails();
            library .LibraryDetails();



        }
    }
}

//from the above program we have explicitly call the parent constructor with the para
