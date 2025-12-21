using FinanceManagement.Domain.Security;
using FinanceManager.Domain.Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Entities
{
    public enum AccountStatus { 
        INACTIVE,
        ACTIVE,
        LOCKED,
        DELETED
    }
    internal class Account
    {
        private string _id { get; }
        private string _username { get; set; }
        private IPasswordHasher _passwordHasher { get;}
        private string _password { get; set; }
        private AccountStatus _status { get; set; }
        private DateTime _createAt { get; set; }

        public Account(string username, string password)
        {
            if(string.IsNullOrEmpty(username)) throw new DomainException("Username is null or empty");
            if (isStrongPassword(password)) throw new DomainException("Strong is weak");

            _username = username;
            _password = _passwordHasher.Hash(password);
            _status = AccountStatus.INACTIVE;
            _createAt = DateTime.Now;
        }


        public bool VerifyPassword(string password) {
            return _passwordHasher.Verify(password, _password);
        }

        public void ChangePassword(string oldPassword, string newPassword) {
            if(_passwordHasher.Hash(oldPassword) != _password)
                throw new DomainException($"Password is not match");

            if (isStrongPassword(newPassword))
                throw new DomainException("Password is weak");

            if (_passwordHasher.Hash(newPassword) == _password)
                throw new DomainException("New password is same old password");

            _password = _passwordHasher.Hash(newPassword);
        }

        void Activate() { 
            _status = AccountStatus.ACTIVE;
        }

        void Lock() { 
            _status = AccountStatus.LOCKED;
        }

        void MarkAsDeleted() { 
            _status |= AccountStatus.DELETED;
        }

        private bool isStrongPassword(string password) { 
            if(password.Length < 8) return false;

            return true;
        }
    }
}
