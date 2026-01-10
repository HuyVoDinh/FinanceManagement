using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    internal class Wallet
    {
        private int _walletID {  get; }
        private string _name = "";
        private List<WalletDetail> walletDetails { get; set; }
        private int _accountID { get; set; }

        public Wallet(List<WalletDetail> walletDetails) {
            this.walletDetails = walletDetails;
        }

        public Wallet() { 
            this.walletDetails = new List<WalletDetail>();
        }

        public Wallet(string name) { 
            this._name = name;
            this.walletDetails = new List<WalletDetail>();
        }

        public Wallet(string name, List<WalletDetail> walletDetails) { 
            this._name = name;
            this.walletDetails = walletDetails;
        }

        public void Rename(string newName) {
            this._name = newName;
        }

        public void Add(WalletDetail walletDetail) { 
            this.walletDetails.Add(walletDetail);
            //TODO: Add to db
        }

        public void Remove(int walledDetailID)
        {
            foreach (WalletDetail walletDetail in this.walletDetails) {
                if (walletDetail._walletDetailID == walledDetailID)
                {
                    this.walletDetails.Remove(walletDetail); break;
                }
            }
        }
    }
}
