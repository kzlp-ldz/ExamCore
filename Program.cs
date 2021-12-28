using System;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = DataManag.GetEmployees();
            
            foreach (var d in b)
            {
                Console.WriteLine(d.fio);
            }
        }
    }
}
