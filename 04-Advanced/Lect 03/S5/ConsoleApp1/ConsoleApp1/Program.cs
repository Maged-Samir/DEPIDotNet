using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StackOfInt
    {
        int[] arr;
        int tos;

        public StackOfInt(int size = 10)
        {
            arr = new int[size];
            tos = 0;
        }

        public void Push(int item)
        {
            if (tos < arr.Length)
                arr[tos++] = item;
        }
        public int Pop()
        {
            if (tos > 0)
                return arr[--tos];
            else
                return -1;
        }

    }
    class StackOfString
    {
        string[] arr;    //change
        int tos;

        public StackOfString(int size = 10)
        {
            arr = new string[size];      //change
            tos = 0;
        }

        public void Push(string item)        //change
        {
            if (tos < arr.Length)
                arr[tos++] = item;
        }
        public string Pop()               //change
        {
            if (tos > 0)
                return arr[--tos];
            else
                return null;             //change
        }

    }
    class StackOfGeneric<T> //where T : struct
    {
        T[] arr;    //change
        int tos;

        public StackOfGeneric(int size = 10)
        {
            arr = new T[size];      //change
            tos = 0;
        }

        public void Push(T item)        //change
        {
            if (tos < arr.Length)
                arr[tos++] = item;
        }
        public T Pop()               //change
        {
            if (tos > 0)
                return arr[--tos];
            else
                return default;             //change
        }

    }
    class Helper
    {
        public static void Print<T>(T s)
        {
            Console.WriteLine(s);
        }
    }
    public sealed class InvalidAgeException : Exception
    {
        public InvalidAgeException(int x):base($"You have Entered : {x} ,Your Student Age Must be less than 18 years")
        {
            HelpLink = "www.student.com";
            //Message = "555"; XXXXXXX
        }
    }

    enum Gender
    {
       Male,
       Female
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }


        int age;
        public int Age
        {
            get { return age; }
            set
            { 
                if(value < 18)
                age = value; 
                else
                    throw new InvalidAgeException(value);
            }
        }

        public Student(int id, string name, int age ,Gender gender)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Age} - {Gender}";
        }


    }



    internal class Program
    {
        static void Main(string[] args)
        {
            #region Stack
            //StackOfInt s1 = new StackOfInt(100);
            //s1.Push(50);
            //s1.Push(40);
            //s1.Push(30);

            //Console.WriteLine(s1.Pop());
            //Console.WriteLine(s1.Pop());


            //StackOfString s2 = new StackOfString(100);
            //s2.Push("Ali");
            //s2.Push("Ahmed");
            //s2.Push("Mohamed");

            //Console.WriteLine(s2.Pop());
            //Console.WriteLine(s2.Pop());

            #endregion
            #region Generic Class
            //StackOfGeneric<int> s1 = new StackOfGeneric<int>();
            //s1.Push(20);
            //s1.Push(40);
            //s1.Push(30);

            //Console.WriteLine(s1.Pop());
            //Console.WriteLine(s1.Pop());

            //StackOfGeneric<string> s2 = new StackOfGeneric<string>();
            //s2.Push("Ali");
            //s2.Push("Ahmed");
            //s2.Push("Mohamed");

            //Console.WriteLine(s2.Pop());
            //Console.WriteLine(s2.Pop());

            #endregion
            #region Generic Methods
            //Helper.Print<string>("Welllcome");
            //Helper.Print<int>(120);

            #endregion

            #region Exception Handeling
            //try
            //{
            //    Console.WriteLine("Please Enter Your Number");
            //    int num = int.Parse(Console.ReadLine());
            //    int result = 20 / num;
            //    Console.WriteLine(result);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please Enter Valid Number");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("You have Entered String");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("sssssssssss");
            //}
            //finally
            //{
            //    Console.WriteLine("TYYYYYYYYYYYYYYYYY");
            //} 
            #endregion
            #region Using Custom Exception
            //try
            //{
            //    Student S1 = new Student(101, "Ali", 22);
            //    Console.WriteLine(S1.ToString());
            //}
            //catch (InvalidAgeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    //Console.WriteLine("Student Age Must be Less than 18 year");
            //} 
            #endregion
            #region Enum
            //Gender g = Gender.Female;
            //Console.WriteLine(g);

            //Student s1 = new Student(101, "Mona", 15, Gender.Female);
            //Console.WriteLine(s1.ToString()); 
            #endregion
        }
    }
}
