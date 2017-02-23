﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C_Funds_Transfer_Csharp.codec
{
    public class AccountReceivable
    {
        private String accountNumber;
        private String accountType;

        public AccountReceivable(String accountNumber, String accountType)
        {
            this.accountType = accountType;
            this.accountNumber = accountNumber;
        }

        public String getAccountNumber()
        {
            return accountNumber;
        }
        public void setAccountNumber(String accountNumber)
        {
            this.accountNumber = accountNumber;
        }
        public String getAccountType()
        {
            return accountType;
        }
        public void setAccountType(String accountType)
        {
            this.accountType = accountType;
        }
    }
}
