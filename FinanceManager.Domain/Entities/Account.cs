using FinanceManagement.Domain.Security;
using FinanceManagement.Infrastructure.Security;
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
    class Account
    {
        private string _id { get; }
        private string _username { get; set; }
        private PasswordHasher _passwordHasher = new PasswordHasher();
        private string _password { get; set; }
        private AccountStatus _status { get; set; }
        private DateTime _createAt { get; set; }

        public Account(string username, string password)
        {
            if (string.IsNullOrEmpty(username)) throw new DomainException("Username is null or empty");
            if (!isStrongPassword(password)) throw new DomainException("Strong is weak");

            _username = username;
            _password = _passwordHasher.Hash(password);
            _status = AccountStatus.INACTIVE;
            _createAt = DateTime.Now;
        }


        public bool VerifyPassword(string password)
        {
            return _passwordHasher.Verify(password, _password);
        }

        public void ChangePassword(string oldPassword, string newPassword)
        {
            if (_passwordHasher.Hash(oldPassword) != _password)
                throw new DomainException($"Password is not match");

            if (isStrongPassword(newPassword))
                throw new DomainException("Password is weak");

            if (_passwordHasher.Hash(newPassword) == _password)
                throw new DomainException("New password is same old password");

            _password = _passwordHasher.Hash(newPassword);
        }

        public void Activate()
        {
            _status = AccountStatus.ACTIVE;
        }

        public void Lock()
        {
            _status = AccountStatus.LOCKED;
        }

        public void MarkAsDeleted()
        {
            _status = AccountStatus.DELETED;
        }

        private bool isStrongPassword(string password)
        {
            if (password.Length < 8) return false;

            bool isUpper = false, isLower = false, isDigit = false, isSpecial = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                    isUpper = true;
                else if (char.IsLower(password[i]))
                    isLower = true;
                else if (char.IsDigit(password[i]))
                    isDigit = true;
                else
                    isSpecial = true;
            }
            return isUpper && isLower && isDigit && isSpecial;
        }
    }
}
