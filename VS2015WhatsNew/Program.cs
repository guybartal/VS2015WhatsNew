using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS2015WhatsNew
{
    class Program
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }

        public class Fibonachi
        {
            // 1,1,2,3,5,...
            public int fibo(int n)
            {
                int r;
                if (n < 1)
                {
                    r = 1;
                }
                else
                {
                    r = fibo(n - 1) + fibo(n - 2);
                }

                return r;
            }
        }

        public class MemLoad
        {
            Dictionary<Guid, byte[]> repo = new Dictionary<Guid, byte[]>();
            public void Load()
            {
                for (int i=0; i<5000; i++)
                {
                    repo.Add(Guid.NewGuid(),System.IO.File.ReadAllBytes("guy.jpg"));
                    System.Threading.Thread.Sleep(10);
                }
            }
        }



        static void Main(string[] args)
        {
            Fibonachi f = new Fibonachi();
            int index = 4;
            int result = f.fibo(index);
            Console.WriteLine($"fibo({index}) = {result}");

            //try
            //{
            //    MemLoad memLoad = new MemLoad();
            //    memLoad.Load();
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

            Console.ReadKey();



        }
    }
}
