using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Przypominajka.Core.Models
{
    public class AlarmDTO
        {
        [XmlIgnore]
        public int Id { get; set; }

        [XmlElementAttribute(IsNullable = false)]
        public DateTime Date { get; set; }

        [XmlElementAttribute(IsNullable = false)]
        public string Note { get; set; }

        [XmlElementAttribute(IsNullable = false)]
        public bool IsPast { get; set; }

        [XmlElementAttribute(IsNullable = false)]
        public bool IsArchived { get; set; }

        public AlarmDTO() {}
    }

    public class AlarmsDTO 
    {
        public List<AlarmDTO> Alarms;
        public AlarmsDTO()
        {
            Alarms = new List<AlarmDTO>();
        }
    }
}
