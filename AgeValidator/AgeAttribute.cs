using System;


namespace AgeValidator
{
    public class AgeAttribute : Attribute
    {
        public uint Age { get; set; }
    }

}
