using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Product()
        {
            
        }
        //public Product(int id, string name, string description)
        //{
        //    Id = id;
        //    Name = name;
        //    Description = description;
        //}

        public override string ToString()
        {
            return $"{Id} - {Name} - {Description}";
        }
    }

    class Car
    {
        public int Model { get; }
        public string Motor { get; set; }
        public Car(int Model,string Motor)
        {
           this.Model = Model;
           this.Motor = Motor;
        }

        public override string ToString()
        {
            return $"{Model} - {Motor}";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Forech
            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            //for (int i =0;i<arr.Length;i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //foreach(int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] arr2 = new string[] { "AA", "BB", "CC" };

            //foreach(string item in arr2)
            //{
            //    Console.WriteLine(item); 
            //} 
            #endregion

            #region Collections
            //Array       => Fixed Size ,Index ,One DataType
            //Collections
            //ArrayList   => Not Fixed Size
            //Stack
            //Queue

            //ArrayList arr = new ArrayList();  //dynamic size
            //arr.Add(10);
            //arr.Add(20);
            //arr.Add(30);
            //arr.AddRange(new int[] { 40, 50, 60 });
            //arr.Add(20);
            //arr.Add("Ahmed");

            ////arr.Remove(20);
            ////arr.RemoveAt(2);
            ////arr.RemoveRange(3, 4);

            //foreach (object item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            // Boxing & UnBoxing  XXXXX
            // Operations         XXXXX


            //Stack s1 = new Stack();
            //s1.Push(100);
            //s1.Push(200);
            //s1.Push(400);
            //s1.Push("Ahmed");
            //Console.WriteLine(s1.Pop()); 
            #endregion

            #region Generic Collections
            // Generic Collections
            // List
            // Stack 
            // Queue

            //List<int> lst = new List<int>()
            //{
            //    20 , 20, 20, 20
            //};
            //lst.Add(100);
            //lst.AddRange(new int[] { 50, 60, 70 });

            //foreach (int i in lst)
            //{
            //    Console.WriteLine(i);
            //}

            ////lst.Add("Ahmed");

            //List<string> names = new List<string>();
            //names.Add("a");
            //names.Add("b");
            //names.Add("C");
            //foreach (string i in names)
            //{
            //    Console.WriteLine(i);
            //}

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //Console.WriteLine(stack.Pop()); 
            #endregion

            #region Dictionary
            //Dictionary<int, string> notebook = new Dictionary<int, string>()
            //{
            //    {111,"Mohamed" },
            //    {222, "Ahmed" }
            //};

            //notebook.Add(333, "Ali");
            ////notebook.Add(222, "Ahmed");
            ////notebook[444] = "Asmaa";

            //foreach (KeyValuePair<int,string> item in notebook)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}

            //Dictionary<int, Product> products = new Dictionary<int, Product>()
            //{
            //    { 1 , new Product(101,"Laptop","New Laptonb")},
            //    { 2 , new Product(102,"Mobile","Used")}

            //};

            //foreach (KeyValuePair<int, Product> product in products)
            //{
            //    Console.WriteLine($"{product.Value}");
            //} 
            #endregion

            #region Immutable Type
            ////Immutable 
            //string txt = "Hello ";
            //txt += "World";
            //Console.WriteLine(txt);

            ////Mutable
            //StringBuilder sb = new StringBuilder("Hello ");
            //sb.Append("World");
            //Console.WriteLine(sb.ToString());


            //Car c1 = new Car(2022, "Honda");
            ////c1.Model = 2025;
            //Console.WriteLine(c1.ToString()); 
            #endregion

            #region Object Intializer
            ////Object Intializer => new way to intiaize New Object
            //Product p = new Product() { Name="Mobile",Description ="New" };
            ////p.Id = 1;
            ////p.Name = "Test";
            ////p.Description = "Test";
            //Console.WriteLine(p.ToString()); 
            #endregion


        }
    }
}
