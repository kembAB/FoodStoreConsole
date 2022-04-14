using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentonecsharp
{


    class GroceryStore
    {

        static void Main(String[] args)
        {

            Console.Title = "Apu's Supermarket";

            Product product = new Product();
            product.start();
            Console.Write(" press Enter to EXit !");
            Console.ReadKey();



        }
    }
}    
      