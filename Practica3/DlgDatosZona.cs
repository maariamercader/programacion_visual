using System;
using System.Windows.Forms;

namespace Practica3
{
    public partial class DlgDatosZona : Form
    {
        private string m_Nombre = "";
        private TimeSpan m_Diferencia = new TimeSpan();
        private bool m_Positivo = true;

        public string Nombre
        {
            get { return m_Nombre; }
            set { m_Nombre = value; }
        }

        public TimeSpan Diferencia
        {
            get { return m_Diferencia; }
            set { m_Diferencia = value; }
        }

        public bool Positivo
        {
            get { return m_Positivo; }
            set { m_Positivo = value; }
        }

        public DlgDatosZona()
        {
            InitializeComponent();
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            if (ct_Nombre.Text.Trim() != "")
            {
                this.Nombre = ct_Nombre.Text.Trim();
            }
            else
            {
                MessageBox.Show("Introduzca un nombre para la zona horaria", "Error en los datos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                ct_Nombre.Focus();
                return;
            }

            if (ct_Diferencia.HoraValida)
            {
                DateTime hora = ct_Diferencia.Hora;
                this.Diferencia = new TimeSpan(hora.Hour, hora.Minute, hora.Second);
            }
            else
            {
                MessageBox.Show("Introduzca una diferencia horaria válida", "Error en los datos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                ct_Diferencia.Focus();
                ct_Diferencia.SelectAll();
                return;
            }

            this.Positivo = rb_Positivo.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
