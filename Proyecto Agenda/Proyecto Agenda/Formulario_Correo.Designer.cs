﻿namespace Proyecto_Agenda
{
    partial class Formulario_Correo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mi_correo_txt = new System.Windows.Forms.TextBox();
            this.mi_contraseña_txt = new System.Windows.Forms.TextBox();
            this.correo_destino_txt = new System.Windows.Forms.TextBox();
            this.asunto_txt = new System.Windows.Forms.TextBox();
            this.mensaje_txt = new System.Windows.Forms.TextBox();
            this.Boton_Enviar = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo Electronico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Asunto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mensaje";
            // 
            // mi_correo_txt
            // 
            this.mi_correo_txt.Location = new System.Drawing.Point(112, 2);
            this.mi_correo_txt.Name = "mi_correo_txt";
            this.mi_correo_txt.Size = new System.Drawing.Size(189, 20);
            this.mi_correo_txt.TabIndex = 5;
            // 
            // mi_contraseña_txt
            // 
            this.mi_contraseña_txt.Location = new System.Drawing.Point(112, 30);
            this.mi_contraseña_txt.Name = "mi_contraseña_txt";
            this.mi_contraseña_txt.PasswordChar = '*';
            this.mi_contraseña_txt.Size = new System.Drawing.Size(189, 20);
            this.mi_contraseña_txt.TabIndex = 6;
            // 
            // correo_destino_txt
            // 
            this.correo_destino_txt.Enabled = false;
            this.correo_destino_txt.Location = new System.Drawing.Point(112, 64);
            this.correo_destino_txt.Name = "correo_destino_txt";
            this.correo_destino_txt.Size = new System.Drawing.Size(189, 20);
            this.correo_destino_txt.TabIndex = 7;
            // 
            // asunto_txt
            // 
            this.asunto_txt.Location = new System.Drawing.Point(112, 95);
            this.asunto_txt.Name = "asunto_txt";
            this.asunto_txt.Size = new System.Drawing.Size(189, 20);
            this.asunto_txt.TabIndex = 8;
            // 
            // mensaje_txt
            // 
            this.mensaje_txt.Location = new System.Drawing.Point(112, 130);
            this.mensaje_txt.Multiline = true;
            this.mensaje_txt.Name = "mensaje_txt";
            this.mensaje_txt.Size = new System.Drawing.Size(235, 189);
            this.mensaje_txt.TabIndex = 9;
            // 
            // Boton_Enviar
            // 
            this.Boton_Enviar.Location = new System.Drawing.Point(15, 184);
            this.Boton_Enviar.Name = "Boton_Enviar";
            this.Boton_Enviar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Enviar.TabIndex = 10;
            this.Boton_Enviar.Text = "Enviar";
            this.Boton_Enviar.UseVisualStyleBackColor = true;
            this.Boton_Enviar.Click += new System.EventHandler(this.Boton_Enviar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Location = new System.Drawing.Point(15, 226);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Cancelar.TabIndex = 11;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // Formulario_Correo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 340);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Enviar);
            this.Controls.Add(this.mensaje_txt);
            this.Controls.Add(this.asunto_txt);
            this.Controls.Add(this.correo_destino_txt);
            this.Controls.Add(this.mi_contraseña_txt);
            this.Controls.Add(this.mi_correo_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Formulario_Correo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario_Correo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mi_correo_txt;
        private System.Windows.Forms.TextBox mi_contraseña_txt;
        private System.Windows.Forms.TextBox correo_destino_txt;
        private System.Windows.Forms.TextBox asunto_txt;
        private System.Windows.Forms.TextBox mensaje_txt;
        private System.Windows.Forms.Button Boton_Enviar;
        private System.Windows.Forms.Button Boton_Cancelar;
    }
}