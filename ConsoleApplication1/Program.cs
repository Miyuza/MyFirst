using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String u = "maham";
            int a = u.GetHashCode();
            Console.WriteLine(a);
            String p = "12345";
            int b = p.GetHashCode();
            Console.WriteLine(b);
            String p1 = "12345";
            int b1 = p1.GetHashCode();
            Console.WriteLine(b1);
            Console.WriteLine(DateTime.Now);
            Guid g;
            g = Guid.NewGuid();
            String str = g.ToString();
            Console.WriteLine(g);
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(str);
            String[] ab = str.Split('-');
            Console.WriteLine(ab[0]);
        }
    }
}
