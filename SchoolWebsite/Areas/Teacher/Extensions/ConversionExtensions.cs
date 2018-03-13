using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SchoolWebsite.Areas.Teacher.Models;
using SchoolWebsite.Models;
using System.Data.Entity;
using SchoolWebsite.Entities;


namespace SchoolWebsite.Areas.Teacher.Extensions
{

    public static class ConversionExtensions
    {
        #region Student
        public static async Task<IEnumerable<StudentModel>> Convert(
            this IEnumerable<Student> students, ApplicationDbContext db)
        {
            if (students.Count().Equals(0))
            {
                return new List<StudentModel>();
            }


            var subjects = await db.Subjects.ToListAsync();
            var grades = await db.Grades.ToListAsync();

            return from s in students
                   select new StudentModel
                   {
                       Id = s.Id,
                       FirstName = s.FirstName,
                       LastName = s.LastName,
                       ClassID = s.ClassID,
                       NumberInClass = s.NumberInClass,
                       SubjectId = s.SubjectId,
                       GradeId = s.GradeId,
                       Subjects = subjects,
                       Grades = grades
                   };
        }

        public static async Task<StudentModel> Convert(
        this Student student, ApplicationDbContext db)
        {
            var subject = await db.Subjects.FirstOrDefaultAsync(
                s => s.Id.Equals(student.SubjectId));
            var grade = await db.Grades.FirstOrDefaultAsync(
                g => g.Id.Equals(student.GradeId));

            var model = new StudentModel
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                ClassID = student.ClassID,
                NumberInClass = student.NumberInClass,
                SubjectId = student.SubjectId,
                GradeId = student.GradeId,
                Subjects = new List<Subject>(),
                Grades = new List<Grade>()
            };

            model.Subjects.Add(subject);
            model.Grades.Add(grade);

            return model;
        }
        #endregion
    }
}