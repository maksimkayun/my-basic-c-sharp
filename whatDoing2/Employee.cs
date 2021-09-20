using System;

namespace whatDoing2
{
    public class Employee : Intern
    {
        private string job;
        public Employee(string fullname, int age, string job) : base(fullname, age) {
            Job = job;
        }
        
        // Собственное свойство - работа
        public string Job {
            get
            {
                if (job.Equals("безработный")) {
                    return "Я пока что безработный";
                }

                return $"Моё место работы: {job}";
            }
            set
            {
                if (value.Equals("")) {
                    job = "безработный";
                }
                else {
                    job = value;
                }
            }
        }

        public override int Age {
            get
            {
                return age;
            }
            set
            {
                if (value is > 32 and < 120) {
                    age = value;
                }
            }
        }

        public override string Name {
            get
            {
                return $"Моё имя {firstName} {lastName}, мне {Age}. {Job}";
            }
            protected set
            {
                base.Name = value;
            }
        }

        public override void Eat() {
            Console.WriteLine("Я пытаюсь питаться правильно. 5-разовое питание, диетическая пища.");
        }
        
        // Собственный метод - получить зарплату
        public void GetSalary(int money) {
            Console.WriteLine($"Ура! Я получил зарплату! Она составляет {money} р. в месяц.");
        }
    }
}