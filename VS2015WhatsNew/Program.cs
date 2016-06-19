using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS2015WhatsNew
{
    class Program
    {
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

        public class StringUtilities
        {
            public static string ReverseString(string str)
            {
                // where's the bug in my code?
                int len = str.Length;
                if (len > 1)
                {
                    var first = str.Substring(1);
                    var last = str.Substring(1, 1);
                    var reverse = ReverseString(first) + last;

                    return reverse;
                }
                return str;
            }
        }

        public class MemLoad
        {
            Dictionary<Guid, byte[]> repo = new Dictionary<Guid, byte[]>();
            public void Load(int count)
            {
                for (int i=0; i<count; i++)
                {
                    repo.Add(Guid.NewGuid(),System.IO.File.ReadAllBytes("guy.jpg"));
                    System.Threading.Thread.Sleep(10);
                }
            }
        }



        static void Main(string[] args)
        {
            //Fibonachi f = new Fibonachi();
            //int index = 4;
            //int result = f.fibo(index);
            //Console.WriteLine($"fibo({index}) = {result}");

            var str = "hello SDP audience!";
            var revStr = StringUtilities.ReverseString("hello SDP audience!");
            Console.WriteLine($"{str} => {revStr}");

            //try
            //{
            //    MemLoad memLoad = new MemLoad();
            //    memLoad.Load(1000);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}




            Console.ReadKey();



        }
    }
}
