using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    public enum DebtType { 
        Owe,
        Lent
    }

    public class Debt
    {
        private int _debtID { get; }
        private string _name { get; set; }
        private decimal _price { get; set; }
        private decimal _paid { get; set; }
        private DebtType _type { get; set; }
        private string _description { get; set; }
        private DateTime _createAt { get; set; }
        private DateTime _updatedAt { get; set; }
        private DateTime _dueDate { get; set; }
        private List<DebtDetail> _debtDetails { get; set; }

        private int _accountID { get; }

        public Debt(string name, decimal price, decimal paid, DebtType type, string description, DateTime createAt, DateTime updatedAt, DateTime dueDate, List<DebtDetail> debtDetails)
        {
            _name = name;
            _price = price;
            _paid = paid;
            _type = type;
            _description = description;
            _createAt = createAt;
            _updatedAt = updatedAt;
            _dueDate = dueDate;
            _debtDetails = debtDetails;
        }

        public Debt(string name, decimal price, decimal paid, DebtType type, string description, DateTime dueDate, List<DebtDetail> debtDetails)
        {
            _name = name;
            _price = price;
            _paid = paid;
            _type = type;
            _description = description;
            _createAt = DateTime.Now;
            _updatedAt = DateTime.Now;
            _dueDate = dueDate;
            _debtDetails = debtDetails;
        }

        public Debt(string name, decimal price, decimal paid, DebtType type, string description, DateTime dueDate)
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
