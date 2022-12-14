namespace CBD.Forms
{
    partial class EditTypes
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
            this.lbxTags = new System.Windows.Forms.ListBox();
            this.lblIDValue = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnTryAdd = new System.Windows.Forms.Button();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbxTags
            // 
            this.lbxTags.FormattingEnabled = true;
            this.lbxTags.ItemHeight = 15;
            this.lbxTags.Location = new System.Drawing.Point(12, 41);
            this.lbxTags.Name = "lbxTags";
            this.lbxTags.Size = new System.Drawing.Size(181, 364);
            this.lbxTags.TabIndex = 11;
            this.lbxTags.SelectedIndexChanged += new System.EventHandler(this.lbxTags_SelectedIndexChanged);
            // 
            // lblIDValue
            // 
            this.lblIDValue.AutoSize = true;
            this.lblIDValue.Location = new System.Drawing.Point(226, 41);
            this.lblIDValue.Name = "lblIDValue";
            this.lblIDValue.Size = new System.Drawing.Size(0, 15);
            this.lblIDValue.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(199, 41);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID:";
            // 
            // btnTryAdd
            // 
            this.btnTryAdd.Location = new System.Drawing.Point(118, 11);
            this.btnTryAdd.Name = "btnTryAdd";
            this.btnTryAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTryAdd.TabIndex = 8;
            this.btnTryAdd.Text = "TryAdd";
            this.btnTryAdd.UseVisualStyleBackColor = true;
            this.btnTryAdd.Click += new System.EventHandler(this.btnTryAdd_Click);
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(12, 12);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(100, 23);
            this.txtTag.TabIndex = 7;
            // 
            // EditTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 421);
            this.Controls.Add(this.lbxTags);
            this.Controls.Add(this.lblIDValue);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnTryAdd);
            this.Controls.Add(this.txtTag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditTypes";
            this.Load += new System.EventHandler(this.EditTypes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbxTags;
        private Label lblIDValue;
        private Label lblID;
        private Button btnTryAdd;
        private TextBox txtTag;
    }
}