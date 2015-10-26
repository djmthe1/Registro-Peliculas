namespace MoviesOrganizer
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.Titulolabel = new System.Windows.Forms.Label();
            this.ListarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonBuscar
            // 
            this.botonBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonBuscar.BackgroundImage")));
            this.botonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonBuscar.Location = new System.Drawing.Point(9, 12);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(81, 56);
            this.botonBuscar.TabIndex = 1;
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonSalir.BackgroundImage")));
            this.botonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonSalir.Location = new System.Drawing.Point(377, 251);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(78, 56);
            this.botonSalir.TabIndex = 3;
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonAgregar
            // 
            this.botonAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAgregar.BackgroundImage")));
            this.botonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAgregar.Location = new System.Drawing.Point(12, 251);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(78, 56);
            this.botonAgregar.TabIndex = 0;
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // Titulolabel
            // 
            this.Titulolabel.AutoSize = true;
            this.Titulolabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolabel.Location = new System.Drawing.Point(96, 9);
            this.Titulolabel.Name = "Titulolabel";
            this.Titulolabel.Size = new System.Drawing.Size(150, 28);
            this.Titulolabel.TabIndex = 4;
            this.Titulolabel.Text = "Movies Organizer";
            // 
            // ListarButton
            // 
            this.ListarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ListarButton.BackgroundImage")));
            this.ListarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ListarButton.Location = new System.Drawing.Point(377, 12);
            this.ListarButton.Name = "ListarButton";
            this.ListarButton.Size = new System.Drawing.Size(78, 56);
            this.ListarButton.TabIndex = 5;
            this.ListarButton.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(468, 332);
            this.Controls.Add(this.ListarButton);
            this.Controls.Add(this.Titulolabel);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonAgregar);
            this.Name = "Principal";
            this.Text = "Movies Organizer";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Label Titulolabel;
        private System.Windows.Forms.Button ListarButton;
    }
}

