using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    class SingletonPattern
    {


    }


    public class SingleItem
    {
        private static SingleItem item = null;

        private SingleItem()
        {
            this.Name = "ilker";
        }

        public string Name { get; set;}


        public static SingleItem GetSingleItem()
        {
            if(item == null)
            {
                item = new SingleItem();
            }
            return item;
        }
    }


    public class SingleItemMultiThread
    {
        private static SingleItemMultiThread item = null;

        private SingleItemMultiThread()
        {
            this.Name = "ilker";
        }

        public string Name { get; set; }


        public static SingleItemMultiThread GetSingleItem()
        {
            SemaphoreSlim semaphore = new SemaphoreSlim(1);

            semaphore.WaitAsync();
            if (item == null)
            {
                item = new SingleItemMultiThread();
            }
            semaphore.Release();
            return item;
        }
    }
}
