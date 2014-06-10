namespace TeretanaBilderhana.Uposlenici
{
    partial class BrisanjeUposlenika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrisanjeUposlenika));
            this.plata_npd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.imetb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uposlenikID_masked_box = new System.Windows.Forms.MaskedTextBox();
            this.zaposlenje_datetime = new System.Windows.Forms.DateTimePicker();
            this.rodjenje_datetime = new System.Windows.Forms.DateTimePicker();
            this.sifra_box = new System.Windows.Forms.TextBox();
            this.zaposlenje_combo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zenskoRB = new System.Windows.Forms.RadioButton();
            this.muskoRB = new System.Windows.Forms.RadioButton();
            this.prezimetb = new System.Windows.Forms.TextBox();
            this.kontakt_masked_box = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.unosButton = new System.Windows.Forms.Button();
            this.izadjiButton = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.plata_npd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // plata_npd
            // 
            this.plata_npd.Enabled = false;
            this.plata_npd.Location = new System.Drawing.Point(120, 195);
            this.plata_npd.Maximum = new decimal(new int[] {
            7000,
            0,
            0,
            0});
            this.plata_npd.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.plata_npd.Name = "plata_npd";
            this.plata_npd.Size = new System.Drawing.Size(135, 20);
            this.plata_npd.TabIndex = 24;
            this.plata_npd.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Unesite ID:";
            // 
            // imetb
            // 
            this.imetb.Enabled = false;
            this.imetb.Location = new System.Drawing.Point(119, 48);
            this.imetb.Name = "imetb";
            this.imetb.Size = new System.Drawing.Size(137, 20);
            this.imetb.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.plata_npd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.uposlenikID_masked_box);
            this.groupBox1.Controls.Add(this.zaposlenje_datetime);
            this.groupBox1.Controls.Add(this.rodjenje_datetime);
            this.groupBox1.Controls.Add(this.sifra_box);
            this.groupBox1.Controls.Add(this.zaposlenje_combo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.prezimetb);
            this.groupBox1.Controls.Add(this.imetb);
            this.groupBox1.Controls.Add(this.kontakt_masked_box);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 308);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brisanje uposlenika:";
            // 
            // uposlenikID_masked_box
            // 
            this.uposlenikID_masked_box.Location = new System.Drawing.Point(119, 20);
            this.uposlenikID_masked_box.Mask = "0000";
            this.uposlenikID_masked_box.Name = "uposlenikID_masked_box";
            this.uposlenikID_masked_box.Size = new System.Drawing.Size(136, 20);
            this.uposlenikID_masked_box.TabIndex = 22;
            this.uposlenikID_masked_box.Leave += new System.EventHandler(this.uposlenikID_masked_box_Leave);
            // 
            // zaposlenje_datetime
            // 
            this.zaposlenje_datetime.Enabled = false;
            this.zaposlenje_datetime.Location = new System.Drawing.Point(119, 221);
            this.zaposlenje_datetime.Name = "zaposlenje_datetime";
            this.zaposlenje_datetime.Size = new System.Drawing.Size(136, 20);
            this.zaposlenje_datetime.TabIndex = 21;
            // 
            // rodjenje_datetime
            // 
            this.rodjenje_datetime.Enabled = false;
            this.rodjenje_datetime.Location = new System.Drawing.Point(120, 147);
            this.rodjenje_datetime.Name = "rodjenje_datetime";
            this.rodjenje_datetime.Size = new System.Drawing.Size(136, 20);
            this.rodjenje_datetime.TabIndex = 20;
            // 
            // sifra_box
            // 
            this.sifra_box.Enabled = false;
            this.sifra_box.Location = new System.Drawing.Point(119, 280);
            this.sifra_box.Name = "sifra_box";
            this.sifra_box.Size = new System.Drawing.Size(137, 20);
            this.sifra_box.TabIndex = 19;
            // 
            // zaposlenje_combo
            // 
            this.zaposlenje_combo.Enabled = false;
            this.zaposlenje_combo.FormattingEnabled = true;
            this.zaposlenje_combo.Location = new System.Drawing.Point(119, 251);
            this.zaposlenje_combo.Name = "zaposlenje_combo";
            this.zaposlenje_combo.Size = new System.Drawing.Size(137, 21);
            this.zaposlenje_combo.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zenskoRB);
            this.groupBox2.Controls.Add(this.muskoRB);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(69, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 41);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spol: ";
            // 
            // zenskoRB
            // 
            this.zenskoRB.AutoSize = true;
            this.zenskoRB.Location = new System.Drawing.Point(90, 18);
            this.zenskoRB.Name = "zenskoRB";
            this.zenskoRB.Size = new System.Drawing.Size(61, 17);
            this.zenskoRB.TabIndex = 1;
            this.zenskoRB.TabStop = true;
            this.zenskoRB.Text = "Zensko";
            this.zenskoRB.UseVisualStyleBackColor = true;
            // 
            // muskoRB
            // 
            this.muskoRB.AutoSize = true;
            this.muskoRB.Location = new System.Drawing.Point(18, 19);
            this.muskoRB.Name = "muskoRB";
            this.muskoRB.Size = new System.Drawing.Size(57, 17);
            this.muskoRB.TabIndex = 0;
            this.muskoRB.TabStop = true;
            this.muskoRB.Text = "Musko";
            this.muskoRB.UseVisualStyleBackColor = true;
            // 
            // prezimetb
            // 
            this.prezimetb.Enabled = false;
            this.prezimetb.Location = new System.Drawing.Point(119, 73);
            this.prezimetb.Name = "prezimetb";
            this.prezimetb.Size = new System.Drawing.Size(137, 20);
            this.prezimetb.TabIndex = 15;
            // 
            // kontakt_masked_box
            // 
            this.kontakt_masked_box.Enabled = false;
            this.kontakt_masked_box.Location = new System.Drawing.Point(119, 172);
            this.kontakt_masked_box.Mask = "000000000";
            this.kontakt_masked_box.Name = "kontakt_masked_box";
            this.kontakt_masked_box.Size = new System.Drawing.Size(137, 20);
            this.kontakt_masked_box.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(79, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Sifra: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(86, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(48, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Zaposlenje: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(66, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(17, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Datum Zaposlenja:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(79, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Plata:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(27, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum Rodjenja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(66, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kontakt:";
            // 
            // unosButton
            // 
            this.unosButton.Location = new System.Drawing.Point(114, 327);
            this.unosButton.Name = "unosButton";
            this.unosButton.Size = new System.Drawing.Size(91, 23);
            this.unosButton.TabIndex = 28;
            this.unosButton.Text = "Obrisi";
            this.unosButton.UseVisualStyleBackColor = true;
            this.unosButton.Click += new System.EventHandler(this.unosButton_Click);
            // 
            // izadjiButton
            // 
            this.izadjiButton.Location = new System.Drawing.Point(217, 327);
            this.izadjiButton.Name = "izadjiButton";
            this.izadjiButton.Size = new System.Drawing.Size(83, 23);
            this.izadjiButton.TabIndex = 29;
            this.izadjiButton.Text = "Odustani";
            this.izadjiButton.UseVisualStyleBackColor = true;
            this.izadjiButton.Click += new System.EventHandler(this.izadjiButton_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(306, 22);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BrisanjeUposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.unosButton);
            this.Controls.Add(this.izadjiButton);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrisanjeUposlenika";
            this.Text = "Brisanje uposlenika";
            ((System.ComponentModel.ISupportInitialize)(this.plata_npd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown plata_npd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imetb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox uposlenikID_masked_box;
        private System.Windows.Forms.DateTimePicker zaposlenje_datetime;
        private System.Windows.Forms.DateTimePicker rodjenje_datetime;
        private System.Windows.Forms.TextBox sifra_box;
        private System.Windows.Forms.ComboBox zaposlenje_combo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton zenskoRB;
        private System.Windows.Forms.RadioButton muskoRB;
        private System.Windows.Forms.TextBox prezimetb;
        private System.Windows.Forms.MaskedTextBox kontakt_masked_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button unosButton;
        private System.Windows.Forms.Button izadjiButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}