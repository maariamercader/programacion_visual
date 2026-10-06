namespace Practica4
{
    partial class DlgEliminarZona
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
            this.lb_Zonas = new System.Windows.Forms.ListBox();
            this.lb_Diferencia = new System.Windows.Forms.Label();
            this.ct_Diferencia = new System.Windows.Forms.TextBox();
            this.lb_Signo = new System.Windows.Forms.Label();
            this.ct_Signo = new System.Windows.Forms.TextBox();
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(15, 15);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(47, 13);
            this.lb_Nombre.TabIndex = 0;
            this.lb_Nombre.Text = "Nombre:";
            // 
            // lb_Zonas
            // 
            this.lb_Zonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Zonas.FormattingEnabled = true;
            this.lb_Zonas.Location = new System.Drawing.Point(18, 35);
            this.lb_Zonas.Name = "lb_Zonas";
            this.lb_Zonas.Size = new System.Drawing.Size(250, 108);
            this.lb_Zonas.TabIndex = 1;
            this.lb_Zonas.SelectedIndexChanged += new System.EventHandler(this.lb_Zonas_SelectedIndexChanged);
            // 
            // lb_Diferencia
            // 
            this.lb_Diferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Diferencia.AutoSize = true;
            this.lb_Diferencia.Location = new System.Drawing.Point(15, 160);
            this.lb_Diferencia.Name = "lb_Diferencia";
            this.lb_Diferencia.Size = new System.Drawing.Size(91, 13);
            this.lb_Diferencia.TabIndex = 2;
            this.lb_Diferencia.Text = "Diferencia horaria:";
            // 
            // ct_Diferencia
            // 
            this.ct_Diferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ct_Diferencia.Location = new System.Drawing.Point(115, 157);
            this.ct_Diferencia.Name = "ct_Diferencia";
            this.ct_Diferencia.ReadOnly = true;
            this.ct_Diferencia.Size = new System.Drawing.Size(70, 20);
            this.ct_Diferencia.TabIndex = 3;
            this.ct_Diferencia.TabStop = false;
            // 
            // lb_Signo
            // 
            this.lb_Signo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Signo.AutoSize = true;
            this.lb_Signo.Location = new System.Drawing.Point(195, 160);
            this.lb_Signo.Name = "lb_Signo";
            this.lb_Signo.Size = new System.Drawing.Size(37, 13);
            this.lb_Signo.TabIndex = 4;
            this.lb_Signo.Text = "Signo:";
            // 
            // ct_Signo
            // 
            this.ct_Signo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ct_Signo.Location = new System.Drawing.Point(238, 157);
            this.ct_Signo.Name = "ct_Signo";
            this.ct_Signo.ReadOnly = true;
            this.ct_Signo.Size = new System.Drawing.Size(70, 20);
            this.ct_Signo.TabIndex = 5;
            this.ct_Signo.TabStop = false;
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Aceptar.Location = new System.Drawing.Point(290, 35);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(80, 25);
            this.bt_Aceptar.TabIndex = 6;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            this.bt_Aceptar.Click += new System.EventHandler(this.bt_Aceptar_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancelar.Location = new System.Drawing.Point(290, 70);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(80, 25);
            this.bt_Cancelar.TabIndex = 7;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            // 
            // DlgEliminarZona
            // 
            this.AcceptButton = this.bt_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_Cancelar;
            this.ClientSize = new System.Drawing.Size(384, 195);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Aceptar);
            this.Controls.Add(this.ct_Signo);
            this.Controls.Add(this.lb_Signo);
            this.Controls.Add(this.ct_Diferencia);
            this.Controls.Add(this.lb_Diferencia);
            this.Controls.Add(this.lb_Zonas);
            this.Controls.Add(this.lb_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgEliminarZona";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar zona horaria";
            this.Load += new System.EventHandler(this.DlgEliminarZona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.ListBox lb_Zonas;
        private System.Windows.Forms.Label lb_Diferencia;
        private System.Windows.Forms.TextBox ct_Diferencia;
        private System.Windows.Forms.Label lb_Signo;
        private System.Windows.Forms.TextBox ct_Signo;
        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.Button bt_Cancelar;
    }
}
