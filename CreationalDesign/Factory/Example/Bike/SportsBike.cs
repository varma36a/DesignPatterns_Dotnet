﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Example
{
    public class SportsBike:Bike
    {
        public override void Create()
        {
            Console.WriteLine("SportsBike");
        }
    }
}
