namespace TeretanaBilderhana.Izvjestaji
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
            this.pregledIzvjestajGrid = new System.Windows.Forms.DataGridView();
            this.idIzvjestajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumIzvjestajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDuposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izvjestajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledIzvjestajGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvjestajBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaTextBox,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(343, 25);
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
            // pregledIzvjestajGrid
            // 
            this.pregledIzvjestajGrid.AllowUserToAddRows = false;
            this.pregledIzvjestajGrid.AllowUserToDeleteRows = false;
            this.pregledIzvjestajGrid.AutoGenerateColumns = false;
            this.pregledIzvjestajGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledIzvjestajGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIzvjestajaDataGridViewTextBoxColumn,
            this.datumIzvjestajaDataGridViewTextBoxColumn,
            this.iDuposlenikDataGridViewTextBoxColumn});
            this.pregledIzvjestajGrid.DataSource = this.izvjestajBindingSource;
            this.pregledIzvjestajGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pregledIzvjestajGrid.Location = new System.Drawing.Point(0, 25);
            this.pregledIzvjestajGrid.Name = "pregledIzvjestajGrid";
            this.pregledIzvjestajGrid.ReadOnly = true;
            this.pregledIzvjestajGrid.Size = new System.Drawing.Size(343, 288);
            this.pregledIzvjestajGrid.TabIndex = 1;
            // 
            // idIzvjestajaDataGridViewTextBoxColumn
            // 
            this.idIzvjestajaDataGridViewTextBoxColumn.DataPropertyName = "IdIzvjestaja";
            this.idIzvjestajaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idIzvjestajaDataGridViewTextBoxColumn.Name = "idIzvjestajaDataGridViewTextBoxColumn";
            this.idIzvjestajaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumIzvjestajaDataGridViewTextBoxColumn
            // 
            this.datumIzvjestajaDataGridViewTextBoxColumn.DataPropertyName = "DatumIzvjestaja";
            this.datumIzvjestajaDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumIzvjestajaDataGridViewTextBoxColumn.Name = "datumIzvjestajaDataGridViewTextBoxColumn";
            this.datumIzvjestajaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDuposlenikDataGridViewTextBoxColumn
            // 
            this.iDuposlenikDataGridViewTextBoxColumn.DataPropertyName = "IDuposlenik";
            this.iDuposlenikDataGridViewTextBoxColumn.HeaderText = "ID uposlenika";
            this.iDuposlenikDataGridViewTextBoxColumn.Name = "iDuposlenikDataGridViewTextBoxColumn";
            this.iDuposlenikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // izvjestajBindingSource
            // 
            this.izvjestajBindingSource.DataSource = typeof(Izvjestaj);
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 313);
            this.Controls.Add(this.pregledIzvjestajGrid);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pregled";
            this.Text = "Pregled";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledIzvjestajGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvjestajBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox pretragaTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView pregledIzvjestajGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIzvjestajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumIzvjestajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDuposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource izvjestajBindingSource;
    }
}