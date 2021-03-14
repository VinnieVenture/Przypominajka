using Przypominajka.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Przypominajka.Core.Serialization
{
    public class XML_Read_Write
    {
        const string fileName= "alarms.xml";

        public AlarmsDTO ReadData()
        {
            AlarmsDTO alarmsDTO = null;
            
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AlarmsDTO));
                FileStream fs = new FileStream(fileName, FileMode.Open);

                alarmsDTO = (AlarmsDTO)serializer.Deserialize(fs);

                fs.Close();

                Console.WriteLine("Deserializacja skończona!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Deserializacja skończona niepowodzeniem!!" + ex.Message);
            }

            return alarmsDTO;
        }

        public void WriteData(AlarmsDTO alarms)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AlarmsDTO));
                TextWriter writer = new StreamWriter(fileName);

                serializer.Serialize(writer, alarms);

                writer.Close();

                Console.WriteLine("Serializacja skończona!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Serializacja skończona niepowodzeniem!!" + ex.Message);
            }
        }  
    }
}
