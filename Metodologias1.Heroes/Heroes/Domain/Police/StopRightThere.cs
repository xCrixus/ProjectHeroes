﻿using System;

namespace Heroes.Domain.Police
{
    public class StopRightThere : IPoliceOrder
    {
        public void Execute()
        {
            Console.WriteLine("This is the police, Stop right there!");
        }
    }
}
