using Przypominajka.Core.Enums;
using Przypominajka.Core.Interfaces;
using Przypominajka.Core.Models;
using Przypominajka.Core.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przypominajka.Core
{
    public class RequestsManager : IRequestManager
    {
        IDataLoadingType dataLoadingType;

        public RequestsManager(DataLoadingTypes type)
        {
            dataLoadingType = new ConnectionFabric(type).GetLoadingType();      
        }

        public void Add()
        {
            Console.WriteLine("Dodano");
        }

        public void Delete()
        {
            Console.WriteLine("Usunięto");
        }

        public void DeleteAll()
        {
            Console.WriteLine("Usunięto wszystkie");
        }

        public AlarmDTO ModifyAlarm_Date(AlarmDTO alarm)
        {
            Console.WriteLine("Zmodyfikowano datę");
            return null;
        }

        public AlarmDTO ModifyAlarm_IsArchived(AlarmDTO alarm)
        {
            Console.WriteLine("Zmodyfikowano - archived");
            return null;
        }

        public AlarmDTO ModifyAlarm_IsPast(AlarmDTO alarm)
        {
            Console.WriteLine("Zmodyfikowano - isPast");
            return null;
        }

        public AlarmDTO ModifyAlarm_Note(AlarmDTO alarm)
        {
            Console.WriteLine("Zmodyfikowano note");
            return null;
        }

        public AlarmDTO ModifyAlarm_Time(AlarmDTO alarm)
        {
            Console.WriteLine("Zmodyfikowano czas");
            return null;
        }

        public AlarmsDTO ReadAll()
        {
            return dataLoadingType.ReadData();
        }

        public void WriteChanges(AlarmsDTO alarms)
        {
            dataLoadingType.WriteData(alarms);
        }
    }
}
