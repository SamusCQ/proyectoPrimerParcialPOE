using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TallerProyecto.Controller;

namespace TallerProyecto.View
{
    public partial class FrmConsultaMecanicos : Form
    {
        private MecanicoController mecanicoController;

        public FrmConsultaMecanicos(MecanicoController mecanicoCtrl)
        {
            InitializeComponent();
            mecanicoController = mecanicoCtrl;
            CargarDatos();
        }

        private void InitializeComponent()
        {
            dataGridViewMecanicos = new DataGridView();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMecanicos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMecanicos
            // 
            dataGridViewMecanicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMecanicos.Location = new Point(6, 22);
            dataGridViewMecanicos.Name = "dataGridViewMecanicos";
            dataGridViewMecanicos.Size = new Size(435, 283);
            dataGridViewMecanicos.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewMecanicos);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 354);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mecanico";
            // 
            // FrmConsultaMecanicos
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(471, 378);
            Controls.Add(groupBox1);
            Name = "FrmConsultaMecanicos";
            Text = "Consulta de Mecánicos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMecanicos).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private GroupBox groupBox1;
        private DataGridView dataGridViewMecanicos;

        private void CargarDatos()
        {
            dataGridViewMecanicos.DataSource = mecanicoController.ObtenerMecanicos();
        }
    }
}