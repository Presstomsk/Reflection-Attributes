using System;


namespace AgeValidator
{
    public class ValidatePerson
    {
        public static bool ValidAge(object obj,out uint valueAttr)
        {
            if (obj.GetType().IsClass)
            {
                Type type = obj.GetType();
                var properties = type.GetProperties();
                foreach (var property in properties)
                {
                    var attributes = (AgeAttribute[])property.GetCustomAttributes(typeof(AgeAttribute), true);
                    foreach (var attr in attributes)
                    {
                        uint valueObj = (uint)property.GetValue(obj);
                        valueAttr = attr.Age;
                        if (valueObj >= valueAttr) return true;
                        else return false;
                    }
                }
                throw new Exception("Атрибут не обнаружен!");
            }
            else throw new Exception("Параметр не является экземрляром класса!");
        }
    }
}



