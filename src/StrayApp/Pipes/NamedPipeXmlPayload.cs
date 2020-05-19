using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace StrayApp.Pipes
{
    public class NamedPipeXmlPayload
    {
        [XmlElement("CommandLineArguments")]
        public List<string> Payload { get; set; } = new List<string>();
    }
}

