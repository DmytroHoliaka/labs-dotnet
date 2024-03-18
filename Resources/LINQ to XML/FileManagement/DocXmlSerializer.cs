using LINQ_to_XML.DataCollector;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace LINQ_to_XML.FileManagement
{
    internal class DocXmlSerializer : ISerializer
    {
        // ToDo: Write validations
        public void Serialize(DataContext content, string path)
        {
            XmlSerializer serializer = new(typeof(DataContext));

            XmlWriterSettings settings = new()
            {
                Indent = true,
                IndentChars = "\t",
                Encoding = Encoding.UTF8,
            };

            using XmlWriter writer = XmlWriter.Create(path, settings);
            serializer.Serialize(writer, content);
        }

        public DataContext Deserialize(string path)
        {
            XmlSerializer deserializer = new(typeof(DataContext));
            using XmlReader reader = XmlReader.Create(path);

            try
            {
                if (deserializer.Deserialize(reader) is DataContext content)
                {
                    return content;
                }
                else
                {
                    throw new ArgumentNullException("Cannot deserialize xml file into DataContext instance");
                }
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
        }
    }
}
