﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace HearthStoneLib
{
    static class ExtensionMethods
    {
        static readonly RNGCryptoServiceProvider random = new RNGCryptoServiceProvider();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do random.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
