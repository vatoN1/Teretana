namespace TeretanaBilderhana.Prehrambeni_programi
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
            this.pregledPProgramGrid = new System.Windows.Forms.DataGridView();
            this.idPrehrambeniProgramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrociDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipProgramaSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prehrambeniProgramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledPProgramGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prehrambeniProgramBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaTextBox,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(254, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pretragaTextBox
            // 
            this.pretragaTextBox.Name = "pretragaTextBox";
            this.pretragaTextBox.Size = new System.Drawing.Size(100, 25);
            this.pretragaTextBox.Text = "Unesi pretragu...";
            this.pretragaTextBox.TextChanged += new System.EventHandler(this.pretragaEvent);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // pregledPProgramGrid
            // 
            this.pregledPProgramGrid.AllowUserToAddRows = false;
            this.pregledPProgramGrid.AllowUserToDeleteRows = false;
            this.pregledPProgramGrid.AutoGenerateColumns = false;
            this.pregledPProgramGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.pregledPProgramGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledPProgramGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPrehrambeniProgramDataGridViewTextBoxColumn,
            this.obrociDataGridViewTextBoxColumn,
            this.tipProgramaSDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.pregledPProgramGrid.DataSource = this.prehrambeniProgramBindingSource;
            this.pregledPProgramGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pregledPProgramGrid.Location = new System.Drawing.Point(0, 25);
            this.pregledPProgramGrid.Name = "pregledPProgramGrid";
            this.pregledPProgramGrid.ReadOnly = true;
            this.pregledPProgramGrid.Size = new System.Drawing.Size(254, 261);
            this.pregledPProgramGrid.TabIndex = 1;
            // 
            // idPrehrambeniProgramDataGridViewTextBoxColumn
            // 
            this.idPrehrambeniProgramDataGridViewTextBoxColumn.DataPropertyName = "IdPrehrambeniProgram";
            this.idPrehrambeniProgramDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idPrehrambeniProgramDataGridViewTextBoxColumn.Name = "idPrehrambeniProgramDataGridViewTextBoxColumn";
            this.idPrehrambeniProgramDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPrehrambeniProgramDataGridViewTextBoxColumn.Width = 43;
            // 
            // obrociDataGridViewTextBoxColumn
            // 
            this.obrociDataGridViewTextBoxColumn.DataPropertyName = "Obroci";
            this.obrociDataGridViewTextBoxColumn.HeaderText = "Obroci";
            this.obrociDataGridViewTextBoxColumn.Name = "obrociDataGridViewTextBoxColumn";
            this.obrociDataGridViewTextBoxColumn.ReadOnly = true;
            this.obrociDataGridViewTextBoxColumn.Width = 63;
            // 
            // tipProgramaSDataGridViewTextBoxColumn
            // 
            this.tipProgramaSDataGridViewTextBoxColumn.DataPropertyName = "TipProgramaS";
            this.tipProgramaSDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipProgramaSDataGridViewTextBoxColumn.Name = "tipProgramaSDataGridViewTextBoxColumn";
            this.tipProgramaSDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipProgramaSDataGridViewTextBoxColumn.Width = 47;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            this.opisDataGridViewTextBoxColumn.Width = 53;
            // 
            // prehrambeniProgramBindingSource
            // 
            this.prehrambeniProgramBindingSource.DataSource = typeof(PrehrambeniProgram);
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 286);
            this.Controls.Add(this.pregledPProgramGrid);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pregled";
            this.Text = "Pregled";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledPProgramGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prehrambeniProgramBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox pretragaTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView pregledPProgramGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrehrambeniProgramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrociDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipProgramaSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prehrambeniProgramBindingSource;
    }
}