namespace Proyecto_Agenda
{
    partial class Formulario_Agenda
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_Agenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Boton_Edicion = new System.Windows.Forms.Button();
            this.Boton_Visualizar = new System.Windows.Forms.Button();
            this.Boton_Salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Boton_Salir);
            this.panel1.Controls.Add(this.Boton_Visualizar);
            this.panel1.Controls.Add(this.Boton_Edicion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 32);
            this.panel1.TabIndex = 0;
            // 
            // Boton_Edicion
            // 
            this.Boton_Edicion.Location = new System.Drawing.Point(9, 3);
            this.Boton_Edicion.Name = "Boton_Edicion";
            this.Boton_Edicion.Size = new System.Drawing.Size(75, 23);
            this.Boton_Edicion.TabIndex = 0;
            this.Boton_Edicion.Text = "Edicion";
            this.Boton_Edicion.UseVisualStyleBackColor = true;
            this.Boton_Edicion.Click += new System.EventHandler(this.button1_Click);
            // 
            // Boton_Visualizar
            // 
            this.Boton_Visualizar.Location = new System.Drawing.Point(90, 3);
            this.Boton_Visualizar.Name = "Boton_Visualizar";
            this.Boton_Visualizar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Visualizar.TabIndex = 1;
            this.Boton_Visualizar.Text = "Visualizar";
            this.Boton_Visualizar.UseVisualStyleBackColor = true;
            this.Boton_Visualizar.Click += new System.EventHandler(this.Boton_Visualizar_Click);
            // 
            // Boton_Salir
            // 
            this.Boton_Salir.Location = new System.Drawing.Point(171, 3);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(75, 23);
            this.Boton_Salir.TabIndex = 2;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = true;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // Formulario_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 32);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formulario_Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Agenda";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Boton_Visualizar;
        private System.Windows.Forms.Button Boton_Edicion;
        private System.Windows.Forms.Button Boton_Salir;
    }
}

