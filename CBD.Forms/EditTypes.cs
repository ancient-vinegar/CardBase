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
    public partial class EditTypes : Form
    {
        public EditTypes()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {
            lbxTags.Items.Clear();
            lbxTags.Items.AddRange(TagEngine.TypeInstance.Tags.ToArray());
        }

        private void EditTypes_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void btnTryAdd_Click(object sender, EventArgs e)
        {
            TagEngine.TypeInstance.TryAddTag(txtTag.Text);
            txtTag.Text = string.Empty;
            int index = lbxTags.SelectedIndex;
            UpdateList();
            lbxTags.SelectedIndex = index;
        }

        private void lbxTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxTags.SelectedIndex != -1 && lbxTags.SelectedItem != null)
                lblIDValue.Text = TagEngine.TypeInstance.KeyOfTag(lbxTags.SelectedItem.ToString()).ToString();
        }
    }
}
