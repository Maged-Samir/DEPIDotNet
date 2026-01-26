using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    enum Gender
    {
        Male,
        Female
    }
    class InvaliedAgeException: Exception
    {
        public InvaliedAgeException():base("Your Age Must be between 1 and 18 ")
        {
           HelpLink = "test.com";
            //Message = "ddddddddd";
        }
    }
    class Student  : IComparable ,ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        int age;
        public int Age
        {
            set
            {
                if (value > 0 && value < 18)
                    age = value;
                else
                    throw new InvaliedAgeException();
            }
            get { return age; }
        }
        public Gender Gender { get; set; }

        public Student()
        {

        }
        public Student(int Id, string Name, int Age,Gender Gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
        }

        public override string ToString()
        {
            return $"Student Info {Id} - {Name} - {Age} - {Gender}";
        }

        public int CompareTo(object obj)
        {
           Student student = obj as Student;
           return Id.CompareTo(student.Id);
        }

        public object Clone()
        {
           return new Student(Id, Name, Age,Gender);
        }
    }





    interface ITest
    {
        void ApplyTesting();
        void Display();
    }
    interface IShap
    {
        int CalcArea();
        void Display();
    }
    class Rect : IShap, ITest
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void ApplyTesting()
        {
            Console.WriteLine("Shape Testing");
        }

        public int CalcArea()
        {
           return Width  * Height;
        }


        void IShap.Display()
        {
            Console.WriteLine("Display Of IShape");
        }

        void ITest.Display()
        {
            Console.WriteLine("Display Of ITest");
        }
    }

    interface IReadable
    {
        void Read();
    }
    interface IWritable : IReadable
    {
        void Write();
    }
    class Device : IWritable
    {
        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }

    interface IPerson
    {
        void Display();
    }
    class Engineer : IPerson
    {
        public void Display()
        {
            Console.WriteLine("I'm Engin....");
        }
    }
    class Doctor : IPerson
    {
        public void Display()
        {
            Console.WriteLine("I'm Doc...");
        }
    }

    static class Operation
    {
        public static void Display(IPerson p)
        {
            p.Display();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exceptions
            //try
            //{
            //    Console.WriteLine("Enter Number");
            //    int num = int.Parse(Console.ReadLine());
            //    int result = 20 / num;
            //    Console.WriteLine(result);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (DivideByZeroException e)
            //{
            //        Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    Student s1 = new Student(1, "Ahmed", 22);
            //    Console.WriteLine(s1.ToString());
            //}
            //catch (InvaliedAgeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Executed...");
            //} 
            #endregion

            #region Interface
            //Rect r1 = new Rect();
            //r1.Width = 100;
            //r1.Height = 100;

            //Console.WriteLine(r1.CalcArea());
            //((IShap)r1).Display();


            //r1.ApplyTesting();

            ////IShap shap = new IShap(); XXXXXX

            //IPerson p = new Engineer();
            //IPerson p2 = new Doctor();

            //Operation.Display(new Engineer());
            //Operation.Display(new Doctor()); 
            #endregion

            #region ICombarable & IClonable
            //int[] arr = { 40, 50, 80, 70, 15, 50, 30, 10, 100 };

            //Array.Sort(arr);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Student[] stds = new Student[]
            //{
            //    new Student(2,"Mona",2),
            //    new Student(5,"Sally",3),
            //    new Student(1,"Asmaa",4),
            //    new Student(3,"Yousef",2),
            //    new Student(4,"Mohamed",1)
            //};

            //Array.Sort(stds);

            //for (int i = 0; i < stds.Length; i++)
            //{
            //    Console.WriteLine(stds[i].ToString());
            //}


            //Student s1 = new Student(1, "Ahmed", 12);
            //Student s2 = (Student)s1.Clone();

            //Console.WriteLine(s2.ToString());

            #endregion

            #region Enum

            //Gender g = (Gender)1;
            //Console.WriteLine(g);

            //Student s1 = new Student(1, "Mona", 12, Gender.Female);
            //Console.WriteLine(s1.ToString()); 
            #endregion
        }
    }
}
