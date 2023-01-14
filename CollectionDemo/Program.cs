using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImplementingCollection.TestList();
            ImplementingCollection.TestSortedList();
            ImplementingCollection.DoListDemo();
            ImplementingCollection.DoStackDemo();
            ImplementingCollection.DoQueueDemo();
            ImplementingCollection.DoSetDemo();
            ImplementingCollection.DoDictionaryDemo();
            Console.ReadLine();
        }
        
    }
}
