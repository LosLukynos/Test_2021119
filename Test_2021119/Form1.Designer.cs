namespace Test_2021119
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAktualniStavUctu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numVybrat = new System.Windows.Forms.NumericUpDown();
            this.numVlozit = new System.Windows.Forms.NumericUpDown();
            this.btnVybrat = new System.Windows.Forms.Button();
            this.btnVlozit = new System.Windows.Forms.Button();
            this.lblJmeno = new System.Windows.Forms.Label();
            this.lblMaxStavUctu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vypisUctu = new System.Windows.Forms.ListBox();
            this.btnVytvoritUcet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numMaxStavUctu = new System.Windows.Forms.NumericUpDown();
            this.btnStorno = new System.Windows.Forms.Button();
            this.Vytvorit = new System.Windows.Forms.Button();
            this.txtJmeno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVybrat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVlozit)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStavUctu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAktualniStavUctu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numVybrat);
            this.groupBox1.Controls.Add(this.numVlozit);
            this.groupBox1.Controls.Add(this.btnVybrat);
            this.groupBox1.Controls.Add(this.btnVlozit);
            this.groupBox1.Controls.Add(this.lblJmeno);
            this.groupBox1.Controls.Add(this.lblMaxStavUctu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Účet";
            // 
            // lblAktualniStavUctu
            // 
            this.lblAktualniStavUctu.AutoSize = true;
            this.lblAktualniStavUctu.Location = new System.Drawing.Point(139, 84);
            this.lblAktualniStavUctu.Name = "lblAktualniStavUctu";
            this.lblAktualniStavUctu.Size = new System.Drawing.Size(29, 15);
            this.lblAktualniStavUctu.TabIndex = 0;
            this.lblAktualniStavUctu.Text = "Stav";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Stav účtu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "CZK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "CZK";
            // 
            // numVybrat
            // 
            this.numVybrat.Location = new System.Drawing.Point(105, 148);
            this.numVybrat.Name = "numVybrat";
            this.numVybrat.Size = new System.Drawing.Size(120, 23);
            this.numVybrat.TabIndex = 2;
            // 
            // numVlozit
            // 
            this.numVlozit.Location = new System.Drawing.Point(105, 119);
            this.numVlozit.Name = "numVlozit";
            this.numVlozit.Size = new System.Drawing.Size(120, 23);
            this.numVlozit.TabIndex = 2;
            // 
            // btnVybrat
            // 
            this.btnVybrat.Location = new System.Drawing.Point(6, 148);
            this.btnVybrat.Name = "btnVybrat";
            this.btnVybrat.Size = new System.Drawing.Size(75, 23);
            this.btnVybrat.TabIndex = 1;
            this.btnVybrat.Text = "Vybrat";
            this.btnVybrat.UseVisualStyleBackColor = true;
            this.btnVybrat.Click += new System.EventHandler(this.btnVybrat_Click);
            // 
            // btnVlozit
            // 
            this.btnVlozit.Location = new System.Drawing.Point(6, 119);
            this.btnVlozit.Name = "btnVlozit";
            this.btnVlozit.Size = new System.Drawing.Size(75, 23);
            this.btnVlozit.TabIndex = 1;
            this.btnVlozit.Text = "Vlozit";
            this.btnVlozit.UseVisualStyleBackColor = true;
            this.btnVlozit.Click += new System.EventHandler(this.btnVlozit_Click);
            // 
            // lblJmeno
            // 
            this.lblJmeno.AutoSize = true;
            this.lblJmeno.Location = new System.Drawing.Point(139, 29);
            this.lblJmeno.Name = "lblJmeno";
            this.lblJmeno.Size = new System.Drawing.Size(42, 15);
            this.lblJmeno.TabIndex = 0;
            this.lblJmeno.Text = "Jmeno";
            // 
            // lblMaxStavUctu
            // 
            this.lblMaxStavUctu.AutoSize = true;
            this.lblMaxStavUctu.Location = new System.Drawing.Point(139, 60);
            this.lblMaxStavUctu.Name = "lblMaxStavUctu";
            this.lblMaxStavUctu.Size = new System.Drawing.Size(29, 15);
            this.lblMaxStavUctu.TabIndex = 0;
            this.lblMaxStavUctu.Text = "Stav";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Maximální stav účtu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno";
            // 
            // vypisUctu
            // 
            this.vypisUctu.FormattingEnabled = true;
            this.vypisUctu.ItemHeight = 15;
            this.vypisUctu.Location = new System.Drawing.Point(500, 55);
            this.vypisUctu.Name = "vypisUctu";
            this.vypisUctu.Size = new System.Drawing.Size(217, 274);
            this.vypisUctu.TabIndex = 1;
            this.vypisUctu.SelectedIndexChanged += new System.EventHandler(this.vypisUctu_SelectedIndexChanged);
            // 
            // btnVytvoritUcet
            // 
            this.btnVytvoritUcet.Location = new System.Drawing.Point(500, 26);
            this.btnVytvoritUcet.Name = "btnVytvoritUcet";
            this.btnVytvoritUcet.Size = new System.Drawing.Size(217, 23);
            this.btnVytvoritUcet.TabIndex = 1;
            this.btnVytvoritUcet.Text = "Vytvořit nový účet";
            this.btnVytvoritUcet.UseVisualStyleBackColor = true;
            this.btnVytvoritUcet.Click += new System.EventHandler(this.btnVytvoritUcet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numMaxStavUctu);
            this.groupBox2.Controls.Add(this.btnStorno);
            this.groupBox2.Controls.Add(this.Vytvorit);
            this.groupBox2.Controls.Add(this.txtJmeno);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(319, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 110);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tvorba účtu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "CZK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Maximalni stav účtu";
            // 
            // numMaxStavUctu
            // 
            this.numMaxStavUctu.Location = new System.Drawing.Point(126, 57);
            this.numMaxStavUctu.Name = "numMaxStavUctu";
            this.numMaxStavUctu.Size = new System.Drawing.Size(100, 23);
            this.numMaxStavUctu.TabIndex = 2;
            this.numMaxStavUctu.ValueChanged += new System.EventHandler(this.numMaxStavUctu_ValueChanged);
            // 
            // btnStorno
            // 
            this.btnStorno.Location = new System.Drawing.Point(160, 81);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(96, 23);
            this.btnStorno.TabIndex = 1;
            this.btnStorno.Text = "Storno";
            this.btnStorno.UseVisualStyleBackColor = true;
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // Vytvorit
            // 
            this.Vytvorit.Location = new System.Drawing.Point(6, 81);
            this.Vytvorit.Name = "Vytvorit";
            this.Vytvorit.Size = new System.Drawing.Size(89, 23);
            this.Vytvorit.TabIndex = 1;
            this.Vytvorit.Text = "Vytvořit";
            this.Vytvorit.UseVisualStyleBackColor = true;
            this.Vytvorit.Click += new System.EventHandler(this.Vytvorit_Click);
            // 
            // txtJmeno
            // 
            this.txtJmeno.Location = new System.Drawing.Point(126, 33);
            this.txtJmeno.Name = "txtJmeno";
            this.txtJmeno.Size = new System.Drawing.Size(100, 23);
            this.txtJmeno.TabIndex = 1;
            this.txtJmeno.TextChanged += new System.EventHandler(this.txtJmeno_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Jméno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVytvoritUcet);
            this.Controls.Add(this.vypisUctu);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVybrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVlozit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStavUctu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numVybrat;
        private System.Windows.Forms.NumericUpDown numVlozit;
        private System.Windows.Forms.Button btnVybrat;
        private System.Windows.Forms.Button btnVlozit;
        private System.Windows.Forms.Label lblJmeno;
        private System.Windows.Forms.Label lblMaxStavUctu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox vypisUctu;
        private System.Windows.Forms.Button btnVytvoritUcet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStorno;
        private System.Windows.Forms.Button Vytvorit;
        private System.Windows.Forms.TextBox txtJmeno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numMaxStavUctu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAktualniStavUctu;
        private System.Windows.Forms.Label label8;
    }
}

