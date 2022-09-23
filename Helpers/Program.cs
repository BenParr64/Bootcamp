using System.Runtime.CompilerServices;

namespace Helpers
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            const string name = "Ben";
            Console.WriteLine(name.FormatName());

            Console.WriteLine(name.ValidateBen() ? "Hi Ben" : "Your name is not Ben");
        }

        internal static string FormatName(this string name)
        {
            return name[0].ToString().ToUpper() + name[1..];

        }

        internal static bool ValidateBen(this string name)
        {
            return name == "Ben";

        }
    }
}