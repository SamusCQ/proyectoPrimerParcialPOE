using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TallerProyecto.Controller;
using TallerProyecto.Model;

namespace TallerProyecto.View
{
    public partial class FrmVehiculo : Form
    {
        private VehiculoController vehiculoController;
        private ClienteController clienteController;

        public FrmVehiculo(VehiculoController vehiculoCtrl, ClienteController clienteCtrl)
        {
            InitializeComponent();
            vehiculoController = vehiculoCtrl;
            clienteController = clienteCtrl;
            CargarClientes();
        }

        private void CargarClientes()
        {
            comboBoxClientes.DataSource = clienteController.ObtenerClientes();
            comboBoxClientes.DisplayMember = "Nombres";
        }

        private void InitializeComponent()
        {
            txtPlaca = new TextBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            comboBoxClientes = new ComboBox();
            groupBox1 = new GroupBox();
            txtAño = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAño).BeginInit();
            SuspendLayout();
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(183, 45);
            txtPlaca.MaxLength = 8;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(100, 23);
            txtPlaca.TabIndex = 0;
            txtPlaca.KeyPress += txtPlaca_KeyPress;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(183, 96);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 1;
            txtMarca.KeyPress += txtMarca_KeyPress;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(183, 147);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 3;
            txtModelo.KeyPress += txtModelo_KeyPress;
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(183, 237);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(100, 23);
            comboBoxClientes.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAño);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxClientes);
            groupBox1.Controls.Add(txtPlaca);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 301);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vehiculo";
            // 
            // txtAño
            // 
            txtAño.Location = new Point(183, 187);
            txtAño.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            txtAño.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(100, 23);
            txtAño.TabIndex = 10;
            txtAño.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 237);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 9;
            label5.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 189);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 8;
            label4.Text = "Año";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 141);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 7;
            label3.Text = "Modelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 93);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Marca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 45);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 5;
            label1.Text = "Placa";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(132, 329);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(250, 329);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmVehiculo
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(471, 378);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox1);
            Name = "FrmVehiculo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAño).EndInit();
            ResumeLayout(false);
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Cliente clienteSeleccionado = (Cliente)comboBoxClientes.SelectedItem;
                Vehiculo nuevoVehiculo = new Vehiculo
                {
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Placa = txtPlaca.Text,
                    Año = (int)txtAño.Value,
                    Cliente = clienteSeleccionado
                };

                vehiculoController.RegistrarVehiculo(nuevoVehiculo);
                clienteSeleccionado.Vehiculos.Add(nuevoVehiculo); 

                MessageBox.Show("Vehículo registrado correctamente.");
                LimpiarCampos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtPlaca.Text) || txtPlaca.Text.Length < 8)
            {
                MessageBox.Show("Por favor, ingrese una placa válida de al menos 8 caracteres.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMarca.Text) || !txtMarca.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Por favor, ingrese una marca válida.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtModelo.Text) || !txtModelo.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Por favor, ingrese un modelo válido.");
                return false;
            }

            if (comboBoxClientes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, Registre un cliente.");
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtPlaca.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtAño.Value = 2023;
            comboBoxClientes.SelectedIndex = -1;
        }

        private TextBox txtPlaca;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private ComboBox comboBoxClientes;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGuardar;
        private NumericUpDown txtAño;
        private Button btnCancelar;
    }
}
