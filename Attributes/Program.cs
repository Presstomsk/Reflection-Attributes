using System;
using AgeValidator;


namespace Attributes
{
    class Program
    {
        static void Main()
        {                   
            // Объект класса Person, свойство Age 

            Person human;
            Console.WriteLine("Введите имя человека:");
            var name = Console.ReadLine();
            Console.WriteLine("Введите возраст человека:");
            var age = Convert.ToUInt32(Console.ReadLine());
            human = new Person(name, age);
            var validAgeResult=ValidatePerson.ValidAge(human,out uint Attr2);
            if (validAgeResult) Console.WriteLine($"{human.Name} совершеннолетний");
            else Console.WriteLine($"{human.Name} несовершеннолетний");

            // Объект класса Engineer, свойство YearsOld 

            Engineer Bob = new Engineer() { Name = "Bob", YearsOld = 24 };
            if (ValidatePerson.ValidAge(Bob,out uint Attr)) Console.WriteLine($"А инженер {Bob.Name} старше {Attr} лет"); 
            else Console.WriteLine($"А инженер {Bob.Name} младше {Attr} лет");

        }
        
    }
}
