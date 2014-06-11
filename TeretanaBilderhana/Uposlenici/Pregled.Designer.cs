namespace TeretanaBilderhana.Uposlenici
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
            this.uposleniciPregledGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRodjenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumZaposlenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenjeSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uposleniciPregledGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaTextBox,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(611, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pretragaTextBox
            // 
            this.pretragaTextBox.Name = "pretragaTextBox";
            this.pretragaTextBox.Size = new System.Drawing.Size(100, 25);
            this.pretragaTextBox.Text = "Unesi pretragu...";
            this.pretragaTextBox.TextChanged += new System.EventHandler(this.pretragaTextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // uposleniciPregledGrid
            // 
            this.uposleniciPregledGrid.AllowUserToAddRows = false;
            this.uposleniciPregledGrid.AllowUserToDeleteRows = false;
            this.uposleniciPregledGrid.AutoGenerateColumns = false;
            this.uposleniciPregledGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uposleniciPregledGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uposleniciPregledGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.plataDataGridViewTextBoxColumn,
            this.datumRodjenjaDataGridViewTextBoxColumn,
            this.datumZaposlenjaDataGridViewTextBoxColumn,
            this.zaposlenjeSDataGridViewTextBoxColumn,
            this.kontaktDataGridViewTextBoxColumn});
            this.uposleniciPregledGrid.DataSource = this.uposlenikBindingSource;
            this.uposleniciPregledGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uposleniciPregledGrid.Location = new System.Drawing.Point(0, 25);
            this.uposleniciPregledGrid.Name = "uposleniciPregledGrid";
            this.uposleniciPregledGrid.ReadOnly = true;
            this.uposleniciPregledGrid.RowHeadersWidth = 20;
            this.uposleniciPregledGrid.Size = new System.Drawing.Size(611, 279);
            this.uposleniciPregledGrid.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prezimeDataGridViewTextBoxColumn.Width = 69;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn.Width = 49;
            // 
            // plataDataGridViewTextBoxColumn
            // 
            this.plataDataGridViewTextBoxColumn.DataPropertyName = "Plata";
            this.plataDataGridViewTextBoxColumn.HeaderText = "Plata";
            this.plataDataGridViewTextBoxColumn.Name = "plataDataGridViewTextBoxColumn";
            this.plataDataGridViewTextBoxColumn.ReadOnly = true;
            this.plataDataGridViewTextBoxColumn.Width = 56;
            // 
            // datumRodjenjaDataGridViewTextBoxColumn
            // 
            this.datumRodjenjaDataGridViewTextBoxColumn.DataPropertyName = "DatumRodjenja";
            this.datumRodjenjaDataGridViewTextBoxColumn.HeaderText = "DatumRodjenja";
            this.datumRodjenjaDataGridViewTextBoxColumn.Name = "datumRodjenjaDataGridViewTextBoxColumn";
            this.datumRodjenjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumRodjenjaDataGridViewTextBoxColumn.Width = 105;
            // 
            // datumZaposlenjaDataGridViewTextBoxColumn
            // 
            this.datumZaposlenjaDataGridViewTextBoxColumn.DataPropertyName = "DatumZaposlenja";
            this.datumZaposlenjaDataGridViewTextBoxColumn.HeaderText = "DatumZaposlenja";
            this.datumZaposlenjaDataGridViewTextBoxColumn.Name = "datumZaposlenjaDataGridViewTextBoxColumn";
            this.datumZaposlenjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumZaposlenjaDataGridViewTextBoxColumn.Width = 115;
            // 
            // zaposlenjeSDataGridViewTextBoxColumn
            // 
            this.zaposlenjeSDataGridViewTextBoxColumn.DataPropertyName = "ZaposlenjeS";
            this.zaposlenjeSDataGridViewTextBoxColumn.HeaderText = "ZaposlenjeS";
            this.zaposlenjeSDataGridViewTextBoxColumn.Name = "zaposlenjeSDataGridViewTextBoxColumn";
            this.zaposlenjeSDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaposlenjeSDataGridViewTextBoxColumn.Width = 91;
            // 
            // kontaktDataGridViewTextBoxColumn
            // 
            this.kontaktDataGridViewTextBoxColumn.DataPropertyName = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.Name = "kontaktDataGridViewTextBoxColumn";
            this.kontaktDataGridViewTextBoxColumn.ReadOnly = true;
            this.kontaktDataGridViewTextBoxColumn.Width = 69;
            // 
            // uposlenikBindingSource
            // 
            this.uposlenikBindingSource.DataSource = typeof(Uposlenik);
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 304);
            this.Controls.Add(this.uposleniciPregledGrid);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pregled";
            this.Text = "Pregled";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uposleniciPregledGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox pretragaTextBox;
        private System.Windows.Forms.DataGridView uposleniciPregledGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRodjenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumZaposlenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenjeSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uposlenikBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}