using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    internal class Wallet
    {
        private int _walletID {  get; }
        private List<WalletDetail> walletDetails { get; set; }
        private int _accountID { get; set; }

        public Wallet(List<WalletDetail> walletDetails) {
            this.walletDetails = walletDetails;
        }

        public Wallet() { 
            this.walletDetails = new List<WalletDetail>();
        }
    }
}
