using LINQ_to_XML.Entities;
using System.Text;
using System.Xml.Serialization;

namespace LINQ_to_XML.DataCollector
{
    [XmlRoot("Data")]
    public class DataContext
    {
        public List<Address> Addresses;
        public List<Caretaker> Caretakers;
        public List<DetailResult> DetailResults;
        public List<Horse> Horses;
        public List<Jockey> Jockeys;
        public List<Participant> Participants;
        public List<Race> Races;
        public List<Stadium> Stadiums;

        public DataContext()
        {
            Addresses = [];
            Caretakers = [];
            DetailResults = [];
            Horses = [];
            Jockeys = [];
            Participants = [];
            Races = [];
            Stadiums = [];
        }

        public override string ToString()
        {
            StringBuilder builder = new();

            string indent = "    ";

            builder.Append("Addresses");
            builder.Append('\n');
            builder.Append(GetListContent(Addresses, indent));

            builder.Append("Caretakers");
            builder.Append('\n');
            builder.Append(GetListContent(Caretakers, indent));

            builder.Append("DetailResults");
            builder.Append('\n');
            builder.Append(GetListContent(DetailResults, indent));

            builder.Append("Horses");
            builder.Append('\n');
            builder.Append(GetListContent(Horses, indent));

            builder.Append("Jockeys");
            builder.Append('\n');
            builder.Append(GetListContent(Jockeys, indent));

            builder.Append("Participants");
            builder.Append('\n');
            builder.Append(GetListContent(Participants, indent));

            builder.Append("Races");
            builder.Append('\n');
            builder.Append(GetListContent(Races, indent));

            builder.Append("Stadiums");
            builder.Append('\n');
            builder.Append(GetListContent(Stadiums, indent));

            return builder.ToString();
        }

        private static string GetListContent<T>(List<T> list, string indent = "")
        {
            StringBuilder builder = new();

            foreach (T item in list)
            {
                string[] lines = item!.ToString()!.Split('\n');
                foreach (string line in lines)
                {
                    builder.Append(indent);
                    builder.Append(line);
                    builder.Append('\n');
                }

                builder.Append('\n');
            }

            return builder.ToString();
        }
    }
}
