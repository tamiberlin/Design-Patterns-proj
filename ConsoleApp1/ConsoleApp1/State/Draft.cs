﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.State
{
    internal class Draft : IState
    {
        public string GetTypeState()
        {
            return "Draft";
        }

        public IState SetState()
        {
            return new Marged();
        }
    }
}