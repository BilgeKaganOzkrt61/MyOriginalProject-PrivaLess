using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebsiteProject_PrivaLess_
{
    class StudentManager : IStudentService
    {
        public void Add(Student student)
        {
            Console.WriteLine(student.FirstName + " "+ student.LastName+ "  Adlı Öğrenci  "+ "--"+ student.UserName+ "--"+
                "   Kullanıcı Adı ile 17.99 $' a Artık PrivaLess'te !!");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<");

        }

        public void Delete(Student student)
        {
            Console.WriteLine(student.FirstName + student.LastName+ "  Adlı Öğrenci  PrivaLess'ten Ayrıldı:(");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<");

        }

        public void AddLesson(Student student ,Teacher teacher,Lesson lesson)
        {
            Console.WriteLine("--"+ student.UserName+ "--"+ "   Kullanıcı Adlı Öğrenci Programına   "+ teacher.FirstName+ 
                "   Adlı Öğretmenden   "+lesson.Name+ "  Adlı Dersi Ekledi. İYİ DERSLER!!");
            Console.WriteLine(lesson.LessonTime);
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<");

        }
    }
}
