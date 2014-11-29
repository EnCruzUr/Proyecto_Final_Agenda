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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.consulta0ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.consulta0ToolStrip = new System.Windows.Forms.ToolStrip();
            this.numRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoFijoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoMovilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendaTelefonicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_Proj_AgendaDataSet = new Proyecto_Agenda.BD_Proj_AgendaDataSet();
            this.agenda_TelefonicaTableAdapter = new Proyecto_Agenda.BD_Proj_AgendaDataSetTableAdapters.Agenda_TelefonicaTableAdapter();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Combo_Ordena_por = new System.Windows.Forms.ToolStripComboBox();
            this.Combo_abcd = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.consulta0ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaTelefonicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Proj_AgendaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Boton_Menu_Regresar,
            this.Boton_Menu_Salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Boton_Menu_Regresar
            // 
            this.Boton_Menu_Regresar.Name = "Boton_Menu_Regresar";
            this.Boton_Menu_Regresar.Size = new System.Drawing.Size(68, 22);
            this.Boton_Menu_Regresar.Text = "Regresar";
            this.Boton_Menu_Regresar.Click += new System.EventHandler(this.Boton_Menu_Regresar_Click_1);
            // 
            // Boton_Menu_Salir
            // 
            this.Boton_Menu_Salir.Name = "Boton_Menu_Salir";
            this.Boton_Menu_Salir.Size = new System.Drawing.Size(43, 22);
            this.Boton_Menu_Salir.Text = "Salir";
            this.Boton_Menu_Salir.Click += new System.EventHandler(this.Boton_Menu_Salir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numRegDataGridViewTextBoxColumn,
            this.telefonoFijoDataGridViewTextBoxColumn,
            this.telefonoMovilDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.agendaTelefonicaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 257);
            this.dataGridView1.TabIndex = 2;
            // 
            // consulta0ToolStripButton
            // 
            this.consulta0ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.consulta0ToolStripButton.Name = "consulta0ToolStripButton";
            this.consulta0ToolStripButton.Size = new System.Drawing.Size(92, 23);
            this.consulta0ToolStripButton.Text = "Mostrar Todos";
            this.consulta0ToolStripButton.Click += new System.EventHandler(this.consulta0ToolStripButton_Click);
            // 
            // consulta0ToolStrip
            // 
            this.consulta0ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulta0ToolStripButton,
            this.toolStripLabel1,
            this.Combo_Ordena_por,
            this.Combo_abcd});
            this.consulta0ToolStrip.Location = new System.Drawing.Point(0, 26);
            this.consulta0ToolStrip.Name = "consulta0ToolStrip";
            this.consulta0ToolStrip.Size = new System.Drawing.Size(693, 26);
            this.consulta0ToolStrip.TabIndex = 3;
            this.consulta0ToolStrip.Text = "consulta0ToolStrip";
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
            // agenda_TelefonicaTableAdapter
            // 
            this.agenda_TelefonicaTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 23);
            this.toolStripLabel1.Text = "Ordenar por";
            // 
            // Combo_Ordena_por
            // 
            this.Combo_Ordena_por.AutoCompleteCustomSource.AddRange(new string[] {
            "Nombre",
            "Apellido",
            "Telefono",
            "e-mail"});
            this.Combo_Ordena_por.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "Telefono",
            "e-mail"});
            this.Combo_Ordena_por.MergeIndex = 1;
            this.Combo_Ordena_por.Name = "Combo_Ordena_por";
            this.Combo_Ordena_por.Size = new System.Drawing.Size(75, 26);
            this.Combo_Ordena_por.Click += new System.EventHandler(this.toolStripComboBox1_Click);
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
            "Z"});
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
            "Z"});
            this.Combo_abcd.MergeIndex = 1;
            this.Combo_abcd.Name = "Combo_abcd";
            this.Combo_abcd.Size = new System.Drawing.Size(75, 26);
            // 
            // Formulario_Visual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 334);
            this.Controls.Add(this.consulta0ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formulario_Visual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizacion de Agenda";
            this.Load += new System.EventHandler(this.Formulario_Visual_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.consulta0ToolStrip.ResumeLayout(false);
            this.consulta0ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaTelefonicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Proj_AgendaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Boton_Menu_Regresar;
        private System.Windows.Forms.ToolStripMenuItem Boton_Menu_Salir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BD_Proj_AgendaDataSet bD_Proj_AgendaDataSet;
        private System.Windows.Forms.BindingSource agendaTelefonicaBindingSource;
        private BD_Proj_AgendaDataSetTableAdapters.Agenda_TelefonicaTableAdapter agenda_TelefonicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numRegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoFijoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoMovilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton consulta0ToolStripButton;
        private System.Windows.Forms.ToolStrip consulta0ToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox Combo_Ordena_por;
        private System.Windows.Forms.ToolStripComboBox Combo_abcd;
    }
}