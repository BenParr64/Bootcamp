static void Main(string[] args)
{
    Console.WriteLine("Hello, World!");
    var value = "Initial Value";
    ChangeValue(value);
    Console.WriteLine(value);
}

static void ChangeValue(string value)
{
    value = "New Value";
} 
