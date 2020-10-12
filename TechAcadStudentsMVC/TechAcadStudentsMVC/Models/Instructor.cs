using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechAcadStudentsMvc.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public int Id { get; internal set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}