﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C_Funds_Transfer_Csharp.codec
{
    public class TransferResponse
    {


        public string mac
        {
            set;get;
        }

        public string transactionDate
        {
            set;get;
        }

        public string transferCode
        {
            set;get;
        }

        public string pin
        {
            set;get;
        }

        public string responseCode
        {
            set;get;
        }

        public ErrorResponse error
        {
            set;get;
        }

        public ErrorResponse[] errors
        {
            set;get;
        }
    }

}
