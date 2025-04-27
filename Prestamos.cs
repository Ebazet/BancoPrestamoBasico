using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoPrestamoBasico
{
    public partial class fmr_prestamos : Form
    {
        string nombreCliente;
        string[] sexo = { "Femenino", "Masculino" };
        string[] lugaresDisponibles;
        int[] cuotas = { 3, 6, 9, 12, 18 };
        Dictionary<int, double> interesesBase;

        public fmr_prestamos(string nombre)
        {
            InitializeComponent();
            nombreCliente = nombre;
            string listadoCiudades = Properties.Resources.lugares.ToString();
            lugaresDisponibles = listadoCiudades.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            interesesBase = new Dictionary<int, double>();
            int i;
            double intereses;

            for (i = 0, intereses = 3.0; i < cuotas.Length; i++, intereses += 0.5)
            {
                interesesBase[cuotas[i]] = intereses;
            }
        }
              

        private void fmr_prestamos_Load(object sender, EventArgs e)
        {
            popularCuotas();
            popularSexo();
            popularCiudades();
            lbl_saludo.Text += nombreCliente;
        }

        void popularCuotas()
        {
            for (int i = 0; i < cuotas.Length; i++)
            {
                cbx_cuotas.Items.Add(cuotas[i]);
            }
        }

        void popularSexo()
        {
            for (int i = 0; i < sexo.Length; i++)
            {
                cbx_sexo.Items.Add(sexo[i]);
            }
        }

        void popularCiudades()
        {
            for (int i = 0; i < lugaresDisponibles.Length; i++)
            {
                cbx_origen.Items.Add(lugaresDisponibles[i]);
            }

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double calcularInteres()
        {
            int cuotasPedidas = (int)cbx_cuotas.SelectedItem;
            string sexoSeleccionado = cbx_sexo.ToString().ToLower();
            string origenSeleccionado = cbx_origen.ToString().ToLower();
            double interes = interesesBase[cuotasPedidas];
            if (new[] { "Femenino" }.Contains(sexoSeleccionado))
            {
                interes += 0.3;
            }
            if (new[] { "rivendell", "tirion", "valinor", "hobbiton", "bree", "gondor" }.Contains(origenSeleccionado))
            {
                interes -= 0.3;
            }

            return interes;
        }

        int validaciones()
        {
            if ((cbx_sexo.SelectedIndex <= -1) || (cbx_origen.SelectedIndex <= -1))
            {
                return 1;
            }
            else
            {
                if (!(txt_monto.Text.All(char.IsDigit)) || (txt_monto.Text == "") || (cbx_cuotas.SelectedIndex <= -1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        private void btn_confirmarSolicitud_Click(object sender, EventArgs e)
        {
            switch (validaciones())
            {
                case 0:
                    {
                        errorProvider1.SetError(gbx_datosPersonales, "");
                        errorProvider1.SetError(gbx_detaPrestamo, "");
                        double interesMensual = calcularInteres();
                        double montoPedido = double.Parse(txt_monto.Text);
                        int cuotasPedidas = (int)cbx_cuotas.SelectedItem;
                        double interesesTotal = montoPedido * (interesMensual / 100) * cuotasPedidas;
                        double montoPagar = montoPedido + interesesTotal;
                        string mensaje = "Su préstamo por " + montoPedido + " en " + cuotasPedidas + " cuotas se consederá con un interés del " + interesMensual + "% mensual \nEl monto final ascienda a " + montoPagar;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Cálculo de intereses", buttons);
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(gbx_datosPersonales, "Completar todos los datos personales");
                        errorProvider1.SetError(gbx_detaPrestamo, "");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(gbx_datosPersonales, "");
                        errorProvider1.SetError(gbx_detaPrestamo, "Debe ingresar un monto númerico y una cantidad de cuotas");
                        break;
                    }
            }
        }


    }
}
