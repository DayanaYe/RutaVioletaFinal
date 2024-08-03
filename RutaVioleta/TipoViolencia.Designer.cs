namespace RutaVioleta
{
    partial class TipoViolencia
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
            this.lblTipoViolenciaSexual = new System.Windows.Forms.Label();
            this.clbTipoViolenciaSexual = new System.Windows.Forms.CheckedListBox();
            this.lblTipoViolenciaFisica = new System.Windows.Forms.Label();
            this.clbTipoViolenciaFisica = new System.Windows.Forms.CheckedListBox();
            this.lblViolenciaEconomica = new System.Windows.Forms.Label();
            this.clbViolenciaEconomica = new System.Windows.Forms.CheckedListBox();
            this.bttCancelar3 = new System.Windows.Forms.Button();
            this.bttSiguiente3 = new System.Windows.Forms.Button();
            this.bttAtras2 = new System.Windows.Forms.Button();
            this.lblUs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTipoViolenciaSexual
            // 
            this.lblTipoViolenciaSexual.AutoSize = true;
            this.lblTipoViolenciaSexual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoViolenciaSexual.Location = new System.Drawing.Point(12, 18);
            this.lblTipoViolenciaSexual.Name = "lblTipoViolenciaSexual";
            this.lblTipoViolenciaSexual.Size = new System.Drawing.Size(842, 32);
            this.lblTipoViolenciaSexual.TabIndex = 11;
            this.lblTipoViolenciaSexual.Text = "Tipo de Violencia Sexual(Se pueden seleccionar varias opciones)";
            this.lblTipoViolenciaSexual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTipoViolenciaSexual.UseMnemonic = false;
            // 
            // clbTipoViolenciaSexual
            // 
            this.clbTipoViolenciaSexual.BackColor = System.Drawing.Color.Lavender;
            this.clbTipoViolenciaSexual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbTipoViolenciaSexual.FormattingEnabled = true;
            this.clbTipoViolenciaSexual.Items.AddRange(new object[] {
            "Acceso carnal violento",
            "Acto sexual violento",
            "Explotación sexual: Inducción a la prostitución",
            "Explotación sexual: Proxenetismo con menor de edad",
            "Explotación sexual: Constreñimiento a la prostitución",
            "Explotación sexual: Trata de personas",
            "Explotación sexual: Estímulo a la prostitución de menores",
            "Explotación sexual: Demanda de explotación sexual comercial de persona menor de 1" +
                "8 años de edad",
            "Explotación sexual: Pornografía con personas menores de 18 años",
            "Acoso Sexual",
            "Obligar a otra persona a realizar cualquier acto o interacción sexual con tercera" +
                " persona Violencia sexual correctiva",
            "Violencia sexual facilitada por las nuevas tecnologías: Creación, difusión, distr" +
                "ibución o intercambio digital de fotografías, videos o audioclips de naturaleza " +
                "sexual o íntima sin consentimiento",
            "Violencia sexual facilitada por las nuevas tecnologías: Amenazas directas de daño" +
                " o violencia - Sextorsion",
            "Violencia sexual facilitada por las nuevas tecnologías: Grooming",
            "Violencia sexual facilitada por las nuevas tecnologías: Sexting sin consentimient" +
                "o",
            "Violencia sexual facilitada por las nuevas tecnologías: Abuso, explotación y/o tr" +
                "ata de mujeres y niñas por medio de las tecnologías",
            "Otra",
            "No aplica "});
            this.clbTipoViolenciaSexual.Location = new System.Drawing.Point(18, 63);
            this.clbTipoViolenciaSexual.Name = "clbTipoViolenciaSexual";
            this.clbTipoViolenciaSexual.Size = new System.Drawing.Size(1468, 400);
            this.clbTipoViolenciaSexual.TabIndex = 12;
            // 
            // lblTipoViolenciaFisica
            // 
            this.lblTipoViolenciaFisica.AutoSize = true;
            this.lblTipoViolenciaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoViolenciaFisica.Location = new System.Drawing.Point(12, 491);
            this.lblTipoViolenciaFisica.Name = "lblTipoViolenciaFisica";
            this.lblTipoViolenciaFisica.Size = new System.Drawing.Size(836, 32);
            this.lblTipoViolenciaFisica.TabIndex = 13;
            this.lblTipoViolenciaFisica.Text = "Tipo de Violencia Fisica (Se pueden seleccionar varias opciones)";
            this.lblTipoViolenciaFisica.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTipoViolenciaFisica.UseMnemonic = false;
            this.lblTipoViolenciaFisica.Click += new System.EventHandler(this.label1_Click);
            // 
            // clbTipoViolenciaFisica
            // 
            this.clbTipoViolenciaFisica.BackColor = System.Drawing.Color.Lavender;
            this.clbTipoViolenciaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbTipoViolenciaFisica.FormattingEnabled = true;
            this.clbTipoViolenciaFisica.Items.AddRange(new object[] {
            "Agresión física",
            "Feminicidio tentado o consumado",
            "Restricción a la libertad física (no es exclusiva del ámbito familiar)",
            "Violencia física facilitada por las nuevas tecnologías",
            "Otra",
            "No aplica "});
            this.clbTipoViolenciaFisica.Location = new System.Drawing.Point(18, 536);
            this.clbTipoViolenciaFisica.Name = "clbTipoViolenciaFisica";
            this.clbTipoViolenciaFisica.Size = new System.Drawing.Size(534, 136);
            this.clbTipoViolenciaFisica.TabIndex = 14;
            // 
            // lblViolenciaEconomica
            // 
            this.lblViolenciaEconomica.AutoSize = true;
            this.lblViolenciaEconomica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViolenciaEconomica.Location = new System.Drawing.Point(12, 699);
            this.lblViolenciaEconomica.Name = "lblViolenciaEconomica";
            this.lblViolenciaEconomica.Size = new System.Drawing.Size(952, 32);
            this.lblViolenciaEconomica.TabIndex = 15;
            this.lblViolenciaEconomica.Text = "Violencia Economica/Patrimonial (Se pueden seleccionar varias opciones)";
            this.lblViolenciaEconomica.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblViolenciaEconomica.UseMnemonic = false;
            this.lblViolenciaEconomica.Click += new System.EventHandler(this.lblViolenciaEconomica_Click);
            // 
            // clbViolenciaEconomica
            // 
            this.clbViolenciaEconomica.BackColor = System.Drawing.Color.Lavender;
            this.clbViolenciaEconomica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbViolenciaEconomica.FormattingEnabled = true;
            this.clbViolenciaEconomica.Items.AddRange(new object[] {
            "Pérdida, transformación, sustracción, destrucción, retención o distracción de obj" +
                "etos o bienes de la persona",
            "Pérdida, transformación, sustracción, destrucción, retención o distracción de ins" +
                "trumentos de trabajo de la persona",
            "Pérdida, transformación, sustracción, destrucción, retención o distracción de doc" +
                "umentos personales",
            "Pérdida, transformación, sustracción, destrucción, retención o distracción de val" +
                "ores o derechos económicos destinados a satisfacer las necesidades de la persona" +
                "",
            "Extorsión",
            "Estafa",
            "Inasistencia alimentaria",
            "Control económico",
            "Violencia económica facilitada por las nuevas tecnologías",
            "Otra",
            "No aplica"});
            this.clbViolenciaEconomica.Location = new System.Drawing.Point(18, 746);
            this.clbViolenciaEconomica.Name = "clbViolenciaEconomica";
            this.clbViolenciaEconomica.Size = new System.Drawing.Size(1276, 246);
            this.clbViolenciaEconomica.TabIndex = 16;
            // 
            // bttCancelar3
            // 
            this.bttCancelar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancelar3.Location = new System.Drawing.Point(747, 1012);
            this.bttCancelar3.Name = "bttCancelar3";
            this.bttCancelar3.Size = new System.Drawing.Size(107, 31);
            this.bttCancelar3.TabIndex = 32;
            this.bttCancelar3.Text = "Cancelar";
            this.bttCancelar3.UseMnemonic = false;
            this.bttCancelar3.UseVisualStyleBackColor = true;
            this.bttCancelar3.Click += new System.EventHandler(this.bttCancelar3_Click);
            // 
            // bttSiguiente3
            // 
            this.bttSiguiente3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSiguiente3.Location = new System.Drawing.Point(971, 1012);
            this.bttSiguiente3.Name = "bttSiguiente3";
            this.bttSiguiente3.Size = new System.Drawing.Size(107, 31);
            this.bttSiguiente3.TabIndex = 33;
            this.bttSiguiente3.Text = "Siguiente";
            this.bttSiguiente3.UseMnemonic = false;
            this.bttSiguiente3.UseVisualStyleBackColor = true;
            this.bttSiguiente3.Click += new System.EventHandler(this.bttSiguiente3_Click);
            // 
            // bttAtras2
            // 
            this.bttAtras2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAtras2.Location = new System.Drawing.Point(517, 1012);
            this.bttAtras2.Name = "bttAtras2";
            this.bttAtras2.Size = new System.Drawing.Size(105, 31);
            this.bttAtras2.TabIndex = 37;
            this.bttAtras2.Text = "Atras";
            this.bttAtras2.UseMnemonic = false;
            this.bttAtras2.UseVisualStyleBackColor = true;
            this.bttAtras2.Click += new System.EventHandler(this.bttAtras2_Click);
            // 
            // lblUs
            // 
            this.lblUs.AutoSize = true;
            this.lblUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUs.Location = new System.Drawing.Point(762, 1043);
            this.lblUs.Margin = new System.Windows.Forms.Padding(7, 15, 7, 10);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(15, 20);
            this.lblUs.TabIndex = 38;
            this.lblUs.Text = "-";
            // 
            // TipoViolencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1554, 1055);
            this.Controls.Add(this.lblUs);
            this.Controls.Add(this.bttAtras2);
            this.Controls.Add(this.bttSiguiente3);
            this.Controls.Add(this.bttCancelar3);
            this.Controls.Add(this.clbViolenciaEconomica);
            this.Controls.Add(this.lblViolenciaEconomica);
            this.Controls.Add(this.clbTipoViolenciaFisica);
            this.Controls.Add(this.lblTipoViolenciaFisica);
            this.Controls.Add(this.clbTipoViolenciaSexual);
            this.Controls.Add(this.lblTipoViolenciaSexual);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipoViolencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TipoViolencia";
            this.Load += new System.EventHandler(this.TipoViolencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoViolenciaSexual;
        private System.Windows.Forms.CheckedListBox clbTipoViolenciaSexual;
        private System.Windows.Forms.Label lblTipoViolenciaFisica;
        private System.Windows.Forms.CheckedListBox clbTipoViolenciaFisica;
        private System.Windows.Forms.Label lblViolenciaEconomica;
        private System.Windows.Forms.CheckedListBox clbViolenciaEconomica;
        private System.Windows.Forms.Button bttCancelar3;
        private System.Windows.Forms.Button bttSiguiente3;
        private System.Windows.Forms.Button bttAtras2;
        private System.Windows.Forms.Label lblUs;
    }
}