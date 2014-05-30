namespace TeretanaBilderhana.Prostorije
{
    partial class EditovanjeProstorija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditovanjeProstorija));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.imetb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.muskoRB = new System.Windows.Forms.RadioButton();
            this.zenskoRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.izadjiButton = new System.Windows.Forms.Button();
            this.unosButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.imetb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 234);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editovanje prostorije:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(119, 20);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(144, 20);
            this.maskedTextBox1.TabIndex = 22;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // imetb
            // 
            this.imetb.Location = new System.Drawing.Point(119, 48);
            this.imetb.Name = "imetb";
            this.imetb.Size = new System.Drawing.Size(144, 20);
            this.imetb.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv prostorije:";
            // 
            // muskoRB
            // 
            this.muskoRB.AutoSize = true;
            this.muskoRB.Location = new System.Drawing.Point(43, 19);
            this.muskoRB.Name = "muskoRB";
            this.muskoRB.Size = new System.Drawing.Size(39, 17);
            this.muskoRB.TabIndex = 0;
            this.muskoRB.TabStop = true;
            this.muskoRB.Text = "Da";
            this.muskoRB.UseVisualStyleBackColor = true;
            // 
            // zenskoRB
            // 
            this.zenskoRB.AutoSize = true;
            this.zenskoRB.Location = new System.Drawing.Point(115, 19);
            this.zenskoRB.Name = "zenskoRB";
            this.zenskoRB.Size = new System.Drawing.Size(39, 17);
            this.zenskoRB.TabIndex = 1;
            this.zenskoRB.TabStop = true;
            this.zenskoRB.Text = "Ne";
            this.zenskoRB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zenskoRB);
            this.groupBox2.Controls.Add(this.muskoRB);
            this.groupBox2.Location = new System.Drawing.Point(76, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 52);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dostupnost:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(119, 132);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(144, 88);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Inventar:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 283);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(311, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // izadjiButton
            // 
            this.izadjiButton.Location = new System.Drawing.Point(216, 252);
            this.izadjiButton.Name = "izadjiButton";
            this.izadjiButton.Size = new System.Drawing.Size(83, 23);
            this.izadjiButton.TabIndex = 27;
            this.izadjiButton.Text = "Izadji";
            this.izadjiButton.UseVisualStyleBackColor = true;
            // 
            // unosButton
            // 
            this.unosButton.Location = new System.Drawing.Point(113, 252);
            this.unosButton.Name = "unosButton";
            this.unosButton.Size = new System.Drawing.Size(91, 23);
            this.unosButton.TabIndex = 26;
            this.unosButton.Text = "Unesi";
            this.unosButton.UseVisualStyleBackColor = true;
            // 
            // EditovanjeProstorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 305);
            this.Controls.Add(this.izadjiButton);
            this.Controls.Add(this.unosButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "EditovanjeProstorija";
            this.Text = "Editovanje prostorija";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox imetb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton zenskoRB;
        private System.Windows.Forms.RadioButton muskoRB;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button izadjiButton;
        private System.Windows.Forms.Button unosButton;

    }
}