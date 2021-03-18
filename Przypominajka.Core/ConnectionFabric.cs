using Przypominajka.Core.Enums;
using Przypominajka.Core.Interfaces;
using Przypominajka.Core.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przypominajka.Core
{
    public class ConnectionFabric
    {
        IDataLoadingType type;

        public ConnectionFabric(DataLoadingTypes dataLoadingType)
        {
            if (dataLoadingType == DataLoadingTypes.Serialization)
                this.type = new XML_Read_Write();
        }

        public IDataLoadingType GetLoadingType() => type;
    }
}
