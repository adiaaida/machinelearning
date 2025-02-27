﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;
using TorchSharp;

namespace Microsoft.ML.TorchSharp.NasBert.Models
{
    internal abstract class BaseHead : BaseModule
    {
        protected BaseHead(string name) : base(name)
        {
        }
    }
}
