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
        private string _id { get;  }
        private string _username { get; set; }
        private string _password { get; set; }
        private AccountStatus _status { get; set; }
        private DateTime _createAt { get; set; }

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
