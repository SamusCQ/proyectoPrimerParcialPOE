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
    public partial class FrmMecanico : Form
    {
        private MecanicoController mecanicoController;

        public FrmMecanico(MecanicoController controller)
        {
            InitializeComponent();
            mecanicoController = controller;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Mecanico mecanico = new Mecanico
                {
                    Apellidos = txtApellidos.Text,
                    Nombres = txtNombres.Text,
                    Cedula = txtCedula.Text,
                    Especialidad = txtEspecialidad.Text,
                    AñosDeExperiencia = (int)txtAñosExperiencia.Value
                };

                mecanicoController.RegistrarMecanico(mecanico);

                MessageBox.Show("Mecánico registrado correctamente.");
                LimpiarCampos();
            }
        }

        private void InitializeComponent()
        {
            btnGuardar = new Button();
            txtApellidos = new TextBox();
            txtCedula = new TextBox();
            txtNombres = new TextBox();
            txtEspecialidad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAñosExperiencia = new NumericUpDown();
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)txtAñosExperiencia).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(121, 286);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(84, 37);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(100, 23);
            txtApellidos.TabIndex = 1;
            txtApellidos.KeyPress += txtApellidos_KeyPress;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(84, 86);
            txtCedula.MaxLength = 10;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(100, 23);
            txtCedula.TabIndex = 2;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(280, 37);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(100, 23);
            txtNombres.TabIndex = 3;
            txtNombres.KeyPress += txtNombres_KeyPress;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(280, 86);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(100, 23);
            txtEspecialidad.TabIndex = 4;
            txtEspecialidad.KeyPress += txtEspecialidad_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 41);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 6;
            label1.Text = "Apellidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 90);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 7;
            label2.Text = "Cedula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 41);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(202, 90);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 9;
            label4.Text = "Especialidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 139);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 10;
            label5.Text = "Años de Experiencia";
            // 
            // txtAñosExperiencia
            // 
            txtAñosExperiencia.Location = new Point(144, 137);
            txtAñosExperiencia.Name = "txtAñosExperiencia";
            txtAñosExperiencia.Size = new Size(120, 23);
            txtAñosExperiencia.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAñosExperiencia);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEspecialidad);
            groupBox1.Controls.Add(txtCedula);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 251);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mecanico";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(252, 286);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmMecanico
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(471, 378);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(btnGuardar);
            Name = "FrmMecanico";
            ((System.ComponentModel.ISupportInitialize)txtAñosExperiencia).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private Button btnGuardar;
        private TextBox txtApellidos;
        private TextBox txtCedula;
        private TextBox txtEspecialidad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown txtAñosExperiencia;
        private GroupBox groupBox1;
        private Button btnCancelar;
        private TextBox txtNombres;

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

        private void txtEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text) || !txtNombres.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Por favor, ingrese un nombre válido.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidos.Text) || !txtApellidos.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Por favor, ingrese un apellido válido.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCedula.Text) || txtCedula.Text.Length != 10 || !txtCedula.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese una cédula válida de 10 dígitos.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEspecialidad.Text) || !txtEspecialidad.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Por favor, ingrese una especialidad válida.");
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCedula.Clear();
            txtEspecialidad.Clear();
            txtAñosExperiencia.Value = 0;
        }
    }
}
