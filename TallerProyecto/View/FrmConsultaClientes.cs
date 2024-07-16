using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerProyecto.Controller;

namespace TallerProyecto.View
{
    public partial class FrmConsultaClientes : Form
    {
        private ClienteController clienteController;

        public FrmConsultaClientes(ClienteController clienteCtrl)
        {
            InitializeComponent();
            clienteController = clienteCtrl;
            CargarDatos();
        }

        private void CargarDatos()
        {
            dataGridViewClientes.DataSource = clienteController.ObtenerClientes();
        }

        private void InitializeComponent()
        {
            dataGridViewClientes = new DataGridView();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(6, 22);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.Size = new Size(435, 288);
            dataGridViewClientes.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewClientes);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 316);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clientes";
            // 
            // FrmConsultaClientes
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(471, 378);
            Controls.Add(groupBox1);
            Name = "FrmConsultaClientes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private GroupBox groupBox1;
        private DataGridView dataGridViewClientes;
    }
}