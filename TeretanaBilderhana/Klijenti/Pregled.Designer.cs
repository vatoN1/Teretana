namespace TeretanaBilderhana.Klijenti
{
    partial class Pregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pregled));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pretragaTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.klijentiPregledGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRodjenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDtreneraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDnutricionisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klijentiPregledGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaTextBox,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(552, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pretragaTextBox
            // 
            this.pretragaTextBox.Name = "pretragaTextBox";
            this.pretragaTextBox.Size = new System.Drawing.Size(100, 25);
            this.pretragaTextBox.Text = "Unesite pretragu...";
            this.pretragaTextBox.TextChanged += new System.EventHandler(this.pretragaEvent);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // klijentiPregledGrid
            // 
            this.klijentiPregledGrid.AllowUserToAddRows = false;
            this.klijentiPregledGrid.AllowUserToDeleteRows = false;
            this.klijentiPregledGrid.AutoGenerateColumns = false;
            this.klijentiPregledGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.klijentiPregledGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klijentiPregledGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.datumRodjenjaDataGridViewTextBoxColumn,
            this.kontaktDataGridViewTextBoxColumn,
            this.iDtreneraDataGridViewTextBoxColumn,
            this.iDnutricionisteDataGridViewTextBoxColumn});
            this.klijentiPregledGrid.DataSource = this.klijentBindingSource;
            this.klijentiPregledGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klijentiPregledGrid.Location = new System.Drawing.Point(0, 25);
            this.klijentiPregledGrid.Name = "klijentiPregledGrid";
            this.klijentiPregledGrid.ReadOnly = true;
            this.klijentiPregledGrid.Size = new System.Drawing.Size(552, 316);
            this.klijentiPregledGrid.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn.Width = 49;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prezimeDataGridViewTextBoxColumn.Width = 69;
            // 
            // datumRodjenjaDataGridViewTextBoxColumn
            // 
            this.datumRodjenjaDataGridViewTextBoxColumn.DataPropertyName = "DatumRodjenja";
            this.datumRodjenjaDataGridViewTextBoxColumn.HeaderText = "DatumRodjenja";
            this.datumRodjenjaDataGridViewTextBoxColumn.Name = "datumRodjenjaDataGridViewTextBoxColumn";
            this.datumRodjenjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumRodjenjaDataGridViewTextBoxColumn.Width = 105;
            // 
            // kontaktDataGridViewTextBoxColumn
            // 
            this.kontaktDataGridViewTextBoxColumn.DataPropertyName = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.Name = "kontaktDataGridViewTextBoxColumn";
            this.kontaktDataGridViewTextBoxColumn.ReadOnly = true;
            this.kontaktDataGridViewTextBoxColumn.Width = 69;
            // 
            // iDtreneraDataGridViewTextBoxColumn
            // 
            this.iDtreneraDataGridViewTextBoxColumn.DataPropertyName = "IDtrenera";
            this.iDtreneraDataGridViewTextBoxColumn.HeaderText = "IDtrenera";
            this.iDtreneraDataGridViewTextBoxColumn.Name = "iDtreneraDataGridViewTextBoxColumn";
            this.iDtreneraDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDtreneraDataGridViewTextBoxColumn.Width = 76;
            // 
            // iDnutricionisteDataGridViewTextBoxColumn
            // 
            this.iDnutricionisteDataGridViewTextBoxColumn.DataPropertyName = "IDnutricioniste";
            this.iDnutricionisteDataGridViewTextBoxColumn.HeaderText = "IDnutricioniste";
            this.iDnutricionisteDataGridViewTextBoxColumn.Name = "iDnutricionisteDataGridViewTextBoxColumn";
            this.iDnutricionisteDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDnutricionisteDataGridViewTextBoxColumn.Width = 99;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataSource = typeof(Klijent);
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 341);
            this.Controls.Add(this.klijentiPregledGrid);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pregled";
            this.Text = "Pregled";
            this.Load += new System.EventHandler(this.Pregled_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klijentiPregledGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox pretragaTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView klijentiPregledGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRodjenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDtreneraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnutricionisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource klijentBindingSource;
    }
}