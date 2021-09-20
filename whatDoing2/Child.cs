using System;

namespace whatDoing2
{
    public class Child : Person
    {
        public Child(string fullname, int age) {
            if (!fullname.Equals("")) {
                Name = fullname;
                Age = age;
            }
        }
        
        // Даём реализацию абстрактному свойству
        public override string Name {
            get
            {
                return $"Моё имя {firstName} {lastName}, приятно познакомиться! \n" + Friends;
            }
            protected set
            {
                string[] fullname = value.Split(" ");
                firstName = fullname[0];
                lastName = fullname[1];
            }
        }

        private int friends;
        public string Friends {
            get
            {
                string ending = "";
                switch (friends % 10) {
                    case 0 or 5 or 6 or 7 or 8 or 9: {
                        if (friends == 0) {
                            ending = "пока нет друзей(((";
                            break;
                        }
                        ending = "друзей!";
                        break;
                    }
                    case 1: {
                        ending = "друг!";
                        break;
                    }
                    case 2 or 3 or 4: {
                        ending = "друга!";
                        break;
                    }
                }

                if (friends == 0) {
                    return $"У меня {ending}";
                }
                return $"У меня {friends} {ending}";
            }
        }
        
        // Собственный метод добавления друзей
        public void AddFriends(int friends) {
            this.friends += friends;
        }
        
        // Ребёнок ест свою еду каждое утро
        public override void Eat() {
            Console.WriteLine("Я ем овсяную кашу каждое утро!");
        }
        
        // Переопределяем возраст ребёнка (допустим, до 8 лет - это ребёнок)
        public override int Age {
            get { return age; }
            set
            {
                if (value is > -1 and < 8) {
                    age = value;
                }
            }
        }
        
        // Собственный метод - поход в детский сад
        public void GoToKindergarten() {
            if (friends == 0) {
                Console.WriteLine("Я хожу в детский сад! Там я пытаюсь найти себе друзей.");
                return;
            } else if (friends == 1) {
                Console.WriteLine("Я хожу в детский сад! Там я играю со своим лучшим другом.");
                return;
            }
            Console.WriteLine("Я хожу в детский сад! Там я встречаюсь со своими друзьями.");
        }
    }
}