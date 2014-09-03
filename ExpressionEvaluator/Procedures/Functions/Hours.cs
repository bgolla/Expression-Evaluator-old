﻿using System;
using Vanderbilt.Biostatistics.Wfccm2;

namespace ExpressionEvaluator.Procedures.Functions
{
    internal class Hours : Function
    {
        public Hours(int precedance)
            : base("hours", precedance, 1, false)
        {
            _name2 = "Hours";
            DecimalTimespan = x => new TimeSpan((long)(x * TimeSpan.TicksPerHour));
        }
    }
}
