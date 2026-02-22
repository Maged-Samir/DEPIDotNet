using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void myDele(Button btn);
    public class Button
    {
        public string Text { get; set; }
        public string Color { get; set; }
        public string Msg { get; set; }

        public event myDele Click;

        public void OnClick()
        {
            Click(this);
        }


    }
    class Page
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Minimized { get; set; }
        public bool Maximized { get; set; }

        public void ShowMessage(Button b)
        {
            Console.WriteLine($"Your Message {b.Msg} - {b.Text} - {b.Color}");
        }

    }
    class Form
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Minimized { get; set; }
        public bool Maximized { get; set; }

        public void DisplayMessage(Button b)
        {
            Console.WriteLine($"Your Message {b.Msg} - {b.Text} - {b.Color}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Event
            //Publisher - Subscripers
            /*
             * Define Delegate (Namespace)
             * Define Event using Delegate (Class Publisher)
             * Fire Event (Class Publisher)
             * 
             * 
             * Define Fun match the Delegate Signature (class Subscriper)
             * Assign Function to Event (Main) 
             * Fire event (Main)
             */


            //Button btn = new Button();
            //btn.Text = "Ok";
            //btn.Color = "Red";
            //btn.Msg = "Button Clicked";

            //Page p1 = new Page();
            //Form form = new Form();

            //btn.Click += p1.ShowMessage;
            //btn.Click += form.DisplayMessage;

            //btn.OnClick();



            Exam ex = new Exam(101, "Programming", DateTime.Now);

            Dictionary<string, List<string>> questions = new Dictionary<string, List<string>>();
            questions.Add("question 1",new List<string>() { "option 1 ","option 2 " });
            questions.Add("question 2", new List<string>() { "option 1 ", "option 2 " });
            questions.Add("question 3", new List<string>() { "option 1 ", "option 2 " });

            ex.Questions = questions;

            Student s1 = new Student(111, "Ahmed");
            Teacher t1 = new Teacher(222, "Mohamed");


            ex.startExam += s1.AswerExam;
            ex.startExam += t1.MonitorExam;

            ex.OnStartExam();





        }
    }
}
