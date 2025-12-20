using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    internal class ExpenseNoteBook
    {
        private string _id;
        private string _name;
        private double _ratio;
        private decimal _price;

        private int _accountID;

        public ExpenseNoteBook(string name, double ratio, decimal price) { 
            this._name = name;
            this._ratio = ratio;
            this._price = price;
        }
    }
}
