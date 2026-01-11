using FinanceManager.Domain.Exception;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    public enum DeptType { 
        Owe,
        Lent
    }

    public enum PaidStatus
    {
        PAID,
        UNPAID
    }

    internal class Debt
    {
        private int _debtID { get; }
        private string _name { get; set; }
        private decimal _totalAmount { get; set; }
        private decimal _paidAmount { get; set; }
        private DeptType _type { get; set; }
        private string _description { get; set; }
        private DateTime _createAt { get; set; }
        private DateTime _updatedAt { get; set; }
        private DateTime _dueDate { get; set; }
        private PaidStatus _paidStatus { get; set; }
        private List<DebtHistory> _debtHistory { get; set; }

        private int _accountID;

        public Debt(string name, decimal price, decimal paid, DeptType type, string description, DateTime createAt, DateTime updatedAt, DateTime dueDate, PaidStatus paidStatus, List<DebtHistory> debtDetails)
        {
            _name = name;
            _totalAmount = price;
            _paidAmount = paid;
            _type = type;
            _description = description;
            _createAt = createAt;
            _updatedAt = updatedAt;
            _dueDate = dueDate;
            _paidStatus = paidStatus;
            this._debtHistory = debtDetails;
        }

        public Debt(string name, decimal price, decimal paid, DeptType type, string description, DateTime dueDate, PaidStatus paidStatus, List<DebtHistory> debtDetails)
        {
            _name = name;
            _totalAmount = price;
            _paidAmount = paid;
            _type = type;
            _description = description;
            _createAt = DateTime.Now;
            _updatedAt = DateTime.Now;
            _dueDate = dueDate;
            _paidStatus = paidStatus;
            this._debtHistory = debtDetails;
        }

        public Debt(string name, decimal price, decimal paid, DeptType type, string description, DateTime dueDate)
        {
            _name = name;
            _totalAmount = price;
            _paidAmount = paid;
            _type = type;
            _description = description;
            _createAt = DateTime.Now;
            _updatedAt = DateTime.Now;
            _paidStatus = PaidStatus.UNPAID;
            _dueDate = dueDate;
        }

        public void AddPayment(decimal amount) {
            if (amount < 0 || _paidAmount + amount > _totalAmount)
                throw new DomainException("Paid amount is invalid");
            DebtHistory debtHistory = new DebtHistory(amount);
            this._paidAmount += amount;

            if (this._paidAmount >= this._totalAmount) {
                this._paidStatus = PaidStatus.PAID;
            }

            //TODO: add to db
        }
        public void MarkAsPaid() {
            this._paidStatus = PaidStatus.PAID;
        }
        public decimal GetRemainingAmount() {
            return _totalAmount - _paidAmount;
        }
        public List<DebtHistory> GetDetails() {
            return _debtHistory;
        }
        bool IsPaid() { 
            return _paidStatus == PaidStatus.PAID;
        }
        bool IsOverdue() { 
            return _dueDate < DateTime.Now;
        }
    }
}
