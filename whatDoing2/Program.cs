using System;

namespace whatDoing2
{
    class Program
    {
        static void Main(string[] args) {
            Person child = new Child("Петя Петров", 5); // Полиморфизм
            Console.WriteLine(child.Name);
            
            Child othercChildhild = new Child("Ваня Иванов", 4);
            othercChildhild.AddFriends(2);
            Console.Write('\n' + othercChildhild.Name + " ");
            othercChildhild.GoToKindergarten();
            othercChildhild.Eat();
        }
    }
}