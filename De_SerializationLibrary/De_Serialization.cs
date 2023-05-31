using Newtonsoft.Json;
using System.Xml.Serialization;

namespace De_SerializationLibrary
{
    public class DataSerialization
    {
        public static T DeserializeXml<T>(string xmlData)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(xmlData))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        public static T DeserializeJson<T>(string jsonData)
        {
            return JsonConvert.DeserializeObject<T>(jsonData);
        }

        public static string SerializeXml<T>(T obj)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, obj);
                return writer.ToString();
            }
        }

        public static string SerializeJson<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
