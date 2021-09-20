using System;

namespace whatDoing2
{
    public class Student : Child
    {
        public Student(string fullname, int age, string school) : base(fullname, age) {
            School = school;
        }
        protected Student(string fullname, int age) : base(fullname, age) {}
        
        public override string Name {
            get
            {
                return $"Моё имя {firstName} {lastName}, место учёбы: {School}";
            }
            protected set { base.Name = value; }
        }
        
        // Собственное свойство
        public string School {
            get;
            set;
        }

        public override void Eat() {
            Console.WriteLine("Я хожу в KFC каждый день.");
        }

        public override int Age {
            get
            {
                return age;
            }
            set
            {
                if (value is > 7 and < 25) {
                    age = value;
                }
            }
        }
        
        // Собственный метод
        public void DoHomeWork() {
            Console.WriteLine("Сейчас я делаю домашнюю работу.");
        }
    }
}