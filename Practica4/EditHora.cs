using System;
using System.Windows.Forms;

namespace Practica4
{
    public class EditHora : MaskedTextBox
    {
        private DateTime m_Hora;

        public EditHora()
        {
            this.Mask = "90:00:99";
            this.TextAlign = HorizontalAlignment.Center;
            this.BeepOnError = true;
            this.PromptChar = '-';
            this.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        public DateTime Hora
        {
            get { return m_Hora; }
            set { m_Hora = value; }
        }

        public bool HoraValida
        {
            get
            {
                if (!this.MaskCompleted)
                    return false;

                string aux = this.Text.Replace(this.PromptChar, '0');
                DateTime hora;
                if (!DateTime.TryParse(aux, out hora))
                    return false;

                this.Hora = hora;
                return true;
            }
        }
    }
}
