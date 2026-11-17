using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Ignorecs
    {

        [Order(2)]
        [Test]
        public async Task nk()
        {
            Console.WriteLine("Prabhass");
        }
        [Order(1)]
        [Test]
        public async Task A()
        {
            Console.WriteLine("RGV");
        }
       
    }
}
