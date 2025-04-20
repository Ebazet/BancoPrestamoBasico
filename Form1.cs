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
    public partial class frm_Inicio : Form
    {
        public frm_Inicio()
        {
            InitializeComponent();
        }

        private void frm_Inicio_Load(object sender, EventArgs e)
        {
            btn_pedir_prestamo.Enabled = false;
        }

        private void controlBotones()
        {
            if (txt_nombre.Text.Trim() != string.Empty && txt_nombre.Text.All(char.IsLetter))
            {
                btn_pedir_prestamo.Enabled = true;
                errorProvider1.SetError(txt_nombre, "");
            }
            else
            {
                if (!(txt_nombre.Text.All(char.IsLetter)))
                {
                    errorProvider1.SetError(txt_nombre, "El nombre solo debe tener letras");
                }
                else
                {
                    errorProvider1.SetError(txt_nombre, "Debe introducir su nombre");
                }
                btn_pedir_prestamo.Enabled=false;
                txt_nombre.Focus();
            }
        }


        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_pedir_prestamo_Click(object sender, EventArgs e)
        {
            using (fmr_prestamos ventanaPrestamos = new fmr_prestamos(txt_nombre.Text)) 
            ventanaPrestamos.ShowDialog();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }
    }
}
