﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    public interface IDirectionCommand
    {
        void Execute(float direction);
    }
}