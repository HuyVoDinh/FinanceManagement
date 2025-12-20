using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    internal class ExpenseNoteBook
    {
        private string _id { get; }
        private string _name { get; set; }
        private double _ratio { get; set; }
        private decimal _price { get; set; }

        private int _accountID;

        public ExpenseNoteBook(string name, double ratio, decimal price) { 
            this._name = name;
            this._ratio = ratio;
            this._price = price;
        }
    }
}
