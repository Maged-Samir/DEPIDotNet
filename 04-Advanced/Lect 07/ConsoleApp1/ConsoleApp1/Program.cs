using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //public delegate int myDelete(int a, int b);

    public delegate void myDelegate(Button btn);

   public enum Color
    {
        White,
        Gray,
        Black
    }
   public class Button
    {
        public string Text { get; set; }
        public Color BackGroundColor { get; set; }
        public Color FontColor { get; set; }
        public string Msg { get; set; }

        public event myDelegate Click;

        public void OnClick()
        {
            Click(this);
        }

        public Button(string Text ,Color BackGroundColor = Color.Gray,string Msg = null)
        {
          this.Text = Text;
          this.BackGroundColor = BackGroundColor;
          this.Msg = Msg;
        }

        public override string ToString()
        {
            return Text;
        }
    }
    class Page
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Minimized { get; set; }
        public bool Maximized { get; set; }


        public Page(string Title ,string Content = null)
        {
            this.Title = Title;
            this.Content = Content;
        }

        public void ShowMessage(Button btn)
        {
            Console.WriteLine($"Page Message : {btn.Msg} ");
        }

        public override string ToString()
        {
            return Title;
        }
    }

    internal class Program
    {
        #region Delegate      
        //public static int Sum (int x, int y)
        //{
        //    Console.WriteLine($"{x+y}");
        //    return x + y; 
        //}
        //public static int Mul(int x, int y)
        //{
        //    Console.WriteLine($"{x * y}");
        //    return x * y;
        //} 
        #endregion      
        static void Main(string[] args)
        {
            #region Delegate
            //myDelete d = Program.Sum;
            //d += Program.Mul;
            //int result = d(5, 8);
            //Console.WriteLine(result);

            /*
             * Func
             * Action
             * Predicate
             */
            #endregion


            /*
             * Define Delegate (NameSpace)
             * Define Event using Delegate (class Publisher)
             * Fire the Event (class Publisher)
             * 
             * Define Function match the delegate signature (class subscriber)
             * 
             * Assign subscriber Function to the Event (Main)
             * Fire the Event (Main)
             **/



            //Button btn = new Button("Submit", Color.White,"Button Clicked");
            //Page p1 = new Page("Home Page");

            //btn.Click += p1.ShowMessage;
            //btn.OnClick();




        }
    }
}
