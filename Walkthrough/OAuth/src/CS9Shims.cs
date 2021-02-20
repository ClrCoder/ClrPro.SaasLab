// Copyright (c) ClrCoder Community. All Rights Reserved.
// Licensed under the MIT license. See LICENSE in the project root for license information.

#if NETFRAMEWORK
// This is bug workarond, see:
// https://stackoverflow.com/questions/62648189/testing-c-sharp-9-0-in-vs2019-cs0518-isexternalinit-is-not-defined-or-imported
namespace System.Runtime.CompilerServices
{
    public class IsExternalInit
    {
    }
}
#endif
