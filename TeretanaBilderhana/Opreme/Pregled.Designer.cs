namespace TeretanaBilderhana.Opreme
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
            this.opremaPregledGrid = new System.Windows.Forms.DataGridView();
            this.idOpremeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipOpremeSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaNajamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opremaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opremaPregledGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opremaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaTextBox,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(268, 25);
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
            // opremaPregledGrid
            // 
            this.opremaPregledGrid.AllowUserToAddRows = false;
            this.opremaPregledGrid.AllowUserToDeleteRows = false;
            this.opremaPregledGrid.AutoGenerateColumns = false;
            this.opremaPregledGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.opremaPregledGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.opremaPregledGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOpremeDataGridViewTextBoxColumn,
            this.tipOpremeSDataGridViewTextBoxColumn,
            this.cijenaNajamaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.opremaPregledGrid.DataSource = this.opremaBindingSource;
            this.opremaPregledGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opremaPregledGrid.Location = new System.Drawing.Point(0, 25);
            this.opremaPregledGrid.Name = "opremaPregledGrid";
            this.opremaPregledGrid.ReadOnly = true;
            this.opremaPregledGrid.Size = new System.Drawing.Size(268, 283);
            this.opremaPregledGrid.TabIndex = 1;
            // 
            // idOpremeDataGridViewTextBoxColumn
            // 
            this.idOpremeDataGridViewTextBoxColumn.DataPropertyName = "IdOpreme";
            this.idOpremeDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idOpremeDataGridViewTextBoxColumn.Name = "idOpremeDataGridViewTextBoxColumn";
            this.idOpremeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOpremeDataGridViewTextBoxColumn.Width = 43;
            // 
            // tipOpremeSDataGridViewTextBoxColumn
            // 
            this.tipOpremeSDataGridViewTextBoxColumn.DataPropertyName = "TipOpremeS";
            this.tipOpremeSDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipOpremeSDataGridViewTextBoxColumn.Name = "tipOpremeSDataGridViewTextBoxColumn";
            this.tipOpremeSDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipOpremeSDataGridViewTextBoxColumn.Width = 47;
            // 
            // cijenaNajamaDataGridViewTextBoxColumn
            // 
            this.cijenaNajamaDataGridViewTextBoxColumn.DataPropertyName = "CijenaNajama";
            this.cijenaNajamaDataGridViewTextBoxColumn.HeaderText = "Cijenaž";
            this.cijenaNajamaDataGridViewTextBoxColumn.Name = "cijenaNajamaDataGridViewTextBoxColumn";
            this.cijenaNajamaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijenaNajamaDataGridViewTextBoxColumn.Width = 66;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.Width = 69;
            // 
            // opremaBindingSource
            // 
            this.opremaBindingSource.DataSource = typeof(Oprema);
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 308);
            this.Controls.Add(this.opremaPregledGrid);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pregled";
            this.Text = "Pregled";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opremaPregledGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opremaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox pretragaTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView opremaPregledGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOpremeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipOpremeSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaNajamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource opremaBindingSource;
    }
}