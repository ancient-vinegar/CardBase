namespace CBD.Forms
{
    partial class EditTags
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTag = new System.Windows.Forms.TextBox();
            this.btnTryAdd = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblIDValue = new System.Windows.Forms.Label();
            this.lbxTags = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(12, 12);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(100, 23);
            this.txtTag.TabIndex = 2;
            // 
            // btnTryAdd
            // 
            this.btnTryAdd.Location = new System.Drawing.Point(118, 11);
            this.btnTryAdd.Name = "btnTryAdd";
            this.btnTryAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTryAdd.TabIndex = 3;
            this.btnTryAdd.Text = "TryAdd";
            this.btnTryAdd.UseVisualStyleBackColor = true;
            this.btnTryAdd.Click += new System.EventHandler(this.btnTryAdd_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(199, 41);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID:";
            // 
            // lblIDValue
            // 
            this.lblIDValue.AutoSize = true;
            this.lblIDValue.Location = new System.Drawing.Point(226, 41);
            this.lblIDValue.Name = "lblIDValue";
            this.lblIDValue.Size = new System.Drawing.Size(0, 15);
            this.lblIDValue.TabIndex = 5;
            // 
            // lbxTags
            // 
            this.lbxTags.FormattingEnabled = true;
            this.lbxTags.ItemHeight = 15;
            this.lbxTags.Location = new System.Drawing.Point(12, 41);
            this.lbxTags.Name = "lbxTags";
            this.lbxTags.Size = new System.Drawing.Size(181, 364);
            this.lbxTags.TabIndex = 6;
            this.lbxTags.SelectedIndexChanged += new System.EventHandler(this.lbxTags_SelectedIndexChanged);
            // 
            // EditTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 420);
            this.Controls.Add(this.lbxTags);
            this.Controls.Add(this.lblIDValue);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnTryAdd);
            this.Controls.Add(this.txtTag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditTags";
            this.Text = "EditTags";
            this.Load += new System.EventHandler(this.EditTags_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtTag;
        private Button btnTryAdd;
        private Label lblID;
        private Label lblIDValue;
        private ListBox lbxTags;
    }
}