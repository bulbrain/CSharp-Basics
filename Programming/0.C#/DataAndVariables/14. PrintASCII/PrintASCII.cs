﻿using System;

class PrintASCII
{
    static void Main()
    {
        for (int i = 0; i < 256; i++)
        {
            Console.WriteLine((char)i);
        }
    }
}