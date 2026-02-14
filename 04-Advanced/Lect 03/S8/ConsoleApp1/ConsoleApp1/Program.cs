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
        //Member Variables
        int[] arr;
        int tos;
        public StackOfInt(int size)
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
        //Member Variables
        string[] arr;                 //change
        int tos;
        public StackOfString(int size)
        {
            arr = new string[size];        //change
            tos = 0;
        }

        public void Push(string item)           //change
        {
            if (tos < arr.Length)
                arr[tos++] = item;
        }
        public string Pop()                  //change
        {
            if (tos > 0)
                return arr[--tos];
            else
                return null;                //change
        }

    }
    class StackOfGeneric<T>  // where T :class
    {
        //Member Variables
        T[] arr;                 //change
        int tos;
        public StackOfGeneric(int size)
        {
            arr = new T[size];        //change
            tos = 0;
        }

        public void Push(T item)           //change
        {
            if (tos < arr.Length)
                arr[tos++] = item;
        }
        public T Pop()                  //change
        {
            if (tos > 0)
                return arr[--tos];
            else
                return default;                //change
        }

    }
    static class Helper
    {
        public static void SumGroupOfNumbers(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
        }

        public static void Print<T, T1>(T Value, T1 text)
        {
            Console.WriteLine($"{text}");
            Console.WriteLine(Value);
        }

        public static void PrintPattern(int num = 10, string pattern = "*")
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write(pattern);
            }
        }

        public static int Sum(int x, int y, out int mul)
        {
            mul = x * y;
            return x + y;
        }

    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee(int id = 0, string name = null, int salary = 0)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }

    class InvaliedAgeException :Exception
    {
        public InvaliedAgeException():base("Your Age must be under 18 ")
        {
             
        }
    }
    class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }

        private int age;
        public int Age 
        {
            get { return age; }
            set 
            {   if(value < 18)
                age = value;
                else
                    throw new InvaliedAgeException();
            }
        }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }


        public override string ToString()
        {
            return $"{Id} - {Name} Age : {Age}";
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {

            #region Generics
            //StackOfInt st1 = new StackOfInt(100);
            //st1.Push(50);
            //st1.Push(40);
            //st1.Push(60);
            //Console.WriteLine(st1.Pop());


            //StackOfString st2 = new StackOfString(100);
            //st2.Push("Ahmed");
            //st2.Push("Ehab");
            //st2.Push("Abdelrahman");
            //Console.WriteLine(st2.Pop());
            //Console.WriteLine(st2.Pop());


            //StackOfGeneric<int> st3 = new StackOfGeneric<int>(100);
            //st3.Push(50);
            //st3.Push(40);
            //st3.Push(60);
            //Console.WriteLine(st3.Pop());

            //StackOfGeneric<string> st4 = new StackOfGeneric<string>(100);
            //st4.Push("Ahmed");
            //st4.Push("Ehab");
            //st4.Push("Abdelrahman");
            //Console.WriteLine(st4.Pop());
            //Console.WriteLine(st4.Pop());


            //StackOfGeneric<Employee> emps = new StackOfGeneric<Employee>(100);
            //emps.Push(new Employee(101, "Ahmed", 2000));
            //emps.Push(new Employee(102, "Ali", 2000));
            //emps.Push(new Employee(103, "Mona", 2000));
            //Console.WriteLine(emps.Pop());
            //Helper.Print(50,"HI");


            //Helper.SumGroupOfNumbers(new int [] { 1, 2, 3, 4, 5, 6 });
            //Helper.SumGroupOfNumbers(1, 2, 3, 4, 5, 6);


            //Helper.PrintPattern(30);
            //Helper.PrintPattern(10, "-");
            //Helper.PrintPattern();
            //Helper.PrintPattern(pattern: "/",num:50);

            //int result = 0;
            //Console.WriteLine(Helper.Sum(5, 6, out result)); ;
            //Console.WriteLine(result) 
            #endregion;      


            //try
            //{
            //    Console.WriteLine("Enter Your Num");
            //    int num = int.Parse(Console.ReadLine());
            //    int result = 20 / num;
            //    Console.WriteLine(result);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Enetr VCorrect Number");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("eeeeee");
            //}

            try
            {
                Student s = new Student(101, "Ali", 20);
                Console.WriteLine(s.ToString());
            }
            catch (InvaliedAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("contact us");
            }


        }
    }
}
