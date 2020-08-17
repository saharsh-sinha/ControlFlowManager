﻿using HumanBeing.Declarations;
using System;
using System.Threading;

namespace HumanBeing.Core.Definitions.DailyTasks
{
    public class TheCooking : TaskBase, IDailyTask
    {
        public override void Execute()
        {
            Console.WriteLine("Food's getting ready");
            Thread.Sleep(100);
        }
    }
}
