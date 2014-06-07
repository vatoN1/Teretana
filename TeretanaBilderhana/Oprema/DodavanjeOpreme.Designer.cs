namespace TeretanaBilderhana.Oprema
{
    partial class DodavanjeOpreme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodavanjeOpreme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tipopremecombo = new System.Windows.Forms.ComboBox();
            this.cijena_numeric = new System.Windows.Forms.NumericUpDown();
            this.kolicina_numeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.izadjiButton = new System.Windows.Forms.Button();
            this.unosButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cijena_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolicina_numeric)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tipopremecombo);
            this.groupBox1.Controls.Add(this.cijena_numeric);
            this.groupBox1.Controls.Add(this.kolicina_numeric);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 108);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editovanje opreme:";
            // 
            // tipopremecombo
            // 
            this.tipopremecombo.FormattingEnabled = true;
            this.tipopremecombo.Items.AddRange(new object[] {
            "Bandaze",
            "Flasa",
            "Peskir",
            "Pojas",
            "Rukavice",
            "Sorts",
            "Tene"});
            this.tipopremecombo.Location = new System.Drawing.Point(120, 19);
            this.tipopremecombo.Name = "tipopremecombo";
            this.tipopremecombo.Size = new System.Drawing.Size(144, 21);
            this.tipopremecombo.TabIndex = 28;
            // 
            // cijena_numeric
            // 
            this.cijena_numeric.Location = new System.Drawing.Point(120, 74);
            this.cijena_numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cijena_numeric.Name = "cijena_numeric";
            this.cijena_numeric.Size = new System.Drawing.Size(144, 20);
            this.cijena_numeric.TabIndex = 27;
            this.cijena_numeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // kolicina_numeric
            // 
            this.kolicina_numeric.Location = new System.Drawing.Point(120, 45);
            this.kolicina_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kolicina_numeric.Name = "kolicina_numeric";
            this.kolicina_numeric.Size = new System.Drawing.Size(144, 20);
            this.kolicina_numeric.TabIndex = 26;
            this.kolicina_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cijena najama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Kolicina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip opreme:";
            // 
            // izadjiButton
            // 
            this.izadjiButton.Location = new System.Drawing.Point(216, 126);
            this.izadjiButton.Name = "izadjiButton";
            this.izadjiButton.Size = new System.Drawing.Size(83, 23);
            this.izadjiButton.TabIndex = 34;
            this.izadjiButton.Text = "Izadji";
            this.izadjiButton.UseVisualStyleBackColor = true;
            this.izadjiButton.Click += new System.EventHandler(this.izadjiButton_Click);
            // 
            // unosButton
            // 
            this.unosButton.Location = new System.Drawing.Point(113, 126);
            this.unosButton.Name = "unosButton";
            this.unosButton.Size = new System.Drawing.Size(91, 23);
            this.unosButton.TabIndex = 33;
            this.unosButton.Text = "Unesi";
            this.unosButton.UseVisualStyleBackColor = true;
            this.unosButton.Click += new System.EventHandler(this.unosButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 154);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(310, 22);
            this.statusStrip1.TabIndex = 32;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DodavanjeOpreme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 176);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.izadjiButton);
            this.Controls.Add(this.unosButton);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "DodavanjeOpreme";
            this.Text = "Dodavanje opreme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cijena_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolicina_numeric)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown cijena_numeric;
        private System.Windows.Forms.NumericUpDown kolicina_numeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button izadjiButton;
        private System.Windows.Forms.Button unosButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox tipopremecombo;
    }
}