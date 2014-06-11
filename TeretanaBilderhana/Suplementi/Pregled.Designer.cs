namespace TeretanaBilderhana.Suplementi
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
            this.pregledSuplementiGrid = new System.Windows.Forms.DataGridView();
            this.tipSuplementaSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledSuplementiGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaTextBox,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(265, 25);
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
            // pregledSuplementiGrid
            // 
            this.pregledSuplementiGrid.AllowUserToAddRows = false;
            this.pregledSuplementiGrid.AllowUserToDeleteRows = false;
            this.pregledSuplementiGrid.AutoGenerateColumns = false;
            this.pregledSuplementiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.pregledSuplementiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledSuplementiGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipSuplementaSDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.pregledSuplementiGrid.DataSource = this.suplementBindingSource;
            this.pregledSuplementiGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pregledSuplementiGrid.Location = new System.Drawing.Point(0, 25);
            this.pregledSuplementiGrid.Name = "pregledSuplementiGrid";
            this.pregledSuplementiGrid.ReadOnly = true;
            this.pregledSuplementiGrid.Size = new System.Drawing.Size(265, 238);
            this.pregledSuplementiGrid.TabIndex = 1;
            // 
            // tipSuplementaSDataGridViewTextBoxColumn
            // 
            this.tipSuplementaSDataGridViewTextBoxColumn.DataPropertyName = "TipSuplementaS";
            this.tipSuplementaSDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipSuplementaSDataGridViewTextBoxColumn.Name = "tipSuplementaSDataGridViewTextBoxColumn";
            this.tipSuplementaSDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipSuplementaSDataGridViewTextBoxColumn.Width = 47;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijenaDataGridViewTextBoxColumn.Width = 61;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.Width = 69;
            // 
            // suplementBindingSource
            // 
            this.suplementBindingSource.DataSource = typeof(Suplement);
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 263);
            this.Controls.Add(this.pregledSuplementiGrid);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pregled";
            this.Text = "Pregled";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledSuplementiGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView pregledSuplementiGrid;
        private System.Windows.Forms.ToolStripTextBox pretragaTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSuplementaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipSuplementaSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource suplementBindingSource;
    }
}