﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGC.Library
{
    public interface ITimeIntervals
    {
        TimeIntervals Today();

        TimeIntervals Tomorrow();

        TimeIntervals ThisWeek();

        TimeIntervals NextWeek();

        TimeIntervals ThisMonth();

        TimeIntervals NextMonth();

        TimeIntervals NextNMonth(int numberOfMonth, bool getSingleMonth);

        void WriteConsoleLog();
    }
}
