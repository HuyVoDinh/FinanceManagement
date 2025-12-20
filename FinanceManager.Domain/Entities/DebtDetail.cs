using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    public enum PaidStatus { 
        PAID,

    }
    internal class DebtDetail
    {
        private int _id;
        private int _debtID;
        private DateTime _paidDate;
        private decimal _amount;
        private PaidStatus _status;
    }
}
