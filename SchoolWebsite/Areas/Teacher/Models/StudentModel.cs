using SchoolWebsite.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolWebsite.Areas.Teacher.Models
{
    public class StudentModel
    {
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
        public int? NumberInClass { get; set; }

        public int GradeId { get; set; }

        public int SubjectId { get; set; }

        [DisplayName("Subject")]
        public ICollection<Subject> Subjects { get; set; }

        [DisplayName("Grade")]
        public ICollection<Grade> Grades { get; set; }

        public string Subject
        {
            get
            {
                return Subjects == null || Subjects.Count.Equals(0) ?
                    String.Empty : Subjects.First(s => s.Id.Equals(SubjectId)).Name;
            }
        }

        public string Grade
        {
            get
            {
                return Grades == null || Grades.Count.Equals(0) ?
                    String.Empty : Grades.First(s => s.Id.Equals(GradeId)).Name.ToString();
            }
        }
    }
}