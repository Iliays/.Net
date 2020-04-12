using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IndividProject.ClassXML
{
    [XmlRoot(ElementName = "Category")]
    public class CategoryXml
    {

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "discription")]
        public string Discription { get; set; }

        [XmlElement(ElementName = "Order")]
        public List<OrderXml> Order { get; set; }
    }
}
