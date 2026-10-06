namespace Practica3
{
    partial class RelojDigital
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAnalogicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despertadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúZona = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContextoAlarma = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpcionesDespertadorActivar = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionesDespertadorDesactivar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContextoZona = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zonaAñadir = new System.Windows.Forms.ToolStripMenuItem();
            this.zonaEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.zonaSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.lb_HoraActual = new System.Windows.Forms.Label();
            this.ct_HoraActual = new System.Windows.Forms.TextBox();
            this.lb_Alarma = new System.Windows.Forms.Label();
            this.ct_Alarma = new Practica3.EditHora();
            this.bt_ZonaHoraria = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.menuContextoAlarma.SuspendLayout();
            this.menuContextoZona.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.menúZona,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarAnalogicoToolStripMenuItem,
            this.colorFondoToolStripMenuItem,
            this.fuenteToolStripMenuItem,
            this.despertadorToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            this.opcionesToolStripMenuItem.DropDownOpened += new System.EventHandler(this.opcionesToolStripMenuItem_DropDownOpened);
            // 
            // mostrarAnalogicoToolStripMenuItem
            // 
            this.mostrarAnalogicoToolStripMenuItem.Name = "mostrarAnalogicoToolStripMenuItem";
            this.mostrarAnalogicoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.mostrarAnalogicoToolStripMenuItem.Text = "&Mostrar analógico";
            this.mostrarAnalogicoToolStripMenuItem.Click += new System.EventHandler(this.mostrarAnalogicoToolStripMenuItem_Click);
            // 
            // colorFondoToolStripMenuItem
            // 
            this.colorFondoToolStripMenuItem.Name = "colorFondoToolStripMenuItem";
            this.colorFondoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.colorFondoToolStripMenuItem.Text = "&Color fondo...";
            this.colorFondoToolStripMenuItem.Click += new System.EventHandler(this.colorFondoToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.fuenteToolStripMenuItem.Text = "&Fuente...";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // despertadorToolStripMenuItem
            // 
            this.despertadorToolStripMenuItem.DropDown = this.menuContextoAlarma;
            this.despertadorToolStripMenuItem.Name = "despertadorToolStripMenuItem";
            this.despertadorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.despertadorToolStripMenuItem.Text = "&Despertador";
            // 
            // menúZona
            // 
            this.menúZona.DropDown = this.menuContextoZona;
            this.menúZona.Name = "menúZona";
            this.menúZona.Size = new System.Drawing.Size(46, 20);
            this.menúZona.Text = "&Zona";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "A&yuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // menuContextoAlarma
            // 
            this.menuContextoAlarma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcionesDespertadorActivar,
            this.OpcionesDespertadorDesactivar});
            this.menuContextoAlarma.Name = "menuContextoAlarma";
            this.menuContextoAlarma.Size = new System.Drawing.Size(177, 48);
            // 
            // OpcionesDespertadorActivar
            // 
            this.OpcionesDespertadorActivar.Name = "OpcionesDespertadorActivar";
            this.OpcionesDespertadorActivar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.OpcionesDespertadorActivar.Size = new System.Drawing.Size(176, 22);
            this.OpcionesDespertadorActivar.Text = "Acti&var";
            this.OpcionesDespertadorActivar.Click += new System.EventHandler(this.OpcionesDespertadorActivar_Click);
            // 
            // OpcionesDespertadorDesactivar
            // 
            this.OpcionesDespertadorDesactivar.Enabled = false;
            this.OpcionesDespertadorDesactivar.Name = "OpcionesDespertadorDesactivar";
            this.OpcionesDespertadorDesactivar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.OpcionesDespertadorDesactivar.Size = new System.Drawing.Size(176, 22);
            this.OpcionesDespertadorDesactivar.Text = "Desacti&var";
            this.OpcionesDespertadorDesactivar.Click += new System.EventHandler(this.OpcionesDespertadorDesactivar_Click);
            // 
            // menuContextoZona
            // 
            this.menuContextoZona.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zonaAñadir,
            this.zonaEliminar,
            this.zonaSeparador});
            this.menuContextoZona.Name = "menuContextoZona";
            this.menuContextoZona.Size = new System.Drawing.Size(206, 54);
            this.menuContextoZona.Opened += new System.EventHandler(this.menuContextoZona_Opened);
            // 
            // zonaAñadir
            // 
            this.zonaAñadir.Name = "zonaAñadir";
            this.zonaAñadir.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.zonaAñadir.Size = new System.Drawing.Size(205, 22);
            this.zonaAñadir.Text = "Añadir";
            this.zonaAñadir.Click += new System.EventHandler(this.zonaAñadir_Click);
            // 
            // zonaEliminar
            // 
            this.zonaEliminar.Name = "zonaEliminar";
            this.zonaEliminar.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.zonaEliminar.Size = new System.Drawing.Size(205, 22);
            this.zonaEliminar.Text = "Eliminar";
            this.zonaEliminar.Visible = false;
            this.zonaEliminar.Click += new System.EventHandler(this.zonaEliminar_Click);
            // 
            // zonaSeparador
            // 
            this.zonaSeparador.Name = "zonaSeparador";
            this.zonaSeparador.Size = new System.Drawing.Size(202, 6);
            this.zonaSeparador.Visible = false;
            // 
            // lb_HoraActual
            // 
            this.lb_HoraActual.AutoSize = true;
            this.lb_HoraActual.Location = new System.Drawing.Point(50, 35);
            this.lb_HoraActual.Name = "lb_HoraActual";
            this.lb_HoraActual.Size = new System.Drawing.Size(65, 13);
            this.lb_HoraActual.TabIndex = 1;
            this.lb_HoraActual.Text = "Hora actual:";
            // 
            // ct_HoraActual
            // 
            this.ct_HoraActual.Location = new System.Drawing.Point(50, 52);
            this.ct_HoraActual.Name = "ct_HoraActual";
            this.ct_HoraActual.ReadOnly = true;
            this.ct_HoraActual.Size = new System.Drawing.Size(160, 20);
            this.ct_HoraActual.TabIndex = 2;
            this.ct_HoraActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Alarma
            // 
            this.lb_Alarma.AutoSize = true;
            this.lb_Alarma.Location = new System.Drawing.Point(50, 80);
            this.lb_Alarma.Name = "lb_Alarma";
            this.lb_Alarma.Size = new System.Drawing.Size(42, 13);
            this.lb_Alarma.TabIndex = 3;
            this.lb_Alarma.Text = "Alarma:";
            // 
            // ct_Alarma
            // 
            this.ct_Alarma.BeepOnError = true;
            this.ct_Alarma.ContextMenuStrip = this.menuContextoAlarma;
            this.ct_Alarma.Hora = new System.DateTime(((long)(0)));
            this.ct_Alarma.Location = new System.Drawing.Point(50, 97);
            this.ct_Alarma.Mask = "90:00:99";
            this.ct_Alarma.Name = "ct_Alarma";
            this.ct_Alarma.PromptChar = '-';
            this.ct_Alarma.Size = new System.Drawing.Size(160, 20);
            this.ct_Alarma.TabIndex = 4;
            this.ct_Alarma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ct_Alarma.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // bt_ZonaHoraria
            // 
            this.bt_ZonaHoraria.Location = new System.Drawing.Point(50, 130);
            this.bt_ZonaHoraria.Name = "bt_ZonaHoraria";
            this.bt_ZonaHoraria.Size = new System.Drawing.Size(160, 26);
            this.bt_ZonaHoraria.TabIndex = 5;
            this.bt_ZonaHoraria.Text = "Diálogo zona";
            this.bt_ZonaHoraria.UseVisualStyleBackColor = true;
            this.bt_ZonaHoraria.Click += new System.EventHandler(this.bt_ZonaHoraria_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RelojDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 175);
            this.ContextMenuStrip = this.menuContextoZona;
            this.Controls.Add(this.bt_ZonaHoraria);
            this.Controls.Add(this.ct_Alarma);
            this.Controls.Add(this.lb_Alarma);
            this.Controls.Add(this.ct_HoraActual);
            this.Controls.Add(this.lb_HoraActual);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "RelojDigital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reloj digital";
            this.Load += new System.EventHandler(this.RelojDigital_Load);
            this.Shown += new System.EventHandler(this.RelojDigital_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuContextoAlarma.ResumeLayout(false);
            this.menuContextoZona.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarAnalogicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despertadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúZona;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menuContextoAlarma;
        private System.Windows.Forms.ToolStripMenuItem OpcionesDespertadorActivar;
        private System.Windows.Forms.ToolStripMenuItem OpcionesDespertadorDesactivar;
        private System.Windows.Forms.ContextMenuStrip menuContextoZona;
        private System.Windows.Forms.ToolStripMenuItem zonaAñadir;
        private System.Windows.Forms.ToolStripMenuItem zonaEliminar;
        private System.Windows.Forms.ToolStripSeparator zonaSeparador;
        private System.Windows.Forms.Label lb_HoraActual;
        private System.Windows.Forms.TextBox ct_HoraActual;
        private System.Windows.Forms.Label lb_Alarma;
        private Practica3.EditHora ct_Alarma;
        private System.Windows.Forms.Button bt_ZonaHoraria;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
