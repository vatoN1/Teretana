﻿namespace TeretanaBilderhana.Prostorije
{
    partial class BrisanjeProstorija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrisanjeProstorija));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prostorijacombo = new System.Windows.Forms.ComboBox();
            this.inventar_rich_box = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prostorijaID_masked_box = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dostupna_NE = new System.Windows.Forms.RadioButton();
            this.dostupna_DA = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.izadjiButton = new System.Windows.Forms.Button();
            this.unosButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prostorijacombo);
            this.groupBox1.Controls.Add(this.inventar_rich_box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.prostorijaID_masked_box);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 234);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editovanje prostorije:";
            // 
            // prostorijacombo
            // 
            this.prostorijacombo.Enabled = false;
            this.prostorijacombo.FormattingEnabled = true;
            this.prostorijacombo.Location = new System.Drawing.Point(119, 48);
            this.prostorijacombo.Name = "prostorijacombo";
            this.prostorijacombo.Size = new System.Drawing.Size(144, 21);
            this.prostorijacombo.TabIndex = 2;
            // 
            // inventar_rich_box
            // 
            this.inventar_rich_box.Enabled = false;
            this.inventar_rich_box.Location = new System.Drawing.Point(119, 132);
            this.inventar_rich_box.Name = "inventar_rich_box";
            this.inventar_rich_box.Size = new System.Drawing.Size(144, 88);
            this.inventar_rich_box.TabIndex = 4;
            this.inventar_rich_box.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(64, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Inventar:";
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
            // prostorijaID_masked_box
            // 
            this.prostorijaID_masked_box.Location = new System.Drawing.Point(119, 20);
            this.prostorijaID_masked_box.Mask = "0000";
            this.prostorijaID_masked_box.Name = "prostorijaID_masked_box";
            this.prostorijaID_masked_box.Size = new System.Drawing.Size(144, 20);
            this.prostorijaID_masked_box.TabIndex = 1;
            this.prostorijaID_masked_box.ValidatingType = typeof(int);
            this.prostorijaID_masked_box.Leave += new System.EventHandler(this.prostorijaID_masked_box_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dostupna_NE);
            this.groupBox2.Controls.Add(this.dostupna_DA);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(76, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 52);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dostupnost:";
            // 
            // dostupna_NE
            // 
            this.dostupna_NE.AutoSize = true;
            this.dostupna_NE.Location = new System.Drawing.Point(115, 19);
            this.dostupna_NE.Name = "dostupna_NE";
            this.dostupna_NE.Size = new System.Drawing.Size(39, 17);
            this.dostupna_NE.TabIndex = 1;
            this.dostupna_NE.TabStop = true;
            this.dostupna_NE.Text = "Ne";
            this.dostupna_NE.UseVisualStyleBackColor = true;
            // 
            // dostupna_DA
            // 
            this.dostupna_DA.AutoSize = true;
            this.dostupna_DA.Location = new System.Drawing.Point(43, 19);
            this.dostupna_DA.Name = "dostupna_DA";
            this.dostupna_DA.Size = new System.Drawing.Size(39, 17);
            this.dostupna_DA.TabIndex = 0;
            this.dostupna_DA.TabStop = true;
            this.dostupna_DA.Text = "Da";
            this.dostupna_DA.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(31, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv prostorije:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 282);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(305, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // izadjiButton
            // 
            this.izadjiButton.Location = new System.Drawing.Point(216, 252);
            this.izadjiButton.Name = "izadjiButton";
            this.izadjiButton.Size = new System.Drawing.Size(83, 23);
            this.izadjiButton.TabIndex = 27;
            this.izadjiButton.Text = "Odustani";
            this.izadjiButton.UseVisualStyleBackColor = true;
            this.izadjiButton.Click += new System.EventHandler(this.izadjiButton_Click);
            // 
            // unosButton
            // 
            this.unosButton.Location = new System.Drawing.Point(113, 252);
            this.unosButton.Name = "unosButton";
            this.unosButton.Size = new System.Drawing.Size(91, 23);
            this.unosButton.TabIndex = 26;
            this.unosButton.Text = "Obrisi";
            this.unosButton.UseVisualStyleBackColor = true;
            this.unosButton.Click += new System.EventHandler(this.unosButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BrisanjeProstorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 304);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.izadjiButton);
            this.Controls.Add(this.unosButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrisanjeProstorija";
            this.Text = "Brisanje prostorija";
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox prostorijacombo;
        private System.Windows.Forms.RichTextBox inventar_rich_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox prostorijaID_masked_box;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton dostupna_NE;
        private System.Windows.Forms.RadioButton dostupna_DA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button izadjiButton;
        private System.Windows.Forms.Button unosButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}