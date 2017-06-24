namespace PokemonMapEditor
{
    partial class frmFreeSpaceFinder
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
            this.fraOptions = new System.Windows.Forms.GroupBox();
            this.cmdFind = new System.Windows.Forms.Button();
            this.lblSkip = new System.Windows.Forms.Label();
            this.numSkip = new System.Windows.Forms.NumericUpDown();
            this.lblStartOffset = new System.Windows.Forms.Label();
            this.txtStartOffset = new System.Windows.Forms.TextBox();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFreeSpaceByte = new System.Windows.Forms.Label();
            this.txtFreeSpaceByte = new System.Windows.Forms.TextBox();
            this.lstOffsets = new System.Windows.Forms.ListBox();
            this.cmdRepoint = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.fraRepoint = new System.Windows.Forms.GroupBox();
            this.lblOffset = new System.Windows.Forms.Label();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.fraOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.fraRepoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // fraOptions
            // 
            this.fraOptions.Controls.Add(this.cmdFind);
            this.fraOptions.Controls.Add(this.lblSkip);
            this.fraOptions.Controls.Add(this.numSkip);
            this.fraOptions.Controls.Add(this.lblStartOffset);
            this.fraOptions.Controls.Add(this.txtStartOffset);
            this.fraOptions.Controls.Add(this.numSize);
            this.fraOptions.Controls.Add(this.label2);
            this.fraOptions.Controls.Add(this.lblFreeSpaceByte);
            this.fraOptions.Controls.Add(this.txtFreeSpaceByte);
            this.fraOptions.Location = new System.Drawing.Point(8, 8);
            this.fraOptions.Name = "fraOptions";
            this.fraOptions.Size = new System.Drawing.Size(216, 160);
            this.fraOptions.TabIndex = 0;
            this.fraOptions.TabStop = false;
            this.fraOptions.Text = "Options";
            // 
            // cmdFind
            // 
            this.cmdFind.Location = new System.Drawing.Point(144, 128);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(64, 24);
            this.cmdFind.TabIndex = 2;
            this.cmdFind.Text = "Find";
            this.cmdFind.UseVisualStyleBackColor = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // lblSkip
            // 
            this.lblSkip.AutoSize = true;
            this.lblSkip.Location = new System.Drawing.Point(16, 98);
            this.lblSkip.Name = "lblSkip";
            this.lblSkip.Size = new System.Drawing.Size(73, 13);
            this.lblSkip.TabIndex = 7;
            this.lblSkip.Text = "Bytes To Skip";
            // 
            // numSkip
            // 
            this.numSkip.Location = new System.Drawing.Point(144, 96);
            this.numSkip.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numSkip.Name = "numSkip";
            this.numSkip.Size = new System.Drawing.Size(56, 20);
            this.numSkip.TabIndex = 6;
            // 
            // lblStartOffset
            // 
            this.lblStartOffset.AutoSize = true;
            this.lblStartOffset.Location = new System.Drawing.Point(16, 26);
            this.lblStartOffset.Name = "lblStartOffset";
            this.lblStartOffset.Size = new System.Drawing.Size(60, 13);
            this.lblStartOffset.TabIndex = 5;
            this.lblStartOffset.Text = "Start Offset";
            // 
            // txtStartOffset
            // 
            this.txtStartOffset.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStartOffset.Location = new System.Drawing.Point(144, 24);
            this.txtStartOffset.MaxLength = 7;
            this.txtStartOffset.Name = "txtStartOffset";
            this.txtStartOffset.Size = new System.Drawing.Size(56, 20);
            this.txtStartOffset.TabIndex = 4;
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(144, 72);
            this.numSize.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(56, 20);
            this.numSize.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Needed Bytes (Size)";
            // 
            // lblFreeSpaceByte
            // 
            this.lblFreeSpaceByte.AutoSize = true;
            this.lblFreeSpaceByte.Location = new System.Drawing.Point(16, 50);
            this.lblFreeSpaceByte.Name = "lblFreeSpaceByte";
            this.lblFreeSpaceByte.Size = new System.Drawing.Size(116, 13);
            this.lblFreeSpaceByte.TabIndex = 1;
            this.lblFreeSpaceByte.Text = "Free Space Byte Value";
            // 
            // txtFreeSpaceByte
            // 
            this.txtFreeSpaceByte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFreeSpaceByte.Location = new System.Drawing.Point(144, 48);
            this.txtFreeSpaceByte.MaxLength = 2;
            this.txtFreeSpaceByte.Name = "txtFreeSpaceByte";
            this.txtFreeSpaceByte.Size = new System.Drawing.Size(32, 20);
            this.txtFreeSpaceByte.TabIndex = 0;
            // 
            // lstOffsets
            // 
            this.lstOffsets.FormattingEnabled = true;
            this.lstOffsets.Location = new System.Drawing.Point(232, 16);
            this.lstOffsets.Name = "lstOffsets";
            this.lstOffsets.Size = new System.Drawing.Size(120, 147);
            this.lstOffsets.TabIndex = 1;
            this.lstOffsets.SelectedIndexChanged += new System.EventHandler(this.lstOffsets_SelectedIndexChanged);
            // 
            // cmdRepoint
            // 
            this.cmdRepoint.Location = new System.Drawing.Point(232, 176);
            this.cmdRepoint.Name = "cmdRepoint";
            this.cmdRepoint.Size = new System.Drawing.Size(120, 24);
            this.cmdRepoint.TabIndex = 3;
            this.cmdRepoint.Text = "Repoint";
            this.cmdRepoint.UseVisualStyleBackColor = true;
            this.cmdRepoint.Click += new System.EventHandler(this.cmdRepoint_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(232, 200);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(120, 24);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // fraRepoint
            // 
            this.fraRepoint.Controls.Add(this.lblOffset);
            this.fraRepoint.Controls.Add(this.txtOffset);
            this.fraRepoint.Location = new System.Drawing.Point(8, 176);
            this.fraRepoint.Name = "fraRepoint";
            this.fraRepoint.Size = new System.Drawing.Size(216, 48);
            this.fraRepoint.TabIndex = 5;
            this.fraRepoint.TabStop = false;
            this.fraRepoint.Text = "Repoint";
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(48, 18);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(35, 13);
            this.lblOffset.TabIndex = 2;
            this.lblOffset.Text = "Offset";
            // 
            // txtOffset
            // 
            this.txtOffset.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOffset.Location = new System.Drawing.Point(96, 16);
            this.txtOffset.MaxLength = 7;
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(64, 20);
            this.txtOffset.TabIndex = 3;
            // 
            // frmFreeSpaceFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 231);
            this.Controls.Add(this.fraRepoint);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdRepoint);
            this.Controls.Add(this.lstOffsets);
            this.Controls.Add(this.fraOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFreeSpaceFinder";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Free Space Finder";
            this.Load += new System.EventHandler(this.frmFreeSpaceFinder_Load);
            this.fraOptions.ResumeLayout(false);
            this.fraOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.fraRepoint.ResumeLayout(false);
            this.fraRepoint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fraOptions;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFreeSpaceByte;
        private System.Windows.Forms.TextBox txtFreeSpaceByte;
        private System.Windows.Forms.ListBox lstOffsets;
        private System.Windows.Forms.Label lblStartOffset;
        private System.Windows.Forms.TextBox txtStartOffset;
        private System.Windows.Forms.Label lblSkip;
        private System.Windows.Forms.NumericUpDown numSkip;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.Button cmdRepoint;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.GroupBox fraRepoint;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.TextBox txtOffset;
    }
}