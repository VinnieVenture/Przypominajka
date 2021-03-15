﻿using Przypominajka.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przypominajka.Core.Interfaces
{
    public interface IDataLoadingType
    {
        AlarmsDTO ReadData();
        void WriteData(AlarmsDTO alarms);
    }
}
