using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timm_DAL
{
    public class Account
    {
        public int ID {  get; set; }
        public DateTime CreateDate { get; set; }
        public string IBAN { get; set; } //KZ696645
        public int ClientID { get; set; }
        public double Balance { get; set; }
        public string BankName { get; set; }
        public int Currency { get; set; }  // 1-KZT, 2-USD
    }
}
