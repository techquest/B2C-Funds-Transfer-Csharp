﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C_Funds_Transfer_Csharp.codec
{
    public class Sender
    {

        private String phone;
        private String email;
        private String lastname;
        private String othernames;

        public Sender(String phone, String email, String lastname, String othernames)
        {
            this.phone = phone;
            this.email = email;
            this.lastname = lastname;
            this.othernames = othernames;
        }

        public Sender()
        {
        }

        public String getPhone()
        {
            return phone;
        }
        public void setPhone(String phone)
        {
            this.phone = phone;
        }
        public String getEmail()
        {
            return email;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public String getLastName()
        {
            return lastname;
        }
        public void setLastName(String lastName)
        {
            this.lastname = lastName;
        }
        public String getOtherNames()
        {
            return othernames;
        }
        public void setOtherNames(String otherNames)
        {
            this.othernames = otherNames;
        }
    }

}
