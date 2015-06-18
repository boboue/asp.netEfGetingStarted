using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Remoting.Messaging;

namespace destinUniversity.Models
{
    public class Student
    {

        public int ID { get; set; }
        [Required]
        [DisplayName("Last Name")]
        [StringLength(50)]
       
        public string LastName { get; set; }
         [Required]
         [DisplayName("First Name")]
        [StringLength(50, ErrorMessage = "le Nom ne peut pas depasser 50 caratères" )]
        [Column("First Name")]
        public string FirstMidName { get; set; }

         [DisplayName("Enrollement Date")]
         [DataType(DataType.Date)]
         [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
    [DisplayName("Full Name")]
        public string FullName {
            get { return LastName + "," + FirstMidName; }
        }

         public string Secret { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}