using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Subject
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Lesson> listOfSubjects { get; set; }
    }
}