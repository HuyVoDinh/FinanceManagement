using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    internal class Wallet
    {
        private int _walletID {  get; set; }
        private List<WalletDetail> walletDetails;
        private int _accountID;

        public Wallet(List<WalletDetail> walletDetails) {
            this.walletDetails = walletDetails;
        }

        public Wallet() { 
            this.walletDetails = new List<WalletDetail>();
        }
    }
}
