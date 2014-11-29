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
            BindingSource muestra = new BindingSource();
            muestra.DataSource = datos;
            Visual_Datos.DataSource = muestra;
            conexion.Close();
        }

        private void Boton_Menu_Regresar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Formulario_Edicion edicion = new Formulario_Edicion();
            edicion.Show();
        }

        private void Boton_Menu_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Formulario_Visual_Load(object sender, EventArgs e)
        {
            Combo_Ordena_por.SelectedIndex = 0;
            Combo_abcd.SelectedIndex = 0;
            this.agenda_TelefonicaTableAdapter.Fill(this.bD_Proj_AgendaDataSet.Agenda_Telefonica);

        }

        private void consulta0ToolStripButton_Click(object sender, EventArgs e)
        {
            string consultar_todo = "SELECT * FROM Agenda_Telefonica";
            conexion.Open();
            OleDbDataAdapter busqueda = new OleDbDataAdapter(consultar_todo, conexion);
            OleDbCommandBuilder comando = new OleDbCommandBuilder();
            DataTable datos = new DataTable();
            busqueda.Fill(datos);
            BindingSource muestra = new BindingSource();
            muestra.DataSource = datos;
            Visual_Datos.DataSource = muestra;
            conexion.Close();


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
            busqueda_de_agenda(consulta);
        }

        private void Boton_Enviar_Mensaje_Click(object sender, EventArgs e)
        {
            string correo;
            string msg = String.Format("Row: {0}, Column: {1}",
            Visual_Datos.CurrentCell.RowIndex,
            Visual_Datos.CurrentCell.ColumnIndex);
            int a, b;
            a = Visual_Datos.CurrentCell.RowIndex;
            b = Visual_Datos.CurrentCell.ColumnIndex;
            correo = Visual_Datos[b, a].Value.ToString();
            Formulario_Correo enviar_email = new Formulario_Correo(correo);
            enviar_email.Show();

        }
    }
}
