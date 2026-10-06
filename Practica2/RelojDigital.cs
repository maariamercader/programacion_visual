using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practica2
{
    public partial class RelojDigital : Form
    {
        private TimeSpan m_DesfaseHorario = new TimeSpan(0);
        private RelojAnalogico m_RelojAnalogico = new RelojAnalogico();

        public RelojDigital()
        {
            InitializeComponent();
            
            // Estilo inicial de ct_HoraActual: Arial 12pt negrita, fondo blanco, texto azul
            ct_HoraActual.Font = new Font("Arial", 12, FontStyle.Bold);
            ct_HoraActual.BackColor = Color.White;
            ct_HoraActual.ForeColor = Color.Blue;

            MostrarHoraActual();
        }

        private void MostrarHoraActual()
        {
            DateTime hora = DateTime.Now + m_DesfaseHorario;
            ct_HoraActual.Text = hora.ToLongTimeString();
            m_RelojAnalogico.Hora = hora;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe dlg = new AcercaDe();
            dlg.ShowDialog();
        }

        private void RelojDigital_Shown(object sender, EventArgs e)
        {
            m_RelojAnalogico.Location = new Point(
                this.Right + 10,
                this.Top
            );
            m_RelojAnalogico.Show(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MostrarHoraActual();
        }

        private void opcionesToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            mostrarAnalogicoToolStripMenuItem.Checked = m_RelojAnalogico.Visible;
        }

        private void mostrarAnalogicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_RelojAnalogico.Visible = !m_RelojAnalogico.Visible;
        }

        private void colorFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.Color = ct_HoraActual.BackColor;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                ct_HoraActual.BackColor = dlgColor.Color;
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlgFuente = new FontDialog();
            dlgFuente.ShowColor = true;
            dlgFuente.Font = ct_HoraActual.Font;
            dlgFuente.Color = ct_HoraActual.ForeColor;
            if (dlgFuente.ShowDialog() == DialogResult.OK)
            {
                ct_HoraActual.Font = dlgFuente.Font;
                ct_HoraActual.ForeColor = dlgFuente.Color;
            }
        }

        internal void CambiarHora(int horas, int minutos, int segundos)
        {
            DateTime actual = DateTime.Now;
            DateTime hora = new DateTime(
                actual.Year,
                actual.Month,
                actual.Day,
                horas,
                minutos,
                segundos
            );
            m_DesfaseHorario = hora - actual;
            MostrarHoraActual();
        }
    }
}
