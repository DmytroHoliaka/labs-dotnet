using LINQ_to_XML.DataCollector;

namespace LINQ_to_XML.FileManagement
{
    internal interface ISerializer
    {
        void Serialize(DataContext content, string path);
        DataContext Deserialize(string path);
    }
}
