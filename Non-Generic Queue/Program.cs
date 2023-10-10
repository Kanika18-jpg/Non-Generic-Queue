using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Generic_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue("Hello");

            foreach(var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(q.Count);
            Console.WriteLine(q.Peek());
            
            q.Dequeue();

            q.Enqueue("Welcome!");

            foreach(var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(q.Contains(2));

            Console.ReadLine();
        }
    }
}
