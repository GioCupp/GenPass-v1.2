namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.genera = new System.Windows.Forms.Button();
            this.Maiuscole = new System.Windows.Forms.CheckBox();
            this.Numeri = new System.Windows.Forms.CheckBox();
            this.Speciali = new System.Windows.Forms.CheckBox();
            this.Minuscole = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.testo1 = new System.Windows.Forms.Label();
            this.meter0 = new System.Windows.Forms.Label();
            this.meter1 = new System.Windows.Forms.Label();
            this.meter2 = new System.Windows.Forms.Label();
            this.meter3 = new System.Windows.Forms.Label();
            this.meter4 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.testo4 = new System.Windows.Forms.Label();
            this.ncarat = new System.Windows.Forms.Label();
            this.checktext = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.versioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Txt_InOut = new System.Windows.Forms.TextBox();
            this.genCas = new System.Windows.Forms.Button();
            this.progettoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // genera
            // 
            this.genera.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.genera.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genera.Location = new System.Drawing.Point(104, 228);
            this.genera.Name = "genera";
            this.genera.Size = new System.Drawing.Size(134, 42);
            this.genera.TabIndex = 0;
            this.genera.Text = "Genera ";
            this.genera.UseVisualStyleBackColor = false;
            this.genera.Click += new System.EventHandler(this.genera_Click);
            // 
            // Maiuscole
            // 
            this.Maiuscole.AutoSize = true;
            this.Maiuscole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maiuscole.Location = new System.Drawing.Point(54, 76);
            this.Maiuscole.Name = "Maiuscole";
            this.Maiuscole.Size = new System.Drawing.Size(95, 22);
            this.Maiuscole.TabIndex = 2;
            this.Maiuscole.Text = "Maiuscole";
            this.Maiuscole.UseVisualStyleBackColor = true;
            // 
            // Numeri
            // 
            this.Numeri.AutoSize = true;
            this.Numeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numeri.Location = new System.Drawing.Point(54, 104);
            this.Numeri.Name = "Numeri";
            this.Numeri.Size = new System.Drawing.Size(75, 22);
            this.Numeri.TabIndex = 3;
            this.Numeri.Text = "Numeri";
            this.Numeri.UseVisualStyleBackColor = true;
            // 
            // Speciali
            // 
            this.Speciali.AutoSize = true;
            this.Speciali.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speciali.Location = new System.Drawing.Point(54, 132);
            this.Speciali.Name = "Speciali";
            this.Speciali.Size = new System.Drawing.Size(78, 22);
            this.Speciali.TabIndex = 4;
            this.Speciali.Text = "Speciali";
            this.Speciali.UseVisualStyleBackColor = true;
            // 
            // Minuscole
            // 
            this.Minuscole.AutoSize = true;
            this.Minuscole.Checked = true;
            this.Minuscole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Minuscole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minuscole.Location = new System.Drawing.Point(54, 48);
            this.Minuscole.Name = "Minuscole";
            this.Minuscole.Size = new System.Drawing.Size(95, 22);
            this.Minuscole.TabIndex = 5;
            this.Minuscole.Text = "Minuscole";
            this.Minuscole.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(366, 109);
            this.trackBar1.Maximum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(362, 45);
            this.trackBar1.TabIndex = 1;
            // 
            // testo1
            // 
            this.testo1.AutoSize = true;
            this.testo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testo1.Location = new System.Drawing.Point(272, 109);
            this.testo1.Name = "testo1";
            this.testo1.Size = new System.Drawing.Size(76, 25);
            this.testo1.TabIndex = 6;
            this.testo1.Text = "Priorita\'";
            // 
            // meter0
            // 
            this.meter0.AutoSize = true;
            this.meter0.Location = new System.Drawing.Point(363, 157);
            this.meter0.Name = "meter0";
            this.meter0.Size = new System.Drawing.Size(49, 13);
            this.meter0.TabIndex = 7;
            this.meter0.Text = "Nessuna";
            // 
            // meter1
            // 
            this.meter1.AutoSize = true;
            this.meter1.Location = new System.Drawing.Point(437, 157);
            this.meter1.Name = "meter1";
            this.meter1.Size = new System.Drawing.Size(55, 13);
            this.meter1.TabIndex = 8;
            this.meter1.Text = "Minuscole";
            // 
            // meter2
            // 
            this.meter2.AutoSize = true;
            this.meter2.Location = new System.Drawing.Point(520, 157);
            this.meter2.Name = "meter2";
            this.meter2.Size = new System.Drawing.Size(55, 13);
            this.meter2.TabIndex = 9;
            this.meter2.Text = "Maiuscole";
            // 
            // meter3
            // 
            this.meter3.AutoSize = true;
            this.meter3.Location = new System.Drawing.Point(611, 157);
            this.meter3.Name = "meter3";
            this.meter3.Size = new System.Drawing.Size(40, 13);
            this.meter3.TabIndex = 10;
            this.meter3.Text = "Numeri";
            // 
            // meter4
            // 
            this.meter4.AutoSize = true;
            this.meter4.Location = new System.Drawing.Point(684, 157);
            this.meter4.Name = "meter4";
            this.meter4.Size = new System.Drawing.Size(44, 13);
            this.meter4.TabIndex = 11;
            this.meter4.Text = "Speciali";
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(366, 43);
            this.trackBar2.Maximum = 32;
            this.trackBar2.Minimum = 4;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(362, 45);
            this.trackBar2.TabIndex = 12;
            this.trackBar2.Value = 12;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // testo4
            // 
            this.testo4.AutoSize = true;
            this.testo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testo4.Location = new System.Drawing.Point(255, 38);
            this.testo4.Name = "testo4";
            this.testo4.Size = new System.Drawing.Size(105, 25);
            this.testo4.TabIndex = 13;
            this.testo4.Text = "N. caratteri";
            // 
            // ncarat
            // 
            this.ncarat.AutoSize = true;
            this.ncarat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncarat.Location = new System.Drawing.Point(296, 63);
            this.ncarat.Name = "ncarat";
            this.ncarat.Size = new System.Drawing.Size(34, 25);
            this.ncarat.TabIndex = 14;
            this.ncarat.Text = "12";
            this.ncarat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checktext
            // 
            this.checktext.AutoSize = true;
            this.checktext.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checktext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.checktext.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checktext.Location = new System.Drawing.Point(97, 378);
            this.checktext.Name = "checktext";
            this.checktext.Size = new System.Drawing.Size(450, 35);
            this.checktext.TabIndex = 15;
            this.checktext.Text = "Sicurezza:                                     ";
            this.checktext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.versioneToolStripMenuItem,
            this.gitHubToolStripMenuItem,
            this.progettoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
            this.toolStripMenuItem1.Text = "Info";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // versioneToolStripMenuItem
            // 
            this.versioneToolStripMenuItem.Name = "versioneToolStripMenuItem";
            this.versioneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versioneToolStripMenuItem.Text = "Versione";
            this.versioneToolStripMenuItem.Click += new System.EventHandler(this.versioneToolStripMenuItem_Click);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gitHubToolStripMenuItem.Text = "Creatore";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // Txt_InOut
            // 
            this.Txt_InOut.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Txt_InOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_InOut.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Txt_InOut.Location = new System.Drawing.Point(5, 299);
            this.Txt_InOut.Margin = new System.Windows.Forms.Padding(15);
            this.Txt_InOut.MaxLength = 32;
            this.Txt_InOut.Name = "Txt_InOut";
            this.Txt_InOut.Size = new System.Drawing.Size(774, 44);
            this.Txt_InOut.TabIndex = 19;
            // 
            // genCas
            // 
            this.genCas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.genCas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genCas.Location = new System.Drawing.Point(326, 228);
            this.genCas.Name = "genCas";
            this.genCas.Size = new System.Drawing.Size(206, 42);
            this.genCas.TabIndex = 20;
            this.genCas.Text = "Genera casuale";
            this.genCas.UseVisualStyleBackColor = false;
            this.genCas.Click += new System.EventHandler(this.genCas_Click);
            // 
            // progettoToolStripMenuItem
            // 
            this.progettoToolStripMenuItem.Name = "progettoToolStripMenuItem";
            this.progettoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.progettoToolStripMenuItem.Text = "Progetto";
            this.progettoToolStripMenuItem.Click += new System.EventHandler(this.progettoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.genCas);
            this.Controls.Add(this.Txt_InOut);
            this.Controls.Add(this.checktext);
            this.Controls.Add(this.ncarat);
            this.Controls.Add(this.testo4);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.meter4);
            this.Controls.Add(this.meter3);
            this.Controls.Add(this.meter2);
            this.Controls.Add(this.meter1);
            this.Controls.Add(this.meter0);
            this.Controls.Add(this.testo1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Minuscole);
            this.Controls.Add(this.Speciali);
            this.Controls.Add(this.Numeri);
            this.Controls.Add(this.Maiuscole);
            this.Controls.Add(this.genera);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Generatore di Password";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button genera;
        private System.Windows.Forms.CheckBox Maiuscole;
        private System.Windows.Forms.CheckBox Numeri;
        private System.Windows.Forms.CheckBox Speciali;
        private System.Windows.Forms.CheckBox Minuscole;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label testo1;
        private System.Windows.Forms.Label meter0;
        private System.Windows.Forms.Label meter1;
        private System.Windows.Forms.Label meter2;
        private System.Windows.Forms.Label meter3;
        private System.Windows.Forms.Label meter4;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label testo4;
        private System.Windows.Forms.Label ncarat;
        private System.Windows.Forms.Label checktext;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox Txt_InOut;
        private System.Windows.Forms.Button genCas;
        private System.Windows.Forms.ToolStripMenuItem versioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progettoToolStripMenuItem;
    }
}

