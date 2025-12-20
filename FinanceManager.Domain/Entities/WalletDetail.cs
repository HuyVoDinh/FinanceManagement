using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    internal class WalletDetail
    {
        private int _walletDetailID { get; }
        private int _walletID { get;}
        private string _name { get; set; }
        private decimal _fund { get; set; }
        private decimal _current { get; set; }
        private DateTime _updatedDate { get; set; }

        public WalletDetail(string name, decimal fund, decimal current) { 
            this._name = name;
            this._fund = fund;
            this._current = current;
            this._updatedDate = DateTime.Now;
        }
    }
}
