using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    public enum PaidStatus { 
        PAID,
        UNPAID
    }
    public class DebtDetail
    {
        private int _id { get; }
        private int _debtID { get; set; }
        private DateTime _paidDate { get; set; }
        private decimal _amount { get; set; }
        private PaidStatus _status { get; set; }

        public DebtDetail(DateTime paidDate, decimal amount, PaidStatus status) { 
            this._paidDate = paidDate;
            this._amount = amount;
            this._status = status;
        }

        public DebtDetail(decimal amount) { 
            this._amount = amount;
            this._paidDate = DateTime.Now;
            this._status = PaidStatus.PAID;
        }
    }
}
