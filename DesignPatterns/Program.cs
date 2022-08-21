using System;
using DesignPatterns.BuilderPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            // singleThreadSingleton();
            multiThreadSingleton();

        }


        private static void singleThreadSingleton()
        {
            SingleItem item = SingleItem.GetSingleItem();
            Console.WriteLine("Item name: {0}", item.Name);

            item.Name = "Ali";
            Console.WriteLine("Item name: {0}", item.Name);

            SingleItem item2 = SingleItem.GetSingleItem();
            Console.WriteLine("Item name: {0}", item.Name);

            item2.Name = "Kübra";
            Console.WriteLine("Item name: {0}", item.Name);
        }


        private static void multiThreadSingleton()
        {
            var item = SingleItemMultiThread.GetSingleItem();
            Console.WriteLine("Item name: {0}", item.Name);

            item.Name = "Ali";
            Console.WriteLine("Item name: {0}", item.Name);

            var item2 = SingleItemMultiThread.GetSingleItem();
            Console.WriteLine("Item name: {0}", item.Name);

            item2.Name = "Kübra";
            Console.WriteLine("Item name: {0}", item.Name);
        }
    }
}
