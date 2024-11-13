using System.Xml.Linq;

namespace animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("manu", 23, "Retrevier");

            dog.Speak();
            Console.WriteLine(dog.Breed);
        }

    }
    public class Animals
    {
        public string Name;
        public int Age;

        public Animals(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public void Speak()
        {
            Console.WriteLine($"my name is {Name},age is {Age}");
        }
    }

     class Dog : Animals
    {
        public string Breed {  get; set; }

        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }
    }
     class Cat : Animals
    {
        public Cat(string name, int age) : base(name, age)
        { }

        void Meow()
        {
            Console.WriteLine("Meow!");
        }
    }
    
}
