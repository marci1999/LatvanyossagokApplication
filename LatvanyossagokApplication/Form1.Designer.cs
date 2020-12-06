namespace LatvanyossagokApplication
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
            this.bVarostHozzaAd = new System.Windows.Forms.Button();
            this.tBVarosNev = new System.Windows.Forms.TextBox();
            this.nUADVarosLakosaga = new System.Windows.Forms.NumericUpDown();
            this.gBVaros = new System.Windows.Forms.GroupBox();
            this.gBLatvanyosag = new System.Windows.Forms.GroupBox();
            this.tBLatvanyosagLeiras = new System.Windows.Forms.TextBox();
            this.nUDLatvanyosagAr = new System.Windows.Forms.NumericUpDown();
            this.bLHozzaAd = new System.Windows.Forms.Button();
            this.cBVaroshozKotes = new System.Windows.Forms.ComboBox();
            this.tBLatvanyosagNev = new System.Windows.Forms.TextBox();
            this.lBVarosLista = new System.Windows.Forms.ListBox();
            this.gBVarosModosit = new System.Windows.Forms.GroupBox();
            this.tBVarosNevModosit = new System.Windows.Forms.TextBox();
            this.nUADVarosLakosagaModosit = new System.Windows.Forms.NumericUpDown();
            this.bVarosModosit = new System.Windows.Forms.Button();
            this.gBLatvanyosagModositas = new System.Windows.Forms.GroupBox();
            this.tBLatvanyosagLeirasModosit = new System.Windows.Forms.TextBox();
            this.nUDLatvanyosagArModosit = new System.Windows.Forms.NumericUpDown();
            this.bLModosit = new System.Windows.Forms.Button();
            this.cBVaroshozKotesModosit = new System.Windows.Forms.ComboBox();
            this.tBLatvanyosagNevModosit = new System.Windows.Forms.TextBox();
            this.lBLatvanyosagLista = new System.Windows.Forms.ListBox();
            this.bVarosTorol = new System.Windows.Forms.Button();
            this.bLatvanyosagTorol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUADVarosLakosaga)).BeginInit();
            this.gBVaros.SuspendLayout();
            this.gBLatvanyosag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLatvanyosagAr)).BeginInit();
            this.gBVarosModosit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUADVarosLakosagaModosit)).BeginInit();
            this.gBLatvanyosagModositas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLatvanyosagArModosit)).BeginInit();
            this.SuspendLayout();
            // 
            // bVarostHozzaAd
            // 
            this.bVarostHozzaAd.Location = new System.Drawing.Point(6, 71);
            this.bVarostHozzaAd.Name = "bVarostHozzaAd";
            this.bVarostHozzaAd.Size = new System.Drawing.Size(75, 23);
            this.bVarostHozzaAd.TabIndex = 0;
            this.bVarostHozzaAd.Text = "Hozzá ad";
            this.bVarostHozzaAd.UseVisualStyleBackColor = true;
            this.bVarostHozzaAd.Click += new System.EventHandler(this.bVarostHozzaAd_Click);
            // 
            // tBVarosNev
            // 
            this.tBVarosNev.Location = new System.Drawing.Point(6, 19);
            this.tBVarosNev.Name = "tBVarosNev";
            this.tBVarosNev.Size = new System.Drawing.Size(100, 20);
            this.tBVarosNev.TabIndex = 1;
            // 
            // nUADVarosLakosaga
            // 
            this.nUADVarosLakosaga.Location = new System.Drawing.Point(6, 45);
            this.nUADVarosLakosaga.Name = "nUADVarosLakosaga";
            this.nUADVarosLakosaga.Size = new System.Drawing.Size(120, 20);
            this.nUADVarosLakosaga.TabIndex = 2;
            // 
            // gBVaros
            // 
            this.gBVaros.Controls.Add(this.tBVarosNev);
            this.gBVaros.Controls.Add(this.nUADVarosLakosaga);
            this.gBVaros.Controls.Add(this.bVarostHozzaAd);
            this.gBVaros.Location = new System.Drawing.Point(12, 12);
            this.gBVaros.Name = "gBVaros";
            this.gBVaros.Size = new System.Drawing.Size(142, 111);
            this.gBVaros.TabIndex = 3;
            this.gBVaros.TabStop = false;
            this.gBVaros.Text = "város felvétele";
            // 
            // gBLatvanyosag
            // 
            this.gBLatvanyosag.Controls.Add(this.tBLatvanyosagLeiras);
            this.gBLatvanyosag.Controls.Add(this.nUDLatvanyosagAr);
            this.gBLatvanyosag.Controls.Add(this.bLHozzaAd);
            this.gBLatvanyosag.Controls.Add(this.cBVaroshozKotes);
            this.gBLatvanyosag.Controls.Add(this.tBLatvanyosagNev);
            this.gBLatvanyosag.Location = new System.Drawing.Point(12, 265);
            this.gBLatvanyosag.Name = "gBLatvanyosag";
            this.gBLatvanyosag.Size = new System.Drawing.Size(142, 173);
            this.gBLatvanyosag.TabIndex = 4;
            this.gBLatvanyosag.TabStop = false;
            this.gBLatvanyosag.Text = "Látványoság felvétele";
            // 
            // tBLatvanyosagLeiras
            // 
            this.tBLatvanyosagLeiras.Location = new System.Drawing.Point(6, 45);
            this.tBLatvanyosagLeiras.Multiline = true;
            this.tBLatvanyosagLeiras.Name = "tBLatvanyosagLeiras";
            this.tBLatvanyosagLeiras.Size = new System.Drawing.Size(100, 20);
            this.tBLatvanyosagLeiras.TabIndex = 3;
            // 
            // nUDLatvanyosagAr
            // 
            this.nUDLatvanyosagAr.Location = new System.Drawing.Point(6, 71);
            this.nUDLatvanyosagAr.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.nUDLatvanyosagAr.Name = "nUDLatvanyosagAr";
            this.nUDLatvanyosagAr.Size = new System.Drawing.Size(120, 20);
            this.nUDLatvanyosagAr.TabIndex = 2;
            // 
            // bLHozzaAd
            // 
            this.bLHozzaAd.Location = new System.Drawing.Point(31, 134);
            this.bLHozzaAd.Name = "bLHozzaAd";
            this.bLHozzaAd.Size = new System.Drawing.Size(75, 23);
            this.bLHozzaAd.TabIndex = 0;
            this.bLHozzaAd.Text = "Hozzá ad";
            this.bLHozzaAd.UseVisualStyleBackColor = true;
            this.bLHozzaAd.Click += new System.EventHandler(this.bLHozzaAd_Click);
            // 
            // cBVaroshozKotes
            // 
            this.cBVaroshozKotes.FormattingEnabled = true;
            this.cBVaroshozKotes.Items.AddRange(new object[] {
            "válaszon várost"});
            this.cBVaroshozKotes.Location = new System.Drawing.Point(6, 97);
            this.cBVaroshozKotes.Name = "cBVaroshozKotes";
            this.cBVaroshozKotes.Size = new System.Drawing.Size(121, 21);
            this.cBVaroshozKotes.TabIndex = 2;
            // 
            // tBLatvanyosagNev
            // 
            this.tBLatvanyosagNev.Location = new System.Drawing.Point(6, 19);
            this.tBLatvanyosagNev.Name = "tBLatvanyosagNev";
            this.tBLatvanyosagNev.Size = new System.Drawing.Size(100, 20);
            this.tBLatvanyosagNev.TabIndex = 1;
            // 
            // lBVarosLista
            // 
            this.lBVarosLista.FormattingEnabled = true;
            this.lBVarosLista.Location = new System.Drawing.Point(12, 140);
            this.lBVarosLista.Name = "lBVarosLista";
            this.lBVarosLista.Size = new System.Drawing.Size(142, 108);
            this.lBVarosLista.TabIndex = 5;
            this.lBVarosLista.SelectedIndexChanged += new System.EventHandler(this.lBVarosLista_SelectedIndexChanged);
            // 
            // gBVarosModosit
            // 
            this.gBVarosModosit.Controls.Add(this.tBVarosNevModosit);
            this.gBVarosModosit.Controls.Add(this.nUADVarosLakosagaModosit);
            this.gBVarosModosit.Controls.Add(this.bVarosModosit);
            this.gBVarosModosit.Location = new System.Drawing.Point(180, 12);
            this.gBVarosModosit.Name = "gBVarosModosit";
            this.gBVarosModosit.Size = new System.Drawing.Size(142, 111);
            this.gBVarosModosit.TabIndex = 4;
            this.gBVarosModosit.TabStop = false;
            this.gBVarosModosit.Text = "város modositasa";
            this.gBVarosModosit.Visible = false;
            // 
            // tBVarosNevModosit
            // 
            this.tBVarosNevModosit.Location = new System.Drawing.Point(6, 19);
            this.tBVarosNevModosit.Name = "tBVarosNevModosit";
            this.tBVarosNevModosit.Size = new System.Drawing.Size(100, 20);
            this.tBVarosNevModosit.TabIndex = 1;
            // 
            // nUADVarosLakosagaModosit
            // 
            this.nUADVarosLakosagaModosit.Location = new System.Drawing.Point(6, 45);
            this.nUADVarosLakosagaModosit.Name = "nUADVarosLakosagaModosit";
            this.nUADVarosLakosagaModosit.Size = new System.Drawing.Size(120, 20);
            this.nUADVarosLakosagaModosit.TabIndex = 2;
            // 
            // bVarosModosit
            // 
            this.bVarosModosit.Location = new System.Drawing.Point(6, 71);
            this.bVarosModosit.Name = "bVarosModosit";
            this.bVarosModosit.Size = new System.Drawing.Size(75, 23);
            this.bVarosModosit.TabIndex = 0;
            this.bVarosModosit.Text = "Modosit";
            this.bVarosModosit.UseVisualStyleBackColor = true;
            this.bVarosModosit.Click += new System.EventHandler(this.bVarosModosit_Click);
            // 
            // gBLatvanyosagModositas
            // 
            this.gBLatvanyosagModositas.Controls.Add(this.tBLatvanyosagLeirasModosit);
            this.gBLatvanyosagModositas.Controls.Add(this.nUDLatvanyosagArModosit);
            this.gBLatvanyosagModositas.Controls.Add(this.bLModosit);
            this.gBLatvanyosagModositas.Controls.Add(this.cBVaroshozKotesModosit);
            this.gBLatvanyosagModositas.Controls.Add(this.tBLatvanyosagNevModosit);
            this.gBLatvanyosagModositas.Location = new System.Drawing.Point(180, 265);
            this.gBLatvanyosagModositas.Name = "gBLatvanyosagModositas";
            this.gBLatvanyosagModositas.Size = new System.Drawing.Size(142, 173);
            this.gBLatvanyosagModositas.TabIndex = 5;
            this.gBLatvanyosagModositas.TabStop = false;
            this.gBLatvanyosagModositas.Text = "Látványoság modositása";
            this.gBLatvanyosagModositas.Visible = false;
            // 
            // tBLatvanyosagLeirasModosit
            // 
            this.tBLatvanyosagLeirasModosit.Location = new System.Drawing.Point(6, 45);
            this.tBLatvanyosagLeirasModosit.Multiline = true;
            this.tBLatvanyosagLeirasModosit.Name = "tBLatvanyosagLeirasModosit";
            this.tBLatvanyosagLeirasModosit.Size = new System.Drawing.Size(100, 20);
            this.tBLatvanyosagLeirasModosit.TabIndex = 3;
            // 
            // nUDLatvanyosagArModosit
            // 
            this.nUDLatvanyosagArModosit.Location = new System.Drawing.Point(6, 71);
            this.nUDLatvanyosagArModosit.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.nUDLatvanyosagArModosit.Name = "nUDLatvanyosagArModosit";
            this.nUDLatvanyosagArModosit.Size = new System.Drawing.Size(120, 20);
            this.nUDLatvanyosagArModosit.TabIndex = 2;
            // 
            // bLModosit
            // 
            this.bLModosit.Location = new System.Drawing.Point(31, 134);
            this.bLModosit.Name = "bLModosit";
            this.bLModosit.Size = new System.Drawing.Size(75, 23);
            this.bLModosit.TabIndex = 0;
            this.bLModosit.Text = "Modosit";
            this.bLModosit.UseVisualStyleBackColor = true;
            this.bLModosit.Click += new System.EventHandler(this.bLModosit_Click);
            // 
            // cBVaroshozKotesModosit
            // 
            this.cBVaroshozKotesModosit.FormattingEnabled = true;
            this.cBVaroshozKotesModosit.Items.AddRange(new object[] {
            "válaszon várost"});
            this.cBVaroshozKotesModosit.Location = new System.Drawing.Point(6, 97);
            this.cBVaroshozKotesModosit.Name = "cBVaroshozKotesModosit";
            this.cBVaroshozKotesModosit.Size = new System.Drawing.Size(121, 21);
            this.cBVaroshozKotesModosit.TabIndex = 2;
            // 
            // tBLatvanyosagNevModosit
            // 
            this.tBLatvanyosagNevModosit.Location = new System.Drawing.Point(6, 19);
            this.tBLatvanyosagNevModosit.Name = "tBLatvanyosagNevModosit";
            this.tBLatvanyosagNevModosit.Size = new System.Drawing.Size(100, 20);
            this.tBLatvanyosagNevModosit.TabIndex = 1;
            // 
            // lBLatvanyosagLista
            // 
            this.lBLatvanyosagLista.FormattingEnabled = true;
            this.lBLatvanyosagLista.Location = new System.Drawing.Point(180, 140);
            this.lBLatvanyosagLista.Name = "lBLatvanyosagLista";
            this.lBLatvanyosagLista.Size = new System.Drawing.Size(142, 108);
            this.lBLatvanyosagLista.TabIndex = 6;
            this.lBLatvanyosagLista.SelectedIndexChanged += new System.EventHandler(this.lBLatvanyosagLista_SelectedIndexChanged);
            // 
            // bVarosTorol
            // 
            this.bVarosTorol.Location = new System.Drawing.Point(346, 140);
            this.bVarosTorol.Name = "bVarosTorol";
            this.bVarosTorol.Size = new System.Drawing.Size(68, 23);
            this.bVarosTorol.TabIndex = 13;
            this.bVarosTorol.Text = "Város töröl";
            this.bVarosTorol.UseVisualStyleBackColor = true;
            this.bVarosTorol.Visible = false;
            this.bVarosTorol.Click += new System.EventHandler(this.bTorol_Click);
            // 
            // bLatvanyosagTorol
            // 
            this.bLatvanyosagTorol.Location = new System.Drawing.Point(346, 225);
            this.bLatvanyosagTorol.Name = "bLatvanyosagTorol";
            this.bLatvanyosagTorol.Size = new System.Drawing.Size(113, 23);
            this.bLatvanyosagTorol.TabIndex = 14;
            this.bLatvanyosagTorol.Text = "Látványoság Töröl";
            this.bLatvanyosagTorol.UseVisualStyleBackColor = true;
            this.bLatvanyosagTorol.Visible = false;
            this.bLatvanyosagTorol.Click += new System.EventHandler(this.bLatvanyosagTorol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bLatvanyosagTorol);
            this.Controls.Add(this.bVarosTorol);
            this.Controls.Add(this.lBLatvanyosagLista);
            this.Controls.Add(this.gBLatvanyosagModositas);
            this.Controls.Add(this.gBVarosModosit);
            this.Controls.Add(this.lBVarosLista);
            this.Controls.Add(this.gBLatvanyosag);
            this.Controls.Add(this.gBVaros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUADVarosLakosaga)).EndInit();
            this.gBVaros.ResumeLayout(false);
            this.gBVaros.PerformLayout();
            this.gBLatvanyosag.ResumeLayout(false);
            this.gBLatvanyosag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLatvanyosagAr)).EndInit();
            this.gBVarosModosit.ResumeLayout(false);
            this.gBVarosModosit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUADVarosLakosagaModosit)).EndInit();
            this.gBLatvanyosagModositas.ResumeLayout(false);
            this.gBLatvanyosagModositas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLatvanyosagArModosit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bVarostHozzaAd;
        private System.Windows.Forms.TextBox tBVarosNev;
        private System.Windows.Forms.NumericUpDown nUADVarosLakosaga;
        private System.Windows.Forms.GroupBox gBVaros;
        private System.Windows.Forms.GroupBox gBLatvanyosag;
        private System.Windows.Forms.TextBox tBLatvanyosagNev;
        private System.Windows.Forms.NumericUpDown nUDLatvanyosagAr;
        private System.Windows.Forms.Button bLHozzaAd;
        private System.Windows.Forms.ComboBox cBVaroshozKotes;
        private System.Windows.Forms.TextBox tBLatvanyosagLeiras;
        private System.Windows.Forms.ListBox lBVarosLista;
        private System.Windows.Forms.GroupBox gBVarosModosit;
        private System.Windows.Forms.TextBox tBVarosNevModosit;
        private System.Windows.Forms.NumericUpDown nUADVarosLakosagaModosit;
        private System.Windows.Forms.Button bVarosModosit;
        private System.Windows.Forms.GroupBox gBLatvanyosagModositas;
        private System.Windows.Forms.TextBox tBLatvanyosagLeirasModosit;
        private System.Windows.Forms.NumericUpDown nUDLatvanyosagArModosit;
        private System.Windows.Forms.Button bLModosit;
        private System.Windows.Forms.ComboBox cBVaroshozKotesModosit;
        private System.Windows.Forms.TextBox tBLatvanyosagNevModosit;
        private System.Windows.Forms.ListBox lBLatvanyosagLista;
        private System.Windows.Forms.Button bVarosTorol;
        private System.Windows.Forms.Button bLatvanyosagTorol;
    }
}

