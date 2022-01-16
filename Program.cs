using System;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = DataManag.GetEmployees(); // Переменные должны иметь более осмысленные названия
            
            foreach (var d in b)
            {
                Console.WriteLine(d.fio);
            }
        }
    }
}
