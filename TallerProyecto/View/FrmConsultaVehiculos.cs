using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TallerProyecto.Controller;

namespace TallerProyecto.View
{
    public partial class FrmConsultaVehiculos : Form
    {
        private VehiculoController vehiculoController;

        public FrmConsultaVehiculos(VehiculoController vehiculoCtrl)
        {
            InitializeComponent();
            vehiculoController = vehiculoCtrl;
            CargarDatos();
        }

        private void InitializeComponent()
        {
            dataGridViewVehiculos = new DataGridView();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewVehiculos
            // 
            dataGridViewVehiculos.AllowUserToAddRows = false;
            dataGridViewVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVehiculos.Location = new Point(6, 22);
            dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            dataGridViewVehiculos.Size = new Size(435, 298);
            dataGridViewVehiculos.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewVehiculos);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 354);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vehiculos";
            // 
            // FrmConsultaVehiculos
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(471, 378);
            Controls.Add(groupBox1);
            Name = "FrmConsultaVehiculos";
            Text = "Consulta de Vehículos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private GroupBox groupBox1;
        private DataGridView dataGridViewVehiculos;

        private void CargarDatos()
        {
            var vehiculos = vehiculoController.ObtenerVehiculos();
            var vehiculosBindingList = new BindingSource { DataSource = vehiculos };
            dataGridViewVehiculos.DataSource = vehiculosBindingList;

            
            dataGridViewVehiculos.Columns["Cliente"].Visible = false; 
            dataGridViewVehiculos.Columns["NombreCliente"].HeaderText = "Cliente";


            dataGridViewVehiculos.Columns["Id"].DisplayIndex = 0;
            dataGridViewVehiculos.Columns["Marca"].DisplayIndex = 1;
            dataGridViewVehiculos.Columns["Modelo"].DisplayIndex = 2;
            dataGridViewVehiculos.Columns["Placa"].DisplayIndex = 3;
            dataGridViewVehiculos.Columns["Año"].DisplayIndex = 4;
        }
    }
}