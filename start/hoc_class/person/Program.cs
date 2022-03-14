using System;


public class Student : Person
{
    public Student(string name, int age, string lop) : base(name, age)
    {
    }

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Person Vu = new Person("Long Vu", 22);
        Person[] persons = new Person[3];
        Vu.nhap();
        Vu.hienThi();

        //  lam viec voi mang 
        int count = 0;
        for (var i = 0; i < persons.Length; i++)
        {

            persons[i] = new Person();
        }
        foreach (Person person in persons)
        {
            Console.WriteLine($"Nhap thong tin person {++count}");
            person.nhap();

        }

        foreach (Person person in persons)
        {
            person.hienThi();
        }
    }
}