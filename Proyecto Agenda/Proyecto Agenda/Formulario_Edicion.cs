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
    public partial class Formulario_Edicion : Form
    {
        public Formulario_Edicion()
        {
            InitializeComponent();
        }

        private void Boton_Menu_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formulario_Visual visual = new Formulario_Visual();
            visual.Show();
        }

        private void Boton_Menu_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agenda_TelefonicaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agenda_TelefonicaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_Proj_AgendaDataSet);

        }

        private void Formulario_Edicion_Load(object sender, EventArgs e)
        {
            this.agenda_TelefonicaTableAdapter.Fill(this.bD_Proj_AgendaDataSet.Agenda_Telefonica);
            this.agenda_TelefonicaTableAdapter.Fill(this.bD_Proj_AgendaDataSet.Agenda_Telefonica);

        }

        private void agenda_TelefonicaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.agenda_TelefonicaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_Proj_AgendaDataSet);

        }
    }
}
