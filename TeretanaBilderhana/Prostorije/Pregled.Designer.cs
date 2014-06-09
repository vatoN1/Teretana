namespace TeretanaBilderhana.Prostorije
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pregledProstorijeGrid = new System.Windows.Forms.DataGridView();
            this.pretragaTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.prostorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostupnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipProstorijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledProstorijeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prostorijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaTextBox,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(283, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pregledProstorijeGrid
            // 
            this.pregledProstorijeGrid.AllowUserToAddRows = false;
            this.pregledProstorijeGrid.AllowUserToDeleteRows = false;
            this.pregledProstorijeGrid.AutoGenerateColumns = false;
            this.pregledProstorijeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.pregledProstorijeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledProstorijeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dostupnostDataGridViewTextBoxColumn,
            this.tipProstorijeDataGridViewTextBoxColumn});
            this.pregledProstorijeGrid.DataSource = this.prostorijaBindingSource;
            this.pregledProstorijeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pregledProstorijeGrid.Location = new System.Drawing.Point(0, 25);
            this.pregledProstorijeGrid.Name = "pregledProstorijeGrid";
            this.pregledProstorijeGrid.ReadOnly = true;
            this.pregledProstorijeGrid.Size = new System.Drawing.Size(283, 208);
            this.pregledProstorijeGrid.TabIndex = 1;
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
            // prostorijaBindingSource
            // 
            this.prostorijaBindingSource.DataSource = typeof(Prostorija);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 43;
            // 
            // dostupnostDataGridViewTextBoxColumn
            // 
            this.dostupnostDataGridViewTextBoxColumn.DataPropertyName = "Dostupnost";
            this.dostupnostDataGridViewTextBoxColumn.HeaderText = "Dostupnost";
            this.dostupnostDataGridViewTextBoxColumn.Name = "dostupnostDataGridViewTextBoxColumn";
            this.dostupnostDataGridViewTextBoxColumn.ReadOnly = true;
            this.dostupnostDataGridViewTextBoxColumn.Width = 86;
            // 
            // tipProstorijeDataGridViewTextBoxColumn
            // 
            this.tipProstorijeDataGridViewTextBoxColumn.DataPropertyName = "TipProstorije";
            this.tipProstorijeDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipProstorijeDataGridViewTextBoxColumn.Name = "tipProstorijeDataGridViewTextBoxColumn";
            this.tipProstorijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipProstorijeDataGridViewTextBoxColumn.Width = 47;
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 233);
            this.Controls.Add(this.pregledProstorijeGrid);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Pregled";
            this.Text = "Pregled";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledProstorijeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prostorijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox pretragaTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView pregledProstorijeGrid;
        private System.Windows.Forms.BindingSource prostorijaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostupnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipProstorijeDataGridViewTextBoxColumn;
    }
}