﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ewssApp1
{
    public class ChartDataModel
    {
        public string Category { get; set; }
        public double Value { get; set; }

        public ChartDataModel(string category, double value)
        {
            Category = category;
            Value = value;
        }
    }
}
