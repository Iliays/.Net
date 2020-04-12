using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IndividProject.ClassXML
{
    [XmlRoot(ElementName = "CATEGORY")]
    public class CATEGORY
    {
        [XmlElement(ElementName = "Category")]
        public List<CategoryXml> Category { get; set; }
    }
}
