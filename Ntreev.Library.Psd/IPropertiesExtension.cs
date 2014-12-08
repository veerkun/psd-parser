﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ntreev.Library.Psd
{
    public static class IPropertiesExtension
    {
        public static string ToString(this IProperties props, string property)
        {
            return props[property] as string;
        }

        public static int ToInt32(this IProperties props, string property)
        {
            return (int)props[property];
        }

        public static float ToSingle(this IProperties props, string property)
        {
            return (float)props[property];
        }

        public static bool ToBoolean(this IProperties props, string property)
        {
            return (bool)props[property];
        }
    }
}