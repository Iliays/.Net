using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IndividProject.ClassXML
{
    [XmlRoot(ElementName = "CLIENT")]
    public class CLIENT
    {
        [XmlElement(ElementName = "Client")]
        public List<ClientXml> Client { get; set; }
    }
}
