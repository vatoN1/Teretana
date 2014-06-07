namespace TeretanaBilderhana.Klijenti
{
    partial class DodavanjeKlijenata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodavanjeKlijenata));
            this.nutricionstaID_masked_box = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.trenerID_masked_box = new System.Windows.Forms.MaskedTextBox();
            this.izadjiButton = new System.Windows.Forms.Button();
            this.unosButton = new System.Windows.Forms.Button();
            this.imetb = new System.Windows.Forms.TextBox();
            this.kontakttb = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.prezimetb = new System.Windows.Forms.TextBox();
            this.zenskoRB = new System.Windows.Forms.RadioButton();
            this.muskoRB = new System.Windows.Forms.RadioButton();
            this.datumRodjenjadtp = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nutricionstaID_masked_box
            // 
            this.nutricionstaID_masked_box.Location = new System.Drawing.Point(119, 195);
            this.nutricionstaID_masked_box.Mask = "0000";
            this.nutricionstaID_masked_box.Name = "nutricionstaID_masked_box";
            this.nutricionstaID_masked_box.Size = new System.Drawing.Size(136, 20);
            this.nutricionstaID_masked_box.TabIndex = 25;
            this.nutricionstaID_masked_box.ValidatingType = typeof(int);
            this.nutricionstaID_masked_box.Validating += new System.ComponentModel.CancelEventHandler(this.nutricionistaID_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "ID nutricioniste:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID trenera:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum Rodjenja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kontakt:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // trenerID_masked_box
            // 
            this.trenerID_masked_box.Location = new System.Drawing.Point(119, 169);
            this.trenerID_masked_box.Mask = "0000";
            this.trenerID_masked_box.Name = "trenerID_masked_box";
            this.trenerID_masked_box.Size = new System.Drawing.Size(136, 20);
            this.trenerID_masked_box.TabIndex = 24;
            this.trenerID_masked_box.ValidatingType = typeof(int);
            this.trenerID_masked_box.Validating += new System.ComponentModel.CancelEventHandler(this.trenerID_Validating);
            // 
            // izadjiButton
            // 
            this.izadjiButton.Location = new System.Drawing.Point(217, 245);
            this.izadjiButton.Name = "izadjiButton";
            this.izadjiButton.Size = new System.Drawing.Size(83, 23);
            this.izadjiButton.TabIndex = 33;
            this.izadjiButton.Text = "Izadji";
            this.izadjiButton.UseVisualStyleBackColor = true;
            this.izadjiButton.Click += new System.EventHandler(this.izadjiButton_Click);
            // 
            // unosButton
            // 
            this.unosButton.Location = new System.Drawing.Point(114, 245);
            this.unosButton.Name = "unosButton";
            this.unosButton.Size = new System.Drawing.Size(91, 23);
            this.unosButton.TabIndex = 32;
            this.unosButton.Text = "Unesi";
            this.unosButton.UseVisualStyleBackColor = true;
            this.unosButton.Click += new System.EventHandler(this.unosButton_Click);
            // 
            // imetb
            // 
            this.imetb.Location = new System.Drawing.Point(119, 19);
            this.imetb.Name = "imetb";
            this.imetb.Size = new System.Drawing.Size(137, 20);
            this.imetb.TabIndex = 14;
            this.imetb.Validating += new System.ComponentModel.CancelEventHandler(this.imetb_Validating);
            // 
            // kontakttb
            // 
            this.kontakttb.Location = new System.Drawing.Point(119, 143);
            this.kontakttb.Mask = "000000000";
            this.kontakttb.Name = "kontakttb";
            this.kontakttb.Size = new System.Drawing.Size(137, 20);
            this.kontakttb.TabIndex = 13;
            this.kontakttb.Validating += new System.ComponentModel.CancelEventHandler(this.kontakttb_Validating);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 277);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(311, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // prezimetb
            // 
            this.prezimetb.Location = new System.Drawing.Point(119, 44);
            this.prezimetb.Name = "prezimetb";
            this.prezimetb.Size = new System.Drawing.Size(137, 20);
            this.prezimetb.TabIndex = 15;
            this.prezimetb.Validating += new System.ComponentModel.CancelEventHandler(this.prezimetb_Validating);
            // 
            // zenskoRB
            // 
            this.zenskoRB.AutoSize = true;
            this.zenskoRB.Location = new System.Drawing.Point(90, 18);
            this.zenskoRB.Name = "zenskoRB";
            this.zenskoRB.Size = new System.Drawing.Size(61, 17);
            this.zenskoRB.TabIndex = 1;
            this.zenskoRB.Text = "Zensko";
            this.zenskoRB.UseVisualStyleBackColor = true;
            // 
            // muskoRB
            // 
            this.muskoRB.AutoSize = true;
            this.muskoRB.Checked = true;
            this.muskoRB.Location = new System.Drawing.Point(18, 19);
            this.muskoRB.Name = "muskoRB";
            this.muskoRB.Size = new System.Drawing.Size(57, 17);
            this.muskoRB.TabIndex = 0;
            this.muskoRB.TabStop = true;
            this.muskoRB.Text = "Musko";
            this.muskoRB.UseVisualStyleBackColor = true;
            // 
            // datumRodjenjadtp
            // 
            this.datumRodjenjadtp.Location = new System.Drawing.Point(120, 118);
            this.datumRodjenjadtp.Name = "datumRodjenjadtp";
            this.datumRodjenjadtp.Size = new System.Drawing.Size(136, 20);
            this.datumRodjenjadtp.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zenskoRB);
            this.groupBox2.Controls.Add(this.muskoRB);
            this.groupBox2.Location = new System.Drawing.Point(69, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 41);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spol: ";
            this.groupBox2.Validating += new System.ComponentModel.CancelEventHandler(this.Spol_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nutricionstaID_masked_box);
            this.groupBox1.Controls.Add(this.trenerID_masked_box);
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
            this.groupBox1.Size = new System.Drawing.Size(288, 227);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editovanje klijenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime:";
            // 
            // DodavanjeKlijenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 299);
            this.Controls.Add(this.izadjiButton);
            this.Controls.Add(this.unosButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "DodavanjeKlijenata";
            this.Text = "Dodavanje klijenata";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox nutricionstaID_masked_box;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button izadjiButton;
        private System.Windows.Forms.Button unosButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox trenerID_masked_box;
        private System.Windows.Forms.DateTimePicker datumRodjenjadtp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton zenskoRB;
        private System.Windows.Forms.RadioButton muskoRB;
        private System.Windows.Forms.TextBox prezimetb;
        private System.Windows.Forms.TextBox imetb;
        private System.Windows.Forms.MaskedTextBox kontakttb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}