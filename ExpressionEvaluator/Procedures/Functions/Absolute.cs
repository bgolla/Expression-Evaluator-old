﻿using System;
using Vanderbilt.Biostatistics.Wfccm2;

namespace ExpressionEvaluator.Procedures.Functions
{
    internal class Absolute : Function
    {
        public Absolute(int precedance)
            : base("abs", precedance, 1, false)
        {
            _name2 = "Absolute";
            DecimalDecimal = x => {
                double dblResult = Math.Abs((double)x);
                if (double.IsNaN(dblResult)) {
                    throw new NotFiniteNumberException("Not a number");
                }
                return Convert.ToDecimal(dblResult.ToString("R"));
            };
        }
    }
}
