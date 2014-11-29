using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Agenda
{
    public partial class Formulario_Agenda : Form
    {
        public Formulario_Agenda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formulario_Edicion edicion = new Formulario_Edicion();
            edicion.Show();
        }

        private void Boton_Visualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formulario_Visual visual = new Formulario_Visual();
            visual.Show();
        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
