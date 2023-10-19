using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tima.DAL;

namespace Timm_DAL
{
    public interface IRepositoryClient
    {
        bool CreateClient(Client client);
        List<Client> GetAllClients();
        Client GetClientById(int id);
        Client GetClient(string login, string password);
    }
}
