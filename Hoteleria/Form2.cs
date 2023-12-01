using Entidades_de_Negocio_BE;
using Reglas_de_Negocio_BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoteleria
{
    public partial class Form2 : Form
    {
        BLLReservas bllReservas = BLLReservas.GetInstance(); 
        BLLClientes bllClientes = BLLClientes.GetInstance(); 
        BEReservas beReservas;
        BEClientes beClientes;
        public Form2()
        {
            InitializeComponent();
            beReservas = new BEReservas();
            beClientes = new BEClientes();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            calendar1.Visible=false;    
            calendar2.Visible=false;

            calendar1.MinDate = DateTime.Today; //que tome la fecha de hoy
            calendar2.MinDate = DateTime.Today; 

            cargarComboBoxClientes(); 

        }

        public void cargarComboBoxClientes()
        {
            List<BEClientes> listaClientes = bllClientes.ObtenerClientes();

            var datosCompletos = listaClientes.Select(cliente => bllClientes.ObtenerDatosCompletos(cliente)).ToList(); 
            
            // Muestra en el combobox los datos
            comBoxCliente.DataSource = datosCompletos;
          
            // Desselecciona cualquier elemento actualmente seleccionado
            Limpieza();
        }

        private void calendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = calendar1.SelectionStart;
            txtCheckIn.Text = selectedDate.ToString("dd/MM/yyyy");

            // Cuando se cambia la fecha en calendar1
            DateTime fechaSeleccionada = calendar1.SelectionStart;

            // fecha minima en calendar2 como el día siguiente a la fecha seleccionada en calendar1
            calendar2.MinDate = fechaSeleccionada.AddDays(1);

            calcularDias();
        }

        private void txtCheckIn_Click(object sender, EventArgs e)
        {
            calendar1.Visible = true;
            calendar2.Visible = true;

        }

        private void calendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = calendar2.SelectionStart;
            txtCheckOut.Text = selectedDate.ToString("dd/MM/yyyy");

            calcularDias();
        }

        public void calcularDias()
        {
            // Obtener las fechas seleccionadas en los calendarios
            DateTime fechaCheckIn = calendar1.SelectionStart;
            DateTime fechaCheckOut = calendar2.SelectionStart;

            // Llamar al método en la capa de reglas de negocio (BLL)
            int cantidadDias = bllReservas.CalcularCantidadDias(fechaCheckIn, fechaCheckOut);

            // Mostrar la cantidad de días en el TextBox
            txtCantDias.Text = cantidadDias.ToString();
        }

        private void btnAceptarReserva_Click(object sender, EventArgs e)
        {
            try
                {
                // Obtén el ID del cliente desde el TextBox
                int ClienteSeleccionado = Convert.ToInt32(txtId.Text);

                // Asigna el cliente a la reserva
                beReservas.ID_cliente = ClienteSeleccionado;

                beReservas.Cant_noches = Convert.ToInt32(txtCantDias.Text);
                beReservas.Cant_habitaciones = Convert.ToInt32(txtCantHab.Text);
                beReservas.Cant_adultos = Convert.ToInt32(txtCantAdultos.Text);
                beReservas.Cant_menores = Convert.ToInt32(txtCantMenores.Text);
                beReservas.Tipo_habitacion = CboxTipoHab.Text;
                beReservas.Check_in = DateTime.Parse(txtCheckIn.Text).Date;
                beReservas.Check_out = DateTime.Parse(txtCheckOut.Text).Date;
                beReservas.Tipo_cama = CboxTipoCama.Text;
                beReservas.Monto_aproximado = Int32.Parse(txtBMontoCalc.Text);

                bllReservas.AgregarReserva(beReservas);
                Limpieza();
                Close();

                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    MessageBox.Show("Hubo un error al procesar la reserva: " + ex.Message);
                }
        }

        private void comBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxCliente.Items.Count > 0 && comBoxCliente.SelectedItem != null)
            {
                // Obtener el texto completo del ComboBox
                string textoCompleto = comBoxCliente.SelectedItem.ToString();


                if (comBoxCliente.SelectedItem != null && comBoxCliente.SelectedItem != DBNull.Value)
                {
                    // Dividir en partes
                    string[] partes = textoCompleto.Split(' ');

                    txtId.Text = partes[0];
                    textDni.Text = partes[1];
                    textNombre.Text = partes[2];
                    txtCuit.Text = partes[3];
                    textApellido.Text = partes[4];
                    txtFechanac.Text = partes[5];
                    txtTel.Text = partes[6];
                    txtLocalidad.Text = partes[7];
                    txtDire.Text = partes[8];
                    txtNac.Text = partes[9];
                    txtCorreo.Text = partes[10];
                }
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargarComboBoxClientes();
        }

        private void CboxTipoHab_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si txtCantHab y txtCantDias no estan vacios
            if (!string.IsNullOrEmpty(txtCantHab.Text) && !string.IsNullOrEmpty(txtCantDias.Text))
            {
                if (CboxTipoHab.SelectedItem != null)
                {
                    // Obtener el texto del elemento seleccionado
                    string opcionSeleccionada = CboxTipoHab.SelectedItem.ToString();

                    // Realizar calculo de lo que seleccione
                    int resultado = bllReservas.CalcularMontoPorTipoHabitacion(opcionSeleccionada);

                    int montoEstimado = int.Parse(txtCantHab.Text) * resultado * int.Parse(txtCantDias.Text);

                    // Muestrar el resultado en el Label
                    txtBMontoCalc.Text = montoEstimado.ToString();
                }

                else
                {
                    MessageBox.Show("Por favor, ingresa valores numéricos válidos en Cantidad de Habitaciones y Cantidad de Días.");
                }
                 
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Limpieza()
        {
            comBoxCliente.SelectedIndex = -1;
            textNombre.Clear();
            textApellido.Clear();
            textDni.Clear();
            txtCorreo.Clear();
            txtCuit.Clear();
            txtDire.Clear();
            txtId.Clear();
            txtNac.Clear();
            txtLocalidad.Clear();
            txtTel.Clear();
            txtDire.Clear();
            txtFechanac.Clear();
            txtCantAdultos.Clear();
            txtCantMenores.Clear();
            txtCantHab.Clear();
            txtCantDias.Clear();
            CboxTipoHab.SelectedIndex = -1;
            CboxTipoCama.SelectedIndex = -1;
        }
    }

       


    }

