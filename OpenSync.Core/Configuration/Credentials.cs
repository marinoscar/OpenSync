using System.Xml.Serialization;

namespace OpenSync.Core.Configuration
{
    [XmlRoot("credentials")]
    public class Credentials : ConfigurationBase
    {
        [XmlElement("key")]
        public string Key { get; set; }
        [XmlElement("user")]
        public string User { get; set; }

        public static Credentials TryToGetFromXmlFile(string fileName)
        {
            return TryToGetFromXmlFile<Credentials>(fileName);
        }

        public static Credentials FromXmlFile(string fileName)
        {
            return FromXmlFile<Credentials>(fileName);
        }
    }
}
