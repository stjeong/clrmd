﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

namespace Microsoft.Diagnostics.Runtime.Utilities
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ElfDynamicEntry32
    {
        public int Tag;            // d_tag
        public uint Ptr;           // d_val/d_ptr
    }
}