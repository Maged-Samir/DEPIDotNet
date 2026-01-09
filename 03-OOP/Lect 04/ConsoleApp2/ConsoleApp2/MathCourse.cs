using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MathCourse : Course
    {
        public int Credit { get; set; }
        public int Level { get; set; }
        public MathCourse(int id,string name ,int hours ,int credit, int level):base(id,name,hours)
        {
            Credit = credit;
            Level = level;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Credit : {Credit} , Level : {Level}");
        }
    }
}
