namespace TeretanaBilderhana.WorkoutProgrami
{
    partial class EditovanjeWorkoutPrograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditovanjeWorkoutPrograma));
            this.izadjiButton = new System.Windows.Forms.Button();
            this.unosButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wprogramID_masked_box = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vjezbe_rich_box = new System.Windows.Forms.RichTextBox();
            this.opis_wprogram_rich_box = new System.Windows.Forms.RichTextBox();
            this.tip_wprogram_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // izadjiButton
            // 
            this.izadjiButton.Location = new System.Drawing.Point(239, 281);
            this.izadjiButton.Name = "izadjiButton";
            this.izadjiButton.Size = new System.Drawing.Size(83, 23);
            this.izadjiButton.TabIndex = 26;
            this.izadjiButton.Text = "Izadji";
            this.izadjiButton.UseVisualStyleBackColor = true;
            this.izadjiButton.Click += new System.EventHandler(this.izadjiButton_Click);
            // 
            // unosButton
            // 
            this.unosButton.Location = new System.Drawing.Point(136, 281);
            this.unosButton.Name = "unosButton";
            this.unosButton.Size = new System.Drawing.Size(91, 23);
            this.unosButton.TabIndex = 25;
            this.unosButton.Text = "Unesi";
            this.unosButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wprogramID_masked_box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.vjezbe_rich_box);
            this.groupBox1.Controls.Add(this.opis_wprogram_rich_box);
            this.groupBox1.Controls.Add(this.tip_wprogram_box);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 263);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editovanje workout programa:";
            // 
            // wprogramID_masked_box
            // 
            this.wprogramID_masked_box.Location = new System.Drawing.Point(139, 23);
            this.wprogramID_masked_box.Mask = "00000";
            this.wprogramID_masked_box.Name = "wprogramID_masked_box";
            this.wprogramID_masked_box.Size = new System.Drawing.Size(144, 20);
            this.wprogramID_masked_box.TabIndex = 23;
            this.wprogramID_masked_box.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Unesite ID:";
            // 
            // vjezbe_rich_box
            // 
            this.vjezbe_rich_box.Location = new System.Drawing.Point(139, 176);
            this.vjezbe_rich_box.Name = "vjezbe_rich_box";
            this.vjezbe_rich_box.Size = new System.Drawing.Size(144, 80);
            this.vjezbe_rich_box.TabIndex = 17;
            this.vjezbe_rich_box.Text = "";
            // 
            // opis_wprogram_rich_box
            // 
            this.opis_wprogram_rich_box.Location = new System.Drawing.Point(139, 82);
            this.opis_wprogram_rich_box.Name = "opis_wprogram_rich_box";
            this.opis_wprogram_rich_box.Size = new System.Drawing.Size(144, 88);
            this.opis_wprogram_rich_box.TabIndex = 16;
            this.opis_wprogram_rich_box.Text = "";
            // 
            // tip_wprogram_box
            // 
            this.tip_wprogram_box.Location = new System.Drawing.Point(139, 54);
            this.tip_wprogram_box.Name = "tip_wprogram_box";
            this.tip_wprogram_box.Size = new System.Drawing.Size(144, 20);
            this.tip_wprogram_box.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip workout programa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vjezbe:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 307);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(334, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // EditovanjeWorkoutPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 329);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.izadjiButton);
            this.Controls.Add(this.unosButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "EditovanjeWorkoutPrograma";
            this.Text = "EditovanjeWorkoutPrograma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button izadjiButton;
        private System.Windows.Forms.Button unosButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox vjezbe_rich_box;
        private System.Windows.Forms.RichTextBox opis_wprogram_rich_box;
        private System.Windows.Forms.TextBox tip_wprogram_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox wprogramID_masked_box;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}