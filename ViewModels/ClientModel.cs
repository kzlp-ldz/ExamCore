using System;
using System.Collections.Generic;
using System.Text;// Неиспользуемая деректива using

namespace Core.ViewModels
{
    public class ClientModel
    {
        public Client client { get; set; } //Названия свойств с заглавной буквы
        public List<TypeTerapy> type { get; set; }
    }
}
