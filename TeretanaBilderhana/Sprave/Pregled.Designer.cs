namespace TeretanaBilderhana.Sprave
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
            this.pregledSpraveGrid = new System.Windows.Forms.DataGridView();
            this.pretragaTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.spravaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipSpraveSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledSpraveGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaTextBox,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(273, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pregledSpraveGrid
            // 
            this.pregledSpraveGrid.AllowUserToAddRows = false;
            this.pregledSpraveGrid.AllowUserToDeleteRows = false;
            this.pregledSpraveGrid.AutoGenerateColumns = false;
            this.pregledSpraveGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.pregledSpraveGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledSpraveGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tipSpraveSDataGridViewTextBoxColumn,
            this.starostDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.pregledSpraveGrid.DataSource = this.spravaBindingSource;
            this.pregledSpraveGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pregledSpraveGrid.Location = new System.Drawing.Point(0, 25);
            this.pregledSpraveGrid.Name = "pregledSpraveGrid";
            this.pregledSpraveGrid.ReadOnly = true;
            this.pregledSpraveGrid.Size = new System.Drawing.Size(273, 319);
            this.pregledSpraveGrid.TabIndex = 1;
            // 
            // pretragaTextBox
            // 
            this.pretragaTextBox.Name = "pretragaTextBox";
            this.pretragaTextBox.Size = new System.Drawing.Size(100, 25);
            this.pretragaTextBox.TextChanged += new System.EventHandler(this.pretragaEvent);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // spravaBindingSource
            // 
            this.spravaBindingSource.DataSource = typeof(Sprava);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 43;
            // 
            // tipSpraveSDataGridViewTextBoxColumn
            // 
            this.tipSpraveSDataGridViewTextBoxColumn.DataPropertyName = "TipSpraveS";
            this.tipSpraveSDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipSpraveSDataGridViewTextBoxColumn.Name = "tipSpraveSDataGridViewTextBoxColumn";
            this.tipSpraveSDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipSpraveSDataGridViewTextBoxColumn.Width = 47;
            // 
            // starostDataGridViewTextBoxColumn
            // 
            this.starostDataGridViewTextBoxColumn.DataPropertyName = "Starost";
            this.starostDataGridViewTextBoxColumn.HeaderText = "Starost";
            this.starostDataGridViewTextBoxColumn.Name = "starostDataGridViewTextBoxColumn";
            this.starostDataGridViewTextBoxColumn.ReadOnly = true;
            this.starostDataGridViewTextBoxColumn.Width = 65;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.Width = 69;
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 344);
            this.Controls.Add(this.pregledSpraveGrid);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Pregled";
            this.Text = "Pregled";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledSpraveGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView pregledSpraveGrid;
        private System.Windows.Forms.ToolStripTextBox pretragaTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipSpraveSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spravaBindingSource;
    }
}