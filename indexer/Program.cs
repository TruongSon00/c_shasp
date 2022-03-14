using System;

public class MyClass
{
    public static void Main(string[] args)
    {
        person newPerson = new person();
        newPerson[0] = "ngu";
        Console.WriteLine(newPerson[1]);
    }
}