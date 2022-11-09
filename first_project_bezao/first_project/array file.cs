using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





public class ArrayFiles
{
    public void CollectName()
    {
        Console.WriteLine("Enter your full name:");
        string name = Console.ReadLine();
        var result = name.First().ToString().ToUpper() + name.Substring(1);

        Console.Write(result);

        Console.ReadKey();
    }
}

