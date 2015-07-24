using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    from RockStar import RockStar


csharp_code = """using System;

internal class HelloWorld
    {
        private static void Main()
        {
            Console.WriteLine("Hello world");
        }
    }"""

rock_it_bro = RockStar(days= 400, file_name= 'helloWorld.cs', code= csharp_code)
rock_it_bro.make_me_a_rockstar()
}