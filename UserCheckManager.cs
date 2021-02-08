using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebsiteProject_PrivaLess_
{
    class UserCheckManager : IUserCheckService
    {
        public void CheckTheStudent(Student student)
        {
            if (student.UserName == "bilgekagan61" & student.Password == "trabzonspor_61" ||
                student.UserName == "yusuftaha55" & student.Password == "toretto34" ||
                student.UserName == "metehanbaba" & student.Password == "kayserili38" ||
                student.UserName == "emrksp15" & student.Password == "dimanali")

            {
                Console.WriteLine("KULLANICI BİLGİLERİ DOĞRULANDI.İYİ DERSLER!!");
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            }
            else
            {
                Console.WriteLine("KULLANICI BULUNAMADI!!");
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<");

            }
        }

        public void CheckTheTeacher(Teacher teacher)
        {
            if (teacher.UserName == "ozdalyum" & teacher.Password == "matematikçi34" ||
                teacher.UserName == "cemboo" & teacher.Password == "edebiyatçi78" ||
                teacher.UserName == "engindemirog" & teacher.Password == "yazılimci06" ||
                teacher.UserName == "cemaluzun61" & teacher.Password == "diboldibol" ||
                teacher.UserName == "ebrusivrikaya" & teacher.Password == "ESbiyoloji3450" )

            {
                Console.WriteLine("KULLANICI BİLGİLERİ DOĞRULANDI.İYİ DERSLER!!");
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            }
            else
            {
                Console.WriteLine("KULLANICI BULUNAMADI!!");
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<");

            }
        }
    }
}
