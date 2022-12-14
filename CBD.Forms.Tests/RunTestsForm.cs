using System.Xml;

namespace CBD.Forms.Tests
{
    public partial class RunTestsForm : Form
    {
        public RunTestsForm()
        {
            InitializeComponent();
        }

        private void btnTestTagEditor_Click(object sender, EventArgs e)
        {
            EditTags t = new EditTags();
            t.ShowDialog();
        }

        private void RunTestsForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("GameTags"))
            {
                XmlReader r = XmlReader.Create("GameTags");
                while (r.Read())
                {
                    if (r.NodeType == XmlNodeType.Element && r.Name == "TagsList")
                        TagEngine.TagInstance.ReadXml(r);
                }
            }
        }

        private void RunTestsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlWriter w = XmlWriter.Create("GameTags");
            w.WriteStartDocument();
            TagEngine.TagInstance.WriteXml(w);
            w.WriteEndDocument();
            w.Close();
        }
    }
}