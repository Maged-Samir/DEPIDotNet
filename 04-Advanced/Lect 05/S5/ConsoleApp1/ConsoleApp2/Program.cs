using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate void myDel(Button btn);
    public class Button
    {
        public string Text { get; set; }
        public string Color { get; set; }
        public string Msg { get; set; }
        public event myDel Click;
        
        public void OnClick()
        {
            Click(this);
        }


        public Button(string text, string color)
        {
            Text = text;
            Color = color;
        }


    }
    class HomePage
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public HomePage(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public void DisplayMessage(Button btn)
        {
            Console.WriteLine($"Data From Button to HomePage : {btn.Msg}");
        }
    }
    class ContactUsPage
    {
        public string Title { get; set; }

        public ContactUsPage(string title)
        {
            Title = title;
        }

      public void ShowMessage(Button btn)
       {
            Console.WriteLine($"Data From Button to ContactUsPage : {btn.Color}");
        }

    }

        internal class Program
    {
        static void Main(string[] args)
        {
            //Event => Notification Between Classes
            /*
             * Define Delegate (NameSpace)
             * Define Event Based on Delegate
             * Fire Event (Class Publisher)
             * 
             * Define Function match Delegate Signature (Subscriper)
             * 
             * Assign Fun to Event (Main)
             * Fire Event Fun (Main)
             * 
             */

            Button btn = new Button("Open Connection", "Gray");
            btn.Msg = "Successed...";
            HomePage p1 = new HomePage("Home Page", "Wellcome to Our Application");
            ContactUsPage p2 = new ContactUsPage("Contact Page");



            btn.Click += p1.DisplayMessage;
            btn.Click += p2.ShowMessage;
            
            btn.OnClick();

        }
    }
}
