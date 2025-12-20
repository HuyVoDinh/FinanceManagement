using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    internal class Income
    {
        private int _id;
        private string _name;
        private decimal _income;
        private decimal _moneyReduce;

        private int _accountID;

        public Income(string name) { 
            this._name = name;
            this._income = 0;
            this._moneyReduce = 0;
        }
    }
}
