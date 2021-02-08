using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebsiteProject_PrivaLess_
{
    class TeacherManager : ITeacherService
    {
        public void Add(Teacher teacher)
        {
            Console.WriteLine(teacher.FirstName + " " + teacher.LastName + "  Adlı Öğretmen PrivaLess Öğretim Üyesi Oldu. " +
                " İYİ DERSLER" );
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<");

        }

        public void Delete(Teacher teacher)
        {
            Console.WriteLine(teacher.FirstName + " " + teacher.LastName + "  Adlı Öğretmen PrivaLess Öğretim Programından Kaldırıldı. " +
                " Güle Güle" );

        }

        public void Inform(Lesson lesson, Teacher teacher)
        {
            Console.WriteLine(teacher.FirstName + " "+ teacher.LastName+ "  Adlı Öğretmene  "+ lesson.LessonTime+ "  Saatinde Yapacağı Ders Hakkında " +
                "--" + teacher.TelephoneNumber+ "--"+ "   Nolu Telefon Numarasından Bilgilendirme Yapıldı. İYİ DERSLER  " );
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<");


        }

        public void PaySalary(Lesson lesson, Teacher teacher)
        {
            Console.WriteLine("--DERS İŞLENDİ--");
            Console.WriteLine(teacher.FirstName+ " "+ teacher.LastName+ "   Adlı Öğretmene  "+ lesson.LessonTime+ "  Saatindeki Yaptığı Ders Gereği  " +
                teacher.Salary+ "   Olan Maaşı Ödenmiştir.");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<");

        }
    }
}
