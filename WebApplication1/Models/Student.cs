using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
        /// <summary>
        /// The unique identifier; Type: Int
        /// </summary>
        [Required]
        [DataType("Int")]
        public int id { get; set; }
        /// <summary>
        /// The name of the Student
        /// </summary>
        [Required]
        public string name { get; set; }
        /// <summary>
        /// List of subjects the student it is in
        /// </summary>
        [DataType("List")]
        public List<Subject> listOfSubjects { get; set; }       
       
    }
}