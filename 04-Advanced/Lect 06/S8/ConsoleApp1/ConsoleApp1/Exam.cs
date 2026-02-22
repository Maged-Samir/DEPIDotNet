using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void myDel(Exam ex);
    public class Exam
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public Dictionary<string, List<string>> Questions { get; set; }

        public event myDel startExam;

        public Exam(int id, string subject, DateTime date)
        {
            Id = id;
            Subject = subject;
            Date = date;
        }

        public void OnStartExam()
        {
            startExam(this);
        }


        public override string ToString()
        {
            string txt = $" Exam Id : {Id} -  Subject :{Subject} - {Date} \n";
            foreach(KeyValuePair<string, List<string>> item in Questions)
            {
                txt += item.Key + "? \n";
                foreach(string ans in item.Value)
                {
                    txt+=  $"{ans}" + " \n";
                }
            }
            return txt ;
        }




    }
}
