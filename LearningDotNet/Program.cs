using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningDotNet
{
    class Program
    {
        static ConcurrentDictionary<int, int> items = new ConcurrentDictionary<int, int>();

        static void AddItem()
        {
            items.TryAdd(1, 2);
            Console.WriteLine(items.Count);
        }

        static async void Download()
        {
            HttpClient client = new HttpClient(); 
            var data = await client.GetStringAsync("http://google.com");
            Console.WriteLine("Download complete" + data);
        }

        // Imaginary external network library
        class Network
        {
            static public Task Download()
            {
                return Task.Run(() => Thread.Sleep(3000));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading file");
            Download();
            Console.ReadLine();

            /* hashSet
            var myHash = new HashSet<String>();

            myHash.Add("hello");
            myHash.Add("hello");

            String[] s = new String[] { "hello" };
            Console.WriteLine(myHash.Count);
            Console.WriteLine(myHash.Overlaps(s));
            /*
            Queue<int> myQueue = new Queue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);

            foreach (var number in myQueue)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Peek());
            /*
            Stack<String> pancakes = new Stack<String>();

            pancakes.Push("first pancake made");
            pancakes.Push("second pancake made");
            pancakes.Push("Third pancake made");

            foreach (var pancake in pancakes)
            {
                Console.WriteLine(pancake);
            }

            Console.WriteLine(pancakes.Pop());
            Console.WriteLine(pancakes.Peek());
            Console.WriteLine(pancakes.Peek());

            /* Tuple
            // Tuple<int, String, bool> myTuple = new Tuple<int, string, bool>(1, "hello", true);

            var myTuple = Tuple.Create(1, "hello", true);

            Console.WriteLine(myTuple.Item2);

            /* Learning BitArray
            bool[] preload = new bool[3] { true, false, true };
            BitArray enemyGrid = new BitArray(preload);

            
            /* Learnign concurrency
            Thread thread1 = new Thread(new ThreadStart(AddItem));
            Thread thread2 = new Thread(new ThreadStart(AddItem));

            thread1.Start();
            thread2.Start();

            /*
            Console.WriteLine("Hello World");
            List<String> customers = new List<string>();

            customers.Add("Kim");
            customers.Add("John");

            Console.WriteLine(customers.Count);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine(customers[1]);
            

            Dictionary<String, String> config = new Dictionary<string, string>();

            config.Add("resolution", "1920x1080");
            config.Add("title", "MyWebsite");
            

            Console.WriteLine(config["title"]);

            foreach (var setting in config)
            {
                Console.WriteLine(setting.Value);
            }

            Hashtable table = new Hashtable();

            table.Add("title", "MyWebsite");

            var s = (String)table["title"];
            Console.WriteLine(s);
            */




        }
    }
}
