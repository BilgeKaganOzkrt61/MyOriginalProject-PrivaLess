using System;

namespace MyWebsiteProject_PrivaLess_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------PrıvaLess---PRIVATE LESSON------");
            

            Student student1 = new Student() { Id=1 , FirstName="Bilge Kağan" , LastName="Özkurt", UserName="bilgekagan61" ,
            Password="trabzonspor_61", TelephoneNumber= +905123456789 , CreditCardNumber= 1234_5678_9087_6543};

            Student student2 = new Student() { Id=2 , FirstName="Yusuf Taha" , LastName="Çebi", UserName="yusuftaha55" ,
            Password="toretto34", TelephoneNumber= +905345678901 , CreditCardNumber= 0987_6543_2109_8765};

            Student student3 = new Student() { Id=3 , FirstName="Metehan" , LastName="Babacan", UserName="metehanbaba" ,
            Password="kayserili38", TelephoneNumber= +905567890123 , CreditCardNumber= 8765_4321_0987_6543};

            Student student4 = new Student() { Id=3 , FirstName="Emre" , LastName="Kasap", UserName="emrksp15" ,
            Password="dimanali", TelephoneNumber= +905741852963 , CreditCardNumber= 9258_8521_3698_7412};

            //Bilgiler Rastgeledir!!

            Lesson lesson1 = new Lesson() { Id = 10, Name = "Matematik", LessonTime = "Her Akşam 17.10-18.00"};

            Lesson lesson2 = new Lesson() { Id = 11, Name = "Edebiyat", LessonTime = "Her Akşam 18.10-19.00"};

            Lesson lesson3 = new Lesson() { Id = 12, Name = "Fizik", LessonTime = "Her Akşam 19.10-20.00"};

            Lesson lesson4 = new Lesson() { Id = 13, Name = "Kimya", LessonTime = "Her Akşam 20.10-21.00"};

            Lesson lesson5 = new Lesson() { Id = 14, Name = "Biyoloji", LessonTime = "Her Akşam 21.10-22.00"};




            Teacher teacher1 = new Teacher() { Id=5, FirstName="Özdal", LastName="Gümüş", UserName="ozdalyum", 
                Password="matematikçi34", Lesson=lesson1, TelephoneNumber= +905135790246, Salary="5500 $ "};

            Teacher teacher3 = new Teacher() { Id=6, FirstName="Cem", LastName="Cihan", UserName="cemboo", 
                Password="edebiyatçi78", Lesson=lesson2, TelephoneNumber= +905223334455, Salary="4500 $ "};

            Teacher teacher2 = new Teacher() { Id=7, FirstName="Engin", LastName="Demiroğ", UserName="engindemirog", 
                Password="yazilimci06", Lesson=lesson3, TelephoneNumber= +905317509876, Salary="3500 $ "};

            Teacher teacher4 = new Teacher() { Id=8, FirstName="Cemal", LastName="Uzun", UserName="cemaluzun61", 
                Password="diboldibol", Lesson=lesson4, TelephoneNumber= +905998887766, Salary="4750 $ "};

            Teacher teacher5 = new Teacher() { Id=9, FirstName="Ebru", LastName="SivriKaya", UserName="ebrusivrikaya", 
                Password="ESbiyoloji3450" , Lesson=lesson5 , TelephoneNumber= +905114446161, Salary="2750 $ "};

            //Bilgiler Rastgeledir!!

            TeacherManager teacherManager = new TeacherManager();
            teacherManager.Add(teacher5);
            UserCheckManager userCheckManager2 = new UserCheckManager();
            userCheckManager2.CheckTheTeacher(teacher5);

            StudentManager studentManager1 = new StudentManager();
            studentManager1.Add(student2);
            UserCheckManager userCheckManager1 = new UserCheckManager();
            userCheckManager1.CheckTheStudent(student2);
            

            StudentManager studentManager2 = new StudentManager();
            studentManager2.AddLesson(student1, teacher1, lesson1);
            StudentManager studentManager3 = new StudentManager();
            studentManager3.AddLesson(student2, teacher4, lesson4);

           
            TeacherManager teacherManager2 = new TeacherManager();
            teacherManager2.Inform(lesson4, teacher4);
            TeacherManager teacherManager3 = new TeacherManager();
            teacherManager3.PaySalary(lesson4,teacher4);
            







        }
    }
}
