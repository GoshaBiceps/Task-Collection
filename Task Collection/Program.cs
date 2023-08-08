using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "1", "2", "1", "3" };
            string[] array2 = { "1", "2", "4", "5" };
            List<string> collection = new List<string>();

            AddItem(array1, collection);
            AddItem(array2, collection);

            Show(collection);
        }

        static void AddItem(string[] array,List<string> collection)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (collection.Contains(array[i]) == false)
                {
                    collection.Add(array[i]);
                }
            }
        }

        static void Show(List<string> collection)
        {
            foreach (string number in collection)
            {
                Console.WriteLine($"{number} ");
            }
        }
    }
}
