using System;

namespace whatDoing1
{
    public class Student : IDisposable
    {
        // Поля. Уровень доступа prootected 
        protected static int idstatic;
        protected int id;
        protected int course;
        
        // Поля. Уровень доступа public
        public string specialization;
        
        // Поля. Уровень доступа private 
        private readonly string firstName;
        private readonly string lastName;
        
        // Свойство-1 Имя
        public string Name {
            get
            {
                string position = course == 0 ? "Абитуриент" : "Студент";
                return $"{position} {firstName} {lastName}, id {id}";
            }
        }
        
        // Свойство-2 Специальность
        public string Specialization {
            get
            {
                if (course != 0) {
                    return $"Специальность: {specialization}, курс {course}";
                }
                else {
                    return $"Специальность: {specialization}";
                }
            }
            set
            {
                if (value is not null && !value.Equals("")) {
                    specialization = value;
                }
            }
        }
        
        // Свойство-3 Курс
        public int Course {
            set
            {
                if (value >= 0 && value < 7) {
                    course = value;
                }
            }
        }
        
        // Свойство-4 Жильё
        public string Housing {
            set;
            get;
        }
        
        // Cвойство-5 Телефон
        public string Phone {
            set;
            get;
        }

        // Конструктор-1: "Полный" конструктор
        public Student(int course, string specialization, string firstName, string lastName) {
            id = idstatic++;
            this.Course = course;
            this.Specialization = specialization ?? throw new ArgumentNullException(nameof(specialization));
            this.firstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        }
        
        // Конструктор-2 с аргументами Специаность, Имя и Фамилия
        public Student(string specialization, string firstName, string lastName) {
            id = idstatic++;
            this.Course = 0;
            this.Specialization = specialization ?? throw new ArgumentNullException(nameof(specialization));
            this.firstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        }
        
        // Конструктор-3 с аргументами Имя-Фамилия
        public Student(string firstName, string lastName) {
            id = idstatic++;
            this.Course = 0;
            this.Specialization = "ещё не выбрана";
            this.firstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        }
        
        // Статический метод "Списать"
        public static string WriteOff() {
            int r = new Random().Next(101);
            return r < 50 ? "Я никогда не списываю!" : "Изи зачётик:)))";
        }
        
        // Метод "Где ты живёшь?"
        public string WhereDoYouLive() {
            return Housing is null ? "Я бездомный((" : $"Место жительства: {Housing}";
        }
        
        // Метод "Что на счёт телефона?)"
        public void WhatAboutYourPhone() {
            if (Phone is not null) {
                int iq = new Random().Next(300);
                if (iq < 120) { // IQ меньше 120, студент "одолжит" свой телефон
                    Console.WriteLine("Конечно, держи мой телефон! ...  Эээ, стой, куда ты побежал?! Вернись!!! " +
                                      "Мне нужно позвонить маме... Или... Или вызвать полицию!");
                }
                else if (iq < 230) {
                    Console.WriteLine("У меня " + Phone);
                }
                else {
                    Console.WriteLine("8-800-555-35-35");
                }
            }
            else {
                Console.WriteLine("У меня нет телефона");
            }
        }
        
        // Метод - "Дай списать!"
        public string LetMeWriteItOff() {
            // Оценим доброту и щедрость студента
            int r = new Random().Next(101);
            if (r < 51) {
                return "Не, прости, я сам ничего не знаю, списывать нечего";
            }
            else {
                return "Пожалуйста! Бери, переписывай, я так люблю работать за бесплатно!";
            }
        }
        
        // Метод - "Дай списать!" перегруженный
        public string LetMeWriteItOff(int money) {
            // Оценим доброту и щедрость студента
            int r = new Random().Next(101) + (money / 4);
            if (r < 140) {
                return "Нууу, вот, держи, но не уверен за правильность...";
            }
            else {
                return "Всегда рад помочь другу!";
            }
        }
        
        // Метод "пойдём в кино"
        public string LetsGoToTheMovies() {
            int mood = new Random().Next(4); // Оценим настроение куда-то идти
            string result = "";
            switch (mood) {
                case 2: {
                    result = "Лучше пойдём в бар!";
                    break;
                }
                case 3: {
                    result = "Лучше пойдём в кальянку";
                    break;
                }
                case 4: {
                    result = "Поехали в Питер!";
                    break;
                }
                default: {
                    result = "Ок, пойдём";
                    break;
                }
            }
            return result;
        }
        
        // Метод - прохлаждается
        public string Chill() {
            int mood = new Random().Next(4); // Оценим настроение что-то делать
            string result = "";
            switch (mood) {
                case 2: {
                    result = "На чилле";
                    break;
                }
                case 3: {
                    result = "Я сейчас учусь";
                    break;
                }
                case 4: {
                    result = "Программирую...";
                    break;
                }
                default: {
                    result = "На лютом чилле";
                    break;
                }
            }
            return result;
        }
        
        // Финализатор
        ~Student() {
            Console.WriteLine("Меня отчислили...");
        }
        public void Dispose() {
            Console.WriteLine("Меня отчислили...");
        }
        //protected override void Finalize() => Console.WriteLine("Меня отчислили...");
    }
}