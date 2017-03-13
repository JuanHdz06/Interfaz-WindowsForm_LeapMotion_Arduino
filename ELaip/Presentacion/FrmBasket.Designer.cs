namespace ELaip.Presentacion
{
    partial class FrmBasket
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dificultadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Facil = new System.Windows.Forms.ToolStripMenuItem();
            this.Normal = new System.Windows.Forms.ToolStripMenuItem();
            this.Dificil = new System.Windows.Forms.ToolStripMenuItem();
            this.instruccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reanudarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titulo = new System.Windows.Forms.Label();
            this.tiempojuego = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.PAUSA = new System.Windows.Forms.Label();
            this.laser = new System.Windows.Forms.Timer(this.components);
            this.nivel2 = new System.Windows.Forms.Timer(this.components);
            this.nivel3 = new System.Windows.Forms.Timer(this.components);
            this.Puntuacion = new System.Windows.Forms.Label();
            this.nave2 = new System.Windows.Forms.PictureBox();
            this.nave1 = new System.Windows.Forms.PictureBox();
            this.sp2 = new System.Windows.Forms.PictureBox();
            this.sp1 = new System.Windows.Forms.PictureBox();
            this.lasser = new System.Windows.Forms.PictureBox();
            this.misil3 = new System.Windows.Forms.PictureBox();
            this.misil2 = new System.Windows.Forms.PictureBox();
            this.misil1 = new System.Windows.Forms.PictureBox();
            this.Juego = new System.Windows.Forms.PictureBox();
            this.Portada = new System.Windows.Forms.PictureBox();
            this.fondo = new System.Windows.Forms.PictureBox();
            this.fondo2 = new System.Windows.Forms.PictureBox();
            this.fondo3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nave2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nave1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.misil3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.misil2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.misil1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Juego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Portada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarJuegoToolStripMenuItem,
            this.dificultadToolStripMenuItem,
            this.instruccionesToolStripMenuItem,
            this.pausaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarJuegoToolStripMenuItem
            // 
            this.iniciarJuegoToolStripMenuItem.Name = "iniciarJuegoToolStripMenuItem";
            this.iniciarJuegoToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.iniciarJuegoToolStripMenuItem.Text = "Iniciar Juego";
            this.iniciarJuegoToolStripMenuItem.Click += new System.EventHandler(this.iniciarJuegoToolStripMenuItem_Click);
            // 
            // dificultadToolStripMenuItem
            // 
            this.dificultadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Facil,
            this.Normal,
            this.Dificil});
            this.dificultadToolStripMenuItem.Name = "dificultadToolStripMenuItem";
            this.dificultadToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.dificultadToolStripMenuItem.Text = "Dificultad";
            // 
            // Facil
            // 
            this.Facil.Name = "Facil";
            this.Facil.Size = new System.Drawing.Size(114, 22);
            this.Facil.Text = "Fácil";
            this.Facil.Click += new System.EventHandler(this.Facil_Click);
            // 
            // Normal
            // 
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(114, 22);
            this.Normal.Text = "Normal";
            this.Normal.Click += new System.EventHandler(this.Normal_Click);
            // 
            // Dificil
            // 
            this.Dificil.Name = "Dificil";
            this.Dificil.Size = new System.Drawing.Size(114, 22);
            this.Dificil.Text = "Díficil";
            this.Dificil.Click += new System.EventHandler(this.Dificil_Click);
            // 
            // instruccionesToolStripMenuItem
            // 
            this.instruccionesToolStripMenuItem.Name = "instruccionesToolStripMenuItem";
            this.instruccionesToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.instruccionesToolStripMenuItem.Text = "Instrucciones";
            this.instruccionesToolStripMenuItem.Click += new System.EventHandler(this.instruccionesToolStripMenuItem_Click);
            // 
            // pausaToolStripMenuItem
            // 
            this.pausaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reanudarToolStripMenuItem});
            this.pausaToolStripMenuItem.Name = "pausaToolStripMenuItem";
            this.pausaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pausaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pausaToolStripMenuItem.Text = "Pausa";
            this.pausaToolStripMenuItem.Click += new System.EventHandler(this.pausaToolStripMenuItem_Click);
            // 
            // reanudarToolStripMenuItem
            // 
            this.reanudarToolStripMenuItem.Name = "reanudarToolStripMenuItem";
            this.reanudarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.reanudarToolStripMenuItem.Text = "Reanudar";
            this.reanudarToolStripMenuItem.Click += new System.EventHandler(this.reanudarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.titulo.Location = new System.Drawing.Point(206, 337);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(267, 42);
            this.titulo.TabIndex = 3;
            this.titulo.Text = "PLANE TRIAL";
            // 
            // tiempojuego
            // 
            this.tiempojuego.Interval = 60;
            this.tiempojuego.Tick += new System.EventHandler(this.tiempojuego_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Intentos:01";
            // 
            // PAUSA
            // 
            this.PAUSA.AutoSize = true;
            this.PAUSA.BackColor = System.Drawing.Color.White;
            this.PAUSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAUSA.ForeColor = System.Drawing.Color.Orange;
            this.PAUSA.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PAUSA.Location = new System.Drawing.Point(12, 432);
            this.PAUSA.Name = "PAUSA";
            this.PAUSA.Size = new System.Drawing.Size(145, 42);
            this.PAUSA.TabIndex = 9;
            this.PAUSA.Text = "PAUSA";
            // 
            // laser
            // 
            this.laser.Interval = 10;
            this.laser.Tick += new System.EventHandler(this.laser_Tick);
            // 
            // nivel2
            // 
            this.nivel2.Interval = 65;
            this.nivel2.Tick += new System.EventHandler(this.nivel2_Tick);
            // 
            // nivel3
            // 
            this.nivel3.Enabled = true;
            this.nivel3.Interval = 80;
            this.nivel3.Tick += new System.EventHandler(this.nivel3_Tick);
            // 
            // Puntuacion
            // 
            this.Puntuacion.AutoSize = true;
            this.Puntuacion.BackColor = System.Drawing.Color.DarkKhaki;
            this.Puntuacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntuacion.Location = new System.Drawing.Point(524, 70);
            this.Puntuacion.Name = "Puntuacion";
            this.Puntuacion.Size = new System.Drawing.Size(76, 20);
            this.Puntuacion.TabIndex = 17;
            this.Puntuacion.Text = "Puntaje:0";
            // 
            // nave2
            // 
            this.nave2.Image = global::ELaip.Properties.Resources.F5S4;
            this.nave2.Location = new System.Drawing.Point(408, 432);
            this.nave2.Name = "nave2";
            this.nave2.Size = new System.Drawing.Size(47, 85);
            this.nave2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nave2.TabIndex = 16;
            this.nave2.TabStop = false;
            // 
            // nave1
            // 
            this.nave1.Image = global::ELaip.Properties.Resources.F5S4;
            this.nave1.Location = new System.Drawing.Point(213, 432);
            this.nave1.Name = "nave1";
            this.nave1.Size = new System.Drawing.Size(47, 85);
            this.nave1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nave1.TabIndex = 15;
            this.nave1.TabStop = false;
            // 
            // sp2
            // 
            this.sp2.Image = global::ELaip.Properties.Resources.ship_fighter_01_final___copia;
            this.sp2.Location = new System.Drawing.Point(-28, 160);
            this.sp2.Name = "sp2";
            this.sp2.Size = new System.Drawing.Size(81, 38);
            this.sp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sp2.TabIndex = 14;
            this.sp2.TabStop = false;
            // 
            // sp1
            // 
            this.sp1.Image = global::ELaip.Properties.Resources.ship_fighter_01_final;
            this.sp1.Location = new System.Drawing.Point(623, 160);
            this.sp1.Name = "sp1";
            this.sp1.Size = new System.Drawing.Size(81, 38);
            this.sp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sp1.TabIndex = 13;
            this.sp1.TabStop = false;
            // 
            // lasser
            // 
            this.lasser.Image = global::ELaip.Properties.Resources.lasser;
            this.lasser.Location = new System.Drawing.Point(331, 454);
            this.lasser.Name = "lasser";
            this.lasser.Size = new System.Drawing.Size(10, 40);
            this.lasser.TabIndex = 10;
            this.lasser.TabStop = false;
            this.lasser.Click += new System.EventHandler(this.lasser_Click);
            // 
            // misil3
            // 
            this.misil3.Image = global::ELaip.Properties.Resources.rocket;
            this.misil3.Location = new System.Drawing.Point(439, 27);
            this.misil3.Name = "misil3";
            this.misil3.Size = new System.Drawing.Size(34, 43);
            this.misil3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.misil3.TabIndex = 7;
            this.misil3.TabStop = false;
            // 
            // misil2
            // 
            this.misil2.Image = global::ELaip.Properties.Resources.rocket;
            this.misil2.Location = new System.Drawing.Point(304, 27);
            this.misil2.Name = "misil2";
            this.misil2.Size = new System.Drawing.Size(37, 61);
            this.misil2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.misil2.TabIndex = 6;
            this.misil2.TabStop = false;
            // 
            // misil1
            // 
            this.misil1.Image = global::ELaip.Properties.Resources.rocket;
            this.misil1.Location = new System.Drawing.Point(130, 27);
            this.misil1.Name = "misil1";
            this.misil1.Size = new System.Drawing.Size(38, 63);
            this.misil1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.misil1.TabIndex = 5;
            this.misil1.TabStop = false;
            // 
            // Juego
            // 
            this.Juego.Image = global::ELaip.Properties.Resources.fighter_01;
            this.Juego.Location = new System.Drawing.Point(304, 211);
            this.Juego.Name = "Juego";
            this.Juego.Size = new System.Drawing.Size(76, 48);
            this.Juego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Juego.TabIndex = 2;
            this.Juego.TabStop = false;
            this.Juego.Visible = false;
            // 
            // Portada
            // 
            this.Portada.Image = global::ELaip.Properties.Resources.AV;
            this.Portada.Location = new System.Drawing.Point(12, 30);
            this.Portada.Name = "Portada";
            this.Portada.Size = new System.Drawing.Size(661, 447);
            this.Portada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Portada.TabIndex = 1;
            this.Portada.TabStop = false;
            this.Portada.Click += new System.EventHandler(this.Portada_Click);
            // 
            // fondo
            // 
            this.fondo.Image = global::ELaip.Properties.Resources.sky;
            this.fondo.Location = new System.Drawing.Point(12, 30);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(661, 447);
            this.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondo.TabIndex = 4;
            this.fondo.TabStop = false;
            this.fondo.Visible = false;
            // 
            // fondo2
            // 
            this.fondo2.Image = global::ELaip.Properties.Resources.redsky;
            this.fondo2.Location = new System.Drawing.Point(12, 30);
            this.fondo2.Name = "fondo2";
            this.fondo2.Size = new System.Drawing.Size(661, 447);
            this.fondo2.TabIndex = 11;
            this.fondo2.TabStop = false;
            // 
            // fondo3
            // 
            this.fondo3.Image = global::ELaip.Properties.Resources.nightsky;
            this.fondo3.Location = new System.Drawing.Point(14, 30);
            this.fondo3.Name = "fondo3";
            this.fondo3.Size = new System.Drawing.Size(659, 444);
            this.fondo3.TabIndex = 12;
            this.fondo3.TabStop = false;
            // 
            // FrmBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 486);
            this.Controls.Add(this.Puntuacion);
            this.Controls.Add(this.nave2);
            this.Controls.Add(this.nave1);
            this.Controls.Add(this.sp2);
            this.Controls.Add(this.sp1);
            this.Controls.Add(this.lasser);
            this.Controls.Add(this.PAUSA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.misil3);
            this.Controls.Add(this.misil2);
            this.Controls.Add(this.misil1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.Juego);
            this.Controls.Add(this.Portada);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.fondo);
            this.Controls.Add(this.fondo2);
            this.Controls.Add(this.fondo3);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmBasket";
            this.Text = "Plane Trial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nave2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nave1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.misil3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.misil2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.misil1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Juego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Portada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dificultadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Facil;
        private System.Windows.Forms.ToolStripMenuItem Normal;
        private System.Windows.Forms.ToolStripMenuItem Dificil;
        private System.Windows.Forms.ToolStripMenuItem instruccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox Juego;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.PictureBox fondo;
        private System.Windows.Forms.Timer tiempojuego;
        private System.Windows.Forms.PictureBox misil1;
        private System.Windows.Forms.PictureBox misil2;
        private System.Windows.Forms.PictureBox misil3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem pausaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reanudarToolStripMenuItem;
        private System.Windows.Forms.Label PAUSA;
        private System.Windows.Forms.PictureBox lasser;
        private System.Windows.Forms.Timer laser;
        private System.Windows.Forms.PictureBox Portada;
        private System.Windows.Forms.PictureBox fondo2;
        private System.Windows.Forms.PictureBox fondo3;
        private System.Windows.Forms.Timer nivel2;
        private System.Windows.Forms.PictureBox sp1;
        private System.Windows.Forms.PictureBox sp2;
        private System.Windows.Forms.Timer nivel3;
        private System.Windows.Forms.PictureBox nave1;
        private System.Windows.Forms.PictureBox nave2;
        private System.Windows.Forms.Label Puntuacion;
    }
}

