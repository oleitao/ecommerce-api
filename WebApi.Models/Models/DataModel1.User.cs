﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 6/7/2024 5:36:32 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace Model
{
    public partial class User : IdentityUser
    {

        public User()
        {
            OnCreated();
        }

        //public Guid Id { get; set; }

        public string FullName { get; set; } = null!;

        public DateTime Birthday { get; set; }

        public string Hobby { get; set; } = null!;

        public string Gender { get; set; } = null!;

        public int Age { get; set; }

        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}
