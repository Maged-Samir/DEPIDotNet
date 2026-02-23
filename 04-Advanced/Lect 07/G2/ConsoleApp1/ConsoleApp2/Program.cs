using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //public delegate void mydele(Exam ex, eventArgs eventArgs);

    public class eventArgs : EventArgs
    {
        public string Location { get; set; }
        public eventArgs(string location)
        {
            Location = location;
        }
    }
    public class Exam
    {
        
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public DateTime DateTime { get; set; }
        public Dictionary<string, List<string>> Questions { get; set; }

        public event EventHandler startExam; 

        public void OnStartExam()
        {
            startExam(this,new eventArgs("Giza"));
        }

        public Exam(int id, string subjectName, DateTime dateTime, Dictionary<string, List<string>> questions)
        {
            Id = id;
            SubjectName = subjectName;
            DateTime = dateTime;
            Questions = questions;
        }

        public override string ToString()
        {
            string txt = $"Exam Id : {Id} \t \t Subject : {SubjectName} \t\t Date : {DateTime} \n";
            foreach(KeyValuePair<string, List<string>> items in Questions)
            {
                txt += items.Key + " ? \n";
                foreach(string ans in items.Value)
                {
                    txt += ans + " \n";
                }
            }
            return txt ;
        }
    }

    public class Student
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

        public void AsnwerExam(object obj ,EventArgs args)
        {
            Exam ex = (Exam)obj;
            Console.WriteLine(ex.ToString());
            Console.WriteLine($"{Name} start answer the exam ");
        }

        public override string ToString()
        {
            return $"Student => No  {Id} - {Name} - {Age}";
        }
    }

    public class Teacher
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public Teacher(int id, string name, int salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void Monitor(object obj, EventArgs args)
        {
            Exam ex = (Exam)obj;
            Console.WriteLine($"{Name} start Monitor the exam , on {ex.DateTime}");
        }

        public override string ToString()
        {
            return $"Teacher => No {Id} - {Name} - {Salary}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string ,List<string>> questions = new Dictionary<string ,List<string>>();

            questions.Add("first question01", new List<string>() { "first ,second ,third" });
            questions.Add("first question02", new List<string>() { "first ,second ,third" });
            questions.Add("first question03", new List<string>() { "first ,second ,third" });

            Exam ex1 = new Exam(101, "Programming", DateTime.Now, questions);

            Student s1 = new Student(1, "Ahmed", 15);
            Teacher t1 = new Teacher(2, "Amany", 1000);

            ex1.startExam += s1.AsnwerExam;
            ex1.startExam += t1.Monitor;

            ex1.OnStartExam();

        }
    }
}
