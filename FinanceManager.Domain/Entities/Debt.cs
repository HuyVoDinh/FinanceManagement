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
        private int _debtID { get; }
        private string _name { get; set; }
        private decimal _price { get; set; }
        private decimal _paid { get; set; }
        private DeptType _type { get; set; }
        private string _description { get; set; }
        private DateTime _createAt { get; set; }
        private DateTime _updatedAt { get; set; }
        private DateTime _dueDate { get; set; }
        private List<DebtDetail> debtDetails { get; set; }

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
