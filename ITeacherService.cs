using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebsiteProject_PrivaLess_
{
    interface ITeacherService
    {
        public void Add(Teacher teacher);
        public void Delete(Teacher teacher);
        public void Inform(Lesson lesson, Teacher teacher);
        public void PaySalary(Lesson lesson, Teacher teacher);
    }
}
