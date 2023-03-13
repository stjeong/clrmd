﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.Diagnostics.Runtime
{
    internal enum DumpFileFormat
    {
        Unknown,
        Minidump,
        Userdump64,
        ElfCoredump,
        CompressedArchive,
        MachOCoredump,
    }
}