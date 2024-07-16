using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerProyecto.Controller;
using TallerProyecto.Model;

namespace TallerProyecto.View
{
    public partial class FrmMantenimiento : Form
    {
        private MantenimientoController mantenimientoController;
        private ClienteController clienteController;
        private ServicioController servicioController;
        private RepuestoController repuestoController;
        private MecanicoController mecanicoController;

        private Button btnRegistrarMantenimiento;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private GroupBox groupBox2;
        private ComboBox comboBoxCliente;
        private ComboBox comboBoxMecanico;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButtonCorrectivo;
        private RadioButton radioButtonPreventivo;
        private Button button1;
        private CheckedListBox checkedListBoxServicios;
        private ComboBox comboBoxVehiculo;
        private CheckedListBox checkedListBoxRepuestos;

        private Label label2;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;

        public FrmMantenimiento(MantenimientoController mantenimientoCtrl, ClienteController clienteCtrl, MecanicoController mecanicoCtrl)
        {
            InitializeComponent();
            mantenimientoController = mantenimientoCtrl;
            clienteController = clienteCtrl;
            mecanicoController = mecanicoCtrl;
            servicioController = new ServicioController();
            repuestoController = new RepuestoController();
            CargarDatos();
            checkedListBoxRepuestos.Visible = false;
        }

        private void InitializeComponent()
        {
            btnRegistrarMantenimiento = new Button();
            groupBox1 = new GroupBox();
            comboBoxVehiculo = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            comboBoxCliente = new ComboBox();
            comboBoxMecanico = new ComboBox();
            richTextBox1 = new RichTextBox();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            checkedListBoxRepuestos = new CheckedListBox();
            checkedListBoxServicios = new CheckedListBox();
            radioButtonCorrectivo = new RadioButton();
            radioButtonPreventivo = new RadioButton();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrarMantenimiento
            // 
            btnRegistrarMantenimiento.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            btnRegistrarMantenimiento.Location = new Point(163, 343);
            btnRegistrarMantenimiento.Name = "btnRegistrarMantenimiento";
            btnRegistrarMantenimiento.Size = new Size(75, 23);
            btnRegistrarMantenimiento.TabIndex = 0;
            btnRegistrarMantenimiento.Text = "Registrar";
            btnRegistrarMantenimiento.UseVisualStyleBackColor = true;
            btnRegistrarMantenimiento.Click += btnRegistrarMantenimiento_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxVehiculo);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBoxCliente);
            groupBox1.Controls.Add(comboBoxMecanico);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 158);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // comboBoxVehiculo
            // 
            comboBoxVehiculo.FormattingEnabled = true;
            comboBoxVehiculo.Location = new Point(320, 64);
            comboBoxVehiculo.Name = "comboBoxVehiculo";
            comboBoxVehiculo.Size = new Size(89, 23);
            comboBoxVehiculo.TabIndex = 14;
            comboBoxVehiculo.SelectedIndexChanged += comboBoxVehiculo_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(288, 119);
            dateTimePicker1.MaxDate = new DateTime(2099, 6, 16, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2024, 6, 16, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 23);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.Value = new DateTime(2024, 6, 16, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(85, 26);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(121, 23);
            comboBoxCliente.TabIndex = 12;
            comboBoxCliente.SelectedIndexChanged += comboBoxCliente_SelectedIndexChanged;
            // 
            // comboBoxMecanico
            // 
            comboBoxMecanico.FormattingEnabled = true;
            comboBoxMecanico.Location = new Point(288, 26);
            comboBoxMecanico.Name = "comboBoxMecanico";
            comboBoxMecanico.Size = new Size(121, 23);
            comboBoxMecanico.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(85, 70);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(121, 72);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 73);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 8;
            label9.Text = "Diagnostico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 67);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 4;
            label5.Text = "Datos del Vehiculo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 101);
            label4.Name = "label4";
            label4.Size = new Size(142, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha del Mantenimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 29);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 29);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Mecanico";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(85, 19);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 6;
            label7.Text = "Servicio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(288, 19);
            label6.Name = "label6";
            label6.Size = new Size(131, 15);
            label6.TabIndex = 5;
            label6.Text = "Tipo de Mantenimiento";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkedListBoxRepuestos);
            groupBox2.Controls.Add(checkedListBoxServicios);
            groupBox2.Controls.Add(radioButtonCorrectivo);
            groupBox2.Controls.Add(radioButtonPreventivo);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(12, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(447, 150);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mantenimiento";
            // 
            // checkedListBoxRepuestos
            // 
            checkedListBoxRepuestos.FormattingEnabled = true;
            checkedListBoxRepuestos.Location = new Point(273, 67);
            checkedListBoxRepuestos.Name = "checkedListBoxRepuestos";
            checkedListBoxRepuestos.Size = new Size(167, 76);
            checkedListBoxRepuestos.TabIndex = 12;
            // 
            // checkedListBoxServicios
            // 
            checkedListBoxServicios.FormattingEnabled = true;
            checkedListBoxServicios.Location = new Point(38, 37);
            checkedListBoxServicios.Name = "checkedListBoxServicios";
            checkedListBoxServicios.Size = new Size(168, 94);
            checkedListBoxServicios.TabIndex = 11;
            // 
            // radioButtonCorrectivo
            // 
            radioButtonCorrectivo.AutoSize = true;
            radioButtonCorrectivo.Location = new Point(360, 37);
            radioButtonCorrectivo.Name = "radioButtonCorrectivo";
            radioButtonCorrectivo.Size = new Size(80, 19);
            radioButtonCorrectivo.TabIndex = 9;
            radioButtonCorrectivo.TabStop = true;
            radioButtonCorrectivo.Text = "Correctivo";
            radioButtonCorrectivo.UseVisualStyleBackColor = true;
            radioButtonCorrectivo.CheckedChanged += radioButtonCorrectivo_CheckedChanged;
            // 
            // radioButtonPreventivo
            // 
            radioButtonPreventivo.AutoSize = true;
            radioButtonPreventivo.Location = new Point(273, 37);
            radioButtonPreventivo.Name = "radioButtonPreventivo";
            radioButtonPreventivo.Size = new Size(81, 19);
            radioButtonPreventivo.TabIndex = 8;
            radioButtonPreventivo.TabStop = true;
            radioButtonPreventivo.Text = "Preventivo";
            radioButtonPreventivo.UseVisualStyleBackColor = true;
            radioButtonPreventivo.CheckedChanged += radioButtonPreventivo_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            button1.Location = new Point(253, 343);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCancelar_Click;
            // 
            // FrmMantenimiento
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(471, 378);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnRegistrarMantenimiento);
            Name = "FrmMantenimiento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        private void btnRegistrarMantenimiento_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Cliente clienteSeleccionado = (Cliente)comboBoxCliente.SelectedItem;
                Mecanico mecanicoSeleccionado = (Mecanico)comboBoxMecanico.SelectedItem;
                Vehiculo vehiculoSeleccionado = (Vehiculo)comboBoxVehiculo.SelectedItem;

                var mantenimiento = new Mantenimiento
                {
                    Cliente = clienteSeleccionado,
                    Mecanico = mecanicoSeleccionado,
                    Vehiculo = vehiculoSeleccionado,
                    Servicios = ObtenerServiciosSeleccionados(),
                    Repuestos = ObtenerRepuestosSeleccionados(),
                    Descripcion = richTextBox1.Text,
                    Fecha = dateTimePicker1.Value
                };

                mantenimiento.CalcularPrecioTotal();
                mantenimientoController.RegistrarMantenimiento(mantenimiento);

                MessageBox.Show($"Mantenimiento registrado correctamente. Precio total: {mantenimiento.PrecioTotal:C}");

                LimpiarCampos();
            }
        }

        private bool ValidarDatos()
        {
            if (comboBoxCliente.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente.");
                return false;
            }

            if (comboBoxMecanico.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un mecánico.");
                return false;
            }

            if (comboBoxVehiculo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un vehículo.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Por favor, ingrese un diagnóstico.");
                return false;
            }

            if (dateTimePicker1.Value >= DateTime.Now)
            {
                MessageBox.Show("La fecha de mantenimiento no puede ser anterior a la fecha actual.");
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            comboBoxCliente.SelectedIndex = -1;
            comboBoxMecanico.SelectedIndex = -1;
            comboBoxVehiculo.SelectedIndex = -1;
            richTextBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
            checkedListBoxServicios.ClearSelected();
            foreach (int i in checkedListBoxServicios.CheckedIndices)
            {
                checkedListBoxServicios.SetItemCheckState(i, CheckState.Unchecked);
            }
            checkedListBoxRepuestos.ClearSelected();
            foreach (int i in checkedListBoxRepuestos.CheckedIndices)
            {
                checkedListBoxRepuestos.SetItemCheckState(i, CheckState.Unchecked);
            }
            radioButtonCorrectivo.Checked = false;
            radioButtonPreventivo.Checked = false;
        }

        private void CargarDatos()
        {
            comboBoxCliente.DataSource = clienteController.ObtenerClientes();
            comboBoxCliente.DisplayMember = "Nombres";
            comboBoxCliente.ValueMember = "Id";

            comboBoxMecanico.DataSource = mecanicoController.ObtenerMecanicos();
            comboBoxMecanico.DisplayMember = "Nombres";
            comboBoxMecanico.ValueMember = "Id";

            checkedListBoxServicios.DataSource = servicioController.ObtenerServicios();
            checkedListBoxServicios.DisplayMember = "Nombre";

            checkedListBoxRepuestos.DataSource = repuestoController.ObtenerRepuestos();
            checkedListBoxRepuestos.DisplayMember = "Nombre";
        }

        private List<Servicio> ObtenerServiciosSeleccionados()
        {
            var serviciosSeleccionados = new List<Servicio>();
            foreach (var item in checkedListBoxServicios.CheckedItems)
            {
                serviciosSeleccionados.Add((Servicio)item);
            }
            return serviciosSeleccionados;
        }

        private List<Repuesto> ObtenerRepuestosSeleccionados()
        {
            var repuestosSeleccionados = new List<Repuesto>();
            foreach (var item in checkedListBoxRepuestos.CheckedItems)
            {
                repuestosSeleccionados.Add((Repuesto)item);
            }
            return repuestosSeleccionados;
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)comboBoxCliente.SelectedItem;
            if (clienteSeleccionado != null)
            {
                var vehiculos = clienteController.ObtenerVehiculosDeCliente(clienteSeleccionado);
                comboBoxVehiculo.DataSource = vehiculos;
                comboBoxVehiculo.DisplayMember = "Modelo";
                comboBoxVehiculo.ValueMember = "Id";
                if (vehiculos.Count > 0)
                {
                    comboBoxVehiculo.SelectedIndex = 0;
                }
            }
            else
            {
                comboBoxVehiculo.DataSource = null;
            }
        }

        private void radioButtonPreventivo_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBoxRepuestos.Visible = false;
            checkedListBoxRepuestos.ClearSelected();
        }

        private void radioButtonCorrectivo_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBoxRepuestos.Visible = true;
        }

        private void comboBoxVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
