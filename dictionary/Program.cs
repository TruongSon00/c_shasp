using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chuois = new List<string>();
            Dictionary<string, int> works = new Dictionary<string, int>();
            Console.WriteLine("Nhap enter de ket thuc");
            string chuoi;
            while (true)
            {
                chuoi = Console.ReadLine();
                chuois.Add(chuoi);
            }
            // works[value] = key 
            // works[key] = value
            // works(key, value)
            int n = 0;
            if (chuois.Contains("hihi"))
                 n++;
            foreach (string work in works.Keys)
            {
                Console.WriteLine($"value: {work}, value: {works[work]}");
            }
           
        }
    }
}
