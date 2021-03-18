using Przypominajka.Core.Models;

namespace Przypominajka.Core.Interfaces
{
    public interface IRequestManager
    {
        AlarmsDTO ReadAll();
        void WriteChanges(AlarmsDTO alarms);

        void Add();
        void Delete();
        void DeleteAll();

        AlarmDTO ModifyAlarm_Date(AlarmDTO alarm);
        AlarmDTO ModifyAlarm_Time(AlarmDTO alarm);
        AlarmDTO ModifyAlarm_Note(AlarmDTO alarm);
        AlarmDTO ModifyAlarm_IsPast(AlarmDTO alarm);
        AlarmDTO ModifyAlarm_IsArchived(AlarmDTO alarm);

    }
}
