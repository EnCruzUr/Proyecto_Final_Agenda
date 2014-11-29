using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace Proyecto_Agenda
{
    public partial class Formulario_Visual : Form
    {
        string ordenamiento;
        string az;
        OleDbConnection conexion = new OleDbConnection(ConfigurationManager.ConnectionStrings["Proyecto_Agenda.Properties.Settings.Coneccion_BD"].ConnectionString);
        public Formulario_Visual()
        {
            InitializeComponent();
        }

        private void busqueda_de_agenda(string consulta)
        {
            conexion.Open();
            OleDbDataAdapter busqueda = new OleDbDataAdapter(consulta, conexion);
            OleDbCommandBuilder comando = new OleDbCommandBuilder();
            DataTable datos = new DataTable();
            busqueda.Fill(datos);
            //DataGridView Visual = new DataGridView();
            BindingSource muestra = new BindingSource();
            muestra.DataSource = datos;
            Visual_Datos.DataSource = muestra;





            
            conexion.Close();
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
        private void Boton_buscar_Click_1(object sender, EventArgs e)
        {
            if (Combo_Ordena_por.Text == "Nombre")
            {
                ordenamiento = "[Nombre(s)]";
            }
            else if (Combo_Ordena_por.Text == "Apellido")
            {
                ordenamiento = "Apellidos";
            }
            else if (Combo_Ordena_por.Text == "Telefono")
            {
                ordenamiento = "[Telefono Fijo]";
            }
            else if (Combo_Ordena_por.Text == "e-mail")
            {
                ordenamiento = "[e-mail]";
            }
            else
            {
                ordenamiento = "[Nombre(s)]";
            }

            az = Combo_abcd.Text;
            string consulta;
            consulta = "SELECT  Num_Reg, [Telefono Fijo], [Telefono Movil], [Nombre(s)], Apellidos, Direccion, [e-mail] FROM     Agenda_Telefonica WHERE  (" + ordenamiento + " LIKE '" + az + "%')";
            //this.agenda_TelefonicaTableAdapter
            Console.WriteLine("consulta: " + consulta);
            busqueda_de_agenda(consulta);
        }
    }
}
