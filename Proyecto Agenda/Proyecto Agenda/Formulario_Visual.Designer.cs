namespace Proyecto_Agenda
{
    partial class Formulario_Visual
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_Visual));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Boton_Menu_Regresar = new System.Windows.Forms.ToolStripMenuItem();
            this.Boton_Menu_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaTelefonicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_Proj_AgendaDataSet = new Proyecto_Agenda.BD_Proj_AgendaDataSet();
            this.consulta0ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Consultas = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Combo_Ordena_por = new System.Windows.Forms.ToolStripComboBox();
            this.Combo_abcd = new System.Windows.Forms.ToolStripComboBox();
            this.Boton_buscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.Boton_Enviar_Mensaje = new System.Windows.Forms.ToolStripButton();
            this.agenda_TelefonicaTableAdapter = new Proyecto_Agenda.BD_Proj_AgendaDataSetTableAdapters.Agenda_TelefonicaTableAdapter();
            this.Visual_Datos = new System.Windows.Forms.DataGridView();
            this.agendaTelefonicaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.numRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoFijoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoMovilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaTelefonicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Proj_AgendaDataSet)).BeginInit();
            this.Consultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Visual_Datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaTelefonicaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Boton_Menu_Regresar,
            this.Boton_Menu_Salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Boton_Menu_Regresar
            // 
            this.Boton_Menu_Regresar.Name = "Boton_Menu_Regresar";
            this.Boton_Menu_Regresar.Size = new System.Drawing.Size(60, 22);
            this.Boton_Menu_Regresar.Text = "Edicion";
            this.Boton_Menu_Regresar.Click += new System.EventHandler(this.Boton_Menu_Regresar_Click_1);
            // 
            // Boton_Menu_Salir
            // 
            this.Boton_Menu_Salir.Name = "Boton_Menu_Salir";
            this.Boton_Menu_Salir.Size = new System.Drawing.Size(43, 22);
            this.Boton_Menu_Salir.Text = "Salir";
            this.Boton_Menu_Salir.Click += new System.EventHandler(this.Boton_Menu_Salir_Click);
            // 
            // agendaTelefonicaBindingSource
            // 
            this.agendaTelefonicaBindingSource.DataMember = "Agenda_Telefonica";
            this.agendaTelefonicaBindingSource.DataSource = this.bD_Proj_AgendaDataSet;
            // 
            // bD_Proj_AgendaDataSet
            // 
            this.bD_Proj_AgendaDataSet.DataSetName = "BD_Proj_AgendaDataSet";
            this.bD_Proj_AgendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consulta0ToolStripButton
            // 
            this.consulta0ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.consulta0ToolStripButton.Name = "consulta0ToolStripButton";
            this.consulta0ToolStripButton.Size = new System.Drawing.Size(92, 23);
            this.consulta0ToolStripButton.Text = "Mostrar Todos";
            this.consulta0ToolStripButton.Click += new System.EventHandler(this.consulta0ToolStripButton_Click);
            // 
            // Consultas
            // 
            this.Consultas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulta0ToolStripButton,
            this.toolStripLabel1,
            this.Combo_Ordena_por,
            this.Combo_abcd,
            this.Boton_buscar,
            this.toolStripLabel2,
            this.Boton_Enviar_Mensaje});
            this.Consultas.Location = new System.Drawing.Point(0, 26);
            this.Consultas.Name = "Consultas";
            this.Consultas.Size = new System.Drawing.Size(712, 26);
            this.Consultas.TabIndex = 3;
            this.Consultas.Text = "consulta0ToolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 23);
            this.toolStripLabel1.Text = "Buscar por";
            // 
            // Combo_Ordena_por
            // 
            this.Combo_Ordena_por.AutoCompleteCustomSource.AddRange(new string[] {
            "Nombre",
            "Apellido",
            "e-mail"});
            this.Combo_Ordena_por.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "e-mail"});
            this.Combo_Ordena_por.Name = "Combo_Ordena_por";
            this.Combo_Ordena_por.Size = new System.Drawing.Size(75, 26);
            // 
            // Combo_abcd
            // 
            this.Combo_abcd.AutoCompleteCustomSource.AddRange(new string[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "Ñ",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.Combo_abcd.DropDownWidth = 30;
            this.Combo_abcd.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "Ñ",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.Combo_abcd.Name = "Combo_abcd";
            this.Combo_abcd.Size = new System.Drawing.Size(75, 26);
            // 
            // Boton_buscar
            // 
            this.Boton_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Boton_buscar.Image = ((System.Drawing.Image)(resources.GetObject("Boton_buscar.Image")));
            this.Boton_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Boton_buscar.Name = "Boton_buscar";
            this.Boton_buscar.Size = new System.Drawing.Size(49, 23);
            this.Boton_buscar.Text = "Buscar";
            this.Boton_buscar.Click += new System.EventHandler(this.Boton_buscar_Click_1);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(124, 23);
            this.toolStripLabel2.Text = "                             ";
            // 
            // Boton_Enviar_Mensaje
            // 
            this.Boton_Enviar_Mensaje.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Boton_Enviar_Mensaje.Image = ((System.Drawing.Image)(resources.GetObject("Boton_Enviar_Mensaje.Image")));
            this.Boton_Enviar_Mensaje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Boton_Enviar_Mensaje.Name = "Boton_Enviar_Mensaje";
            this.Boton_Enviar_Mensaje.Size = new System.Drawing.Size(154, 23);
            this.Boton_Enviar_Mensaje.Text = "Enviar Correo Electronico";
            this.Boton_Enviar_Mensaje.Click += new System.EventHandler(this.Boton_Enviar_Mensaje_Click);
            // 
            // agenda_TelefonicaTableAdapter
            // 
            this.agenda_TelefonicaTableAdapter.ClearBeforeFill = true;
            // 
            // Visual_Datos
            // 
            this.Visual_Datos.AutoGenerateColumns = false;
            this.Visual_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Visual_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numRegDataGridViewTextBoxColumn,
            this.telefonoFijoDataGridViewTextBoxColumn,
            this.telefonoMovilDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.Visual_Datos.DataSource = this.agendaTelefonicaBindingSource;
            this.Visual_Datos.Location = new System.Drawing.Point(0, 55);
            this.Visual_Datos.Name = "Visual_Datos";
            this.Visual_Datos.Size = new System.Drawing.Size(712, 278);
            this.Visual_Datos.TabIndex = 4;
            // 
            // agendaTelefonicaBindingSource2
            // 
            this.agendaTelefonicaBindingSource2.DataMember = "Agenda_Telefonica";
            this.agendaTelefonicaBindingSource2.DataSource = this.bD_Proj_AgendaDataSet;
            // 
            // numRegDataGridViewTextBoxColumn
            // 
            this.numRegDataGridViewTextBoxColumn.DataPropertyName = "Num_Reg";
            this.numRegDataGridViewTextBoxColumn.HeaderText = "Registro";
            this.numRegDataGridViewTextBoxColumn.Name = "numRegDataGridViewTextBoxColumn";
            this.numRegDataGridViewTextBoxColumn.ReadOnly = true;
            this.numRegDataGridViewTextBoxColumn.Width = 45;
            // 
            // telefonoFijoDataGridViewTextBoxColumn
            // 
            this.telefonoFijoDataGridViewTextBoxColumn.DataPropertyName = "Telefono Fijo";
            this.telefonoFijoDataGridViewTextBoxColumn.HeaderText = "Telefono Fijo";
            this.telefonoFijoDataGridViewTextBoxColumn.Name = "telefonoFijoDataGridViewTextBoxColumn";
            this.telefonoFijoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoMovilDataGridViewTextBoxColumn
            // 
            this.telefonoMovilDataGridViewTextBoxColumn.DataPropertyName = "Telefono Movil";
            this.telefonoMovilDataGridViewTextBoxColumn.HeaderText = "Telefono Movil";
            this.telefonoMovilDataGridViewTextBoxColumn.Name = "telefonoMovilDataGridViewTextBoxColumn";
            this.telefonoMovilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombre(s)";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombre(s)";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "e-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "e-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Formulario_Visual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 334);
            this.Controls.Add(this.Visual_Datos);
            this.Controls.Add(this.Consultas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formulario_Visual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizacion de Agenda";
            this.Load += new System.EventHandler(this.Formulario_Visual_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaTelefonicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Proj_AgendaDataSet)).EndInit();
            this.Consultas.ResumeLayout(false);
            this.Consultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Visual_Datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaTelefonicaBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Boton_Menu_Regresar;
        private System.Windows.Forms.ToolStripMenuItem Boton_Menu_Salir;
        private BD_Proj_AgendaDataSet bD_Proj_AgendaDataSet;
        private System.Windows.Forms.BindingSource agendaTelefonicaBindingSource;
        private BD_Proj_AgendaDataSetTableAdapters.Agenda_TelefonicaTableAdapter agenda_TelefonicaTableAdapter;
        private System.Windows.Forms.ToolStripButton consulta0ToolStripButton;
        private System.Windows.Forms.ToolStrip Consultas;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox Combo_Ordena_por;
        private System.Windows.Forms.ToolStripComboBox Combo_abcd;
        private System.Windows.Forms.DataGridView Visual_Datos;
        private System.Windows.Forms.BindingSource agendaTelefonicaBindingSource2;
        private System.Windows.Forms.ToolStripButton Boton_buscar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton Boton_Enviar_Mensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn numRegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoFijoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoMovilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}