using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IShape
    {
        int CalcArea();
        void Display();
    }
    interface ITest
    {
        void ApplyTesting();
        void Display();
    }
    class Rect : IShape, ITest
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rect() { }
        public Rect(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void ApplyTesting()
        {
            Console.WriteLine("Apply Testing ....");
        }

        public int CalcArea()
        {
            return Width * Height;
        }

        void IShape.Display()
        {
            Console.WriteLine("Display Of Shape");
        }

        void ITest.Display()
        {
            Console.WriteLine("Display Of Testing");
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
        void Info();
    }
    class Doctor : IPerson
    {
        public void Info()
        {
            Console.WriteLine("I'm a Doctor");
        }
    }
    class Engineer : IPerson
    {
        public void Info()
        {
            Console.WriteLine("I'm a Engineer");
        }
    }
    class Operation
    {
        public static void DisplayInfo(IPerson p)
        {
            p.Info();
        }
    }


    class Student : IComparable<Student>, ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student()
        {
            
        }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }

        //public int CompareTo(object obj)
        //{
        //     Student s = obj as Student;
        //    return Id.CompareTo(s.Id);
        //}

        public int CompareTo(Student other)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            return new Student(Id, Name);
        }
    }







    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface
            //Rect r = new Rect(10, 20);
            //r.ApplyTesting();
            //Console.WriteLine(r.CalcArea());
            //((ITest)r).Display();


            //Operation.DisplayInfo(new Engineer());
            //Operation.DisplayInfo(new Doctor());






            //int[] arr = new int[] { 20, 40, 10, 50, 15 };

            //Array.Sort(arr);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //Student[] stds = new Student[]
            //{
            //  new Student(3,"Mohamed"),
            //  new Student(4,"Mona"),
            //  new Student(2,"Ali"),
            //  new Student(1,"Asmaa")
            //};

            //Array.Sort(stds);

            //for (int i = 0; i < stds.Length; i++)
            //{
            //    Console.WriteLine(stds[i]);
            //}


            //Student s1 = new Student(1,"Ahmed");
            //Student s2 = s1.Clone() as Student;

            #endregion

            #region Foreach
            //int[] arr = new int[] { 20, 40, 10, 50, 15 };

            ////for (int i = 0; i < arr.Length; i++)
            ////{
            ////    Console.WriteLine(arr[i]);
            ////}

            //foreach(int item in arr)
            //{
            //    Console.WriteLine(item);
            //}


            //string[] arr2 = new string[] { "Ahmed", "Mohamed", "Mona" };
            //foreach(string item in arr2)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Collections
            //Collections
            //int[] arr = { 1, 2, 3 };

            //ArrayList
            //ArrayList arr = new ArrayList(); //dynamic size
            //arr.Add(10);
            //arr.Add(20);
            //arr.Add(30);
            //arr.AddRange(new int[] { 10, 20, 30, 40 });
            //arr.Insert(2, 100);

            //arr.Remove(20);
            //arr.RemoveAt(1);
            //arr.RemoveRange(3, 3);

            //arr.Add("Ahmed");
            //arr.Add(new Student(1,"Ahmed"));

            //foreach(object item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Operation XXXXXXXXXXXXXXXX
            //Boxing&UnBoxing

            //Stack s1 = new Stack();
            //s1.Push(1);
            //s1.Push(2);
            //Console.WriteLine(s1.Pop());

            #endregion

            #region Generic Collections
            ////System.Collection.Generics
            //Stack<int> s1 = new Stack<int> ();
            //s1.Push(1);
            //s1.Push(2);
            //Console.WriteLine(s1.Pop());


            //Stack<string> s11 = new Stack<string>();
            //s11.Push("Mona");
            //s11.Push("Ali");
            //Console.WriteLine(s1.Pop());


            //List<string> lst = new List<string>()
            //{
            //    "Ahmed",
            //    "Ali",
            //    "Mona"
            //};
            //lst.Add("Mahmoud");

            //foreach (string item in lst)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Student> stds = new List<Student>()
            //{
            //  new Student(1,"Ahmed"),
            //  new Student(2,"sss")
            //}; 
            #endregion

            #region Dictionary
            //Dictionary<int, string> notebook = new Dictionary<int, string>();
            ////{
            ////    {111,"Ali" },
            ////    {222,"Mona" }
            ////};


            //notebook.Add(111, "Ahmed");
            //notebook.Add(222, "Mohamed");
            //notebook[333] = "Sayed";


            //foreach (KeyValuePair<int, string> item in notebook)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //} 
            #endregion  


        }
    }
}
