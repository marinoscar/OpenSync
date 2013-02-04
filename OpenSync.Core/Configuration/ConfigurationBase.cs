using System;
using System.IO;
using System.Xml.Serialization;

namespace OpenSync.Core.Configuration
{
    public class ConfigurationBase
    {
        public void ToXml(Stream stream)
        {
            var serializer = new XmlSerializer(GetType());
            serializer.Serialize(stream, this);
            stream.Close();
        }

        public void ToXmlFile(string fileName)
        {
            var streamWriter = new StreamWriter(fileName);
            ToXml(streamWriter.BaseStream);
        }

        protected static T FromXml<T>(Stream stream)
        {
            var serializer = new XmlSerializer(typeof(T));
            var obj = (T)serializer.Deserialize(stream);
            return obj;
        }

        protected static T FromXmlFile<T>(string fileName)
        {
            var streamReader = new StreamReader(fileName);
            var obj = FromXml<T>(streamReader.BaseStream);
            return obj;
        }

        protected static T TryToGetFromXmlFile<T>(string fileName)
        {
            var result = default(T);
            try
            {
                result = FromXmlFile<T>(fileName);
            }
            catch (Exception)
            {
            }
            return result;
        }
    }
}
