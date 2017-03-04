﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMode.SimpleMode
{
    public abstract class AbstractCarFactory
    {
        public abstract ICar CreateCar(string type);
    }
}