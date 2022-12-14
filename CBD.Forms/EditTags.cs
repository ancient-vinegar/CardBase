using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBD.Forms
{
    public partial class EditTags : Form
    {
        public EditTags()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {
            lbxTags.Items.Clear();
            lbxTags.Items.AddRange(TagEngine.TagInstance.Tags.ToArray());
        }

        private void EditTags_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void btnTryAdd_Click(object sender, EventArgs e)
        {
            TagEngine.TagInstance.TryAddTag(txtTag.Text);
            txtTag.Text = string.Empty; 
            int index = lbxTags.SelectedIndex;
            UpdateList();
            lbxTags.SelectedIndex = index;
        }

        private void lbxTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxTags.SelectedIndex != -1 && lbxTags.SelectedItem != null)
            lblIDValue.Text = TagEngine.TagInstance.KeyOfTag(lbxTags.SelectedItem.ToString()).ToString();
        }
    }
}
