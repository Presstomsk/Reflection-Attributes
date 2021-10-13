using System;


namespace AgeValidator
{    
    public class AttributeException : ApplicationException
    {
        public DateTime TimeException { get; private set; }
        public AttributeException() : base("Attribute not found")
        {
            TimeException = DateTime.Now;
        }

    }
    public class UninitializedParameterException : ApplicationException
    {
        public DateTime TimeException { get; private set; }
        public UninitializedParameterException() : base("Uninitialized parameter")
        {
            TimeException = DateTime.Now;
        }

    }

}
