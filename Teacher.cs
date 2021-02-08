using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebsiteProject_PrivaLess_
{
    class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Lesson Lesson { get; set; }
        public long  TelephoneNumber { get; set; }
        public string Salary { get; set; }
    }
}
