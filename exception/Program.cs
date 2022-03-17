using System;

namespace exception;
public class exception
{
    public static void Main(string[] args)
    {
        int a = -1;
        try
        {
            a = Convert.ToInt32(Console.ReadLine());
        }
        catch (System.Exception ex)
        {
            a = 0;
            Console.WriteLine("Nhap lon gi the");
        }
        finally
        {

            Console.Write($"So a: {a}");
        }

    }
}