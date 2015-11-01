namespace MoviesOrganizer.Registros
{
    partial class InsertarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarForm));
            this.SeleccionarComboBox = new System.Windows.Forms.ComboBox();
            this.SeleccionarLabel = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeleccionarComboBox
            // 
            this.SeleccionarComboBox.FormattingEnabled = true;
            this.SeleccionarComboBox.Items.AddRange(new object[] {
            "Genero",
            "Actor",
            "Estudio",
            "Categoría",
            "Pelicula"});
            this.SeleccionarComboBox.Location = new System.Drawing.Point(16, 27);
            this.SeleccionarComboBox.Name = "SeleccionarComboBox";
            this.SeleccionarComboBox.Size = new System.Drawing.Size(121, 21);
            this.SeleccionarComboBox.TabIndex = 0;
            this.SeleccionarComboBox.SelectedIndexChanged += new System.EventHandler(this.SeleccionarComboBox_SelectedIndexChanged);
            // 
            // SeleccionarLabel
            // 
            this.SeleccionarLabel.AutoSize = true;
            this.SeleccionarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionarLabel.Location = new System.Drawing.Point(13, 9);
            this.SeleccionarLabel.Name = "SeleccionarLabel";
            this.SeleccionarLabel.Size = new System.Drawing.Size(226, 15);
            this.SeleccionarLabel.TabIndex = 1;
            this.SeleccionarLabel.Text = "Seleccione lo Que Desea Insertar ";
            // 
            // botonVolver
            // 
            this.botonVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonVolver.BackgroundImage")));
            this.botonVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonVolver.Location = new System.Drawing.Point(326, 208);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(78, 56);
            this.botonVolver.TabIndex = 4;
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // InsertarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 276);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.SeleccionarLabel);
            this.Controls.Add(this.SeleccionarComboBox);
            this.DoubleBuffered = true;
            this.Name = "InsertarForm";
            this.Text = "Insertar";
            this.Load += new System.EventHandler(this.InsertarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SeleccionarComboBox;
        private System.Windows.Forms.Label SeleccionarLabel;
        private System.Windows.Forms.Button botonVolver;
    }
}