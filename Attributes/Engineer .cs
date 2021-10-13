using AgeValidator;

namespace Attributes
{
    class Engineer
    {
        public string Name { get; set; }
        [Age(Age = 25)]
        public uint YearsOld { get; set; }
    }
}
