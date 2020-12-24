﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Base.Models
{
    [XmlRoot(ElementName = "ExrateList")]
    public class ExrateList
    {
        [XmlElement(ElementName = "DateTime")]
        public string DateTime { get; set; }
        [XmlElement(ElementName = "Exrate")]
        public List<Exrate> Exrates { get; set; }
        [XmlElement(ElementName = "Source")]
        public string Source { get; set; }
    }
}
