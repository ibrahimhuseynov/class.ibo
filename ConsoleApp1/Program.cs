using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product prd=new Product();
            prd.name = "kartof";
            prd.brandname = "bakikartofu";
            prd.price = 0.80;
            Console.WriteLine("name :" + prd.name);
            Console.WriteLine("brandname :"+prd.brandname);
            Console.WriteLine("price :"+prd.price);
            Console.Read();
        }
    }
}
