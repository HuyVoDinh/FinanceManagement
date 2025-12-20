using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    internal class WalletDetail
    {
        private int _walletDetailID;
        private int _walletID;
        public string name { get; set; }
        public decimal fund { get; set; }
        public decimal current { get; set; }
        public DateTime updatedDate { get; set; }
    }
}
