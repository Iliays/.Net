using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IndividProject.ClassXML
{
    [XmlRoot(ElementName = "Client")]
    public class ClientXml
    {

        [XmlElement(ElementName = "surname")]
        public string Surname { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "patronimic")]
        public string Patronimic { get; set; }

        [XmlElement(ElementName = "number")]
        public string Number { get; set; }

        [XmlElement(ElementName = "seria")]
        public string Seria { get; set; }

        [XmlElement(ElementName = "datePas")]
        public string DatePas { get; set; }

        [XmlElement(ElementName = "Category")]
        public List<CategoryXml> Category { get; set; }

    }
}
