using Entidades_de_Negocio_BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reglas_de_Negocio_BLL;

namespace Hoteleria
{
    public partial class btnListaReservas : Form
    {
        BLLClientes bllClientes = BLLClientes.GetInstance();
        BLLReservas bllReservas = BLLReservas.GetInstance();
        BEClientes beClientes;
        

        public btnListaReservas()
        {
            InitializeComponent();
            beClientes = new BEClientes();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (pReserva.Visible)
            {
                pReserva.Visible = false;
            }
            if (pCliente.Visible)
            {
                pCliente.Visible = false;
            }
        }
        #region Botones
        private void btnReserva_Click(object sender, EventArgs e)
        {
            if (!pReserva.Visible)
            {
                pReserva.Visible = true;

                pCliente.Visible = false;

                //pCliente.Height = 56;


            }
            else
            {
                pReserva.Visible = false;
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (!pCliente.Visible)
            {
                pCliente.Visible = true;
                pReserva.Visible = false;

            }
            else
            {
                pCliente.Visible = false;

            }
        }

        #endregion
      

        #region Metodos para Reservas
        Form2 form2 = new Form2();
        private void btnRealizarReserva_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ATENCION! Antes de hacer una reserva, por favor, registre los datos del cliente.");
            pReserva.Visible = false;
            if (bllClientes.ObtenerClientes().Count > 0)
            {
                if (form2.ShowDialog(this) == DialogResult.OK)
                {
                    form2.Owner = this;
                    pReserva.Visible = false;
                }
            }
            CargarGrilla(dataGridView2, bllReservas.CargarListaReservas());
        }

        private void btnListaReser_Click(object sender, EventArgs e)
        {
            pReserva.Visible = false;


            if (bllReservas.CargarListaReservas().Count > 0)
            {
                CargarGrilla(dataGridView2, bllReservas.CargarListaReservas());
            }
            else { MessageBox.Show("No hay reservas registradas"); }
        }

        #endregion


        #region Metodos para Clientes
        private void btnAceptarCliente_Click(object sender, EventArgs e)
        {
            //el ID es autocremental en la BD
            beClientes.Dni = Convert.ToInt32(txtDni.Text);
            beClientes.Nombre = txtNombre.Text;
            beClientes.CuitCuil = txtCuit.Text;
            beClientes.Apellido = txtApellido.Text;
            beClientes.FechaNac = txtNacim.Text;
            beClientes.Telefono = Convert.ToInt32(txtTelefono.Text);
            beClientes.Localidad = txtLocalidad.Text;
            beClientes.Direccion = txtDireccion.Text;
            beClientes.Nacionalidad = txtNacionalidad.Text;
            beClientes.Correo = txtCorreo.Text;

            bllClientes.AgregarCliente(beClientes);

            CargarGrilla(dataGridView1, bllClientes.CargarListaClientes());

            Limpiar();

        }
        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            pCliente.Visible = false;
            CargarGrilla(dataGridView1, bllClientes.CargarListaClientes());
        }

        private void btnModifCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();
                bllClientes.ModificarCliente(beClientes);
                CargarGrilla(dataGridView1, bllClientes.CargarListaClientes());
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al querer modificar los datos del cliente: " + ex.Message);
            }
        }
        #endregion
        private void CargarGrilla(DataGridView dgv, Object ob)
        {
            dgv.DataSource = null;
            //llamo metodo para cargar clientes
            dgv.DataSource = ob;
            //propiedad de la grilla para autosize de columnas
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //cambio color alternando las filas de la grilla
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(192,192,255);
        }
        #region Limpiar
        private void btnLimpiarData_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                pReserva.Visible = false;
                pCliente.Visible = false;

                this.dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
            }
            else { MessageBox.Show("No hay listas que limpiar"); }
        }

       
        private void LimpiarData2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count != 0)
            {
                pReserva.Visible = false;
                pCliente.Visible = false;

                this.dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
            }
            else { MessageBox.Show("No hay listas que limpiar"); }
        }

        void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtCorreo.Clear();
            txtCuit.Clear();
            txtDireccion.Clear();
            txtLocalidad.Clear();
            txtNacim.Clear();
            txtTelefono.Clear();
            txtNacionalidad.Clear();
        }
        #endregion
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            beClientes = (BEClientes)this.dataGridView1.CurrentRow.DataBoundItem;

            txtTelefono.Text = beClientes.Telefono.ToString();
            txtLocalidad.Text = beClientes.Localidad;
            txtDireccion.Text = beClientes.Direccion;
            txtCorreo.Text = beClientes.Correo;

        }

        void Asignar()
        {
            beClientes.Correo= txtCorreo.Text;
            beClientes.Direccion= txtDireccion.Text;
            beClientes.Localidad= txtLocalidad.Text;
            beClientes.Telefono= Convert.ToInt32(txtTelefono.Text);
        }

      
    }
}


        


