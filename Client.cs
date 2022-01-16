using System; // неиспользуемая деректива using
using System.Collections.Generic;
using System.Text;
using Core.ViewModels;

namespace Core
{
    public class Client
    {
        public int id_client { get; set; }
        public string fio { get; set; }
        public string passport { get; set; }
        public string phone { get; set; } // Имена свойств с заглавной буквы :/
        public int id_type { get; set; }
        public int id_employee { get; set; }
        public void AddClient (Client client, List<TypeTerapy> types)  
        {
            var model = new ClientModel() { client = client, type = types};
            DataManag.AddClient(model);
        }
        public void RemoveClient (Client client)
        {
            DataManag.RemoveClient(client.id_client);
        }
    }
    
}

// лучше поместить файлы с классами в отдельную папку