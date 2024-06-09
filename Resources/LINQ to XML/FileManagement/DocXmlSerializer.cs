using LINQ_to_XML.DataCollector;
using LINQ_to_XML.Service;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace LINQ_to_XML.FileManagement
{
    internal class DocXmlSerializer : ISerializer
    {
        public void Serialize(DataContext? content, string? path)
        {
            if (content is null)
            {
                throw new ArgumentNullException(nameof(content), "DataContext instance cannot be null");
            }

            if (path is null)
            {
                throw new ArgumentNullException(nameof(path), "Path cannot be null");
            }

            string expectedFileExtension = ".xml";

            if (Validator.IsExtensionCorrect(path, expectedFileExtension) == false)
            {
                throw new ArgumentException("File have incorrect extension", nameof(path));
            }

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

        public DataContext Deserialize(string? path)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path), "Path cannot be null");
            }

            if (File.Exists(path) == false)
            {
                throw new ArgumentException("File doesn't exists", nameof(path));
            }

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
                    throw new ArgumentException("Cannot deserialize xml file into DataContext instance", nameof(path));
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
