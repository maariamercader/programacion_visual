using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Practica4
{
    public partial class DlgEliminarZona : Form
    {
        private List<ZonaHoraria> m_Zonas;
        private int m_ZonaSeleccionada = -1;

        public int ZonaSeleccionada
        {
            get { return m_ZonaSeleccionada; }
        }

        public DlgEliminarZona()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
        }

        private void DlgEliminarZona_Load(object sender, EventArgs e)
        {
            RelojDigital principal = this.Owner as RelojDigital;
            if (principal != null)
            {
                m_Zonas = principal.Zonas;
                lb_Zonas.Items.Clear();
                foreach (ZonaHoraria z in m_Zonas)
                {
                    lb_Zonas.Items.Add(z.Nombre);
                }
                if (lb_Zonas.Items.Count > 0)
                {
                    lb_Zonas.SelectedIndex = 0;
                }
            }
        }

        private void lb_Zonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Zonas.SelectedItem == null || m_Zonas == null)
                return;

            string nombreZona = lb_Zonas.SelectedItem.ToString();
            ZonaHoraria zonaSeleccionada = m_Zonas.Find(
                delegate(ZonaHoraria zona)
                {
                    return zona.Nombre == nombreZona;
                }
            );

            if (zonaSeleccionada != null)
            {
                ct_Diferencia.Text = zonaSeleccionada.Diferencia.ToString();
                ct_Signo.Text = zonaSeleccionada.Positivo ? "Positivo" : "Negativo";
            }
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            m_ZonaSeleccionada = lb_Zonas.SelectedIndex;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
