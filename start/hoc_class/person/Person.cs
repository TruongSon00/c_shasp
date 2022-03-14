public class Person
{

    public string name;
    public int age;
    // public Person()
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public Person()
    {
        this.name = "Name default";
        this.age = 0;
    }
    public void nhap()
    {
        Console.Write("Nhap ten person: ");
        name = Console.ReadLine();

        Console.Write("Nhap tuoi person: ");
        this.age = int.Parse(Console.ReadLine());
    }

    public void hienThi()
    {
        Console.WriteLine($"Name: {this.name}  |  age: {this.age}");
    }
}