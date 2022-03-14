using System;
public class person
{
    public string[] name = new string[10];

    public string this[int i]
    {
        set { name[i] = value; }

        get { return name[i]; }
    }
}