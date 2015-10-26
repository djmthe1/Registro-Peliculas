namespace MoviesOrganizer.Registros
{
    partial class BuscarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarForm));
            this.BuscarLabel = new System.Windows.Forms.Label();
            this.BuscarComboBox = new System.Windows.Forms.ComboBox();
            this.BuscarTextBox = new System.Windows.Forms.TextBox();
            this.BuscarDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarLabel
            // 
            this.BuscarLabel.AutoSize = true;
            this.BuscarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarLabel.Location = new System.Drawing.Point(12, 9);
            this.BuscarLabel.Name = "BuscarLabel";
            this.BuscarLabel.Size = new System.Drawing.Size(219, 15);
            this.BuscarLabel.TabIndex = 2;
            this.BuscarLabel.Text = "Seleccione el Indice Para Buscar";
            // 
            // BuscarComboBox
            // 
            this.BuscarComboBox.FormattingEnabled = true;
            this.BuscarComboBox.Items.AddRange(new object[] {
            "Genero",
            "Actor",
            "Estudio",
            "Categoría",
            "Pelicula"});
            this.BuscarComboBox.Location = new System.Drawing.Point(15, 27);
            this.BuscarComboBox.Name = "BuscarComboBox";
            this.BuscarComboBox.Size = new System.Drawing.Size(121, 21);
            this.BuscarComboBox.TabIndex = 3;
            // 
            // BuscarTextBox
            // 
            this.BuscarTextBox.Location = new System.Drawing.Point(156, 27);
            this.BuscarTextBox.Name = "BuscarTextBox";
            this.BuscarTextBox.Size = new System.Drawing.Size(150, 20);
            this.BuscarTextBox.TabIndex = 4;
            // 
            // BuscarDataGridView
            // 
            this.BuscarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuscarDataGridView.Location = new System.Drawing.Point(12, 95);
            this.BuscarDataGridView.Name = "BuscarDataGridView";
            this.BuscarDataGridView.Size = new System.Drawing.Size(294, 173);
            this.BuscarDataGridView.TabIndex = 5;
            // 
            // BuscarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 280);
            this.Controls.Add(this.BuscarDataGridView);
            this.Controls.Add(this.BuscarTextBox);
            this.Controls.Add(this.BuscarComboBox);
            this.Controls.Add(this.BuscarLabel);
            this.DoubleBuffered = true;
            this.Name = "BuscarForm";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.BuscarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BuscarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BuscarLabel;
        private System.Windows.Forms.ComboBox BuscarComboBox;
        private System.Windows.Forms.TextBox BuscarTextBox;
        private System.Windows.Forms.DataGridView BuscarDataGridView;
    }
}