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
    public partial class Formulario_Visual : Form
    {
        public Formulario_Visual()
        {
            InitializeComponent();
        }

        private void Boton_Menu_Regresar_Click(object sender, EventArgs e)
        {

        }

        private void Boton_Menu_Regresar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Formulario_Agenda agenda = new Formulario_Agenda();
            agenda.Show();
        }

        private void Boton_Menu_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Formulario_Visual_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_Proj_AgendaDataSet.Agenda_Telefonica' Puede moverla o quitarla según sea necesario.
            this.agenda_TelefonicaTableAdapter.Fill(this.bD_Proj_AgendaDataSet.Agenda_Telefonica);

        }

        private void consulta0ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.agenda_TelefonicaTableAdapter.consulta0(this.bD_Proj_AgendaDataSet.Agenda_Telefonica);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
