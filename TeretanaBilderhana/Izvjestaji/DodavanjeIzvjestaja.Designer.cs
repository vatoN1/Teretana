namespace TeretanaBilderhana.Izvjestaji
{
    partial class DodavanjeIzvjestaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodavanjeIzvjestaja));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sadrzaj_rich_box = new System.Windows.Forms.RichTextBox();
            this.izvjestaj_datetime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.id_uposlenik_masked_box = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.izadjiButton = new System.Windows.Forms.Button();
            this.unosButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sadrzaj_rich_box);
            this.groupBox1.Controls.Add(this.izvjestaj_datetime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.id_uposlenik_masked_box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 192);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje izvjestaja:";
            // 
            // sadrzaj_rich_box
            // 
            this.sadrzaj_rich_box.Location = new System.Drawing.Point(120, 73);
            this.sadrzaj_rich_box.Name = "sadrzaj_rich_box";
            this.sadrzaj_rich_box.Size = new System.Drawing.Size(144, 96);
            this.sadrzaj_rich_box.TabIndex = 31;
            this.sadrzaj_rich_box.Text = "";
            // 
            // izvjestaj_datetime
            // 
            this.izvjestaj_datetime.Location = new System.Drawing.Point(120, 45);
            this.izvjestaj_datetime.Name = "izvjestaj_datetime";
            this.izvjestaj_datetime.Size = new System.Drawing.Size(144, 20);
            this.izvjestaj_datetime.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "ID uposlenika:";
            // 
            // id_uposlenik_masked_box
            // 
            this.id_uposlenik_masked_box.Location = new System.Drawing.Point(120, 19);
            this.id_uposlenik_masked_box.Mask = "00000";
            this.id_uposlenik_masked_box.Name = "id_uposlenik_masked_box";
            this.id_uposlenik_masked_box.Size = new System.Drawing.Size(144, 20);
            this.id_uposlenik_masked_box.TabIndex = 28;
            this.id_uposlenik_masked_box.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sadrzaj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum izvjestaja:";
            // 
            // izadjiButton
            // 
            this.izadjiButton.Location = new System.Drawing.Point(219, 210);
            this.izadjiButton.Name = "izadjiButton";
            this.izadjiButton.Size = new System.Drawing.Size(83, 23);
            this.izadjiButton.TabIndex = 37;
            this.izadjiButton.Text = "Izadji";
            this.izadjiButton.UseVisualStyleBackColor = true;
            this.izadjiButton.Click += new System.EventHandler(this.izadjiButton_Click);
            // 
            // unosButton
            // 
            this.unosButton.Location = new System.Drawing.Point(116, 210);
            this.unosButton.Name = "unosButton";
            this.unosButton.Size = new System.Drawing.Size(91, 23);
            this.unosButton.TabIndex = 36;
            this.unosButton.Text = "Unesi";
            this.unosButton.UseVisualStyleBackColor = true;
            this.unosButton.Click += new System.EventHandler(this.unosButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 242);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(314, 22);
            this.statusStrip1.TabIndex = 35;
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
            // DodavanjeIzvjestaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 264);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.izadjiButton);
            this.Controls.Add(this.unosButton);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "DodavanjeIzvjestaja";
            this.Text = "Dodavanje izvjestaja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox sadrzaj_rich_box;
        private System.Windows.Forms.DateTimePicker izvjestaj_datetime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox id_uposlenik_masked_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button izadjiButton;
        private System.Windows.Forms.Button unosButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}