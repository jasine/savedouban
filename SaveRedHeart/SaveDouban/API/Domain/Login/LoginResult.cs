﻿#region Copyright
/*
       Author:	Ran
  Last Update:	2012-7-12 6:22
Creating Time:	2012-7-12 4:25

      Project:  DoubanFM API Code Pack
         File:	LoginResult.cs
      
     Copyright (c) Chobi-Q 2012 All rights reserved.
*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChobiQ.DoubanFMAPICodePack
{
    /// <summary>
    /// Specifies sign-in result.
    /// </summary>
    public enum LoginResult
    {
        Success,
        InvalidEmail,
        InvalidPassword
    }
}
