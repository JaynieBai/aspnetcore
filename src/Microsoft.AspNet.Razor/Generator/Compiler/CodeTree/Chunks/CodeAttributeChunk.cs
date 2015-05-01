// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Razor.Text;

namespace Microsoft.AspNet.Razor.Generator.Compiler
{
    public class CodeAttributeChunk : ChunkBlock
    {
        public string Attribute { get; set; }
        public LocationTagged<string> Prefix { get; set; }
        public LocationTagged<string> Suffix { get; set; }
    }
}
