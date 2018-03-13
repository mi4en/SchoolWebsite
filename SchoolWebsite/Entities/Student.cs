using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SchoolWebsite.Entities
{
    [Table("Student")]
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(60)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(3)]
        [DisplayName("Class")]
        public string ClassID { get; set; }

        [Required]       
        [DisplayName("Number In Class")]
        public int NumberInClass { get; set; }

        public int GradeId { get; set; }

        public int SubjectId { get; set; }

        //[DisplayName("Subject")]
        //public ICollection<Subject> Subjects { get; set; }

        //[DisplayName("Grade")]
        //public ICollection<Grade> Grades { get; set; }
    }
}