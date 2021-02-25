using System;
using CustomList;
namespace ListDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>(1,12,3,8,99,10,6);           
            list.Insert(2, 7);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
