using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    //EF Convention
    internal class Student
    {
        public int Id { get; set; } //Pk,Identity(1,1)  => Id or EntityId
        public string? Name { get; set; }
        public int? Age { get; set; }
    }
}
