using FinanceManager.Domain.Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    public class WalletDetail
    {
        public int _walletDetailID { get; }
        public int _walletID { get;}
        public string _name { get; private set; }
        public decimal _fund { get; private set; }
        public decimal _current { get; private set; }
        public DateTime _updatedDate { get; private set; }

        public WalletDetail(string name, decimal fund, decimal current) { 
            if (fund < 0)
                throw new ValueIsNegative("Fund value cannot be negative", nameof(fund));
            this._name = name;
            this._fund = fund;
            this._current = current;
            this._updatedDate = DateTime.Now;
        }

        public void updateWalletDetail(string name, decimal fund, decimal current) {
            if (fund < 0)
                throw new ValueIsNegative("Fund value cannot be negative", nameof(fund));
            this._name = name;
            this._fund = fund;
            this._current = current;
            this._updatedDate = DateTime.Now;
        }

        public void UpdateName(string name) { 
            this._name = name;
            this._updatedDate = DateTime.Now;
        }

        public void AddToFund(decimal amout) { 
            this._fund += amout;
            this._updatedDate = DateTime.Now;
        }

        public void UpdateFund(decimal fund) { 
            if (fund < 0)
                throw new ValueIsNegative("Fund value cannot be negative", nameof(fund));
            this._fund = fund;
            this._updatedDate = DateTime.Now;
        }

        public void AddToCurrent(decimal amout)
        {
            this._current += amout;
            this._updatedDate = DateTime.Now;
        }

        public void UpdateCurrent(decimal current) { 
            if (current < 0)
                throw new ValueIsNegative("Current value cannot be negative", nameof(current));
            this._current = current;
            this._updatedDate = DateTime.Now;
        }

    }
}
