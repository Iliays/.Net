using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IndividProject.ClassXML
{
    [XmlRoot(ElementName = "Journal")]
    public class JournalXml
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "number")]
        public string Number { get; set; }

        [XmlElement(ElementName = "seria")]
        public string Seria { get; set; }

        [XmlElement(ElementName = "discriptionOrder")]
        public string DiscriptionOrder { get; set; }

        [XmlElement(ElementName = "dateGive")]
        public string DateGive { get; set; }

        [XmlElement(ElementName = "dateTake")]
        public string DateTake { get; set; }

        [XmlElement(ElementName = "summa")]
        public string Summa { get; set; }
    }
}
