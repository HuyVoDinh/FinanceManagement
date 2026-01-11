using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    internal class DebtHistory
    {
        private int _id { get; }
        private int _debtID { get; set; }
        private DateTime _paidDate { get; set; }
        private decimal _amount { get; set; }

        public DebtHistory(DateTime paidDate, decimal amount) { 
            this._paidDate = paidDate;
            this._amount = amount;
        }

        public DebtHistory(decimal amount) { 
            this._amount = amount;
            this._paidDate = DateTime.Now;
        }

        public void updateHistory(DebtHistory debtHistory) {
            this._paidDate = debtHistory._paidDate;
            this._amount = debtHistory._amount;
        }
    }
}
