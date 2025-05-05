namespace prySalvarezza_20250505
{
    partial class frmSuperheroes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuperheroes));
            this.cmbSuperheroes = new System.Windows.Forms.ComboBox();
            this.imgSuperheroes = new System.Windows.Forms.PictureBox();
            this.lblSuperheroes = new System.Windows.Forms.Label();
            this.mrcCrear = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.numDestreza = new System.Windows.Forms.NumericUpDown();
            this.numFuerza = new System.Windows.Forms.NumericUpDown();
            this.lblDestreza = new System.Windows.Forms.Label();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgSuperheroes)).BeginInit();
            this.mrcCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDestreza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuerza)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSuperheroes
            // 
            this.cmbSuperheroes.FormattingEnabled = true;
            this.cmbSuperheroes.Location = new System.Drawing.Point(12, 23);
            this.cmbSuperheroes.Name = "cmbSuperheroes";
            this.cmbSuperheroes.Size = new System.Drawing.Size(284, 21);
            this.cmbSuperheroes.TabIndex = 0;
            this.cmbSuperheroes.SelectedIndexChanged += new System.EventHandler(this.cmbSuperheroes_SelectedIndexChanged);
            // 
            // imgSuperheroes
            // 
            this.imgSuperheroes.Location = new System.Drawing.Point(12, 50);
            this.imgSuperheroes.Name = "imgSuperheroes";
            this.imgSuperheroes.Size = new System.Drawing.Size(284, 194);
            this.imgSuperheroes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSuperheroes.TabIndex = 1;
            this.imgSuperheroes.TabStop = false;
            // 
            // lblSuperheroes
            // 
            this.lblSuperheroes.AutoSize = true;
            this.lblSuperheroes.Location = new System.Drawing.Point(12, 7);
            this.lblSuperheroes.Name = "lblSuperheroes";
            this.lblSuperheroes.Size = new System.Drawing.Size(70, 13);
            this.lblSuperheroes.TabIndex = 2;
            this.lblSuperheroes.Text = "Superheroes:";
            // 
            // mrcCrear
            // 
            this.mrcCrear.Controls.Add(this.txtNombre);
            this.mrcCrear.Controls.Add(this.lblNombre);
            this.mrcCrear.Controls.Add(this.numDestreza);
            this.mrcCrear.Controls.Add(this.numFuerza);
            this.mrcCrear.Controls.Add(this.lblDestreza);
            this.mrcCrear.Controls.Add(this.lblFuerza);
            this.mrcCrear.Location = new System.Drawing.Point(318, 23);
            this.mrcCrear.Name = "mrcCrear";
            this.mrcCrear.Size = new System.Drawing.Size(161, 127);
            this.mrcCrear.TabIndex = 3;
            this.mrcCrear.TabStop = false;
            this.mrcCrear.Text = "Crear Personaje";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(69, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(80, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // numDestreza
            // 
            this.numDestreza.Location = new System.Drawing.Point(69, 65);
            this.numDestreza.Name = "numDestreza";
            this.numDestreza.Size = new System.Drawing.Size(80, 20);
            this.numDestreza.TabIndex = 3;
            // 
            // numFuerza
            // 
            this.numFuerza.Location = new System.Drawing.Point(69, 27);
            this.numFuerza.Name = "numFuerza";
            this.numFuerza.Size = new System.Drawing.Size(80, 20);
            this.numFuerza.TabIndex = 2;
            // 
            // lblDestreza
            // 
            this.lblDestreza.AutoSize = true;
            this.lblDestreza.Location = new System.Drawing.Point(6, 65);
            this.lblDestreza.Name = "lblDestreza";
            this.lblDestreza.Size = new System.Drawing.Size(52, 13);
            this.lblDestreza.TabIndex = 1;
            this.lblDestreza.Text = "Destreza:";
            // 
            // lblFuerza
            // 
            this.lblFuerza.AutoSize = true;
            this.lblFuerza.Location = new System.Drawing.Point(7, 27);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(42, 13);
            this.lblFuerza.TabIndex = 0;
            this.lblFuerza.Text = "Fuerza:";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(318, 173);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(161, 23);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // frmSuperheroes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 270);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.mrcCrear);
            this.Controls.Add(this.lblSuperheroes);
            this.Controls.Add(this.imgSuperheroes);
            this.Controls.Add(this.cmbSuperheroes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSuperheroes";
            this.Text = "Superheroes";
            this.Load += new System.EventHandler(this.frmSuperheroes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgSuperheroes)).EndInit();
            this.mrcCrear.ResumeLayout(false);
            this.mrcCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDestreza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuerza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSuperheroes;
        private System.Windows.Forms.PictureBox imgSuperheroes;
        private System.Windows.Forms.Label lblSuperheroes;
        private System.Windows.Forms.GroupBox mrcCrear;
        private System.Windows.Forms.NumericUpDown numDestreza;
        private System.Windows.Forms.NumericUpDown numFuerza;
        private System.Windows.Forms.Label lblDestreza;
        private System.Windows.Forms.Label lblFuerza;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCrear;
    }
}

