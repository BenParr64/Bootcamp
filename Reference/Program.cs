namespace Reference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value Type");
            var value = "Initial Value 1";
            ChangeValue(value);
            Console.WriteLine(value);

            Console.WriteLine("\nReference Type");
            var value2 = "Initial Value 2";
            ChangeValueByRef(ref value2);
            Console.WriteLine(value2);

            Console.WriteLine("\nOther Way");
            var value3 = "Initial Value 2";
            value3 = ChangeValueReturn(value3);
            Console.WriteLine(value3);
        }

        static void ChangeValue(string value)
        {
            value = "New Value 1";
        }

        static void ChangeValueByRef(ref string value)
        {
            value = "New Value 2";
        }

        static string ChangeValueReturn(string value)
        {
            value = "New Value 3";
            return value;
        }
    }


}