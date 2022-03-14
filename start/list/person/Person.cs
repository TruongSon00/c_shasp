public class Person
{

    public string name;
    // {
    //     set
    //     {
    //         name = value;
    //     }
    //     get
    //     {
    //         return name;
    //     }
    // }
    public int age;



    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public Person()
    {
        this.name = "name default";
        this.age = 22;
    }
}