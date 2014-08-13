namespace EasyPaint
{
    partial class frmPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaint));
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnDefaultColor = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnPurple = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.menuOptions = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSelection = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chBoxFill = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.grpColor.SuspendLayout();
            this.menuOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEllipse
            // 
            this.btnEllipse.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEllipse.FlatAppearance.BorderSize = 0;
            this.btnEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnEllipse.Image")));
            this.btnEllipse.Location = new System.Drawing.Point(6, 19);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(35, 35);
            this.btnEllipse.TabIndex = 1;
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRectangle.FlatAppearance.BorderSize = 0;
            this.btnRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangle.Image")));
            this.btnRectangle.Location = new System.Drawing.Point(47, 19);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(35, 35);
            this.btnRectangle.TabIndex = 3;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRed.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRed.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRed.Location = new System.Drawing.Point(5, 105);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(32, 32);
            this.btnRed.TabIndex = 6;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(6, 67);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(32, 32);
            this.btnYellow.TabIndex = 7;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.Location = new System.Drawing.Point(47, 28);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(32, 32);
            this.btnBlack.TabIndex = 8;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnDefaultColor
            // 
            this.btnDefaultColor.BackColor = System.Drawing.Color.Black;
            this.btnDefaultColor.Enabled = false;
            this.btnDefaultColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDefaultColor.Location = new System.Drawing.Point(30, 193);
            this.btnDefaultColor.Name = "btnDefaultColor";
            this.btnDefaultColor.Size = new System.Drawing.Size(24, 24);
            this.btnDefaultColor.TabIndex = 9;
            this.btnDefaultColor.UseVisualStyleBackColor = false;
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(47, 105);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(32, 32);
            this.btnBlue.TabIndex = 10;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // numSize
            // 
            this.numSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numSize.Location = new System.Drawing.Point(18, 19);
            this.numSize.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.ReadOnly = true;
            this.numSize.Size = new System.Drawing.Size(50, 23);
            this.numSize.TabIndex = 11;
            this.numSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpColor
            // 
            this.grpColor.Controls.Add(this.btnOrange);
            this.grpColor.Controls.Add(this.btnGreen);
            this.grpColor.Controls.Add(this.btnWhite);
            this.grpColor.Controls.Add(this.btnYellow);
            this.grpColor.Controls.Add(this.btnPurple);
            this.grpColor.Controls.Add(this.btnRed);
            this.grpColor.Controls.Add(this.btnBlue);
            this.grpColor.Controls.Add(this.btnBlack);
            this.grpColor.Controls.Add(this.btnDefaultColor);
            this.grpColor.Location = new System.Drawing.Point(10, 331);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(90, 222);
            this.grpColor.TabIndex = 13;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOrange.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnOrange.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOrange.Location = new System.Drawing.Point(5, 143);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(32, 32);
            this.btnOrange.TabIndex = 11;
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Location = new System.Drawing.Point(47, 67);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(32, 32);
            this.btnGreen.TabIndex = 12;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.Location = new System.Drawing.Point(6, 28);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(32, 32);
            this.btnWhite.TabIndex = 13;
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnPurple
            // 
            this.btnPurple.BackColor = System.Drawing.Color.Violet;
            this.btnPurple.Location = new System.Drawing.Point(47, 144);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(32, 32);
            this.btnPurple.TabIndex = 14;
            this.btnPurple.UseVisualStyleBackColor = false;
            this.btnPurple.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTriangle.FlatAppearance.BorderSize = 0;
            this.btnTriangle.Image = ((System.Drawing.Image)(resources.GetObject("btnTriangle.Image")));
            this.btnTriangle.Location = new System.Drawing.Point(47, 60);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(35, 35);
            this.btnTriangle.TabIndex = 11;
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLine.FlatAppearance.BorderSize = 0;
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.Location = new System.Drawing.Point(6, 60);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(35, 35);
            this.btnLine.TabIndex = 14;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // menuOptions
            // 
            this.menuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuOptions.Location = new System.Drawing.Point(0, 0);
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(835, 24);
            this.menuOptions.TabIndex = 15;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuSave});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuNew
            // 
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(103, 22);
            this.menuNew.Text = "New";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(103, 22);
            this.menuOpen.Text = "Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(103, 22);
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
            // 
            // btnSelection
            // 
            this.btnSelection.Location = new System.Drawing.Point(18, 19);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(50, 33);
            this.btnSelection.TabIndex = 4;
            this.btnSelection.Text = "OFF";
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEllipse);
            this.groupBox1.Controls.Add(this.btnLine);
            this.groupBox1.Controls.Add(this.btnTriangle);
            this.groupBox1.Controls.Add(this.btnRectangle);
            this.groupBox1.Location = new System.Drawing.Point(10, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 103);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelection);
            this.groupBox2.Location = new System.Drawing.Point(10, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 65);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selection";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numSize);
            this.groupBox3.Location = new System.Drawing.Point(12, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(90, 57);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Size";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chBoxFill);
            this.groupBox4.Location = new System.Drawing.Point(10, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(90, 54);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fill";
            // 
            // chBoxFill
            // 
            this.chBoxFill.AutoSize = true;
            this.chBoxFill.Location = new System.Drawing.Point(12, 23);
            this.chBoxFill.Name = "chBoxFill";
            this.chBoxFill.Size = new System.Drawing.Size(70, 17);
            this.chBoxFill.TabIndex = 0;
            this.chBoxFill.Text = "Fill shape";
            this.chBoxFill.UseVisualStyleBackColor = true;
            // 
            // frmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 586);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.menuOptions);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuOptions;
            this.Name = "frmPaint";
            this.Text = "Easy Paint";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPaint_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.grpColor.ResumeLayout(false);
            this.menuOptions.ResumeLayout(false);
            this.menuOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnDefaultColor;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.MenuStrip menuOptions;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chBoxFill;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnPurple;

    }
}

