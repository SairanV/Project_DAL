using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timm_DAL;

namespace Tima.BLL
{
    public class ServiceAccount
    { 

        public List<Account> GetClientAccount(int clientId)
        {
            RepositoryAccount repository = new RepositoryAccount();

            List<Account> accounts = repository.GetAccount(clientId);


            return accounts;
        }
    }
}
