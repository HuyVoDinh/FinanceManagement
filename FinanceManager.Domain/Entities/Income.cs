using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    internal class Income
    {
        private int _id { get; }
        private string _name { get; set; }
        private decimal _income { get; set; }
        private decimal _moneyReduce { get; set; }

        private int _accountID;

        public Income(string name) { 
            this._name = name;
            this._income = 0;
            this._moneyReduce = 0;
        }
    }
}
