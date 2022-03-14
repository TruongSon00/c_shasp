using System;
using System.Collections.Generic;
public class Student : Person
{

    public string lop;

    public Student(string name, int age, string lop) : base(name, age)
    {
        this.lop = lop;
    }

    public Student() : base()
    {
        this.lop = "t2104e";
    }
    public override string ToString()
    {
        return $"Name = {this.name}  |  age = {this.age}  |  lop = {this.lop}";
    }
    public static void Main(string[] args)
    {

        List<Student> persons = new List<Student>();

        persons.Add(new Student());
        // persons[0].name = " ngu";
        Console.WriteLine(persons[0]);

    }
}
