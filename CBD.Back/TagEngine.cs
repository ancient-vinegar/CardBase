using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CBD
{
    public class TagEngine : IXmlSerializable
    {
        private static TagEngine? tagInstance;
        private static TagEngine? typeInstance;
        public static TagEngine TagInstance { get { 
                if (tagInstance == null)
                    tagInstance = new TagEngine();
                return tagInstance; 
            } }
        public static TagEngine TypeInstance
        {
            get
            {
                if (typeInstance == null)
                    typeInstance = new TagEngine();
                return typeInstance;
            }
        }

        public TagEngine()
        {
            tags = new();
        }

        private Dictionary<int, string> tags;

        public string this[int key]
        {
            get { return tags[key]; }
        }
        private int NextKey()
        {
            int i = 0;
            while (true)
            {
                if (!tags.ContainsKey(i))
                    return i;
                i++;
            }
        }
        public bool TryAddTag(string tag)
        {
            if (tags.Values.Contains(tag))
                return false;
            tags.TryAdd(NextKey(), tag);
            return true;
        }
        public int KeyOfTag(string tag)
        {
            return tags.Where(x => x.Value.Equals(tag)).First().Key;
        }

        public XmlSchema? GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                    if (reader.Name == "Tag")
                    {
                        int id = Convert.ToInt32(reader.GetAttribute("id"));
                        string name = reader.GetAttribute("name") ?? "";
                        tags.Add(id, name);
                    }
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("TagsList");

            foreach(var tag in tags)
            {
                writer.WriteStartElement("Tag");
                writer.WriteAttributeString("id", tag.Key.ToString());
                writer.WriteAttributeString("name", tag.Value.ToString());
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }

        public List<string> Tags => tags.Values.ToList();


    }
}
