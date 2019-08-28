﻿using System;
namespace C1GridControl
{
    public class License
    {
        public const string Key = "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";
    }
}
