using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ProjectHouseUWP
{
    class XmlParser
    {
        public static Envelope Desirialize(string xml)
        {
            var serializer = new XmlSerializer(typeof(Envelope));
            Envelope result;
            using (TextReader reader = new StringReader(xml))
            {
                result = (Envelope)serializer.Deserialize(reader);
            }
            return result;
        }

        public static class1.Envelope DesirializeBig(string xml)
        {
            var serializer = new XmlSerializer(typeof(class1.Envelope));
            class1.Envelope result;
            using (TextReader reader = new StringReader(xml))
            {
                result = (class1.Envelope)serializer.Deserialize(reader);
            }
            return result;
        }

        public static void Serialize(class1.Envelope xml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(xml.GetType());
            using (FileStream fs = new FileStream(Windows.Storage.ApplicationData.Current.LocalFolder.Path + "\\" + "Out.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, xml);

                Console.WriteLine("Объект сериализован");
            }

        }
    }
}
