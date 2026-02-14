using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student  
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student()
        {

        }
        public Student(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        //public string Display()
        //{
        //    return $"{Id} - {Name}"; 
        //}

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        //public static bool operator ==(Student a, Student b)
        //{
        //    return a.Id == b.Id && a.Name == b.Name;
        //}
        //public static bool operator !=(Student a, Student b)
        //{
        //    return a.Id != b.Id || a.Name != b.Name;
        //}

        public override bool Equals(object obj)
        {
            //Student s =  (Student)obj;  
            //return  s.Id == this.Id && s.Name == this.Name;

            //Check Operators


            // is return Boolean
            // if (obj is Student)
            // {
            //     Student s =  (Student)obj;  
            //     return  s.Id == this.Id && s.Name == this.Name;
            // }
            //else { return false; }



            // as return specific Type or Null
            Student s = obj as Student;
            if (s == null) return false;
            else
                return s.Id == this.Id && s.Name == this.Name;

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            #region System.Object
            //parent p = new Child();
            //object o = new object();
            //o = 11;
            //o = "Ahmed";
            //o = new Student();


            //int[] grads = new int[10];
            //object[] arr = new object[10];
            //arr[0] = 10;
            //arr[1] = 20;
            //arr[2] = 30;
            //arr[3] = "Ahmed";

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Operations XXXX
            //Boxing & UnBoxing  XXXXXXXX

            //Casting
            //Implicit 
            //Explicit

            ////Boxing      value => ref
            //int x = 10;
            //object o = x;

            ////UnBoxing    Ref => value
            //object obj = 50;
            //int y = (int)obj; 
            #endregion

            #region ToString()
            //Student s = new Student(101,"Mona");
            ////Console.WriteLine(s.Display());
            //Console.WriteLine(s.ToString());


            //int x = 50;
            //Console.WriteLine(x.ToString());  

            #endregion

            #region GetHashCode
            //Student s1 = new Student(101,"Ahmed");
            //Console.WriteLine(s1.GetHashCode());

            //Student s2 = new Student(101, "Mohaed");
            //Console.WriteLine(s2.GetHashCode()); 
            #endregion

            #region GetType()
            //Student s1 = new Student(101,"Ali");
            //Console.WriteLine(s1.ToString());
            //Console.WriteLine(s1.GetType().IsClass); 
            #endregion

            Student s1 = new Student(101, "Ahmed");
            Student s2 = new Student(101, "Ahmed");
            //employee e1 = new employee();   

            if (s1.Equals(s2))
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("Not Equals");
            }
            

        }
    }
}
