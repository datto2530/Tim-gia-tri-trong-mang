
using System;

namespace Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nameList = { "loc", "tri", "dat", "thang", "duc anh", "trung", "duc", "viet" };
            Console.WriteLine("nhap ten ban: ");
            string name = Console.ReadLine();
            bool isTrue = false;
            for (int i = 0; i <= nameList.Length-1 ; i++)
            {
                if (nameList[i].Equals(name))
                {
                    Console.WriteLine($"Co ten trong mang va vi tri {i+1}");
                    isTrue = true;
                    break;
                }
            }
            if(isTrue=false)
            {
                Console.WriteLine("khong co ten");
            }
            Console.ReadKey();
        }
    }
}