namespace TeretanaBilderhana.Oprema
{
    partial class EditovanjeOpreme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditovanjeOpreme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cijena_numeric = new System.Windows.Forms.NumericUpDown();
            this.kolicina_numeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.opremaID_masked_box = new System.Windows.Forms.MaskedTextBox();
            this.tip_opreme_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.izadjiButton = new System.Windows.Forms.Button();
            this.unosButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cijena_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolicina_numeric)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cijena_numeric);
            this.groupBox1.Controls.Add(this.kolicina_numeric);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.opremaID_masked_box);
            this.groupBox1.Controls.Add(this.tip_opreme_box);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 139);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editovanje opreme:";
            // 
            // cijena_numeric
            // 
            this.cijena_numeric.DecimalPlaces = 2;
            this.cijena_numeric.Location = new System.Drawing.Point(119, 103);
            this.cijena_numeric.Name = "cijena_numeric";
            this.cijena_numeric.Size = new System.Drawing.Size(144, 20);
            this.cijena_numeric.TabIndex = 27;
            // 
            // kolicina_numeric
            // 
            this.kolicina_numeric.Location = new System.Drawing.Point(119, 74);
            this.kolicina_numeric.Name = "kolicina_numeric";
            this.kolicina_numeric.Size = new System.Drawing.Size(144, 20);
            this.kolicina_numeric.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cijena najama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Kolicina:";
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
            // opremaID_masked_box
            // 
            this.opremaID_masked_box.Location = new System.Drawing.Point(119, 20);
            this.opremaID_masked_box.Mask = "00000";
            this.opremaID_masked_box.Name = "opremaID_masked_box";
            this.opremaID_masked_box.Size = new System.Drawing.Size(144, 20);
            this.opremaID_masked_box.TabIndex = 22;
            this.opremaID_masked_box.ValidatingType = typeof(int);
            // 
            // tip_opreme_box
            // 
            this.tip_opreme_box.Location = new System.Drawing.Point(119, 48);
            this.tip_opreme_box.Name = "tip_opreme_box";
            this.tip_opreme_box.Size = new System.Drawing.Size(144, 20);
            this.tip_opreme_box.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip opreme:";
            // 
            // izadjiButton
            // 
            this.izadjiButton.Location = new System.Drawing.Point(216, 157);
            this.izadjiButton.Name = "izadjiButton";
            this.izadjiButton.Size = new System.Drawing.Size(83, 23);
            this.izadjiButton.TabIndex = 30;
            this.izadjiButton.Text = "Izadji";
            this.izadjiButton.UseVisualStyleBackColor = true;
            // 
            // unosButton
            // 
            this.unosButton.Location = new System.Drawing.Point(113, 157);
            this.unosButton.Name = "unosButton";
            this.unosButton.Size = new System.Drawing.Size(91, 23);
            this.unosButton.TabIndex = 29;
            this.unosButton.Text = "Unesi";
            this.unosButton.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 186);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(311, 22);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // EditovanjeOpreme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 208);
            this.Controls.Add(this.izadjiButton);
            this.Controls.Add(this.unosButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "EditovanjeOpreme";
            this.Text = "Editovanje opreme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cijena_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolicina_numeric)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox opremaID_masked_box;
        private System.Windows.Forms.TextBox tip_opreme_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown cijena_numeric;
        private System.Windows.Forms.NumericUpDown kolicina_numeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button izadjiButton;
        private System.Windows.Forms.Button unosButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}