using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practica3
{
    public partial class RelojDigital : Form
    {
        private TimeSpan m_DesfaseHorario = new TimeSpan(0);
        private RelojAnalogico m_RelojAnalogico = new RelojAnalogico();
        private bool m_DespertadorActivado = false;
        private const int MaxZonas = 4;

        public bool DespertadorActivado
        {
            get { return m_DespertadorActivado; }
            set
            {
                m_DespertadorActivado = value;
                OpcionesDespertadorActivar.Enabled = !m_DespertadorActivado;
                OpcionesDespertadorDesactivar.Enabled = m_DespertadorActivado;
            }
        }

        public int NúmeroZonas
        {
            get { return menuContextoZona.Items.Count - 3; }
        }

        public RelojDigital()
        {
            InitializeComponent();
            ct_HoraActual.Font = new Font("Arial", 12, FontStyle.Bold);
            ct_HoraActual.BackColor = Color.White;
            ct_HoraActual.ForeColor = Color.Blue;
            MostrarHoraActual();
        }

        private void RelojDigital_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.menuStrip1, Properties.Resources.mensajeBarraMenus);
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
            m_RelojAnalogico.Location = new Point(this.Right + 10, this.Top);
            m_RelojAnalogico.Show(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MostrarHoraActual();

            if (!DespertadorActivado)
                return;

            if (!ct_Alarma.HoraValida)
            {
                System.Diagnostics.Debug.WriteLine("Hora alarma no válida");
                return;
            }

            DateTime horaActual = DateTime.Now + m_DesfaseHorario;
            DateTime horaAlarma = ct_Alarma.Hora;
            int segundosActual = horaActual.Second + horaActual.Minute * 60 + horaActual.Hour * 3600;
            int segundosAlarma = horaAlarma.Second + horaAlarma.Minute * 60 + horaAlarma.Hour * 3600;

            if (segundosActual >= segundosAlarma)
            {
                if (segundosActual - segundosAlarma < 300)
                    System.Media.SystemSounds.Beep.Play();
            }
            else if (segundosAlarma - segundosActual > 86400 - 300)
            {
                System.Media.SystemSounds.Beep.Play();
            }
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

        private void OpcionesDespertadorActivar_Click(object sender, EventArgs e)
        {
            this.DespertadorActivado = true;
        }

        private void OpcionesDespertadorDesactivar_Click(object sender, EventArgs e)
        {
            this.DespertadorActivado = false;
        }

        private void menuContextoZona_Opened(object sender, EventArgs e)
        {
            zonaAñadir.Visible = (this.NúmeroZonas < MaxZonas);
            zonaEliminar.Visible = (this.NúmeroZonas > 0);
            zonaSeparador.Visible = (this.NúmeroZonas > 0);
        }

        private void zonaAñadir_Click(object sender, EventArgs e)
        {
            if (this.NúmeroZonas == MaxZonas)
            {
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            ToolStripMenuItem zonaNueva = new ToolStripMenuItem();
            zonaNueva.Text = "Zona " + (this.NúmeroZonas + 1);
            zonaNueva.Click += new EventHandler(zona_Click);
            menuContextoZona.Items.Add(zonaNueva);
        }

        private void zonaEliminar_Click(object sender, EventArgs e)
        {
            if (this.NúmeroZonas == 0)
            {
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            menuContextoZona.Items.RemoveAt(menuContextoZona.Items.Count - 1);
        }

        private void zona_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                MessageBox.Show(item.Text, "Zona seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_ZonaHoraria_Click(object sender, EventArgs e)
        {
            DlgDatosZona dlg = new DlgDatosZona();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                string desfase = dlg.Diferencia.ToString();
                string signo = dlg.Positivo ? "Positivo" : "Negativo";
                MessageBox.Show("Nombre: " + dlg.Nombre + "\nDesfase: " + desfase + "\nSigno: " + signo,
                                "Datos de la zona", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
