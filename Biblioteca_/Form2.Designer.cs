namespace Biblioteca_
{
    partial class Form2
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
            this.registrarUsuario = new System.Windows.Forms.Button();
            this.cedula = new System.Windows.Forms.Label();
            this.cedulaUsuario = new System.Windows.Forms.TextBox();
            this.nombreUsuario = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.rolUsuario = new System.Windows.Forms.TextBox();
            this.rol = new System.Windows.Forms.Label();
            this.eliminarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrarUsuario
            // 
            this.registrarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.registrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarUsuario.FlatAppearance.BorderSize = 2;
            this.registrarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.registrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarUsuario.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registrarUsuario.Location = new System.Drawing.Point(303, 331);
            this.registrarUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.registrarUsuario.Name = "registrarUsuario";
            this.registrarUsuario.Size = new System.Drawing.Size(188, 44);
            this.registrarUsuario.TabIndex = 1;
            this.registrarUsuario.Text = "Registar Usuario";
            this.registrarUsuario.UseVisualStyleBackColor = true;
            this.registrarUsuario.Click += new System.EventHandler(this.registrarUsuario_Click);
            // 
            // cedula
            // 
            this.cedula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cedula.AutoSize = true;
            this.cedula.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedula.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cedula.Location = new System.Drawing.Point(175, 113);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(93, 23);
            this.cedula.TabIndex = 2;
            this.cedula.Text = "Cédula";
            // 
            // cedulaUsuario
            // 
            this.cedulaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cedulaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cedulaUsuario.Location = new System.Drawing.Point(303, 110);
            this.cedulaUsuario.Name = "cedulaUsuario";
            this.cedulaUsuario.Size = new System.Drawing.Size(188, 31);
            this.cedulaUsuario.TabIndex = 3;
            this.cedulaUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreUsuario.Location = new System.Drawing.Point(303, 172);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(188, 31);
            this.nombreUsuario.TabIndex = 5;
            // 
            // nombre
            // 
            this.nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nombre.Location = new System.Drawing.Point(175, 180);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(101, 23);
            this.nombre.TabIndex = 4;
            this.nombre.Text = "Nombre";
            // 
            // rolUsuario
            // 
            this.rolUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rolUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rolUsuario.Location = new System.Drawing.Point(303, 241);
            this.rolUsuario.Name = "rolUsuario";
            this.rolUsuario.Size = new System.Drawing.Size(188, 31);
            this.rolUsuario.TabIndex = 7;
            // 
            // rol
            // 
            this.rol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rol.AutoSize = true;
            this.rol.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rol.Location = new System.Drawing.Point(175, 249);
            this.rol.Name = "rol";
            this.rol.Size = new System.Drawing.Size(52, 23);
            this.rol.TabIndex = 6;
            this.rol.Text = "Rol";
            // 
            // eliminarUsuario
            // 
            this.eliminarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.eliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarUsuario.FlatAppearance.BorderSize = 2;
            this.eliminarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.eliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarUsuario.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eliminarUsuario.Location = new System.Drawing.Point(303, 404);
            this.eliminarUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.eliminarUsuario.Name = "eliminarUsuario";
            this.eliminarUsuario.Size = new System.Drawing.Size(188, 44);
            this.eliminarUsuario.TabIndex = 8;
            this.eliminarUsuario.Text = "Eliminar Usuario";
            this.eliminarUsuario.UseVisualStyleBackColor = true;
            this.eliminarUsuario.Click += new System.EventHandler(this.eliminarUsuario_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 584);
            this.Controls.Add(this.eliminarUsuario);
            this.Controls.Add(this.rolUsuario);
            this.Controls.Add(this.rol);
            this.Controls.Add(this.nombreUsuario);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.cedulaUsuario);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.registrarUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrarUsuario;
        private System.Windows.Forms.Label cedula;
        private System.Windows.Forms.TextBox cedulaUsuario;
        private System.Windows.Forms.TextBox nombreUsuario;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox rolUsuario;
        private System.Windows.Forms.Label rol;
        private System.Windows.Forms.Button eliminarUsuario;
    }
}