using AgeValidator;

namespace Attributes
{
    public class Person
    {
        [Age(Age=18)]
        public uint Age { get; set; }
        public string Name { get; set; }        
        public Person(string name, uint age)
        {
            Age = age;
            Name = name;            
        }
    }
}
