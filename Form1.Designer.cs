namespace Chess
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nul = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PP = new System.Windows.Forms.CheckBox();
            this.RP = new System.Windows.Forms.CheckBox();
            this.NP = new System.Windows.Forms.CheckBox();
            this.BP = new System.Windows.Forms.CheckBox();
            this.QP = new System.Windows.Forms.CheckBox();
            this.KP = new System.Windows.Forms.CheckBox();
            this.Bteam = new System.Windows.Forms.RadioButton();
            this.Wteam = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BlackHeatlh = new System.Windows.Forms.ProgressBar();
            this.WhiteHeatlh = new System.Windows.Forms.ProgressBar();
            this.Board = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreTracker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Nul);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.PP);
            this.panel1.Controls.Add(this.RP);
            this.panel1.Controls.Add(this.NP);
            this.panel1.Controls.Add(this.BP);
            this.panel1.Controls.Add(this.QP);
            this.panel1.Controls.Add(this.KP);
            this.panel1.Controls.Add(this.Bteam);
            this.panel1.Controls.Add(this.Wteam);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(599, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 581);
            this.panel1.TabIndex = 0;
            // 
            // Nul
            // 
            this.Nul.AutoSize = true;
            this.Nul.Location = new System.Drawing.Point(13, 289);
            this.Nul.Name = "Nul";
            this.Nul.Size = new System.Drawing.Size(44, 17);
            this.Nul.TabIndex = 18;
            this.Nul.Text = "Null";
            this.Nul.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(100, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "UndoSet";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Set";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Standard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PP
            // 
            this.PP.AutoSize = true;
            this.PP.Location = new System.Drawing.Point(14, 266);
            this.PP.Name = "PP";
            this.PP.Size = new System.Drawing.Size(33, 17);
            this.PP.TabIndex = 14;
            this.PP.Text = "P";
            this.PP.UseVisualStyleBackColor = true;
            // 
            // RP
            // 
            this.RP.AutoSize = true;
            this.RP.Location = new System.Drawing.Point(14, 243);
            this.RP.Name = "RP";
            this.RP.Size = new System.Drawing.Size(34, 17);
            this.RP.TabIndex = 13;
            this.RP.Text = "R";
            this.RP.UseVisualStyleBackColor = true;
            // 
            // NP
            // 
            this.NP.AutoSize = true;
            this.NP.Location = new System.Drawing.Point(14, 220);
            this.NP.Name = "NP";
            this.NP.Size = new System.Drawing.Size(34, 17);
            this.NP.TabIndex = 12;
            this.NP.Text = "N";
            this.NP.UseVisualStyleBackColor = true;
            // 
            // BP
            // 
            this.BP.AutoSize = true;
            this.BP.Location = new System.Drawing.Point(14, 197);
            this.BP.Name = "BP";
            this.BP.Size = new System.Drawing.Size(33, 17);
            this.BP.TabIndex = 11;
            this.BP.Text = "B";
            this.BP.UseVisualStyleBackColor = true;
            // 
            // QP
            // 
            this.QP.AutoSize = true;
            this.QP.Location = new System.Drawing.Point(14, 174);
            this.QP.Name = "QP";
            this.QP.Size = new System.Drawing.Size(34, 17);
            this.QP.TabIndex = 10;
            this.QP.Text = "Q";
            this.QP.UseVisualStyleBackColor = true;
            // 
            // KP
            // 
            this.KP.AutoSize = true;
            this.KP.Location = new System.Drawing.Point(14, 151);
            this.KP.Name = "KP";
            this.KP.Size = new System.Drawing.Size(33, 17);
            this.KP.TabIndex = 9;
            this.KP.Text = "K";
            this.KP.UseVisualStyleBackColor = true;
            // 
            // Bteam
            // 
            this.Bteam.AutoSize = true;
            this.Bteam.Location = new System.Drawing.Point(14, 127);
            this.Bteam.Name = "Bteam";
            this.Bteam.Size = new System.Drawing.Size(32, 17);
            this.Bteam.TabIndex = 8;
            this.Bteam.TabStop = true;
            this.Bteam.Text = "B";
            this.Bteam.UseVisualStyleBackColor = true;
            // 
            // Wteam
            // 
            this.Wteam.AutoSize = true;
            this.Wteam.Location = new System.Drawing.Point(14, 108);
            this.Wteam.Name = "Wteam";
            this.Wteam.Size = new System.Drawing.Size(36, 17);
            this.Wteam.TabIndex = 7;
            this.Wteam.TabStop = true;
            this.Wteam.Text = "W";
            this.Wteam.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(100, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(110, 407);
            this.listBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ToggleSide";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BlackHeatlh
            // 
            this.BlackHeatlh.Location = new System.Drawing.Point(-1, 558);
            this.BlackHeatlh.Name = "BlackHeatlh";
            this.BlackHeatlh.Size = new System.Drawing.Size(601, 23);
            this.BlackHeatlh.TabIndex = 1;
            // 
            // WhiteHeatlh
            // 
            this.WhiteHeatlh.Location = new System.Drawing.Point(-1, 1);
            this.WhiteHeatlh.Name = "WhiteHeatlh";
            this.WhiteHeatlh.Size = new System.Drawing.Size(601, 23);
            this.WhiteHeatlh.TabIndex = 2;
            // 
            // Board
            // 
            this.Board.AllowUserToAddRows = false;
            this.Board.AllowUserToDeleteRows = false;
            this.Board.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Board.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C,
            this.D,
            this.E,
            this.F,
            this.G,
            this.H});
            this.Board.Location = new System.Drawing.Point(1, 25);
            this.Board.MultiSelect = false;
            this.Board.Name = "Board";
            this.Board.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Board.Size = new System.Drawing.Size(599, 532);
            this.Board.TabIndex = 3;
            // 
            // A
            // 
            this.A.HeaderText = "A";
            this.A.Name = "A";
            // 
            // B
            // 
            this.B.HeaderText = "B";
            this.B.Name = "B";
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.Name = "C";
            // 
            // D
            // 
            this.D.HeaderText = "D";
            this.D.Name = "D";
            // 
            // E
            // 
            this.E.HeaderText = "E";
            this.E.Name = "E";
            // 
            // F
            // 
            this.F.HeaderText = "F";
            this.F.Name = "F";
            // 
            // G
            // 
            this.G.HeaderText = "G";
            this.G.Name = "G";
            // 
            // H
            // 
            this.H.HeaderText = "H";
            this.H.Name = "H";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 582);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.WhiteHeatlh);
            this.Controls.Add(this.BlackHeatlh);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar BlackHeatlh;
        private System.Windows.Forms.ProgressBar WhiteHeatlh;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn E;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker ScoreTracker;
        public System.Windows.Forms.DataGridView Board;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox PP;
        private System.Windows.Forms.CheckBox RP;
        private System.Windows.Forms.CheckBox NP;
        private System.Windows.Forms.CheckBox BP;
        private System.Windows.Forms.CheckBox QP;
        private System.Windows.Forms.CheckBox KP;
        private System.Windows.Forms.RadioButton Bteam;
        private System.Windows.Forms.RadioButton Wteam;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox Nul;
    }
}

