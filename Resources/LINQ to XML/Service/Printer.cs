using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace LINQ_to_XML.Service
{
    internal class Printer
    {
        // ToDo: Write file validator
        // ToDo: Add ability to choice print or not xml file
        public static void PrintXmlFile(Action<string> source, string path)
        {
            XmlDocument doc = new();
            doc.Load(path);

            using StringWriter sw = new();
            doc.Save(sw);
            source(sw.ToString());
        }
    }
}
