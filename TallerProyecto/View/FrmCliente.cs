using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TallerProyecto.Controller;
using TallerProyecto.Model;

namespace TallerProyecto.View
{
    public partial class FrmCliente : Form
    {
        private ClienteController clienteController;

        public FrmCliente(ClienteController controller)
        {
            InitializeComponent();
            clienteController = controller;
        }

        private TextBox txtApellidos;
        private TextBox txtNombres;
        private TextBox txtCedula;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnCancelar;
        private Button btnGuardar;

        private void InitializeComponent()
        {
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            txtCedula = new TextBox();
            btnGuardar = new Button();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(102, 34);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(100, 23);
            txtApellidos.TabIndex = 0;
            txtApellidos.KeyPress += txtApellidos_KeyPress;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(284, 34);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(100, 23);
            txtNombres.TabIndex = 1;
            txtNombres.KeyPress += txtNombres_KeyPress;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(102, 103);
            txtCedula.MaxLength = 10;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(100, 23);
            txtCedula.TabIndex = 2;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(114, 323);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(284, 103);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 4;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(103, 153);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(269, 23);
            txtCorreo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 38);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 6;
            label1.Text = "Apellidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 38);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 103);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 8;
            label3.Text = "Cedula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 103);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 9;
            label4.Text = "Celular";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 157);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 10;
            label5.Text = "Correo";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCedula);
            groupBox1.Location = new Point(12, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 224);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(252, 323);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmCliente
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(471, 378);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(btnGuardar);
            Name = "FrmCliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Cliente nuevoCliente = new Cliente
                {
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text,
                    Cedula = txtCedula.Text,
                    Correo = txtCorreo.Text,
                    Telefono = txtTelefono.Text
                };

                clienteController.RegistrarCliente(nuevoCliente);

                MessageBox.Show("Cliente registrado correctamente.");
                LimpiarCampos();
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text) || !txtNombres.Text.All(char.IsLetter))
            {
                MessageBox.Show("Ingrese un nombre válido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtApellidos.Text) || !txtApellidos.Text.All(char.IsLetter))
            {
                MessageBox.Show("Ingrese un apellido válido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCedula.Text) || txtCedula.Text.Length != 10 || !txtCedula.Text.All(char.IsDigit))
            {
                MessageBox.Show("Ingrese una cédula válida (10 dígitos).");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text) || txtTelefono.Text.Length != 10 || !txtTelefono.Text.All(char.IsDigit))
            {
                MessageBox.Show("Ingrese un número de teléfono válido (10 dígitos).");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !Regex.IsMatch(txtCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.");
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCedula.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
