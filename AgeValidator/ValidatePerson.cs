using System;


namespace AgeValidator
{
    public class ValidatePerson
    {
        public static bool ValidAge<T>(T obj,out uint valueAttr) where T:class
        {
            if (obj != null)
            {
                var properties = obj.GetType().GetProperties();
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
            else throw new Exception("Неинициализированный параметр");
        }
        
    }
}



