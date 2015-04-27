using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while (!done)
            {
                Console.Clear();
                string name = Question.AskForString("Course Name");
                int number = Question.AskForInteger("Course Number");
                int size = Question.AskForInteger("Course Size");
                Course course = new Course(name, number, size);
                done = Question.AskForBoolean("\nCorrect? y/n");                
            }
            Console.ReadKey();
        }
    }
}
