﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace DOAN.Module.ORMDataModel1
{

    public partial class User : XPObject
    {
        string fFullName;
        public string FullName
        {
            get { return fFullName; }
            set { SetPropertyValue<string>(nameof(FullName), ref fFullName, value); }
        }
        string fPassword;
        public string Password
        {
            get { return fPassword; }
            set { SetPropertyValue<string>(nameof(Password), ref fPassword, value); }
        }
        string fAvatar;
        public string Avatar
        {
            get { return fAvatar; }
            set { SetPropertyValue<string>(nameof(Avatar), ref fAvatar, value); }
        }
        string fNumberPhone;
        public string NumberPhone
        {
            get { return fNumberPhone; }
            set { SetPropertyValue<string>(nameof(NumberPhone), ref fNumberPhone, value); }
        }
        string fAddress;
        public string Address
        {
            get { return fAddress; }
            set { SetPropertyValue<string>(nameof(Address), ref fAddress, value); }
        }
        string fEmail;
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>(nameof(Email), ref fEmail, value); }
        }
        string fRoles;
        public string Roles
        {
            get { return fRoles; }
            set { SetPropertyValue<string>(nameof(Roles), ref fRoles, value); }
        }
        [Association(@"OrderReferencesUser")]
        public XPCollection<Order> Orders { get { return GetCollection<Order>(nameof(Orders)); } }
        [Association(@"StoreReferencesUser")]
        public XPCollection<Store> Stores { get { return GetCollection<Store>(nameof(Stores)); } }
    }

}
