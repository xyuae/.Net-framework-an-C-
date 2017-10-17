using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningNull
{
    class Person
    {
        public int MyProperty { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String s = null; //"hello";

            int? i = null;
            int i2 = i ?? 2;
            var s2 = s ?? "default";

            Console.WriteLine(s2);

            try
            {
                throw new Exception();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            } 
        }
    }
}
