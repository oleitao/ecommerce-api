﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 6/6/2024 8:19:55 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace Model
{
    public partial class ShopAvatar {

        public ShopAvatar()
        {
            OnCreated();
        }

        public Guid Id { get; set; }

        public string PublicId { get; set; }

        public string Url { get; set; }

        public Guid ShopId { get; set; }

        public virtual Shop Shop { get; set; }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}
