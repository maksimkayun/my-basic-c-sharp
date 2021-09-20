namespace whatDoing2
{
    public abstract class Person
    {
        protected string firstName;
        protected string lastName;
        
        // Абстрактное свойство
        public abstract string Name {
            get;
            protected set;
        }
        
        // Обычное поле с виртуальным свойством
        protected int age;
        public virtual int Age {
            get => age;
            set
            {
                if (value is > -1 and < 120) {
                    age = value;
                }
            }
        }
        
        // Абстрактный метод, без реализации
        public abstract void Eat();
        
        // Обычный метод
        public string GoWalk() {
            return "Я гуляю!";
        }
    }
}