using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Remoting.Messaging;

namespace destinUniversity.Models
{
    public class Student : Person
    {
         [DisplayName("Enrollement Date")]
         [DataType(DataType.Date)]
         [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
   

         public string Secret { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}