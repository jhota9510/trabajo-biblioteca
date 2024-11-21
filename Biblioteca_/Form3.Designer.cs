namespace Biblioteca_
{
    partial class Form3
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
            this.codigoMaterial = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.registrarMaterial = new System.Windows.Forms.Button();
            this.registrarPrestamo = new System.Windows.Forms.Button();
            this.registrarDevolucion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tituloMaterial = new System.Windows.Forms.TextBox();
            this.cedulaMaterial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // codigoMaterial
            // 
            this.codigoMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoMaterial.Location = new System.Drawing.Point(302, 93);
            this.codigoMaterial.Name = "codigoMaterial";
            this.codigoMaterial.Size = new System.Drawing.Size(228, 31);
            this.codigoMaterial.TabIndex = 5;
            this.codigoMaterial.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // codigo
            // 
            this.codigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigo.AutoSize = true;
            this.codigo.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.codigo.Location = new System.Drawing.Point(182, 101);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(94, 23);
            this.codigo.TabIndex = 4;
            this.codigo.Text = "Código";
            // 
            // titulo
            // 
            this.titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titulo.Location = new System.Drawing.Point(182, 174);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(86, 23);
            this.titulo.TabIndex = 6;
            this.titulo.Text = "Título";
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            // 
            // registrarMaterial
            // 
            this.registrarMaterial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.registrarMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarMaterial.FlatAppearance.BorderSize = 2;
            this.registrarMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.registrarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarMaterial.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarMaterial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registrarMaterial.Location = new System.Drawing.Point(302, 232);
            this.registrarMaterial.Margin = new System.Windows.Forms.Padding(6);
            this.registrarMaterial.Name = "registrarMaterial";
            this.registrarMaterial.Size = new System.Drawing.Size(228, 44);
            this.registrarMaterial.TabIndex = 8;
            this.registrarMaterial.Text = "Registrar Material";
            this.registrarMaterial.UseVisualStyleBackColor = true;
            this.registrarMaterial.Click += new System.EventHandler(this.registrarMaterial_Click);
            // 
            // registrarPrestamo
            // 
            this.registrarPrestamo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.registrarPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarPrestamo.FlatAppearance.BorderSize = 2;
            this.registrarPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.registrarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarPrestamo.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarPrestamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registrarPrestamo.Location = new System.Drawing.Point(302, 392);
            this.registrarPrestamo.Margin = new System.Windows.Forms.Padding(6);
            this.registrarPrestamo.Name = "registrarPrestamo";
            this.registrarPrestamo.Size = new System.Drawing.Size(228, 44);
            this.registrarPrestamo.TabIndex = 9;
            this.registrarPrestamo.Text = "Registrar Prestamo";
            this.registrarPrestamo.UseVisualStyleBackColor = true;
            this.registrarPrestamo.Click += new System.EventHandler(this.registrarPrestamo_Click);
            // 
            // registrarDevolucion
            // 
            this.registrarDevolucion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.registrarDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarDevolucion.FlatAppearance.BorderSize = 2;
            this.registrarDevolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.registrarDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarDevolucion.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarDevolucion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registrarDevolucion.Location = new System.Drawing.Point(302, 468);
            this.registrarDevolucion.Margin = new System.Windows.Forms.Padding(6);
            this.registrarDevolucion.Name = "registrarDevolucion";
            this.registrarDevolucion.Size = new System.Drawing.Size(228, 48);
            this.registrarDevolucion.TabIndex = 10;
            this.registrarDevolucion.Text = "Registrar Devolucion";
            this.registrarDevolucion.UseVisualStyleBackColor = true;
            this.registrarDevolucion.Click += new System.EventHandler(this.registrarDevolucion_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(182, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cédula";
            // 
            // tituloMaterial
            // 
            this.tituloMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tituloMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tituloMaterial.Location = new System.Drawing.Point(302, 166);
            this.tituloMaterial.Name = "tituloMaterial";
            this.tituloMaterial.Size = new System.Drawing.Size(228, 31);
            this.tituloMaterial.TabIndex = 14;
            // 
            // cedulaMaterial
            // 
            this.cedulaMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cedulaMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cedulaMaterial.Location = new System.Drawing.Point(302, 329);
            this.cedulaMaterial.Name = "cedulaMaterial";
            this.cedulaMaterial.Size = new System.Drawing.Size(228, 31);
            this.cedulaMaterial.TabIndex = 15;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 584);
            this.Controls.Add(this.cedulaMaterial);
            this.Controls.Add(this.tituloMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrarDevolucion);
            this.Controls.Add(this.registrarPrestamo);
            this.Controls.Add(this.registrarMaterial);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.codigoMaterial);
            this.Controls.Add(this.codigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigoMaterial;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button registrarMaterial;
        private System.Windows.Forms.Button registrarPrestamo;
        private System.Windows.Forms.Button registrarDevolucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tituloMaterial;
        private System.Windows.Forms.TextBox cedulaMaterial;
    }
}