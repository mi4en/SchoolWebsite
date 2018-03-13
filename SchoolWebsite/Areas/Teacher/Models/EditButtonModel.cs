using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SchoolWebsite.Areas.Teacher.Models
{
    public class EditButtonModel
    {
        public int SubjectId { get; set; }

        public int StudentId { get; set; }

        public int GradeId { get; set; }

        public string Link
        {
            get
            {
                var s = new StringBuilder("?");
                if (SubjectId > 0)
                {
                    s.Append(String.Format("{0}={1}&", "ubjectId", SubjectId));
                }
                if (StudentId > 0)
                {
                    s.Append(String.Format("{0}={1}&", "tudentId", StudentId));
                }
                if (GradeId > 0)
                {
                    s.Append(String.Format("{0}={1}&", "gradeId", GradeId));
                }

                return s.ToString().Substring(0, s.Length - 1);
            }
        }
    }
}