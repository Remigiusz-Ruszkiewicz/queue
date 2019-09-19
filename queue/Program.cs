using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack collection = new Stack();
            collection.Push("Anna");
            collection.Push(12);
            collection.Push(true);
            while (collection.Count != 0)
            {
                Console.WriteLine(collection.Pop());
            }
            
            Console.Read();
        }
    }
}
