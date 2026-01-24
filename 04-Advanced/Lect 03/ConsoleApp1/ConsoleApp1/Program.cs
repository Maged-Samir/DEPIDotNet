using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Test
    {
        public int Entity { get; set; }
    }
    class stackOfInt
    {
        //Member Variables (Storage)
        int[] arr;
        int tos;

        public stackOfInt(int size = 10)
        {
           arr = new int[size]; 
           tos = 0;
        }
        //Operations
        public void Push(int item)
        {
            if (tos < arr.Length)
            arr[tos++] = item;
        }
        public int Pop()
        {
            if (tos>0)
            return arr[--tos];
            else return -1;
        }
    }
    class stackOfString
    {
        //Member Variables (Storage)
        string[] arr;
        int tos;

        public stackOfString(int size = 10)
        {
            arr = new string[size];
            tos = 0;
        }
        //Operations
        public void Push(string item)
        {
            if (tos < arr.Length)
                arr[tos++] = item;
        }
        public string Pop()
        {
            if (tos > 0)
                return arr[--tos];
            else return null;
        }
    }
    class stackOfGeneric <T> :Test  where T :class    //Constraints 
    {
        //Member Variables (Storage)
        T [] arr;
        int tos;

        public stackOfGeneric(int size = 10)
        {
            arr = new T[size];
            tos = 0;
        }
        //Operations
        public void Push(T item)
        {
            if (tos < arr.Length)
                arr[tos++] = item;
        }
        public T Pop()
        {
            if (tos > 0)
                return arr[--tos];
            else return default;
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $" Student No :{Id} - Student Name : {Name} - Student Age : {Age}";
        }
    }

    static class  Helper
    {
        //public static void Swap(ref int x,ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void Swap(ref string x, ref string y)
        //{
        //    string temp = x;
        //    x = y;
        //    y = temp;
        //}

        public static void Swap<T> (ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //stackOfInt s1 = new stackOfInt(100);
            //s1.Push(14);
            //s1.Push(10);
            //s1.Push(7);
            //s1.Push(3);
            //Console.WriteLine(s1.Pop());
            //Console.WriteLine(s1.Pop());
            //Console.WriteLine(s1.Pop());

            //stackOfString s2 = new stackOfString(100);
            //s2.Push("Ahmed");
            //s2.Push("Mohamed");
            //s2.Push("Ali");
            //Console.WriteLine(s2.Pop());
            //Console.WriteLine(s2.Pop());
            //Console.WriteLine(s2.Pop());


            //stackOfGeneric<int> s3 = new stackOfGeneric<int>();
            //s3.Push(50);
            //s3.Push(100);
            //s3.Push(150);
            //Console.WriteLine(s3.Pop());


            //stackOfGeneric<double> s4 = new stackOfGeneric<double>();
            //s4.Push(4.5);
            //s4.Push(5.8);
            //Console.WriteLine(s4.Pop());

            //stackOfGeneric<Student> stds = new stackOfGeneric<Student>(100);
            //stds.Push(new Student(1, "Yousef", 20));
            //stds.Push(new Student(2, "Hossam", 24));
            //stds.Push(new Student(3, "Mona", 18));

            //Console.WriteLine(stds.Pop());
            //Console.WriteLine(stds.Pop());

            //int a = 5;
            //int b = 6;

            //Helper.Swap<int>(ref a,ref b);

            //Console.WriteLine($"Result of A {a}");
            //Console.WriteLine($"Result of B {b}");


            //string name1 = "ahmed";
            //string name2 = "ali";


            //Helper.Swap<string>(ref name1, ref name2);

            //Console.WriteLine($"Result of Na1 {name1}");
            //Console.WriteLine($"Result of Na2 {name2}");


        }
    }
}
