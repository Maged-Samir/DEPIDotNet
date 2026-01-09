using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ProgrammingCourse : Course
    {
        public string Language { get; set; }
        public string Level { get; set; }

        public ProgrammingCourse(int Id, string Name, int Hours,string Language,string Level):base(Id,Name, Hours)
        {
           this.Language = Language;
           this.Level = Level;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Language : {Language} , Level : {Level}");
        }

    }
}
