using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Course
    {
        private string _name;
        private int _number;
        public Student[] student;
 
        public Course(string name, int number, int size)
        {
            this.student = new Student [size];
            _name = name;
            _number = number;
            for (int i = 0; i < size; i++)
            {
                string sName = Question.AskForString("Student " + i + " Name");
                int sNum = Question.AskForInteger("Student " + i + " Number");
                student[i] = new Student(sName, sNum);
            }
            Console.WriteLine("\n" + name + " " + number);
             for (int i = 0; i < size; i++)
            {
                Console.WriteLine("     " + "Student " + i +", Name: " + student[i]._name + ", Number: " + student[i]._number);
            }
        }               
    }
}
