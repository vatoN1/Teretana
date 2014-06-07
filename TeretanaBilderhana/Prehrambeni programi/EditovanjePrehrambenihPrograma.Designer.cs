namespace TeretanaBilderhana.Prehrambeni_programi
{
    partial class EditovanjePrehrambenihPrograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditovanjePrehrambenihPrograma));
            this.izadjiButton = new System.Windows.Forms.Button();
            this.unosButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tipprehrambenog_combo = new System.Windows.Forms.ComboBox();
            this.pprogram_masked_box = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.obroci_pprogram_rich_box = new System.Windows.Forms.RichTextBox();
            this.opis_pprogram_rich_box = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // izadjiButton
            // 
            this.izadjiButton.Location = new System.Drawing.Point(260, 282);
            this.izadjiButton.Name = "izadjiButton";
            this.izadjiButton.Size = new System.Drawing.Size(83, 23);
            this.izadjiButton.TabIndex = 6;
            this.izadjiButton.Text = "Izadji";
            this.izadjiButton.UseVisualStyleBackColor = true;
            this.izadjiButton.Click += new System.EventHandler(this.izadjiButton_Click);
            // 
            // unosButton
            // 
            this.unosButton.Location = new System.Drawing.Point(157, 282);
            this.unosButton.Name = "unosButton";
            this.unosButton.Size = new System.Drawing.Size(91, 23);
            this.unosButton.TabIndex = 5;
            this.unosButton.Text = "Unesi";
            this.unosButton.UseVisualStyleBackColor = true;
            this.unosButton.Click += new System.EventHandler(this.unosButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tipprehrambenog_combo);
            this.groupBox1.Controls.Add(this.pprogram_masked_box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.obroci_pprogram_rich_box);
            this.groupBox1.Controls.Add(this.opis_pprogram_rich_box);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 265);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editovanje prehrambenog programa:";
            // 
            // tipprehrambenog_combo
            // 
            this.tipprehrambenog_combo.FormattingEnabled = true;
            this.tipprehrambenog_combo.Location = new System.Drawing.Point(166, 50);
            this.tipprehrambenog_combo.Name = "tipprehrambenog_combo";
            this.tipprehrambenog_combo.Size = new System.Drawing.Size(144, 21);
            this.tipprehrambenog_combo.TabIndex = 2;
            this.tipprehrambenog_combo.Validating += new System.ComponentModel.CancelEventHandler(this.tipprehrambenog_combo_Validating);
            // 
            // pprogram_masked_box
            // 
            this.pprogram_masked_box.Location = new System.Drawing.Point(166, 24);
            this.pprogram_masked_box.Mask = "0000";
            this.pprogram_masked_box.Name = "pprogram_masked_box";
            this.pprogram_masked_box.Size = new System.Drawing.Size(144, 20);
            this.pprogram_masked_box.TabIndex = 1;
            this.pprogram_masked_box.ValidatingType = typeof(int);
            this.pprogram_masked_box.Leave += new System.EventHandler(this.pprogram_masked_box_Leave);
            this.pprogram_masked_box.Validating += new System.ComponentModel.CancelEventHandler(this.pprogramID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Unesite ID:";
            // 
            // obroci_pprogram_rich_box
            // 
            this.obroci_pprogram_rich_box.Location = new System.Drawing.Point(166, 172);
            this.obroci_pprogram_rich_box.Name = "obroci_pprogram_rich_box";
            this.obroci_pprogram_rich_box.Size = new System.Drawing.Size(144, 80);
            this.obroci_pprogram_rich_box.TabIndex = 4;
            this.obroci_pprogram_rich_box.Text = "";
            this.obroci_pprogram_rich_box.Validating += new System.ComponentModel.CancelEventHandler(this.obroci_pprogram_rich_box_Validating);
            // 
            // opis_pprogram_rich_box
            // 
            this.opis_pprogram_rich_box.Location = new System.Drawing.Point(166, 78);
            this.opis_pprogram_rich_box.Name = "opis_pprogram_rich_box";
            this.opis_pprogram_rich_box.Size = new System.Drawing.Size(144, 88);
            this.opis_pprogram_rich_box.TabIndex = 3;
            this.opis_pprogram_rich_box.Text = "";
            this.opis_pprogram_rich_box.Validating += new System.ComponentModel.CancelEventHandler(this.opis_pprogram_rich_box_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip prehrambenog programa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Obroci:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 317);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(371, 22);
            this.statusStrip1.TabIndex = 27;
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
            // EditovanjePrehrambenihPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 339);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.izadjiButton);
            this.Controls.Add(this.unosButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "EditovanjePrehrambenihPrograma";
            this.Text = "Editovanje prehrambenih programa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button izadjiButton;
        private System.Windows.Forms.Button unosButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox obroci_pprogram_rich_box;
        private System.Windows.Forms.RichTextBox opis_pprogram_rich_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MaskedTextBox pprogram_masked_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tipprehrambenog_combo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}