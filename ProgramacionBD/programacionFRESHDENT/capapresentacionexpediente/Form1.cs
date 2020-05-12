using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using capaNegocio;

namespace capapresentacionexpediente
{
    public partial class Form1 : Form
    {
        logicaNegocioExpediente logicaNRP = new logicaNegocioExpediente();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (buttonguardar.Text == "Guardar")
                {
                    Expediente objetoRegistroPaciente = new Expediente();
                    objetoRegistroPaciente.Nombre = textBoxnombre.Text;
                    objetoRegistroPaciente.Apellido = textBoxapellido.Text;
                    objetoRegistroPaciente.Departamento = textBoxdepartamento.Text;
                    objetoRegistroPaciente.Municipio = textBoxmunicipio.Text;
                    objetoRegistroPaciente.Celular = Convert.ToInt32(textBoxcelular.Text);
                    objetoRegistroPaciente.Cedula = textBoxcedula.Text;
                    objetoRegistroPaciente.FechaNacimiento = Convert.ToInt32(textBoxfechnac.Text);
                   

                    if (logicaNRP.insertarExpediente(objetoRegistroPaciente) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewregpaciente.DataSource = logicaNRP.listarExpediente();
                        textBoxnombre.Text = "";
                        textBoxapellido.Text = "";
                        textBoxdepartamento.Text = "";
                        textBoxmunicipio.Text = "";
                        textBoxcelular.Text = "";
                        textBoxcedula.Text = "";
                        textBoxfechnac.Text = "";
                        tabControl1.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Paciente");
                    }

                }
                if (buttonguardar.Text == "ACTUALIZAR")
                {
                    Expediente objetoRegistroPaciente = new Expediente();
                    objetoRegistroPaciente.Nombre = textBoxnombre.Text;
                    objetoRegistroPaciente.Apellido = textBoxapellido.Text;
                    objetoRegistroPaciente.Departamento = textBoxdepartamento.Text;
                    objetoRegistroPaciente.Municipio = textBoxmunicipio.Text;
                    objetoRegistroPaciente.Celular = Convert.ToInt32(textBoxcelular.Text);
                    objetoRegistroPaciente.Cedula = textBoxcedula.Text;
                    objetoRegistroPaciente.FechaNacimiento = Convert.ToInt32(textBoxfechnac.Text);
                    MessageBox.Show("Actualizado con éxito");

                    if (logicaNRP.editarExpediente(objetoRegistroPaciente) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewregpaciente.DataSource = logicaNRP.listarExpediente();
                        textBoxnombre.Text = "";
                        textBoxapellido.Text = "";
                        textBoxdepartamento.Text = "";
                        textBoxmunicipio.Text = "";
                        textBoxcelular.Text = "";
                        textBoxcedula.Text = "";
                        textBoxfechnac.Text = "";
                        tabControl1.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Paciente");
                    }
                    buttonguardar.Text = "GUARDAR";
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
      