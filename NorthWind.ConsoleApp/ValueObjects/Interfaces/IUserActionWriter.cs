﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entities.ValueObjects.Interfaces
{
    public interface IUserActionWriter

    {
        void Write(UserAction action);
    }
}
