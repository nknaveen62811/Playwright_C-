using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Collections
    {

        [Test]
        public async Task nk()
        {
            /*
             List<string> names = new List<string>
             {

                 "nknaveen","nh","bhjb","bjhg"


             };
            // Console.WriteLine(names[1]);
            foreach(var name in names)
             {
                 Console.WriteLine(name);
             }

             HashSet<int> integers = new HashSet<int>
             {
                 1,2,3,4,5,6,7,8,9

             };
             foreach(int i in integers)
             {
                 Console.WriteLine(i);
             }
             
            HashSet<string> sett = new HashSet<string>();
            sett.Add("Naveen");
            sett.Add("nk");
            sett.Add("bhavana");
            sett.Remove("bhavana");
            sett.Count();
            sett.Clear();
            Console.WriteLine(sett.Count);
            Console.WriteLine(sett.Clear);
            foreach (var item in sett)
            {
               

            }
            Dictionary<char, string> d = new Dictionary<char, string>();
            d.Add('A', "ghj");
            d.Add('B', "fhf");
            Console.WriteLine(d['B']);
            
            Queue<string> name = new Queue<string>();
            name.Enqueue("A");
            name.Enqueue("B");
            name.Enqueue("C");
            name.Enqueue("D");

            name.Enqueue("E");
            Console.WriteLine(name.Dequeue());
           */
            Stack<string> stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            Console.WriteLine(stack.Pop());

        }
    }
    }

