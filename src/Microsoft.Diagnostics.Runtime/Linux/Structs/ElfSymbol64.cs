﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

namespace Microsoft.Diagnostics.Runtime.Utilities
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ElfSymbol64
    {
        public uint Name;
        public byte Info;
        public byte Other;
        public ushort Shndx;
        public uint Value;
        public ulong Size;
    }
}