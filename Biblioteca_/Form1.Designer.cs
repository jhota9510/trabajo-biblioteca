namespace Biblioteca_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.usuarios = new System.Windows.Forms.Button();
            this.material = new System.Windows.Forms.Button();
            this.biblio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarios
            // 
            this.usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.usuarios.FlatAppearance.BorderSize = 0;
            this.usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usuarios.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usuarios.Image = ((System.Drawing.Image)(resources.GetObject("usuarios.Image")));
            this.usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usuarios.Location = new System.Drawing.Point(0, 160);
            this.usuarios.Margin = new System.Windows.Forms.Padding(6);
            this.usuarios.Name = "usuarios";
            this.usuarios.Size = new System.Drawing.Size(160, 50);
            this.usuarios.TabIndex = 0;
            this.usuarios.Text = "Usuarios";
            this.usuarios.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.usuarios.UseVisualStyleBackColor = true;
            this.usuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // material
            // 
            this.material.Cursor = System.Windows.Forms.Cursors.Hand;
            this.material.Dock = System.Windows.Forms.DockStyle.Top;
            this.material.FlatAppearance.BorderSize = 0;
            this.material.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.material.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.material.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.material.Image = ((System.Drawing.Image)(resources.GetObject("material.Image")));
            this.material.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.material.Location = new System.Drawing.Point(0, 260);
            this.material.Margin = new System.Windows.Forms.Padding(6);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(160, 50);
            this.material.TabIndex = 2;
            this.material.Text = "Material";
            this.material.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.material.UseVisualStyleBackColor = true;
            this.material.Click += new System.EventHandler(this.material_Click);
            // 
            // biblio
            // 
            this.biblio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biblio.Dock = System.Windows.Forms.DockStyle.Top;
            this.biblio.FlatAppearance.BorderSize = 0;
            this.biblio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.biblio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.biblio.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biblio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.biblio.Image = ((System.Drawing.Image)(resources.GetObject("biblio.Image")));
            this.biblio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.biblio.Location = new System.Drawing.Point(0, 210);
            this.biblio.Margin = new System.Windows.Forms.Padding(6);
            this.biblio.Name = "biblio";
            this.biblio.Size = new System.Drawing.Size(160, 50);
            this.biblio.TabIndex = 3;
            this.biblio.Text = "Biblioteca";
            this.biblio.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.biblio.UseVisualStyleBackColor = true;
            this.biblio.Click += new System.EventHandler(this.biblio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 41);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.material);
            this.panel2.Controls.Add(this.biblio);
            this.panel2.Controls.Add(this.usuarios);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 584);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(160, 41);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(801, 584);
            this.panelMenu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(379, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "biblioteca ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 625);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "biblioteca";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button usuarios;
        private System.Windows.Forms.Button material;
        private System.Windows.Forms.Button biblio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
    }
}

