﻿namespace TeretanaBilderhana.Klijenti
{
    partial class EditovanjeKlijenata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditovanjeKlijenata));
            this.label1 = new System.Windows.Forms.Label();
            this.klijentID_masked_box = new System.Windows.Forms.MaskedTextBox();
            this.datumRodjenjadtp = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zenskoRB = new System.Windows.Forms.RadioButton();
            this.muskoRB = new System.Windows.Forms.RadioButton();
            this.prezimetb = new System.Windows.Forms.TextBox();
            this.imetb = new System.Windows.Forms.TextBox();
            this.kontakttb = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.izadjiButton = new System.Windows.Forms.Button();
            this.unosButton = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nutricionista_combo = new System.Windows.Forms.ComboBox();
            this.trener_combo = new System.Windows.Forms.ComboBox();
            this.bodymass_numeric = new System.Windows.Forms.NumericUpDown();
            this.tezina_numeric = new System.Windows.Forms.NumericUpDown();
            this.visina_numeric = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nutricionistaID_masked_box = new System.Windows.Forms.MaskedTextBox();
            this.trenerID_masked_box = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bodymass_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tezina_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visina_numeric)).BeginInit();
            this.SuspendLayout();
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
            // klijentID_masked_box
            // 
            this.klijentID_masked_box.Location = new System.Drawing.Point(119, 20);
            this.klijentID_masked_box.Mask = "0000";
            this.klijentID_masked_box.Name = "klijentID_masked_box";
            this.klijentID_masked_box.Size = new System.Drawing.Size(136, 20);
            this.klijentID_masked_box.TabIndex = 1;
            this.klijentID_masked_box.ValidatingType = typeof(int);
            this.klijentID_masked_box.Leave += new System.EventHandler(this.klijentID_masked_box_Leave);
            this.klijentID_masked_box.Validating += new System.ComponentModel.CancelEventHandler(this.klijentID_Validating);
            // 
            // datumRodjenjadtp
            // 
            this.datumRodjenjadtp.Location = new System.Drawing.Point(120, 147);
            this.datumRodjenjadtp.Name = "datumRodjenjadtp";
            this.datumRodjenjadtp.Size = new System.Drawing.Size(136, 20);
            this.datumRodjenjadtp.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zenskoRB);
            this.groupBox2.Controls.Add(this.muskoRB);
            this.groupBox2.Location = new System.Drawing.Point(69, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 41);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spol: ";
            this.groupBox2.Validating += new System.ComponentModel.CancelEventHandler(this.Spol_Validating);
            // 
            // zenskoRB
            // 
            this.zenskoRB.AutoSize = true;
            this.zenskoRB.Location = new System.Drawing.Point(90, 18);
            this.zenskoRB.Name = "zenskoRB";
            this.zenskoRB.Size = new System.Drawing.Size(61, 17);
            this.zenskoRB.TabIndex = 6;
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
            this.muskoRB.TabIndex = 5;
            this.muskoRB.TabStop = true;
            this.muskoRB.Text = "Musko";
            this.muskoRB.UseVisualStyleBackColor = true;
            // 
            // prezimetb
            // 
            this.prezimetb.Location = new System.Drawing.Point(119, 73);
            this.prezimetb.Name = "prezimetb";
            this.prezimetb.Size = new System.Drawing.Size(137, 20);
            this.prezimetb.TabIndex = 3;
            this.prezimetb.Validating += new System.ComponentModel.CancelEventHandler(this.prezimetb_Validating);
            // 
            // imetb
            // 
            this.imetb.Location = new System.Drawing.Point(119, 48);
            this.imetb.Name = "imetb";
            this.imetb.Size = new System.Drawing.Size(137, 20);
            this.imetb.TabIndex = 2;
            this.imetb.Validating += new System.ComponentModel.CancelEventHandler(this.imetb_Validating);
            // 
            // kontakttb
            // 
            this.kontakttb.Location = new System.Drawing.Point(119, 242);
            this.kontakttb.Mask = "000000000";
            this.kontakttb.Name = "kontakttb";
            this.kontakttb.Size = new System.Drawing.Size(137, 20);
            this.kontakttb.TabIndex = 8;
            this.kontakttb.Validating += new System.ComponentModel.CancelEventHandler(this.kontakttb_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime:";
            // 
            // izadjiButton
            // 
            this.izadjiButton.Location = new System.Drawing.Point(217, 394);
            this.izadjiButton.Name = "izadjiButton";
            this.izadjiButton.Size = new System.Drawing.Size(83, 23);
            this.izadjiButton.TabIndex = 12;
            this.izadjiButton.Text = "Izadji";
            this.izadjiButton.UseVisualStyleBackColor = true;
            this.izadjiButton.Click += new System.EventHandler(this.izadjiButton_Click);
            // 
            // unosButton
            // 
            this.unosButton.Location = new System.Drawing.Point(114, 394);
            this.unosButton.Name = "unosButton";
            this.unosButton.Size = new System.Drawing.Size(91, 23);
            this.unosButton.TabIndex = 11;
            this.unosButton.Text = "Unesi";
            this.unosButton.UseVisualStyleBackColor = true;
            this.unosButton.Click += new System.EventHandler(this.unosButton_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(312, 22);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "ID nutricioniste:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID trenera:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum Rodjenja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kontakt:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.nutricionista_combo);
            this.groupBox1.Controls.Add(this.trener_combo);
            this.groupBox1.Controls.Add(this.bodymass_numeric);
            this.groupBox1.Controls.Add(this.tezina_numeric);
            this.groupBox1.Controls.Add(this.visina_numeric);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.nutricionistaID_masked_box);
            this.groupBox1.Controls.Add(this.trenerID_masked_box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.klijentID_masked_box);
            this.groupBox1.Controls.Add(this.datumRodjenjadtp);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.prezimetb);
            this.groupBox1.Controls.Add(this.imetb);
            this.groupBox1.Controls.Add(this.kontakttb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 376);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editovanje klijenta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Izaberi nutricionistu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Izaberi trenera:";
            // 
            // nutricionista_combo
            // 
            this.nutricionista_combo.FormattingEnabled = true;
            this.nutricionista_combo.Location = new System.Drawing.Point(120, 295);
            this.nutricionista_combo.Name = "nutricionista_combo";
            this.nutricionista_combo.Size = new System.Drawing.Size(137, 21);
            this.nutricionista_combo.TabIndex = 45;
            this.nutricionista_combo.SelectedIndexChanged += new System.EventHandler(this.nutricionista_combo_SelectedIndexChanged);
            // 
            // trener_combo
            // 
            this.trener_combo.FormattingEnabled = true;
            this.trener_combo.Location = new System.Drawing.Point(120, 268);
            this.trener_combo.Name = "trener_combo";
            this.trener_combo.Size = new System.Drawing.Size(137, 21);
            this.trener_combo.TabIndex = 44;
            this.trener_combo.SelectedIndexChanged += new System.EventHandler(this.trener_combo_SelectedIndexChanged);
            // 
            // bodymass_numeric
            // 
            this.bodymass_numeric.DecimalPlaces = 3;
            this.bodymass_numeric.Location = new System.Drawing.Point(118, 218);
            this.bodymass_numeric.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.bodymass_numeric.Name = "bodymass_numeric";
            this.bodymass_numeric.Size = new System.Drawing.Size(137, 20);
            this.bodymass_numeric.TabIndex = 43;
            this.bodymass_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bodymass_numeric.ValueChanged += new System.EventHandler(this.bodymass_numeric_ValueChanged);
            // 
            // tezina_numeric
            // 
            this.tezina_numeric.DecimalPlaces = 3;
            this.tezina_numeric.Location = new System.Drawing.Point(118, 196);
            this.tezina_numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tezina_numeric.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tezina_numeric.Name = "tezina_numeric";
            this.tezina_numeric.Size = new System.Drawing.Size(137, 20);
            this.tezina_numeric.TabIndex = 42;
            this.tezina_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tezina_numeric.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // visina_numeric
            // 
            this.visina_numeric.Location = new System.Drawing.Point(118, 173);
            this.visina_numeric.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.visina_numeric.Name = "visina_numeric";
            this.visina_numeric.Size = new System.Drawing.Size(137, 20);
            this.visina_numeric.TabIndex = 41;
            this.visina_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.visina_numeric.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.visina_numeric.ValueChanged += new System.EventHandler(this.visina_numeric_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Body mass index:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(74, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Visina:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(70, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Tezina:";
            // 
            // nutricionistaID_masked_box
            // 
            this.nutricionistaID_masked_box.Location = new System.Drawing.Point(118, 348);
            this.nutricionistaID_masked_box.Mask = "0000";
            this.nutricionistaID_masked_box.Name = "nutricionistaID_masked_box";
            this.nutricionistaID_masked_box.Size = new System.Drawing.Size(138, 20);
            this.nutricionistaID_masked_box.TabIndex = 49;
            // 
            // trenerID_masked_box
            // 
            this.trenerID_masked_box.Location = new System.Drawing.Point(120, 322);
            this.trenerID_masked_box.Mask = "0000";
            this.trenerID_masked_box.Name = "trenerID_masked_box";
            this.trenerID_masked_box.Size = new System.Drawing.Size(136, 20);
            this.trenerID_masked_box.TabIndex = 9;
            this.trenerID_masked_box.Validating += new System.ComponentModel.CancelEventHandler(this.trenerID_Validating);
            // 
            // EditovanjeKlijenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 442);
            this.Controls.Add(this.izadjiButton);
            this.Controls.Add(this.unosButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "EditovanjeKlijenata";
            this.Text = "Editovanje klijenata";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bodymass_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tezina_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visina_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox klijentID_masked_box;
        private System.Windows.Forms.DateTimePicker datumRodjenjadtp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton zenskoRB;
        private System.Windows.Forms.RadioButton muskoRB;
        private System.Windows.Forms.TextBox prezimetb;
        private System.Windows.Forms.TextBox imetb;
        private System.Windows.Forms.MaskedTextBox kontakttb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button izadjiButton;
        private System.Windows.Forms.Button unosButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox trenerID_masked_box;
        private System.Windows.Forms.MaskedTextBox nutricionistaID_masked_box;
        private System.Windows.Forms.NumericUpDown bodymass_numeric;
        private System.Windows.Forms.NumericUpDown tezina_numeric;
        private System.Windows.Forms.NumericUpDown visina_numeric;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox nutricionista_combo;
        private System.Windows.Forms.ComboBox trener_combo;
    }
}