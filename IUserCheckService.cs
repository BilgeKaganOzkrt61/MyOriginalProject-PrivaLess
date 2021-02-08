using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebsiteProject_PrivaLess_
{
    interface IUserCheckService
    {
        void CheckTheStudent(Student student);
        void CheckTheTeacher(Teacher teacher);
    }
}
