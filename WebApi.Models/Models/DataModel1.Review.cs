﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 6/7/2024 5:36:32 PM
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
    public partial class Review {

        public Review()
        {
            OnCreated();
        }

        public Guid Id { get; set; }

        public string Comment { get; set; } = null!;

        public int Rating { get; set; }

        public Guid UserId { get; set; }

        public User? User { get; set; }

        public Guid ProductId { get; set; }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}
