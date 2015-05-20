﻿using System;
using System.IO;
using System.Text;

namespace Ntreev.Library.Psd
{
    public struct FileHeaderSection
    {
        public int Depth
        {
            get;
            set;
        }

        public int NumberOfChannels
        {
            get;
            set;
        }

        public ColorMode ColorMode
        {
            get;
            set;
        }

        public int Height
        {
            get;
            set;
        }

        public int Width
        {
            get;
            set;
        }
    }
}