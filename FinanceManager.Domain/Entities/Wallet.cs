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
    }
}
