using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public Person()
            {

            }
            public Person(int Id,string Name,int Age)
            {
                this.Id = Id;
                this.Name = Name;
                this.Age = Age; 
            }

            public string PrintDetails()
            {
                return $"Id: {Id}, Name: {Name}, Age: {Age}";
            }
        }
        class Player : Person
        {
            //public int Id { get; set; }
            //public string Name { get; set; }
            //public int Age { get; set; }
            public int Number { get; set; }
            public string Position { get; set; }

            public Player() :base()
            {
                
            }
            public Player(int number, string position)
            {
                Number = number;
                Position = position;
            }

            public Player(int id, string name, int age, int number, string position) 
            {
                Id = id;
                Name = name;
                Age = age;
                Number = number;
                Position = position;
            }

            //Method Hiding  => overriding
            //Extend the PrintDetails method
            public string PrintDetails()
            {
                //Method Hiding  => overriding
                //return $"Id: {Id}, Name: {Name}, Number: {Number}, Position: {Position} \n";

                //Extend the PrintDetails method
                return base.PrintDetails() + $", Number: {Number}, Position: {Position} \n";
            }
        }
        class Coach : Person
        {
            //public int Id { get; set; }
            //public string Name { get; set; }
            //public int Age { get; set; }
            public int Experience { get; set; }
            public Coach(int id, string name, int age, int experience)
            {
                Id = id;
                Name = name;
                Age = age;
                Experience = experience;
            }
        }
        class Team
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Color { get; set; }
            public Player[] Players { get; set; }
            public Coach Coach { get; set; }


            public Team()
            {
            }
            public Team(int id) : this()
            {
                Id = id;
            }
            public Team(int id, string name) : this(id)
            {
                //Id = id;
                Name = name;
            }
            public Team(int id, string name, int age) : this(id, name)
            {
                //Id = id;
                //Name = name;
                Age = age;
            }
            public Team(int id, string name, int age, string color) : this(id, name, age)
            {
                //Id = id;
                //Name = name;
                //Age = age;
                Color = color;
            }
            public Team(int id, string name, int age, string color, Player[] players) : this(id, name, age, color)
            {
                //Id = id;
                //Name = name;
                //Age = age;
                //Color = color;
                Players = players;
            }
            public Team(int id, string name, int age, string color, Player[] players, Coach coach) : this(id, name, age, color, players)
            {
                //Id = id;
                //Name = name;
                //Age = age;
                //Color = color;
                //Players = players;
                Coach = coach;
            }

            public string PrintDetails()
            {
                string txt = $"Id: {Id}, Name: {Name}, Color: {Color}, Players Count: {Players.Length} ,Coach Name :{Coach.Name} \n";

                for (int i = 0; i < Players.Length; i++)
                {
                    txt += Players[i].PrintDetails();
                }

                return txt;
            }
            public int this[string name]
            {
            //t[name]  = 20;
                get
                {
                    for(int i=0;i<Players.Length;i++)
                    {
                        if (Players[i].Name == name)
                            return Players[i].Number;
                    }
                    return 0;
                }
                set
                {
                    for (int i = 0; i < Players.Length; i++)
                    {
                        if (Players[i].Name == name)
                            Players[i].Number = value;
                    }
                }
            }


        }
        static void Main(string[] args)
        {
            #region Array Of Class Vs Array Of Struct
            //Array Of Struct
            //Array Of Class
            //Console.WriteLine("Enter Number Of Products");
            //int numberOfProudcts = int.Parse(Console.ReadLine());
            //Product[] prds = new Product[numberOfProudcts];

            //for (int i = 0; i < numberOfProudcts; i++)
            //{
            //    prds[i] = new Product();
            //    Console.WriteLine($"Enter Id of Product {i + 1}");
            //    prds[i].Id = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Enter Name of Product {i + 1}");
            //    prds[i].Name = Console.ReadLine();
            //    Console.WriteLine($"Enter Qty of Product {i + 1}");
            //    prds[i].Qty = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("--------------------------------------");
            //for (int i = 0; i < numberOfProudcts; i++)
            //{
            //    Console.WriteLine(prds[i].PrintDetails());
            //} 
            #endregion

            #region Class Contain Array Of Another Class
            //Design Classes
            //Team , Player

            //Player p1 = new Player(1, "Player One", 25, 10, "Forward");
            //Player p2 = new Player(2, "Player Two", 27, 8, "Midfielder");


            //Player[] players = new Player[] { p1, p2 };

            //Coach c1 = new Coach(1, "Coach One", 45, 20);


            //Team t1 = new Team(1, "Team A", 50, "Red", players, c1);

            ////T[name]  = 20;
            //t1["Player One"] = 99;

            //Console.WriteLine(t1.PrintDetails());


            #endregion

            #region This Keyword
            //this Keyword in C#
            //Refere to Current instance
            //Constructor Chaining in C#
            //C# Indexer
            //Extention Methods 
            #endregion

            #region Inheritance
            //Player p1 = new Player(1, "Player One", 25, 10, "Forward");
            //Console.WriteLine(p1.PrintDetails());


            //Coach c1 = new Coach(1, "Coach One", 45, 20);
            //Console.WriteLine(c1.PrintDetails());



            //Person p = new Person();
            //Console.WriteLine(p.PrintDetails());

            //Player p1 = new Player(101, "Striker");
            //Console.WriteLine(p1.PrintDetails()); 
            #endregion

        }
    }
}
