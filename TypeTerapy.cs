using System;
using System.Collections.Generic;
using System.Text;  

namespace Core
{
    public class TypeTerapy
    {
        public int id_type { get; set; }
        public string name { get; set; }
        public int price { get; set; }  //для денег лучше подходит тип данных decimal 
    }
}
