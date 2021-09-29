using System;

namespace whatDoing2
{
    class Program
    {
        static void Main(string[] args) {
            Person child = new Child("Петя Петров", 5); // Полиморфизм
            Console.WriteLine(child.Name);
            child.GoWalk();

            // Демонстрация методов Child
            Child othercChildhild = new Child("Ваня Иванов", 4);
            othercChildhild.AddFriends(new Random().Next(30));
            Console.Write('\n' + othercChildhild.Name + " ");
            othercChildhild.GoToKindergarten();
            othercChildhild.Eat();
            Console.Write(othercChildhild.GoWalk() + '\n');
            
            // Демонстрация методов Student
            Student student = new Student("Николай Николаев", 20, "Российский университет транспорта");
            Console.WriteLine('\n' + student.Name);
            student.Eat();
            student.DoHomeWork();
            student.GoWalk();
            
            // Демонстрация методов Intern
            Intern intern = new Intern("Максим Максимов", 27, "Yandex");
            Console.WriteLine('\n' + intern.Name);
            intern.Eat();
            intern.Sleep();
            
            // Демонстрация методов Employee
            Employee employee = new Employee("Анатолий Анатольев", 42, "Mail.ru Group");
            Console.WriteLine('\n' + employee.Name);
            employee.Eat();
            employee.GetSalary(120000);

            // Person em_2 = new Employee("Анатолий Анатольев", 42, "Mail.ru Group");
            // Console.WriteLine('\n' + em_2.Name);
        }
    }
}