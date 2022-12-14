namespace CBD.Forms
{
    partial class ManaCostControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudWhite = new System.Windows.Forms.NumericUpDown();
            this.lblWhite = new System.Windows.Forms.Label();
            this.grpManaMain = new System.Windows.Forms.GroupBox();
            this.lblBlue = new System.Windows.Forms.Label();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.lblBlack = new System.Windows.Forms.Label();
            this.nudBlack = new System.Windows.Forms.NumericUpDown();
            this.lblRed = new System.Windows.Forms.Label();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.lblGreen = new System.Windows.Forms.Label();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.lblColorless = new System.Windows.Forms.Label();
            this.nudColorless = new System.Windows.Forms.NumericUpDown();
            this.lblAnyColor = new System.Windows.Forms.Label();
            this.nudAnyColor = new System.Windows.Forms.NumericUpDown();
            this.tlpMana = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudWhite)).BeginInit();
            this.grpManaMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorless)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnyColor)).BeginInit();
            this.tlpMana.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudWhite
            // 
            this.nudWhite.Location = new System.Drawing.Point(93, 8);
            this.nudWhite.Name = "nudWhite";
            this.nudWhite.Size = new System.Drawing.Size(93, 23);
            this.nudWhite.TabIndex = 0;
            this.nudWhite.ValueChanged += new System.EventHandler(this.nudWhite_ValueChanged);
            // 
            // lblWhite
            // 
            this.lblWhite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWhite.Location = new System.Drawing.Point(18, 5);
            this.lblWhite.Name = "lblWhite";
            this.lblWhite.Size = new System.Drawing.Size(69, 30);
            this.lblWhite.TabIndex = 1;
            this.lblWhite.Text = "White:";
            this.lblWhite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpManaMain
            // 
            this.grpManaMain.Controls.Add(this.tlpMana);
            this.grpManaMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpManaMain.Location = new System.Drawing.Point(0, 0);
            this.grpManaMain.Name = "grpManaMain";
            this.grpManaMain.Size = new System.Drawing.Size(402, 170);
            this.grpManaMain.TabIndex = 0;
            this.grpManaMain.TabStop = false;
            this.grpManaMain.Text = "Mana Cost";
            // 
            // lblBlue
            // 
            this.lblBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBlue.Location = new System.Drawing.Point(18, 40);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(69, 30);
            this.lblBlue.TabIndex = 3;
            this.lblBlue.Text = "Blue:";
            this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudBlue
            // 
            this.nudBlue.Location = new System.Drawing.Point(93, 43);
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(93, 23);
            this.nudBlue.TabIndex = 2;
            this.nudBlue.ValueChanged += new System.EventHandler(this.nudBlue_ValueChanged);
            // 
            // lblBlack
            // 
            this.lblBlack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBlack.Location = new System.Drawing.Point(18, 75);
            this.lblBlack.Name = "lblBlack";
            this.lblBlack.Size = new System.Drawing.Size(69, 30);
            this.lblBlack.TabIndex = 5;
            this.lblBlack.Text = "Black:";
            this.lblBlack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudBlack
            // 
            this.nudBlack.Location = new System.Drawing.Point(93, 78);
            this.nudBlack.Name = "nudBlack";
            this.nudBlack.Size = new System.Drawing.Size(93, 23);
            this.nudBlack.TabIndex = 4;
            this.nudBlack.ValueChanged += new System.EventHandler(this.nudBlack_ValueChanged);
            // 
            // lblRed
            // 
            this.lblRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRed.Location = new System.Drawing.Point(207, 5);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(69, 30);
            this.lblRed.TabIndex = 7;
            this.lblRed.Text = "Red:";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudRed
            // 
            this.nudRed.Location = new System.Drawing.Point(282, 8);
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(93, 23);
            this.nudRed.TabIndex = 6;
            this.nudRed.ValueChanged += new System.EventHandler(this.nudRed_ValueChanged);
            // 
            // lblGreen
            // 
            this.lblGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGreen.Location = new System.Drawing.Point(207, 40);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(69, 30);
            this.lblGreen.TabIndex = 9;
            this.lblGreen.Text = "Green:";
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudGreen
            // 
            this.nudGreen.Location = new System.Drawing.Point(282, 43);
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(93, 23);
            this.nudGreen.TabIndex = 8;
            this.nudGreen.ValueChanged += new System.EventHandler(this.nudGreen_ValueChanged);
            // 
            // lblColorless
            // 
            this.lblColorless.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColorless.Location = new System.Drawing.Point(207, 75);
            this.lblColorless.Name = "lblColorless";
            this.lblColorless.Size = new System.Drawing.Size(69, 30);
            this.lblColorless.TabIndex = 11;
            this.lblColorless.Text = "Colorless:";
            this.lblColorless.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudColorless
            // 
            this.nudColorless.Location = new System.Drawing.Point(282, 78);
            this.nudColorless.Name = "nudColorless";
            this.nudColorless.Size = new System.Drawing.Size(93, 23);
            this.nudColorless.TabIndex = 10;
            this.nudColorless.ValueChanged += new System.EventHandler(this.nudColorless_ValueChanged);
            // 
            // lblAnyColor
            // 
            this.lblAnyColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnyColor.Location = new System.Drawing.Point(93, 110);
            this.lblAnyColor.Name = "lblAnyColor";
            this.lblAnyColor.Size = new System.Drawing.Size(93, 30);
            this.lblAnyColor.TabIndex = 13;
            this.lblAnyColor.Text = "Any Color:";
            this.lblAnyColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudAnyColor
            // 
            this.nudAnyColor.Location = new System.Drawing.Point(207, 113);
            this.nudAnyColor.Name = "nudAnyColor";
            this.nudAnyColor.Size = new System.Drawing.Size(69, 23);
            this.nudAnyColor.TabIndex = 12;
            this.nudAnyColor.ValueChanged += new System.EventHandler(this.nudAnyColor_ValueChanged);
            // 
            // tlpMana
            // 
            this.tlpMana.ColumnCount = 7;
            this.tlpMana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.816602F));
            this.tlpMana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.08301F));
            this.tlpMana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.19208F));
            this.tlpMana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.816602F));
            this.tlpMana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.08301F));
            this.tlpMana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.19209F));
            this.tlpMana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.816602F));
            this.tlpMana.Controls.Add(this.lblWhite, 1, 1);
            this.tlpMana.Controls.Add(this.nudAnyColor, 4, 7);
            this.tlpMana.Controls.Add(this.nudWhite, 2, 1);
            this.tlpMana.Controls.Add(this.lblColorless, 4, 5);
            this.tlpMana.Controls.Add(this.lblBlue, 1, 3);
            this.tlpMana.Controls.Add(this.nudColorless, 5, 5);
            this.tlpMana.Controls.Add(this.nudBlue, 2, 3);
            this.tlpMana.Controls.Add(this.lblGreen, 4, 3);
            this.tlpMana.Controls.Add(this.lblBlack, 1, 5);
            this.tlpMana.Controls.Add(this.nudGreen, 5, 3);
            this.tlpMana.Controls.Add(this.nudBlack, 2, 5);
            this.tlpMana.Controls.Add(this.lblRed, 4, 1);
            this.tlpMana.Controls.Add(this.nudRed, 5, 1);
            this.tlpMana.Controls.Add(this.lblAnyColor, 2, 7);
            this.tlpMana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMana.Location = new System.Drawing.Point(3, 19);
            this.tlpMana.Name = "tlpMana";
            this.tlpMana.RowCount = 9;
            this.tlpMana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMana.Size = new System.Drawing.Size(396, 148);
            this.tlpMana.TabIndex = 14;
            // 
            // ManaCostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpManaMain);
            this.Name = "ManaCostControl";
            this.Size = new System.Drawing.Size(402, 170);
            ((System.ComponentModel.ISupportInitialize)(this.nudWhite)).EndInit();
            this.grpManaMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorless)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnyColor)).EndInit();
            this.tlpMana.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown nudWhite;
        private Label lblWhite;
        private GroupBox grpManaMain;
        private TableLayoutPanel tlpMana;
        private NumericUpDown nudAnyColor;
        private Label lblColorless;
        private Label lblBlue;
        private NumericUpDown nudColorless;
        private NumericUpDown nudBlue;
        private Label lblGreen;
        private Label lblBlack;
        private NumericUpDown nudGreen;
        private NumericUpDown nudBlack;
        private Label lblRed;
        private NumericUpDown nudRed;
        private Label lblAnyColor;
    }
}
