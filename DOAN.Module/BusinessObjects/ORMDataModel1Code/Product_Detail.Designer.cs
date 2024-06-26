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

    public partial class Product_Detail : XPObject
    {
        string fColor;
        public string Color
        {
            get { return fColor; }
            set { SetPropertyValue<string>(nameof(Color), ref fColor, value); }
        }
        string fSize;
        public string Size
        {
            get { return fSize; }
            set { SetPropertyValue<string>(nameof(Size), ref fSize, value); }
        }
        short fStock;
        public short Stock
        {
            get { return fStock; }
            set { SetPropertyValue<short>(nameof(Stock), ref fStock, value); }
        }
        Product fProductId;
        [Association(@"Product_DetailReferencesProduct")]
        public Product ProductId
        {
            get { return fProductId; }
            set { SetPropertyValue<Product>(nameof(ProductId), ref fProductId, value); }
        }
        [Association(@"Store_DetailReferencesProduct_Detail")]
        public XPCollection<Store_Detail> Store_Details { get { return GetCollection<Store_Detail>(nameof(Store_Details)); } }
        [Association(@"Order_DetailReferencesProduct_Detail")]
        public XPCollection<Order_Detail> Order_Details { get { return GetCollection<Order_Detail>(nameof(Order_Details)); } }
    }

}
