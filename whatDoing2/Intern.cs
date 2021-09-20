using System;

namespace whatDoing2
{
    public class Intern : Student
    {
        private string internship;
        public Intern(string fullname, int age, string internship) : base(fullname, age) {
            Internship = internship;
        }
        protected Intern(string fullname, int age) : base(fullname, age) {}
        
        // Собственное свойство - место стажировки
        public string Internship {
            get
            {
                return $"Моё место стажировки: {internship}";
            }
            set
            {
                if (!value.Equals("")) {
                    internship = value;
                }
            }
        }

        public override string Name {
            get
            {
                return $"Моё имя {firstName} {lastName}, мне {Age}. Моё место стажировки: {Internship}";
            }
            protected set
            {
                base.Name = value;
            }
        }

        public override int Age {
            get
            {
                return age;
            }
            set
            {
                if (value is > 24 and < 33) {
                    age = value;
                }
            }
        }

        public override void Eat() {
            Console.WriteLine("Я пью кофе по утрам.");
        }
        
        // Собственный метод - спать
        public void Sleep() {
            Console.WriteLine("Я сплю везде, где только смогу, потому что не высыпаюсь!");
            int r = new Random().Next(0, 4);
            switch (r) {
                case 1: {
                    Console.WriteLine("Сейчас я сплю дома в кровати.");
                    break;
                }
                case 2: {
                    Console.WriteLine("Сейчас я сплю на кухне.");
                    break;
                }
                case 3: {
                    Console.WriteLine("Сейчас я сплю в метро.");
                    break;
                }
                case 4: {
                    Console.WriteLine("Сейчас я сплю в месте прохождения стажировки.");
                    break;
                }
                default: {
                    Console.WriteLine("Сейчас я сплю под мостом в коробке");
                    break;
                }
            }
        }
    }
}