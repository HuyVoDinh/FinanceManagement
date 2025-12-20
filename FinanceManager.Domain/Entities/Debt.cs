using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    public enum DeptType { 
        Owe,
        Lent
    }

    internal class Debt
    {
        private int _debtID;
        private string _name;
        private decimal _price;
        private decimal _paid;
        private DeptType _type;
        private string _description;
        private DateTime _createAt;
        private DateTime _updatedAt;
        private DateTime _dueDate;
        private List<DebtDetail> debtDetails;

        private int _accountID;

        public Debt(string name, decimal price, decimal paid, DeptType type, string description, DateTime createAt, DateTime updatedAt, DateTime dueDate, List<DebtDetail> debtDetails)
        {
            _name = name;
            _price = price;
            _paid = paid;
            _type = type;
            _description = description;
            _createAt = createAt;
            _updatedAt = updatedAt;
            _dueDate = dueDate;
            this.debtDetails = debtDetails;
        }

        public Debt(string name, decimal price, decimal paid, DeptType type, string description, DateTime dueDate, List<DebtDetail> debtDetails)
        {
            _name = name;
            _price = price;
            _paid = paid;
            _type = type;
            _description = description;
            _createAt = DateTime.Now;
            _updatedAt = DateTime.Now;
            _dueDate = dueDate;
            this.debtDetails = debtDetails;
        }

        public Debt(string name, decimal price, decimal paid, DeptType type, string description, DateTime dueDate)
        {
            _name = name;
            _price = price;
            _paid = paid;
            _type = type;
            _description = description;
            _createAt = DateTime.Now;
            _updatedAt = DateTime.Now;
            _dueDate = dueDate;
        }

        
    }
}
