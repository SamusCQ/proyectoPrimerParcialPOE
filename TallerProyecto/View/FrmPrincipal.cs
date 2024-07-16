using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerProyecto.Controller;

namespace TallerProyecto.View
{
    public partial class FrmPrincipal : Form
    {
        private ClienteController clienteController;
        private MecanicoController mecanicoController;
        private MantenimientoController mantenimientoController;
        private VehiculoController vehiculoController;

        private Button btnRegistrarMecanico;
        private Button btnRegistrarMantenimiento;
        private Panel panelVentanas;
        private Panel panelOpciones;
        private Button btnRegistrarCliente;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnMantenimientos;
        private Button btnClientes;
        private Button btnMecanicos;
        private Button btnVehiculos;
        private Button btnIntegrantes;
        private Button btnRegistrarVehiculo;

        public FrmPrincipal(ClienteController clienteCtrl, MecanicoController mecanicoCtrl, MantenimientoController mantenimientoCtrl, VehiculoController vehiculoCtrl)
        {
            InitializeComponent();
            clienteController = clienteCtrl;
            mecanicoController = mecanicoCtrl;
            mantenimientoController = mantenimientoCtrl;
            vehiculoController = vehiculoCtrl;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            btnRegistrarMecanico = new Button();
            btnRegistrarMantenimiento = new Button();
            panelVentanas = new Panel();
            panelOpciones = new Panel();
            btnIntegrantes = new Button();
            groupBox2 = new GroupBox();
            btnVehiculos = new Button();
            btnMantenimientos = new Button();
            btnClientes = new Button();
            btnMecanicos = new Button();
            groupBox1 = new GroupBox();
            btnRegistrarVehiculo = new Button();
            btnRegistrarCliente = new Button();
            panelOpciones.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrarMecanico
            // 
            btnRegistrarMecanico.Location = new Point(12, 22);
            btnRegistrarMecanico.Name = "btnRegistrarMecanico";
            btnRegistrarMecanico.Size = new Size(134, 32);
            btnRegistrarMecanico.TabIndex = 0;
            btnRegistrarMecanico.Text = "Registrar Mecanico";
            btnRegistrarMecanico.UseVisualStyleBackColor = true;
            btnRegistrarMecanico.Click += btnRegistrarMecanico_Click_1;
            // 
            // btnRegistrarMantenimiento
            // 
            btnRegistrarMantenimiento.Font = new Font("ROG Fonts", 8F);
            btnRegistrarMantenimiento.Location = new Point(12, 139);
            btnRegistrarMantenimiento.Name = "btnRegistrarMantenimiento";
            btnRegistrarMantenimiento.Size = new Size(134, 38);
            btnRegistrarMantenimiento.TabIndex = 1;
            btnRegistrarMantenimiento.Text = "Registrar Mantenimiento";
            btnRegistrarMantenimiento.UseVisualStyleBackColor = true;
            btnRegistrarMantenimiento.Click += btnRegistrarMantenimiento_Click_1;
            // 
            // panelVentanas
            // 
            panelVentanas.BackgroundImage = (Image)resources.GetObject("panelVentanas.BackgroundImage");
            panelVentanas.BackgroundImageLayout = ImageLayout.Stretch;
            panelVentanas.Location = new Point(205, 12);
            panelVentanas.Name = "panelVentanas";
            panelVentanas.Size = new Size(487, 417);
            panelVentanas.TabIndex = 4;
            // 
            // panelOpciones
            // 
            panelOpciones.Controls.Add(btnIntegrantes);
            panelOpciones.Controls.Add(groupBox2);
            panelOpciones.Controls.Add(groupBox1);
            panelOpciones.Location = new Point(9, 12);
            panelOpciones.Name = "panelOpciones";
            panelOpciones.Size = new Size(190, 417);
            panelOpciones.TabIndex = 5;
            panelOpciones.Paint += panelOpciones_Paint;
            // 
            // btnIntegrantes
            // 
            btnIntegrantes.Font = new Font("ROG Fonts", 9F);
            btnIntegrantes.Location = new Point(32, 377);
            btnIntegrantes.Name = "btnIntegrantes";
            btnIntegrantes.Size = new Size(125, 23);
            btnIntegrantes.TabIndex = 5;
            btnIntegrantes.Text = "Integrantes";
            btnIntegrantes.UseVisualStyleBackColor = true;
            btnIntegrantes.Click += btnIntegrantes_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnVehiculos);
            groupBox2.Controls.Add(btnMantenimientos);
            groupBox2.Controls.Add(btnClientes);
            groupBox2.Controls.Add(btnMecanicos);
            groupBox2.Font = new Font("ROG Fonts", 9F);
            groupBox2.Location = new Point(18, 209);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(152, 147);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Consultar";
            // 
            // btnVehiculos
            // 
            btnVehiculos.Location = new Point(14, 83);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(125, 23);
            btnVehiculos.TabIndex = 3;
            btnVehiculos.Text = "Vehiculos";
            btnVehiculos.UseVisualStyleBackColor = true;
            btnVehiculos.Click += btnVehiculos_Click;
            // 
            // btnMantenimientos
            // 
            btnMantenimientos.Font = new Font("ROG Fonts", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMantenimientos.Location = new Point(6, 112);
            btnMantenimientos.Name = "btnMantenimientos";
            btnMantenimientos.Size = new Size(140, 27);
            btnMantenimientos.TabIndex = 2;
            btnMantenimientos.Text = "Mantenimientos";
            btnMantenimientos.UseVisualStyleBackColor = true;
            btnMantenimientos.Click += btnMantenimientos_Click;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(14, 54);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(125, 23);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click_1;
            // 
            // btnMecanicos
            // 
            btnMecanicos.Location = new Point(14, 22);
            btnMecanicos.Name = "btnMecanicos";
            btnMecanicos.Size = new Size(125, 26);
            btnMecanicos.TabIndex = 0;
            btnMecanicos.Text = "Mecanicos";
            btnMecanicos.UseVisualStyleBackColor = true;
            btnMecanicos.Click += btnMecanicos_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrarVehiculo);
            groupBox1.Controls.Add(btnRegistrarMecanico);
            groupBox1.Controls.Add(btnRegistrarMantenimiento);
            groupBox1.Controls.Add(btnRegistrarCliente);
            groupBox1.Font = new Font("ROG Fonts", 7F);
            groupBox1.Location = new Point(18, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(152, 185);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro";
            // 
            // btnRegistrarVehiculo
            // 
            btnRegistrarVehiculo.Location = new Point(12, 100);
            btnRegistrarVehiculo.Name = "btnRegistrarVehiculo";
            btnRegistrarVehiculo.Size = new Size(132, 33);
            btnRegistrarVehiculo.TabIndex = 3;
            btnRegistrarVehiculo.Text = "Registrar Vehiculo";
            btnRegistrarVehiculo.UseVisualStyleBackColor = true;
            btnRegistrarVehiculo.Click += btnRegistrarVehiculo_Click;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Location = new Point(12, 60);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(134, 34);
            btnRegistrarCliente.TabIndex = 2;
            btnRegistrarCliente.Text = "Registrar Cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click_1;
            // 
            // FrmPrincipal
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(704, 441);
            Controls.Add(panelVentanas);
            Controls.Add(panelOpciones);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            panelOpciones.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void btnRegistrarMecanico_Click_1(object sender, EventArgs e)
        {
            FrmMecanico frmMecanico = new FrmMecanico(mecanicoController);
            MostrarFormularioEnPanel(frmMecanico);
        }

        private void btnRegistrarMantenimiento_Click_1(object sender, EventArgs e)
        {
            FrmMantenimiento frmMantenimiento = new FrmMantenimiento(mantenimientoController, clienteController, mecanicoController);
            MostrarFormularioEnPanel(frmMantenimiento);
        }

        private void btnRegistrarCliente_Click_1(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente(clienteController);
            MostrarFormularioEnPanel(frmCliente);
        }

        private void btnRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            FrmVehiculo frmVehiculo = new FrmVehiculo(vehiculoController, clienteController);
            MostrarFormularioEnPanel(frmVehiculo);
        }

        private void MostrarFormularioEnPanel(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelVentanas.Controls.Clear();
            panelVentanas.Controls.Add(formulario);
            formulario.Show();
        }

        private void panelOpciones_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            FrmConsultaClientes frmConsultaClientes = new FrmConsultaClientes(clienteController);
            MostrarFormularioEnPanel(frmConsultaClientes);
        }

        private void btnMecanicos_Click(object sender, EventArgs e)
        {
            FrmConsultaMecanicos frmConsultaMecanicos = new FrmConsultaMecanicos(mecanicoController);
            MostrarFormularioEnPanel(frmConsultaMecanicos);
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            FrmConsultaVehiculos frmConsultaVehiculos = new FrmConsultaVehiculos(vehiculoController);
            MostrarFormularioEnPanel(frmConsultaVehiculos);
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            FrmConsultaMantenimientos frmConsultaMantenimientos = new FrmConsultaMantenimientos(mantenimientoController);
            MostrarFormularioEnPanel(frmConsultaMantenimientos);
        }

        private void btnIntegrantes_Click(object sender, EventArgs e)
        {
            string texto = "Integrantes:\n- Samuel Cedeño Q\n- Hillary Manjarres\n- Francisco Calderon";

            MessageBox.Show(texto, "Integrantes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
