using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
