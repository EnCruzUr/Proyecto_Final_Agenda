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
            Formulario_Agenda agenda = new Formulario_Agenda();
            agenda.Show();
            //connectionString="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\bin\Debug\BD_Proj_Agenda.accdb;Persist Security Info=True;Jet OLEDB:Database Password=2789"
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
            // TODO: esta línea de código carga datos en la tabla 'bD_Proj_AgendaDataSet.Agenda_Telefonica' Puede moverla o quitarla según sea necesario.
            this.agenda_TelefonicaTableAdapter.Fill(this.bD_Proj_AgendaDataSet.Agenda_Telefonica);
            // TODO: esta línea de código carga datos en la tabla 'bD_Proj_AgendaDataSet.Agenda_Telefonica' Puede moverla o quitarla según sea necesario.
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
