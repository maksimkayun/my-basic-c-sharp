using System;

namespace whatDoing1
{
    class Program
    {
        static void Main(string[] args) {
            Student s_1 = new Student("Менеджмент","Иван", "Иванов");
            Student s_2 = new Student("Информатика","Пётр", "Петров");
            
            Console.WriteLine(s_1.Name + '\n' + s_1.Specialization);
            Console.WriteLine('\n' + s_2.Name + '\n' + s_2.Specialization);

            Student s_3 = new Student(2, "Логистика", "Василий", "Васильев");
            Console.WriteLine('\n' + s_3.Name + '\n' + s_3.Specialization);

            Student s_4 = new Student("Алексей", "Николаев");
            Console.WriteLine('\n' + s_4.Name + '\n' + s_4.Specialization);
            
            
            // Списывает или нет?
            Console.WriteLine('\n'+ "Проверка на списывание случайного студента: " + Student.WriteOff());
            
            
            // История про жильё
            s_4.Housing = "Общежитие";
            Console.WriteLine('\n'+ "Узнаем, кто где живёт...");
            Console.WriteLine("Один студент гвоорит: \"" + s_4.WhereDoYouLive() + "\"");
            Console.WriteLine("Другой студент: \"" + s_3.WhereDoYouLive()+ "\"");
            
            // Пранк с телефоном
            Console.WriteLine('\n'+ "Теперь попробуем \"одолжить\" телефон у парочки студентов))");
            s_4.WhatAboutYourPhone();
            s_1.Phone = "iPhone 13";
            s_1.WhatAboutYourPhone();
            
            // Пойдём в кино!
            Console.WriteLine('\n' + "Предложим сходить в кино...");
            Console.WriteLine(s_1.LetsGoToTheMovies());
            Console.WriteLine(s_2.LetsGoToTheMovies());
            
            // Спросим студентов, что они делают?
            Console.WriteLine('\n' + "Спросим студентов, что они делают...");
            Console.WriteLine(s_1.Chill());
            Console.WriteLine(s_2.Chill());
        }
    }
}
