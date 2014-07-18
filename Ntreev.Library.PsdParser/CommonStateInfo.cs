﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ntreev.Library.PsdParser.PsdParser
{
    struct CommonStateInfo
    {
        public int Size { get; set; }

        public int Version { get; set; }

        public bool Visible { get; set; }

        public short Unused { get; set; }
    }
}