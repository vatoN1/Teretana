namespace TeretanaBilderhana.WorkoutProgrami
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
            this.pregledTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pregledWProgramGrid = new System.Windows.Forms.DataGridView();
            this.idWorkoutProgramaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vjezbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipProgramaSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workoutProgramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledWProgramGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutProgramBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledTextBox,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(256, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pregledTextBox
            // 
            this.pregledTextBox.Name = "pregledTextBox";
            this.pregledTextBox.Size = new System.Drawing.Size(100, 25);
            this.pregledTextBox.Text = "Unesite pretragu...";
            this.pregledTextBox.TextChanged += new System.EventHandler(this.pretragaEvent);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // pregledWProgramGrid
            // 
            this.pregledWProgramGrid.AllowUserToAddRows = false;
            this.pregledWProgramGrid.AllowUserToDeleteRows = false;
            this.pregledWProgramGrid.AutoGenerateColumns = false;
            this.pregledWProgramGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.pregledWProgramGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledWProgramGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idWorkoutProgramaDataGridViewTextBoxColumn,
            this.vjezbeDataGridViewTextBoxColumn,
            this.tipProgramaSDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.pregledWProgramGrid.DataSource = this.workoutProgramBindingSource;
            this.pregledWProgramGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pregledWProgramGrid.Location = new System.Drawing.Point(0, 25);
            this.pregledWProgramGrid.Name = "pregledWProgramGrid";
            this.pregledWProgramGrid.ReadOnly = true;
            this.pregledWProgramGrid.Size = new System.Drawing.Size(256, 317);
            this.pregledWProgramGrid.TabIndex = 1;
            // 
            // idWorkoutProgramaDataGridViewTextBoxColumn
            // 
            this.idWorkoutProgramaDataGridViewTextBoxColumn.DataPropertyName = "IdWorkoutPrograma";
            this.idWorkoutProgramaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idWorkoutProgramaDataGridViewTextBoxColumn.Name = "idWorkoutProgramaDataGridViewTextBoxColumn";
            this.idWorkoutProgramaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idWorkoutProgramaDataGridViewTextBoxColumn.Width = 43;
            // 
            // vjezbeDataGridViewTextBoxColumn
            // 
            this.vjezbeDataGridViewTextBoxColumn.DataPropertyName = "Vjezbe";
            this.vjezbeDataGridViewTextBoxColumn.HeaderText = "Vjezbe";
            this.vjezbeDataGridViewTextBoxColumn.Name = "vjezbeDataGridViewTextBoxColumn";
            this.vjezbeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vjezbeDataGridViewTextBoxColumn.Width = 64;
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
            // workoutProgramBindingSource
            // 
            this.workoutProgramBindingSource.DataSource = typeof(WorkoutProgram);
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 342);
            this.Controls.Add(this.pregledWProgramGrid);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pregled";
            this.Text = "Pregled";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledWProgramGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutProgramBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox pregledTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView pregledWProgramGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkoutProgramaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vjezbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipProgramaSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource workoutProgramBindingSource;
    }
}