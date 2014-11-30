namespace Proyecto_Agenda
{
    partial class Formulario_Edicion
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
            System.Windows.Forms.Label telefono_FijoLabel;
            System.Windows.Forms.Label telefono_MovilLabel;
            System.Windows.Forms.Label nombre_s_Label;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_Edicion));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Boton_Menu_Regresar = new System.Windows.Forms.ToolStripMenuItem();
            this.Boton_Menu_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.bD_Proj_AgendaDataSet = new Proyecto_Agenda.BD_Proj_AgendaDataSet();
            this.agenda_TelefonicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agenda_TelefonicaTableAdapter = new Proyecto_Agenda.BD_Proj_AgendaDataSetTableAdapters.Agenda_TelefonicaTableAdapter();
            this.tableAdapterManager = new Proyecto_Agenda.BD_Proj_AgendaDataSetTableAdapters.TableAdapterManager();
            this.agenda_TelefonicaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.agenda_TelefonicaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.agenda_TelefonicaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.telefono_FijoTextBox = new System.Windows.Forms.TextBox();
            this.telefono_MovilTextBox = new System.Windows.Forms.TextBox();
            this.nombre_s_TextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            telefono_FijoLabel = new System.Windows.Forms.Label();
            telefono_MovilLabel = new System.Windows.Forms.Label();
            nombre_s_Label = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Proj_AgendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenda_TelefonicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenda_TelefonicaBindingNavigator)).BeginInit();
            this.agenda_TelefonicaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agenda_TelefonicaDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // telefono_FijoLabel
            // 
            telefono_FijoLabel.AutoSize = true;
            telefono_FijoLabel.Location = new System.Drawing.Point(16, 11);
            telefono_FijoLabel.Name = "telefono_FijoLabel";
            telefono_FijoLabel.Size = new System.Drawing.Size(71, 13);
            telefono_FijoLabel.TabIndex = 2;
            telefono_FijoLabel.Text = "Telefono Fijo:";
            // 
            // telefono_MovilLabel
            // 
            telefono_MovilLabel.AutoSize = true;
            telefono_MovilLabel.Location = new System.Drawing.Point(16, 37);
            telefono_MovilLabel.Name = "telefono_MovilLabel";
            telefono_MovilLabel.Size = new System.Drawing.Size(80, 13);
            telefono_MovilLabel.TabIndex = 4;
            telefono_MovilLabel.Text = "Telefono Movil:";
            // 
            // nombre_s_Label
            // 
            nombre_s_Label.AutoSize = true;
            nombre_s_Label.Location = new System.Drawing.Point(16, 63);
            nombre_s_Label.Name = "nombre_s_Label";
            nombre_s_Label.Size = new System.Drawing.Size(58, 13);
            nombre_s_Label.TabIndex = 6;
            nombre_s_Label.Text = "Nombre(s):";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(316, 11);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 8;
            apellidosLabel.Text = "Apellidos:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(316, 37);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 10;
            direccionLabel.Text = "Direccion:";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(316, 63);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(37, 13);
            e_mailLabel.TabIndex = 12;
            e_mailLabel.Text = "e-mail:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Boton_Menu_Regresar,
            this.Boton_Menu_Salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Boton_Menu_Regresar
            // 
            this.Boton_Menu_Regresar.Name = "Boton_Menu_Regresar";
            this.Boton_Menu_Regresar.Size = new System.Drawing.Size(70, 22);
            this.Boton_Menu_Regresar.Text = "Visualizar";
            this.Boton_Menu_Regresar.Click += new System.EventHandler(this.Boton_Menu_Regresar_Click);
            // 
            // Boton_Menu_Salir
            // 
            this.Boton_Menu_Salir.Name = "Boton_Menu_Salir";
            this.Boton_Menu_Salir.Size = new System.Drawing.Size(43, 22);
            this.Boton_Menu_Salir.Text = "Salir";
            this.Boton_Menu_Salir.Click += new System.EventHandler(this.Boton_Menu_Salir_Click);
            // 
            // bD_Proj_AgendaDataSet
            // 
            this.bD_Proj_AgendaDataSet.DataSetName = "BD_Proj_AgendaDataSet";
            this.bD_Proj_AgendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agenda_TelefonicaBindingSource
            // 
            this.agenda_TelefonicaBindingSource.DataMember = "Agenda_Telefonica";
            this.agenda_TelefonicaBindingSource.DataSource = this.bD_Proj_AgendaDataSet;
            // 
            // agenda_TelefonicaTableAdapter
            // 
            this.agenda_TelefonicaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Agenda_TelefonicaTableAdapter = this.agenda_TelefonicaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Proyecto_Agenda.BD_Proj_AgendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // agenda_TelefonicaBindingNavigator
            // 
            this.agenda_TelefonicaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.agenda_TelefonicaBindingNavigator.BindingSource = this.agenda_TelefonicaBindingSource;
            this.agenda_TelefonicaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.agenda_TelefonicaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.agenda_TelefonicaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.agenda_TelefonicaBindingNavigatorSaveItem});
            this.agenda_TelefonicaBindingNavigator.Location = new System.Drawing.Point(0, 26);
            this.agenda_TelefonicaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.agenda_TelefonicaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.agenda_TelefonicaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.agenda_TelefonicaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.agenda_TelefonicaBindingNavigator.Name = "agenda_TelefonicaBindingNavigator";
            this.agenda_TelefonicaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.agenda_TelefonicaBindingNavigator.Size = new System.Drawing.Size(713, 25);
            this.agenda_TelefonicaBindingNavigator.TabIndex = 1;
            this.agenda_TelefonicaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(40, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // agenda_TelefonicaBindingNavigatorSaveItem
            // 
            this.agenda_TelefonicaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.agenda_TelefonicaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("agenda_TelefonicaBindingNavigatorSaveItem.Image")));
            this.agenda_TelefonicaBindingNavigatorSaveItem.Name = "agenda_TelefonicaBindingNavigatorSaveItem";
            this.agenda_TelefonicaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.agenda_TelefonicaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.agenda_TelefonicaBindingNavigatorSaveItem.Click += new System.EventHandler(this.agenda_TelefonicaBindingNavigatorSaveItem_Click_1);
            // 
            // agenda_TelefonicaDataGridView
            // 
            this.agenda_TelefonicaDataGridView.AutoGenerateColumns = false;
            this.agenda_TelefonicaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agenda_TelefonicaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.agenda_TelefonicaDataGridView.DataSource = this.agenda_TelefonicaBindingSource;
            this.agenda_TelefonicaDataGridView.Location = new System.Drawing.Point(12, 70);
            this.agenda_TelefonicaDataGridView.Name = "agenda_TelefonicaDataGridView";
            this.agenda_TelefonicaDataGridView.Size = new System.Drawing.Size(697, 220);
            this.agenda_TelefonicaDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Num_Reg";
            this.dataGridViewTextBoxColumn1.HeaderText = "Registro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 45;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Telefono Fijo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Telefono Fijo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telefono Movil";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefono Movil";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nombre(s)";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre(s)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Apellidos";
            this.dataGridViewTextBoxColumn5.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "e-mail";
            this.dataGridViewTextBoxColumn7.HeaderText = "e-mail";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(telefono_FijoLabel);
            this.panel1.Controls.Add(this.telefono_FijoTextBox);
            this.panel1.Controls.Add(telefono_MovilLabel);
            this.panel1.Controls.Add(this.telefono_MovilTextBox);
            this.panel1.Controls.Add(nombre_s_Label);
            this.panel1.Controls.Add(this.nombre_s_TextBox);
            this.panel1.Controls.Add(apellidosLabel);
            this.panel1.Controls.Add(this.apellidosTextBox);
            this.panel1.Controls.Add(direccionLabel);
            this.panel1.Controls.Add(this.direccionTextBox);
            this.panel1.Controls.Add(e_mailLabel);
            this.panel1.Controls.Add(this.e_mailTextBox);
            this.panel1.Location = new System.Drawing.Point(20, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 86);
            this.panel1.TabIndex = 3;
            // 
            // telefono_FijoTextBox
            // 
            this.telefono_FijoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agenda_TelefonicaBindingSource, "Telefono Fijo", true));
            this.telefono_FijoTextBox.Location = new System.Drawing.Point(102, 8);
            this.telefono_FijoTextBox.Name = "telefono_FijoTextBox";
            this.telefono_FijoTextBox.Size = new System.Drawing.Size(179, 20);
            this.telefono_FijoTextBox.TabIndex = 3;
            // 
            // telefono_MovilTextBox
            // 
            this.telefono_MovilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agenda_TelefonicaBindingSource, "Telefono Movil", true));
            this.telefono_MovilTextBox.Location = new System.Drawing.Point(102, 34);
            this.telefono_MovilTextBox.Name = "telefono_MovilTextBox";
            this.telefono_MovilTextBox.Size = new System.Drawing.Size(179, 20);
            this.telefono_MovilTextBox.TabIndex = 5;
            // 
            // nombre_s_TextBox
            // 
            this.nombre_s_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agenda_TelefonicaBindingSource, "Nombre(s)", true));
            this.nombre_s_TextBox.Location = new System.Drawing.Point(102, 60);
            this.nombre_s_TextBox.Name = "nombre_s_TextBox";
            this.nombre_s_TextBox.Size = new System.Drawing.Size(179, 20);
            this.nombre_s_TextBox.TabIndex = 7;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agenda_TelefonicaBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(402, 8);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(172, 20);
            this.apellidosTextBox.TabIndex = 9;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agenda_TelefonicaBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(402, 34);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(172, 20);
            this.direccionTextBox.TabIndex = 11;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agenda_TelefonicaBindingSource, "e-mail", true));
            this.e_mailTextBox.Location = new System.Drawing.Point(402, 60);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(172, 20);
            this.e_mailTextBox.TabIndex = 13;
            // 
            // Formulario_Edicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.agenda_TelefonicaDataGridView);
            this.Controls.Add(this.agenda_TelefonicaBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formulario_Edicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edicion de Agenda";
            this.Load += new System.EventHandler(this.Formulario_Edicion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Proj_AgendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenda_TelefonicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenda_TelefonicaBindingNavigator)).EndInit();
            this.agenda_TelefonicaBindingNavigator.ResumeLayout(false);
            this.agenda_TelefonicaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agenda_TelefonicaDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Boton_Menu_Regresar;
        private System.Windows.Forms.ToolStripMenuItem Boton_Menu_Salir;
        private BD_Proj_AgendaDataSet bD_Proj_AgendaDataSet;
        private System.Windows.Forms.BindingSource agenda_TelefonicaBindingSource;
        private BD_Proj_AgendaDataSetTableAdapters.Agenda_TelefonicaTableAdapter agenda_TelefonicaTableAdapter;
        private BD_Proj_AgendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator agenda_TelefonicaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton agenda_TelefonicaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView agenda_TelefonicaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox telefono_FijoTextBox;
        private System.Windows.Forms.TextBox telefono_MovilTextBox;
        private System.Windows.Forms.TextBox nombre_s_TextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
    }
}