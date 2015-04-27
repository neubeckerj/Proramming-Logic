using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Student
    {
        public string _name { get; set; }
        public int _number;
        public Student(string name, int id)
        {
            this._name = name;
            this._number = id;
        }
        
    }
}
