﻿using Vanderbilt.Biostatistics.Wfccm2;

namespace ExpressionEvaluator.Procedures.Functions
{
    internal class Substring : Function
    {
        public Substring(int precedance)
            : base("substring", precedance, 3, false)
        {
            _name2 = "Substring";
            StringDecimalDecimalString = (x, y, z) => x.Substring((int)y, (int)z);
        }
    }
}
