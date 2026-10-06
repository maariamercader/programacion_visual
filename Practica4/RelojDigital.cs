using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Practica4
{
    public partial class RelojDigital : Form
    {
        private TimeSpan m_DesfaseHorario = new TimeSpan(0);
        private RelojAnalogico m_RelojAnalogico = new RelojAnalogico();
        private bool m_DespertadorActivado = false;
        private List<ZonaHoraria> m_Zonas = new List<ZonaHoraria>();

        public bool DespertadorActivado
        {
            get { return m_DespertadorActivado; }
            set
            {
                m_DespertadorActivado = value;
                OpcionesDespertadorActivar.Enabled = !m_DespertadorActivado;
                OpcionesDespertadorDesactivar.Enabled = m_DespertadorActivado;
                cv_Despertador.Checked = m_DespertadorActivado;
            }
        }

        public int NúmeroZonas
        {
            get { return m_Zonas.Count; }
        }

        public List<ZonaHoraria> Zonas
        {
            get { return m_Zonas; }
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
            try
            {
                if (File.Exists("reloj.dat"))
                {
                    using (Stream stream = File.Open("reloj.dat", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        m_Zonas = (List<ZonaHoraria>)bin.Deserialize(stream);
                        foreach (ZonaHoraria nuevaZona in m_Zonas)
                        {
                            AñadirOrdenZona(nuevaZona);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo leer el archivo de zonas. Causa: " + ex.Message);
            }

            toolTip1.SetToolTip(this.menuStrip1, Properties.Resources.mensajeBarraMenus);
        }

        private void RelojDigital_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (Stream stream = File.Open("reloj.dat", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, m_Zonas);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo crear el archivo de zonas. Causa: " + ex.Message);
            }
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

        private void cv_Despertador_Click(object sender, EventArgs e)
        {
            this.DespertadorActivado = !this.DespertadorActivado;
        }

        private void menuContextoZona_Opened(object sender, EventArgs e)
        {
            zonaAñadir.Visible = true;
            zonaEliminar.Visible = (this.NúmeroZonas > 0);
            zonaSeparador.Visible = (this.NúmeroZonas > 0);
        }

        private void AñadirOrdenZona(ZonaHoraria nuevaZona)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(nuevaZona.Nombre);
            item.Click += new EventHandler(zona_Click);
            menuContextoZona.Items.Add(item);
        }

        private void zonaAñadir_Click(object sender, EventArgs e)
        {
            DlgDatosZona dlgZona = new DlgDatosZona();
            if (dlgZona.ShowDialog(this) == DialogResult.OK)
            {
                bool existe = m_Zonas.Exists(
                    delegate(ZonaHoraria zona)
                    {
                        return zona.Nombre.Equals(dlgZona.Nombre, StringComparison.OrdinalIgnoreCase);
                    }
                );

                if (existe)
                {
                    MessageBox.Show("Ya existe una zona llamada " + dlgZona.Nombre,
                                    "Zona existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ZonaHoraria nueva = new ZonaHoraria();
                nueva.Nombre = dlgZona.Nombre;
                nueva.Diferencia = dlgZona.Diferencia;
                nueva.Positivo = dlgZona.Positivo;

                m_Zonas.Add(nueva);
                AñadirOrdenZona(nueva);
            }
        }

        private void zonaEliminar_Click(object sender, EventArgs e)
        {
            if (m_Zonas.Count == 0)
            {
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            DlgEliminarZona dlg = new DlgEliminarZona();
            if (dlg.ShowDialog(this) == DialogResult.OK && dlg.ZonaSeleccionada >= 0 && dlg.ZonaSeleccionada < m_Zonas.Count)
            {
                int index = dlg.ZonaSeleccionada;
                m_Zonas.RemoveAt(index);
                menuContextoZona.Items.RemoveAt(3 + index);
            }
        }

        private void zona_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item == null) return;

            string nombreZona = item.Text;
            ZonaHoraria zona = m_Zonas.Find(
                delegate(ZonaHoraria z)
                {
                    return z.Nombre == nombreZona;
                }
            );

            if (zona != null)
            {
                DateTime baseHora = DateTime.Now + m_DesfaseHorario;
                DateTime horaZona = zona.Positivo
                    ? baseHora + zona.Diferencia
                    : baseHora - zona.Diferencia;
                MessageBox.Show("Hora en " + zona.Nombre + ": " + horaZona.ToLongTimeString(),
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
