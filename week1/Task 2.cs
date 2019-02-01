using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        class Student  // create class with the name Student
        {
            private string name;  // name of the student
            private string id;  //  ID of the student
            private int yearofstudy;  //  student study year
            public Student(string name, string id)  //  create constructor with two parameter
            {
                this.name = name;   //  
                this.id = id;  //  id is entered         
            }
            public void Increment()  //  Method for incrementing the student's year of study
            {
                yearofstudy++;
            }
            public int YearofStudy  // This is done to access the yearofstudy private property.
            {
                get
                {
                    return yearofstudy;
                }
                set
                {
                    yearofstudy = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student("Yernur", "18BD110941");  // create a class object Student
            s.YearofStudy = 1;  //  the default value is 1
            s.Increment();  //  after the method, the value is incremented (+1), that is, equals 2
            Console.WriteLine(s.YearofStudy);  //  Show that the Increment method works (Output: 2)

        }
    }
}