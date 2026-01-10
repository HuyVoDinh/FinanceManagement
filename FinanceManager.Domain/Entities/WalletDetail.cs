using FinanceManager.Domain.Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    public class WalletDetail
    {
        public int _walletDetailID {get; }
        private int _walletID { get;}
        private string _name { get; set; }
        private decimal _fund { get; set; }
        private decimal _current { get; set; }
        private DateTime _updatedDate { get; set; }

        public WalletDetail(string name, decimal fund, decimal current) {
            if (fund < 0) throw new DomainException("Value is not valid");   

            this._name = name;
            this._fund = fund;
            this._current = current;
            this._updatedDate = DateTime.Now;
        }

        public void Update(WalletDetail walletDetail) {
            _name = walletDetail._name;
            _fund = walletDetail._fund;
            _current = walletDetail._current;
            _updatedDate = walletDetail._updatedDate;
        }
        
    }
}
