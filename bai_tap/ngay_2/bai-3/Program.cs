
public class MyClass
{

  bool  checkPrime(int n)
    {
        bool result = true;
        if (n == 2)
            return result;
        for (var i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return result;
    }
    public static void Main(string[] args)
    {
        int num1, num2;
        Console.WriteLine("Nhap so thu nhat: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so thu hai: ");
        num2 = Convert.ToInt32(Console.ReadLine());


    }
}