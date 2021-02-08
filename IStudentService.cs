using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebsiteProject_PrivaLess_
{
    interface IStudentService
    {
        public void Add(Student student);
        public void Delete(Student student);
        public void AddLesson(Student student,Teacher teacher ,Lesson lesson);
    }
}
