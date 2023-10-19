using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timm_DAL;

namespace Tima.BLL
{
    public interface IRepositoryAccount
    {
        bool CreateAccount(Account account);
        List<Account> GetAccount(int clientId);



    }
}
