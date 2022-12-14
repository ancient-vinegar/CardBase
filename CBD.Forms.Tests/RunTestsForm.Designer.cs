namespace CBD.Forms.Tests
{
    partial class RunTestsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTestTagEditor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestTagEditor
            // 
            this.btnTestTagEditor.Location = new System.Drawing.Point(12, 49);
            this.btnTestTagEditor.Name = "btnTestTagEditor";
            this.btnTestTagEditor.Size = new System.Drawing.Size(126, 23);
            this.btnTestTagEditor.TabIndex = 0;
            this.btnTestTagEditor.Text = "Test Tag Editor";
            this.btnTestTagEditor.UseVisualStyleBackColor = true;
            this.btnTestTagEditor.Click += new System.EventHandler(this.btnTestTagEditor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Test Type Editor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTestTypeEditor_Click);
            // 
            // RunTestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTestTagEditor);
            this.Name = "RunTestsForm";
            this.Text = "RunTestForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RunTestsForm_FormClosing);
            this.Load += new System.EventHandler(this.RunTestsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTestTagEditor;
        private Button button1;
    }
}