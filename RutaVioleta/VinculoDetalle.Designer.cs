namespace RutaVioleta
{
    partial class VinculoDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VinculoDetalle));
            this.lblVinculoPersona = new System.Windows.Forms.Label();
            this.clbVinculoPersonaV = new System.Windows.Forms.CheckedListBox();
            this.txtCuales = new System.Windows.Forms.TextBox();
            this.lblDetalleExperiencia = new System.Windows.Forms.Label();
            this.lblTipoViolenciapPsicologica = new System.Windows.Forms.Label();
            this.clbTipoViolenciaPsicologica = new System.Windows.Forms.CheckedListBox();
            this.bttCancelar2 = new System.Windows.Forms.Button();
            this.bttSiguiente2 = new System.Windows.Forms.Button();
            this.bttAtras1 = new System.Windows.Forms.Button();
            this.lblCualEs = new System.Windows.Forms.Label();
            this.lblU = new System.Windows.Forms.Label();
            this.lblUs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVinculoPersona
            // 
            this.lblVinculoPersona.AutoSize = true;
            this.lblVinculoPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVinculoPersona.Location = new System.Drawing.Point(6, 28);
            this.lblVinculoPersona.Name = "lblVinculoPersona";
            this.lblVinculoPersona.Size = new System.Drawing.Size(523, 32);
            this.lblVinculoPersona.TabIndex = 1;
            this.lblVinculoPersona.Text = "Vinculo de Persona Victima con la UdeA";
            this.lblVinculoPersona.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblVinculoPersona.Click += new System.EventHandler(this.lblPrimerNombre_Click);
            // 
            // clbVinculoPersonaV
            // 
            this.clbVinculoPersonaV.BackColor = System.Drawing.Color.Lavender;
            this.clbVinculoPersonaV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbVinculoPersonaV.FormattingEnabled = true;
            this.clbVinculoPersonaV.Items.AddRange(new object[] {
            "Estudiante",
            "Personal administrativo",
            "Docente",
            "Egresado",
            "Personal de servicio UdeA",
            "Contratista Fundación UdeA",
            "Contratista CIS",
            "Otro"});
            this.clbVinculoPersonaV.Location = new System.Drawing.Point(12, 72);
            this.clbVinculoPersonaV.Name = "clbVinculoPersonaV";
            this.clbVinculoPersonaV.Size = new System.Drawing.Size(568, 202);
            this.clbVinculoPersonaV.TabIndex = 4;
            // 
            // txtCuales
            // 
            this.txtCuales.BackColor = System.Drawing.Color.Lavender;
            this.txtCuales.Location = new System.Drawing.Point(113, 270);
            this.txtCuales.Name = "txtCuales";
            this.txtCuales.Size = new System.Drawing.Size(142, 22);
            this.txtCuales.TabIndex = 8;
            this.txtCuales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // lblDetalleExperiencia
            // 
            this.lblDetalleExperiencia.AutoSize = true;
            this.lblDetalleExperiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleExperiencia.Location = new System.Drawing.Point(422, 300);
            this.lblDetalleExperiencia.Name = "lblDetalleExperiencia";
            this.lblDetalleExperiencia.Size = new System.Drawing.Size(521, 38);
            this.lblDetalleExperiencia.TabIndex = 9;
            this.lblDetalleExperiencia.Text = "DETALLE DE LA EXPERIENCIA";
            this.lblDetalleExperiencia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDetalleExperiencia.UseMnemonic = false;
            this.lblDetalleExperiencia.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTipoViolenciapPsicologica
            // 
            this.lblTipoViolenciapPsicologica.AutoSize = true;
            this.lblTipoViolenciapPsicologica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoViolenciapPsicologica.Location = new System.Drawing.Point(6, 364);
            this.lblTipoViolenciapPsicologica.Name = "lblTipoViolenciapPsicologica";
            this.lblTipoViolenciapPsicologica.Size = new System.Drawing.Size(897, 32);
            this.lblTipoViolenciapPsicologica.TabIndex = 10;
            this.lblTipoViolenciapPsicologica.Text = "Tipo de Violencia psicológica(Se pueden seleccionar varias opciones)";
            this.lblTipoViolenciapPsicologica.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTipoViolenciapPsicologica.UseMnemonic = false;
            // 
            // clbTipoViolenciaPsicologica
            // 
            this.clbTipoViolenciaPsicologica.BackColor = System.Drawing.Color.Lavender;
            this.clbTipoViolenciaPsicologica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbTipoViolenciaPsicologica.FormattingEnabled = true;
            this.clbTipoViolenciaPsicologica.Items.AddRange(new object[] {
            "Acción que degrade a la otra persona",
            "Omisión que degrade a la otra persona",
            "Acción que busque controlar los comportamientos, creencias o decisiones de otra p" +
                "ersona Omisión que busque controlar los comportamientos, creencias o decisiones " +
                "de otra persona Intimidación",
            "Manipulación",
            "Amenaza directa",
            "Amenaza indirecta",
            "Humillación",
            "Aislamiento",
            "Constreñimiento ilegal",
            "Lenguaje misógino, sexista o discursos de odio",
            "Injuria",
            "Calumnia",
            "Injuria por vía de hecho",
            "Abuso de poder y/o confianza",
            "Violencia epistémica",
            "Violencia psicológica facilitada por las nuevas tecnologías: Acceso, uso, control" +
                ", manipulación, intercambio o publicación no autorizada de información privada y" +
                " datos personales",
            resources.GetString("clbTipoViolenciaPsicologica.Items"),
            "Violencia psicológica facilitada por las nuevas tecnologías: Ciberhostigamiento o" +
                " ciberacecho Violencia psicológica facilitada por las nuevas tecnologías: Cibera" +
                "coso",
            "Violencia psicológica facilitada por las nuevas tecnologías: Ciberbullying",
            "Violencia psicológica facilitada por las nuevas tecnologías: Slutshaming",
            "Violencia psicológica facilitada por las nuevas tecnologías: Ataques a grupos, or" +
                "ganizaciones o comunidades de mujeres",
            "Otra conducta que implique un perjuicio a la salud psicológica, autodeterminación" +
                " o al desarrollo personal",
            "No aplica"});
            this.clbTipoViolenciaPsicologica.Location = new System.Drawing.Point(12, 413);
            this.clbTipoViolenciaPsicologica.Name = "clbTipoViolenciaPsicologica";
            this.clbTipoViolenciaPsicologica.Size = new System.Drawing.Size(1694, 532);
            this.clbTipoViolenciaPsicologica.TabIndex = 11;
            // 
            // bttCancelar2
            // 
            this.bttCancelar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancelar2.Location = new System.Drawing.Point(760, 974);
            this.bttCancelar2.Name = "bttCancelar2";
            this.bttCancelar2.Size = new System.Drawing.Size(107, 31);
            this.bttCancelar2.TabIndex = 34;
            this.bttCancelar2.Text = "Cancelar";
            this.bttCancelar2.UseMnemonic = false;
            this.bttCancelar2.UseVisualStyleBackColor = true;
            this.bttCancelar2.Click += new System.EventHandler(this.bttCancelar2_Click);
            // 
            // bttSiguiente2
            // 
            this.bttSiguiente2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSiguiente2.Location = new System.Drawing.Point(952, 974);
            this.bttSiguiente2.Name = "bttSiguiente2";
            this.bttSiguiente2.Size = new System.Drawing.Size(107, 31);
            this.bttSiguiente2.TabIndex = 35;
            this.bttSiguiente2.Text = "Siguiente";
            this.bttSiguiente2.UseMnemonic = false;
            this.bttSiguiente2.UseVisualStyleBackColor = true;
            this.bttSiguiente2.Click += new System.EventHandler(this.bttSiguiente1_Click);
            // 
            // bttAtras1
            // 
            this.bttAtras1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAtras1.Location = new System.Drawing.Point(564, 974);
            this.bttAtras1.Name = "bttAtras1";
            this.bttAtras1.Size = new System.Drawing.Size(107, 31);
            this.bttAtras1.TabIndex = 36;
            this.bttAtras1.Text = "Atras";
            this.bttAtras1.UseMnemonic = false;
            this.bttAtras1.UseVisualStyleBackColor = true;
            this.bttAtras1.Click += new System.EventHandler(this.bttAtras1_Click);
            // 
            // lblCualEs
            // 
            this.lblCualEs.AutoSize = true;
            this.lblCualEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCualEs.Location = new System.Drawing.Point(8, 270);
            this.lblCualEs.Name = "lblCualEs";
            this.lblCualEs.Size = new System.Drawing.Size(85, 20);
            this.lblCualEs.TabIndex = 37;
            this.lblCualEs.Text = "¿Cual es?";
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblU.Location = new System.Drawing.Point(800, 1023);
            this.lblU.Margin = new System.Windows.Forms.Padding(7, 15, 7, 10);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(0, 20);
            this.lblU.TabIndex = 38;
            // 
            // lblUs
            // 
            this.lblUs.AutoSize = true;
            this.lblUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUs.Location = new System.Drawing.Point(783, 1023);
            this.lblUs.Margin = new System.Windows.Forms.Padding(7, 15, 7, 10);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(15, 20);
            this.lblUs.TabIndex = 39;
            this.lblUs.Text = "-";
            // 
            // VinculoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.lblUs);
            this.Controls.Add(this.lblU);
            this.Controls.Add(this.lblCualEs);
            this.Controls.Add(this.bttAtras1);
            this.Controls.Add(this.bttSiguiente2);
            this.Controls.Add(this.bttCancelar2);
            this.Controls.Add(this.clbTipoViolenciaPsicologica);
            this.Controls.Add(this.lblTipoViolenciapPsicologica);
            this.Controls.Add(this.lblDetalleExperiencia);
            this.Controls.Add(this.txtCuales);
            this.Controls.Add(this.clbVinculoPersonaV);
            this.Controls.Add(this.lblVinculoPersona);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VinculoDetalle";
            this.Text = "VinculoDetalle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVinculoPersona;
        private System.Windows.Forms.CheckedListBox clbVinculoPersonaV;
        private System.Windows.Forms.TextBox txtCuales;
        private System.Windows.Forms.Label lblDetalleExperiencia;
        private System.Windows.Forms.Label lblTipoViolenciapPsicologica;
        private System.Windows.Forms.CheckedListBox clbTipoViolenciaPsicologica;
        private System.Windows.Forms.Button bttCancelar2;
        private System.Windows.Forms.Button bttSiguiente2;
        private System.Windows.Forms.Button bttAtras1;
        private System.Windows.Forms.Label lblCualEs;
        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.Label lblUs;
    }
}