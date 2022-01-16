using System; //Неиспользуемые пространства имен
using System.Collections.Generic;
using System.Text;

namespace Core.ViewModels
{
    public class EmployeeModel
    {
        public Employee employee { get; set; } //Названия свойств с заглавной буквы
        public List<Problems> problems { get; set; }
        public Position position { get; set; }
        public List<TypeTerapy> types { get; set; }
        public List<Client> clients { get; set; }
    }
}
