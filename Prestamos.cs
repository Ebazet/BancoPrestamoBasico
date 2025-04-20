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
            lugaresDisponibles = listadoCiudades.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            interesesBase = new Dictionary<int, double>();
            int i;
            double intereses;

            for (i = 0, intereses = 3.0; i < cuotas.Length; i++, intereses += 0.5)
            {
                interesesBase[cuotas[i]] = intereses;
            }
        }

        private void btn_confirmarSolicitud_Click(object sender, EventArgs e)
        {

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
    }
}
