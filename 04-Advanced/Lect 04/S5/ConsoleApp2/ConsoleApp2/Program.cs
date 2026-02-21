using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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

        public Rect(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public void ApplyTesting()
        {
            Console.WriteLine("Apply Testing ...");
        }

        public int CalcArea()
        {
            return Width * Height;
        }

        void IShape.Display()
        {
            Console.WriteLine("Display From Ishape ....");
        }

        void ITest.Display()
        {
            Console.WriteLine("Display From ITest ....");
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
    class Doctor : IPerson
    {
        public void Display()
        {
            Console.WriteLine("I'm a Doctor");
        }
    }
    class Engineer : IPerson
    {
        public void Display()
        {
            Console.WriteLine("I'm an Engineer");
        }
    }
    class Operation
    {
        public static void Show(IPerson p)
        {
            p.Display();
        }
    }

    class Student : IComparable<Student>, ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student()
        {
            
        }
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Age}";
        }

        public int CompareTo(Student other)
        {
            return Id.CompareTo(other.Id);
        }

        public object Clone()
        {
            return new Student(Id, Name, Age);
        }

        //public int CompareTo(object obj)
        //{
        //    Student std = obj as Student;
        //    return Age.CompareTo(std.Age);
        //}
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface
            //Rect r1 = new Rect(5, 8);
            //Console.WriteLine(r1.CalcArea());
            //r1.ApplyTesting();
            //((ITest)r1).Display();


            //Operation.Show(new Doctor());
            //Operation.Show(new Engineer());

            #endregion
            #region IComparable
            //int[] arr = new int[] { 50, 40, 80, 20, 70, 100, 30 };

            //Array.Sort(arr);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //Student[] stds = new Student[]
            //{
            //  new Student(3,"Ali",15),
            //  new Student(2,"Mohamed",25),
            //  new Student(4,"Mona",20),
            //  new Student(1,"Esraa",21),
            //};

            //Array.Sort(stds);

            //for (int i = 0; i < stds.Length; i++)
            //{
            //    Console.WriteLine(stds[i]);
            //} 
            #endregion
            #region IClonable
            //Student s1 = new Student(1, "Esraa", 21);
            //Student s2 = (Student)s1.Clone();
            //Console.WriteLine(s2.ToString()); 
            #endregion

            #region Foreach
            //int[] arr = new int[] { 40, 80, 90, 20, 30, 70 };
            //string[] arr = new string[] { "Ahmed", "Mohamed", "Samy" };

            //foreach(string item in arr)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region Collections
            //Array => Fixed Size , Index ,Same DataType
            // int [] arr = new int [10];
            //Collections
            //ArrayList arr = new ArrayList();   //dynamic Size
            //arr.Add(10);
            //arr.Add(20);
            //arr.Add(30);
            //arr.AddRange(new int[] { 40, 50, 60 });
            //arr.Add("Ahmed");
            //arr.Add("Ali");

            ////arr.Insert(2, 100);
            ////arr.Remove(20);
            ////arr.RemoveAt(3);
            ////arr.RemoveRange(2, 3);


            //foreach(object item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Boxing&UnBoxing
            //Operations 
            #endregion
            #region Generic Collections
            //Generic Collections
            //List<int> grads = new List<int>() { 8,9,6,2,5,26};

            //grads.Add(1);
            //grads.Add(2);
            //grads.Add(3);
            //grads.AddRange(new int[] { 4, 5, 6 });

            //grads.Remove(26);
            //grads.RemoveAt(2);

            //foreach (int grad in grads)
            //{
            //    Console.WriteLine(grad);
            //}

            //List<Student> stds = new List<Student>()
            //{
            //  new Student(1,"Ahmed",15),
            //  new Student(2,"Mona",15),
            //  new Student(3,"Ali",15),
            //};

            //foreach (Student student in stds)
            //{
            //    Console.WriteLine(student);
            //} 
            #endregion
            #region Dictionary  
            //Dictionary<int,string> notebook = new Dictionary<int,string>();
            //notebook.Add(111, "Ahmed");
            //notebook.Add(222, "Mona");
            //notebook.Add(333, "Osama");
            //notebook.Add(444, "Yousef");


            //foreach (KeyValuePair<int,string> item in notebook)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}


            //Dictionary<string,List<string>>  MCQQuestions = new Dictionary<string,List<string>>(); 


            //Stack<int> st1 = new Stack<int>();

            #endregion
        }
    }
}
