namespace MoviesOrganizer.Registros
{
    partial class ListarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarForm));
            this.ListarLabel = new System.Windows.Forms.Label();
            this.ListarComboBox = new System.Windows.Forms.ComboBox();
            this.ListarDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListarLabel
            // 
            this.ListarLabel.AutoSize = true;
            this.ListarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarLabel.Location = new System.Drawing.Point(12, 9);
            this.ListarLabel.Name = "ListarLabel";
            this.ListarLabel.Size = new System.Drawing.Size(211, 15);
            this.ListarLabel.TabIndex = 3;
            this.ListarLabel.Text = "Seleccione el Indice Para Listar";
            // 
            // ListarComboBox
            // 
            this.ListarComboBox.FormattingEnabled = true;
            this.ListarComboBox.Items.AddRange(new object[] {
            "Genero",
            "Actor",
            "Estudio",
            "Categoría",
            "Pelicula"});
            this.ListarComboBox.Location = new System.Drawing.Point(15, 27);
            this.ListarComboBox.Name = "ListarComboBox";
            this.ListarComboBox.Size = new System.Drawing.Size(121, 21);
            this.ListarComboBox.TabIndex = 4;
            // 
            // ListarDataGridView
            // 
            this.ListarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListarDataGridView.Location = new System.Drawing.Point(139, 92);
            this.ListarDataGridView.Name = "ListarDataGridView";
            this.ListarDataGridView.Size = new System.Drawing.Size(294, 173);
            this.ListarDataGridView.TabIndex = 6;
            // 
            // ListarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 277);
            this.Controls.Add(this.ListarDataGridView);
            this.Controls.Add(this.ListarComboBox);
            this.Controls.Add(this.ListarLabel);
            this.DoubleBuffered = true;
            this.Name = "ListarForm";
            this.Text = "ListarForm";
            ((System.ComponentModel.ISupportInitialize)(this.ListarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListarLabel;
        private System.Windows.Forms.ComboBox ListarComboBox;
        private System.Windows.Forms.DataGridView ListarDataGridView;
    }
}