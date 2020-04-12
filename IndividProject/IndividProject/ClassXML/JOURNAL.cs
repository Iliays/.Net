using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IndividProject.ClassXML
{
    [XmlRoot(ElementName = "JOURNAL")]
    public class JOURNAL
    {
        [XmlElement(ElementName = "Journal")]
        public List<JournalXml> Journal { get; set; }
    }
}
