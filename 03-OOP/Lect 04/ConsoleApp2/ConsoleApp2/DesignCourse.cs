using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class DesignCourse : Course
    {
        public string Tools { get; set; }
        public string Specialization { get; set; }
        public DesignCourse(int Id, string Name, int Hours, string Tools, string Specialization) : base(Id, Name, Hours)
        {
            this.Tools = Tools;
            this.Specialization = Specialization;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Tools : {Tools} , Specialization : {Specialization}");
        }
    }
}
