namespace Practica3
{
    partial class DlgDatosZona
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.ct_Nombre = new System.Windows.Forms.TextBox();
            this.lb_Diferencia = new System.Windows.Forms.Label();
            this.ct_Diferencia = new Practica3.EditHora();
            this.gb_Signo = new System.Windows.Forms.GroupBox();
            this.rb_Negativo = new System.Windows.Forms.RadioButton();
            this.rb_Positivo = new System.Windows.Forms.RadioButton();
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.gb_Signo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(20, 20);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(47, 13);
            this.lb_Nombre.TabIndex = 0;
            this.lb_Nombre.Text = "Nombre:";
            // 
            // ct_Nombre
            // 
            this.ct_Nombre.Location = new System.Drawing.Point(120, 17);
            this.ct_Nombre.Name = "ct_Nombre";
            this.ct_Nombre.Size = new System.Drawing.Size(180, 20);
            this.ct_Nombre.TabIndex = 1;
            // 
            // lb_Diferencia
            // 
            this.lb_Diferencia.AutoSize = true;
            this.lb_Diferencia.Location = new System.Drawing.Point(20, 60);
            this.lb_Diferencia.Name = "lb_Diferencia";
            this.lb_Diferencia.Size = new System.Drawing.Size(91, 13);
            this.lb_Diferencia.TabIndex = 2;
            this.lb_Diferencia.Text = "Diferencia horaria:";
            // 
            // ct_Diferencia
            // 
            this.ct_Diferencia.BeepOnError = true;
            this.ct_Diferencia.Hora = new System.DateTime(((long)(0)));
            this.ct_Diferencia.Location = new System.Drawing.Point(120, 57);
            this.ct_Diferencia.Mask = "90:00:99";
            this.ct_Diferencia.Name = "ct_Diferencia";
            this.ct_Diferencia.PromptChar = '-';
            this.ct_Diferencia.Size = new System.Drawing.Size(75, 20);
            this.ct_Diferencia.TabIndex = 3;
            this.ct_Diferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ct_Diferencia.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // gb_Signo
            // 
            this.gb_Signo.Controls.Add(this.rb_Negativo);
            this.gb_Signo.Controls.Add(this.rb_Positivo);
            this.gb_Signo.Location = new System.Drawing.Point(205, 45);
            this.gb_Signo.Name = "gb_Signo";
            this.gb_Signo.Size = new System.Drawing.Size(95, 65);
            this.gb_Signo.TabIndex = 4;
            this.gb_Signo.TabStop = false;
            this.gb_Signo.Text = "Signo:";
            // 
            // rb_Negativo
            // 
            this.rb_Negativo.AutoSize = true;
            this.rb_Negativo.Location = new System.Drawing.Point(10, 40);
            this.rb_Negativo.Name = "rb_Negativo";
            this.rb_Negativo.Size = new System.Drawing.Size(68, 17);
            this.rb_Negativo.TabIndex = 1;
            this.rb_Negativo.Text = "Negativo";
            this.rb_Negativo.UseVisualStyleBackColor = true;
            // 
            // rb_Positivo
            // 
            this.rb_Positivo.AutoSize = true;
            this.rb_Positivo.Checked = true;
            this.rb_Positivo.Location = new System.Drawing.Point(10, 18);
            this.rb_Positivo.Name = "rb_Positivo";
            this.rb_Positivo.Size = new System.Drawing.Size(62, 17);
            this.rb_Positivo.TabIndex = 0;
            this.rb_Positivo.TabStop = true;
            this.rb_Positivo.Text = "Positivo";
            this.rb_Positivo.UseVisualStyleBackColor = true;
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.Location = new System.Drawing.Point(320, 15);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(75, 25);
            this.bt_Aceptar.TabIndex = 5;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            this.bt_Aceptar.Click += new System.EventHandler(this.bt_Aceptar_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancelar.Location = new System.Drawing.Point(320, 50);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(75, 25);
            this.bt_Cancelar.TabIndex = 6;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            // 
            // DlgDatosZona
            // 
            this.AcceptButton = this.bt_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_Cancelar;
            this.ClientSize = new System.Drawing.Size(410, 125);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Aceptar);
            this.Controls.Add(this.gb_Signo);
            this.Controls.Add(this.ct_Diferencia);
            this.Controls.Add(this.lb_Diferencia);
            this.Controls.Add(this.ct_Nombre);
            this.Controls.Add(this.lb_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DlgDatosZona";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos de zona horaria";
            this.gb_Signo.ResumeLayout(false);
            this.gb_Signo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.TextBox ct_Nombre;
        private System.Windows.Forms.Label lb_Diferencia;
        private Practica3.EditHora ct_Diferencia;
        private System.Windows.Forms.GroupBox gb_Signo;
        private System.Windows.Forms.RadioButton rb_Negativo;
        private System.Windows.Forms.RadioButton rb_Positivo;
        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.Button bt_Cancelar;
    }
}
