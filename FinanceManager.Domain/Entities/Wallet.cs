using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    public class Wallet
    {
        private int _walletID {  get; }
        private List<WalletDetail> _walletDetails { get; set; }
        private int _accountID { get; set; }

        public Wallet() { 
            this._walletDetails = new List<WalletDetail>();
        }

        public Wallet(List<WalletDetail> walletDetails)
        {
            this._walletDetails = walletDetails;
        }

        public void AddWalletDetail(WalletDetail walletDetail) { 
            this._walletDetails.Add(walletDetail);
        }

        public void RemoveWalletDetail(int walletDetailID) { 
            this._walletDetails.RemoveAll(wd => wd._walletDetailID == walletDetailID);
        }

        public List<WalletDetail> GetWalletDetails() { 
            return this._walletDetails;
        }

        public void showWalletDetails() { 
            foreach(var wd in this._walletDetails) { 
                Console.WriteLine($"Wallet Detail ID: {wd._walletDetailID}, Name: {wd._name}, Fund: {wd._fund}, Current: {wd._current}");
            }
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
