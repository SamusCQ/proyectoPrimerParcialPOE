using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TallerProyecto.Controller;
using TallerProyecto.Model;

namespace TallerProyecto.View
{
    public partial class FrmConsultaMantenimientos : Form
    {
        private MantenimientoController mantenimientoController;

        public FrmConsultaMantenimientos(MantenimientoController mantenimientoCtrl)
        {
            InitializeComponent();
            mantenimientoController = mantenimientoCtrl;
            CargarDatos();
        }

        private void InitializeComponent()
        {
            dataGridViewMantenimientos = new DataGridView();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMantenimientos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMantenimientos
            // 
            dataGridViewMantenimientos.AllowUserToAddRows = false;
            dataGridViewMantenimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMantenimientos.Location = new Point(6, 22);
            dataGridViewMantenimientos.Name = "dataGridViewMantenimientos";
            dataGridViewMantenimientos.Size = new Size(435, 326);
            dataGridViewMantenimientos.TabIndex = 0;
            dataGridViewMantenimientos.CellFormatting += dataGridViewMantenimientos_CellFormatting;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewMantenimientos);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 354);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mantenimiento";
            // 
            // FrmConsultaMantenimientos
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(471, 378);
            Controls.Add(groupBox1);
            Name = "FrmConsultaMantenimientos";
            Text = "Consulta de Mantenimientos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMantenimientos).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private GroupBox groupBox1;
        private DataGridView dataGridViewMantenimientos;

        private void CargarDatos()
        {
            var mantenimientos = mantenimientoController.ObtenerMantenimientos();
            var mantenimientoBindingList = new BindingSource { DataSource = mantenimientos };
            dataGridViewMantenimientos.DataSource = mantenimientoBindingList;

            dataGridViewMantenimientos.AutoGenerateColumns = false;
            dataGridViewMantenimientos.Columns.Clear();

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                Name = "Id"
            };
            dataGridViewMantenimientos.Columns.Add(idColumn);

            DataGridViewTextBoxColumn clienteColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cliente",
                HeaderText = "Cliente",
                Name = "Cliente"
            };
            dataGridViewMantenimientos.Columns.Add(clienteColumn);

            DataGridViewTextBoxColumn mecanicoColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Mecanico",
                HeaderText = "Mecánico",
                Name = "Mecanico"
            };
            dataGridViewMantenimientos.Columns.Add(mecanicoColumn);

            DataGridViewTextBoxColumn vehiculoColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Vehiculo",
                HeaderText = "Vehículo",
                Name = "Vehiculo"
            };
            dataGridViewMantenimientos.Columns.Add(vehiculoColumn);

            DataGridViewTextBoxColumn serviciosColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Servicios",
                HeaderText = "Servicios",
                Name = "Servicios"
            };
            dataGridViewMantenimientos.Columns.Add(serviciosColumn);

            DataGridViewTextBoxColumn repuestosColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Repuestos",
                HeaderText = "Repuestos",
                Name = "Repuestos"
            };
            dataGridViewMantenimientos.Columns.Add(repuestosColumn);

            DataGridViewTextBoxColumn descripcionColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descripcion",
                HeaderText = "Descripción",
                Name = "Descripcion"
            };
            dataGridViewMantenimientos.Columns.Add(descripcionColumn);

            // Añadir columna para la fecha
            DataGridViewTextBoxColumn fechaColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Fecha",
                HeaderText = "Fecha",
                Name = "Fecha"
            };
            dataGridViewMantenimientos.Columns.Add(fechaColumn);
        }

        private void dataGridViewMantenimientos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewMantenimientos.Columns[e.ColumnIndex].Name == "Cliente" && e.Value != null)
            {
                e.Value = ((Cliente)e.Value).ToString();
            }
            else if (dataGridViewMantenimientos.Columns[e.ColumnIndex].Name == "Mecanico" && e.Value != null)
            {
                e.Value = ((Mecanico)e.Value).ToString();
            }
            else if (dataGridViewMantenimientos.Columns[e.ColumnIndex].Name == "Vehiculo" && e.Value != null)
            {
                e.Value = ((Vehiculo)e.Value).Modelo;
            }
            else if (dataGridViewMantenimientos.Columns[e.ColumnIndex].Name == "Servicios" && e.Value != null)
            {
                var servicios = (List<Servicio>)e.Value;
                e.Value = string.Join(", ", servicios.Select(s => s.Nombre));
            }
            else if (dataGridViewMantenimientos.Columns[e.ColumnIndex].Name == "Repuestos" && e.Value != null)
            {
                var repuestos = (List<Repuesto>)e.Value;
                e.Value = string.Join(", ", repuestos.Select(r => r.Nombre));
            }
            else if (dataGridViewMantenimientos.Columns[e.ColumnIndex].Name == "Fecha" && e.Value != null)
            {
                e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy");
            }
        }
    }
}



