using System;
using System.Collections;

namespace destinUniversity.Models
{
    public class Student
    {

        public int ID { get; set; }

        public string LastName { get; set; }
        public string FristMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}