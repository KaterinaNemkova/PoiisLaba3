using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiis3
{
    public class Coach:Person
    {
        List<Client> ClientList { get; set; }=new List<Client>();
        
        public string Spetialization {  get; set; }

        public Coach(string name,string spetialization):base(name)
        {
            Spetialization = spetialization;
            
        }

        public void AddClient(Client client)
        {
            ClientList.Add(client);
        }
        public void PrintClientList()
        {
            Console.WriteLine($"Список клиентов для тренера {Name}:");
            foreach (Client client in ClientList)
            {
                Console.WriteLine($"Имя: {client.Name}, Пол: {client.Sex}, Возраст: {client.Age}, Вес: {client.StartWeight}, Рост: {client.Height}");
            }
        }
        
    }

}
