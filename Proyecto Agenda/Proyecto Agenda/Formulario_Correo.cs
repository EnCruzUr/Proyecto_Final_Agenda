using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;

namespace Proyecto_Agenda
{
    public partial class Formulario_Correo : Form
    {

        private string Para;
        private string Asunto;
        private string Mensaje;

        private MailMessage Correo;

        public Formulario_Correo(string correo_envio)
        {
            InitializeComponent();
            correo_destino_txt.Text = correo_envio;
        }


        private void Boton_Enviar_Click(object sender, EventArgs e)
        {
            if (!(correo_destino_txt.Text.Trim() == ""))
            {
                try{
                Para = correo_destino_txt.Text;
                Asunto = asunto_txt.Text;
                Mensaje = mensaje_txt.Text;

                Correo = new MailMessage();
                Correo.To.Add(new MailAddress(this.Para));
                Correo.From = new MailAddress("tu correo@hotmail.com");
                Correo.Subject = Asunto;
                Correo.Body = Mensaje;
                Correo.IsBodyHtml = false;

                SmtpClient client = new SmtpClient("smtp.live.com", 587);
                using (client)
                {

                    client.Credentials = new System.Net.NetworkCredential(mi_correo_txt.Text,mi_contraseña_txt.Text);
                    client.EnableSsl = true;
                    client.Send(Correo);
                }
                MessageBox.Show("Mensaje enviado Exitosamente");
            }
                
            catch{
                MessageBox.Show("Verifique su Correo o Contraseña");
            }
            finally{
                this.Hide();
            }
        }}

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
