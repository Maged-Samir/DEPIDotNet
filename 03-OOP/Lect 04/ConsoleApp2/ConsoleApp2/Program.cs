using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Course c1 = new ProgrammingCourse(1, "C# Programming", 40, "C#", "Beginner");
            //Course c2 = new DesignCourse(2, "Graphic Design", 30, "Photoshop", "Intermediate");
            //Course c3 = new MathCourse(3, "Calculus I", 50, 101,102);

            //Course[] courses = new Course[] { c1, c2, c3 };

            Track t1 = new Track(101,"Software Development", 120, 3);

            t1.AddCourse(new ProgrammingCourse(1, "C# Programming", 40, "C#", "Beginner"));
            t1.AddCourse(new DesignCourse(2, "Graphic Design", 30, "Photoshop", "Intermediate"));
            t1.AddCourse(new MathCourse(3, "Calculus I", 50, 101,102));

            t1.DisplayTrackInfo();

            //t1["Graphic Design"].Display();
        }
    }
}
