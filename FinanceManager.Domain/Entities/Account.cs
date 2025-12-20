using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    public enum AccountStatus { 
        INCONFIRM,
        CONFIRMED,
        DELETED
    }
    internal class Account
    {
        private string _id;
        private string _username;
        private string _password;
        private AccountStatus _status;
        private DateTime _createAt;

        public Account(string id, string username, string password)
        {
            _id = id;
            _username = username;
            _password = password;
            _status = AccountStatus.INCONFIRM;
            _createAt = DateTime.Now;
        }
    }

    
}
