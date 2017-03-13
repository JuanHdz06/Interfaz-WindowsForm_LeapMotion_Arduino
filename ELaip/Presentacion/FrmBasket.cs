using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO.Ports;
using Leap;

namespace ELaip.Presentacion
{
    public partial class FrmBasket : Form, ILeapEventDelegate
    {
        SerialPort coon;
        private Controller controller;
        private LeapEventListener listener;
        public int nivel;
        public int contador;
        public int puntaje;
        public int dificultad= 1;
        public System.Media.SoundPlayer musica = new System.Media.SoundPlayer();
        public int intentos;
        public int i, j;
        public FrmBasket()
        {
            
            InitializeComponent();
            this.controller = new Controller();
            this.listener = new LeapEventListener(this);
            controller.AddListener(listener);
            //Init();
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            misil1.Visible = false;
            misil2.Visible = false;
            misil3.Visible = false;
            
            
            
            label1.Visible = false;
            lasser.Visible = false;
            PAUSA.Visible = false;
            fondo2.Visible = true;
            fondo3.Visible = true;


            sp1.Visible = false;
            sp2.Visible = false;
            nave1.Visible = false;
            nave2.Visible = false;
            
        }


        private void Init()
        {
            coon = new SerialPort();
            coon.PortName = "COM5";
            coon.BaudRate = 9600
                ;


            try
            {
                coon.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        delegate void LeapEventDelegate(string EventName);
        public void LeapEventNotification(string EventName)
        {
            if (!this.InvokeRequired)
            {
                switch (EventName)
                {
                    case "onInit":

                        //MessageBox.Show("Conexion Establecida");
                        break;
                    case "onConnect":
                        this.connectHandler();
                        break;
                    case "onFrame":
                        if (!this.Disposing)
                            this.newFrameHandler(this.controller.Frame());
                        break;
                }
            }
            else
            {
                BeginInvoke(new LeapEventDelegate(LeapEventNotification), new object[] { EventName });
            }
        }

        void connectHandler()
        {
            this.controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
            this.controller.Config.SetFloat("Gesture.Circle.MinRadius", 40.0f);
            this.controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
        }

        void newFrameHandler(Frame frame)
        {

            double Ar,Ar2;
            for (int h = 0; h < frame.Hands.Count; h++)
            {
                Hand leapHand = frame.Hands[h];

                Vector handXBasis = leapHand.PalmNormal.Cross(leapHand.Direction).Normalized;
                Vector handYBasis = -leapHand.PalmNormal;
                Vector handZBasis = -leapHand.Direction;
                Vector handOrigin = leapHand.PalmPosition;
                Matrix handTransform = new Matrix(handXBasis, handYBasis, handZBasis, handOrigin);
                handTransform = handTransform.RigidInverse();
                //this.textBox2.Text = handOrigin.x.ToString();
                //this.textBox4.Text = handOrigin.y.ToString();

                for (int f = 0; f < leapHand.Fingers.Count; f++)
                {
                    Finger leapFinger = leapHand.Fingers[f];
                    Vector transformedPosition = handTransform.TransformPoint(leapFinger.TipPosition);
                    Vector transformedDirection = handTransform.TransformDirection(leapFinger.Direction);

                    int x = Juego.Location.X;
                    int y = Juego.Location.Y;
                    Ar = (handOrigin.x + 100) * 1.8;
                    Ar2 = (handOrigin.y);

                    if (Ar >= 0)
                    {
                        x = (int)Math.Ceiling(Ar);
                    }

                    if (Ar2 >= 50)
                    {
                        y = 500+(int)Math.Ceiling(-Ar2);
                    }
                    //if (handOrigin.x < 0)
                    //{ x --; }
                    //if (handOrigin.y > 0)
                    //{ y -= 13; }
                    //if (handOrigin.x > 0)
                    //{ y += 13; }


                    Juego.Location = new System.Drawing.Point(x, y);
                    i = x;
                    j = y;
                   
                }

            }
        }

        private void Facil_Click(object sender, EventArgs e)
        {
            dificultad = 1;
            tiempojuego.Interval = 110;
            fondo.Visible = true;
            sp1.Visible = false;
            sp2.Visible = false;
            nave1.Visible = false;
            nave2.Visible = false;

            nivel2.Stop();
            nivel3.Stop();
            
        }

        private void Normal_Click(object sender, EventArgs e)
        {
            dificultad = 2;
            tiempojuego.Interval = 57;
            fondo.Visible = false;
            fondo2.Visible = true;
            fondo3.Visible = false;
            nave1.Visible = false;
            nave2.Visible = false;
            if(tiempojuego.Enabled==true)
            {
                nivel2.Start();
            }
            
            nivel3.Stop();

        }

        private void Dificil_Click(object sender, EventArgs e)
        {
            dificultad = 3;
            tiempojuego.Interval = 40;
            if (tiempojuego.Enabled==true)
            {
                nivel2.Start();
                nivel3.Start();
            }
            
            fondo.Visible = false;
            fondo2.Visible = false;
            fondo3.Visible = true;        
        }



        private void iniciarJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musica.Stream = Properties.Resources.Fatboy_Slim___Acid_8000;
            musica.Play();
            dificultadToolStripMenuItem.Enabled = true;
            pausaToolStripMenuItem.Enabled = true;
            Juego.Location = new Point(304, 211);
            Portada.Visible = false;
            titulo.Visible = false;
            misil1.Visible = true;
            misil2.Visible = true;
            misil3.Visible = true;

            sp1.Visible = false;
            sp2.Visible = false;

            nave1.Visible = false;
            nave2.Visible = false;

            fondo.Visible = true;
            Juego.Visible = true;
            lasser.Visible = false;
            PAUSA.Visible = false;
            label1.Visible = true;
           
            this.misil1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.misil2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.misil3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.lasser.SizeMode = PictureBoxSizeMode.StretchImage;

            Random rdn = new Random();
            int a = rdn.Next(50, 550);
            int b = rdn.Next(50, 550);
            int c = rdn.Next(50, 550);
            misil1.Location = new Point(a, 0);
            misil2.Location = new Point(b, 0);
            misil3.Location = new Point(c, 0);
            
            intentos = 1;
            tiempojuego.Start();

            puntaje = 0;
            Puntuacion.Text = "Puntaje:0";



           












        }

        
        
        private void tiempojuego_Tick(object sender, EventArgs e)
        {

            Random rdn = new Random();
            int a = rdn.Next(50, 550);
            int b = rdn.Next(50, 550);
            int c = rdn.Next(50, 550);
            contador = contador + 1;
            if ((misil1.Top < 500) && (misil1.Top < 500) && (misil1.Top < 500))
            {
                misil1.Top = misil1.Top + 11;
                misil2.Top = misil2.Top + 12;
                misil3.Top = misil3.Top + 13;

                  
            }

            else
            {
                
                    misil1.Visible = true;
                    misil2.Visible = true;
                    misil3.Visible = true;
                
                misil1.Location = new Point(a, 0);
                misil2.Location = new Point(b, 0);
                misil3.Location = new Point(c, 0);
            }
            if (lasser.Bounds.IntersectsWith(misil1.Bounds))
                {
                    misil1.Visible = false;
                    puntaje = puntaje + 10;
                    Puntuacion.Text = "Puntaje:" + puntaje;
                }
                if (lasser.Bounds.IntersectsWith(misil2.Bounds))
                {
                    misil2.Visible = false;
                    puntaje = puntaje + 10;
                    Puntuacion.Text = "Puntaje:" + puntaje;
                }
                if (lasser.Bounds.IntersectsWith(misil3.Bounds))
                {
                    misil3.Visible = false;
                    puntaje = puntaje + 10;
                    Puntuacion.Text = "Puntaje:" + puntaje;
                }
            if (misil1.Visible==true)
            {
                    if (misil1.Bounds.IntersectsWith(Juego.Bounds) )
                    {

                        intentos=intentos+1;
                        label1.Text = "Intentos: 0"+intentos;
                        if (intentos>3)
                        {
                            label1.Visible = false;
                            tiempojuego.Stop();
                            nivel2.Stop();
                            nivel3.Stop();
                            //Perdedor Intenta = new Perdedor();
                            //Intenta.Show();
                    
                    
                            misil1.Visible = false;
                            misil2.Visible = false;
                            misil3.Visible = false;
                            sp1.Visible = false;
                            sp2.Visible = false;
                            nave1.Visible = false;
                            nave2.Visible = false;
                            lasser.Visible = false;
                               
                            Juego.Visible = false;
                            Portada.Visible = true;
                            titulo.Visible = true;
                            label1.Visible = true;
                     
                            musica.Stop();

                   

                            label1.Text = "Intentos: 01";
                        }
                        else
                        {
                            Juego.Location = new System.Drawing.Point(300, 400);
                            misil1.Location = new Point(a, 0);
                            misil2.Location = new Point(b, 0);
                            misil3.Location = new Point(c, 0);
                        }

                    }
                
            }
            if (misil2.Visible == true)
            {
                if (misil2.Bounds.IntersectsWith(Juego.Bounds))
                {

                    intentos = intentos + 1;
                    label1.Text = "Intentos: 0" + intentos;
                    if (intentos > 3)
                    {
                        label1.Visible = true;
                        tiempojuego.Stop();
                        nivel2.Stop();
                        nivel3.Stop();
                        //Perdedor Intenta = new Perdedor();
                        //Intenta.Show();


                        misil1.Visible = false;
                        misil2.Visible = false;
                        misil3.Visible = false;
                        sp1.Visible = false;
                        sp2.Visible = false;
                        nave1.Visible = false;
                        nave2.Visible = false;

                        lasser.Visible = false;
                        Juego.Visible = false;
                        Portada.Visible = true;
                        titulo.Visible = true;
                        label1.Visible = true;

                        musica.Stop();



                        label1.Text = "Intentos: 01";
                    }
                    else
                    {
                        Juego.Location = new System.Drawing.Point(304, 211);
                        misil1.Location = new Point(a, 0);
                        misil2.Location = new Point(b, 0);
                        misil3.Location = new Point(c, 0);
                    }

                }

            }
            if (misil3.Visible == true)
            {
                if (misil3.Bounds.IntersectsWith(Juego.Bounds))
                {

                    intentos = intentos + 1;
                    label1.Text = "Intentos: 0" + intentos;
                    if (intentos > 3)
                    {
                        label1.Visible = false;
                        tiempojuego.Stop();
                        nivel2.Stop();
                        nivel3.Stop();
                        //Perdedor Intenta = new Perdedor();
                        //Intenta.Show();


                        misil1.Visible = false;
                        misil2.Visible = false;
                        misil3.Visible = false;
                        sp1.Visible = false;
                        sp2.Visible = false;
                        nave1.Visible = false;
                        nave2.Visible = false;
                        Juego.Visible = false;
                        Portada.Visible = true;
                        titulo.Visible = true;
                        label1.Visible = true;

                        musica.Stop();



                        label1.Text = "Intentos: 01";
                    }
                    else
                    {
                        Juego.Location = new System.Drawing.Point(304, 211);
                        misil1.Location = new Point(a, 0);
                        misil2.Location = new Point(b, 0);
                        misil3.Location = new Point(c, 0);
                    }

                }

            }
   

              
            
        }

        private void nivel2_Tick(object sender, EventArgs e)
        {

           
            Random rdn = new Random();
            int d = rdn.Next(50, 450);
            int f = rdn.Next(50, 450);
            int g = rdn.Next(50, 450);
            if (fondo.Visible==true)
            {
                sp1.Visible = false;
                sp2.Visible = false;
            }
            else
            { 

            if (sp1.Left > 0)
            {
                sp1.Left = sp1.Left - 11;
                sp2.Left = sp2.Left + 12;


            }

            else
            {

                sp1.Visible = true;
                sp2.Visible = true;

                sp1.Location = new Point(604, d);
                sp2.Location = new Point(0, f);
            }
            if (lasser.Bounds.IntersectsWith(sp1.Bounds))
            {
                sp1.Visible = false;
                puntaje = puntaje + 10;
                Puntuacion.Text = "Puntaje:" + puntaje;
            }
            if (lasser.Bounds.IntersectsWith(sp2.Bounds))
            {
                sp2.Visible = false;
                puntaje = puntaje + 10;
                Puntuacion.Text = "Puntaje:" + puntaje;
            }

            if (sp1.Visible == true)
            {
                if (sp1.Bounds.IntersectsWith(Juego.Bounds))
                {

                    intentos = intentos + 1;
                    label1.Text = "Intentos: 0" + intentos;
                    if (intentos > 3)
                    {
                        label1.Visible = false;
                        tiempojuego.Stop();
                        nivel2.Stop();
                        nivel3.Stop();
                        //Perdedor Intenta = new Perdedor();
                        //Intenta.Show();


                        misil1.Visible = false;
                        misil2.Visible = false;
                        misil3.Visible = false;
                        lasser.Visible = false;
                        sp1.Visible = false;
                        sp2.Visible = false;
                        nave1.Visible = false;
                        nave2.Visible = false;

                        Juego.Visible = false;
                        Portada.Visible = true;
                        titulo.Visible = true;
                        label1.Visible = true;

                        musica.Stop();



                        label1.Text = "Intentos: 01";
                    }
                    else
                    {
                        Juego.Location = new System.Drawing.Point(303, 211);
                        sp1.Location = new Point(640, d);
                        sp2.Location = new Point(0, f);
                    }
                }
                if (sp2.Visible == true)
                {



                    if (sp2.Bounds.IntersectsWith(Juego.Bounds))
                    {

                        intentos = intentos + 1;
                        label1.Text = "Intentos: 0" + intentos;
                        if (intentos > 3)
                        {
                            label1.Visible = false;
                            tiempojuego.Stop();
                            nivel2.Stop();
                            nivel3.Stop();
                            //Perdedor Intenta = new Perdedor();
                            //Intenta.Show();


                            misil1.Visible = false;
                            misil2.Visible = false;
                            misil3.Visible = false;
                            lasser.Visible = false;
                            sp1.Visible = false;
                            sp2.Visible = false;
                            nave1.Visible = false;
                            nave2.Visible = false;

                            Juego.Visible = false;
                            Portada.Visible = true;
                            titulo.Visible = true;
                            label1.Visible = true;

                            musica.Stop();



                            label1.Text = "Intentos: 01";
                        }
                        else
                        {
                            Juego.Location = new System.Drawing.Point(304, 211);
                            sp1.Location = new Point(640, d);
                            sp2.Location = new Point(0, f);
                        }

                    }
                }
            }    
          }

        }
         private void nivel3_Tick(object sender, EventArgs e)
         {

             Random rdn = new Random();
             int d = rdn.Next(50, 450);
             int f = rdn.Next(50, 450);
             if ((fondo.Visible==true)||(fondo2.Visible==true))
             {
                 nave1.Visible = false;
                 nave2.Visible = false;
             }
             else
             { 
                 if (nave1.Top > 1)
                 {
                     nave1.Top = nave1.Top - 11;
                 }
                 if (nave2.Top > 1)
                 {
                     nave2.Top = nave2.Top - 11;
                 }

                 else
                 {

                     nave1.Visible = true;
                     nave2.Visible = true;
                     nave1.Location = new Point(d,500);
                     nave2.Location = new Point(f, 500);
                 }
                 if (lasser.Bounds.IntersectsWith(nave1.Bounds))
                 {
                     nave1.Visible = false;
                     puntaje = puntaje + 10;
                     Puntuacion.Text = "Puntaje:" + puntaje;
                 }
                 if (lasser.Bounds.IntersectsWith(nave2.Bounds))
                 {
                     nave2.Visible = false;
                     puntaje = puntaje + 10;
                     Puntuacion.Text = "Puntaje:" + puntaje;
                 }

                 if (nave1.Visible == true)
                 {
                         if (nave1.Bounds.IntersectsWith(Juego.Bounds))
                         {

                             intentos = intentos + 1;
                             label1.Text = "Intentos: 0" + intentos;
                             if (intentos > 3)
                             {
                                 label1.Visible = false;
                                 tiempojuego.Stop();
                                 nivel2.Stop();
                                 nivel3.Stop();
                                 //Perdedor Intenta = new Perdedor();
                                 //Intenta.Show();


                                 misil1.Visible = false;
                                 misil2.Visible = false;
                                 misil3.Visible = false;
                                 lasser.Visible = false;
                                 sp1.Visible = false;
                                 sp2.Visible = false;
                                 nave1.Visible = false;
                                 nave2.Visible = false;

                                 Juego.Visible = false;
                                 Portada.Visible = true;
                                 titulo.Visible = true;
                                 label1.Visible = true;

                                 musica.Stop();



                                 label1.Text = "Intentos: 01";
                             }
                             else
                             {
                                 Juego.Location = new System.Drawing.Point(303, 211);
                                 nave1.Location = new Point(d,500 );

                             }
                          }
                 }
                 if (nave2.Visible == true)
                 {
                     if (nave2.Bounds.IntersectsWith(Juego.Bounds))
                     {

                         intentos = intentos + 1;
                         label1.Text = "Intentos: 0" + intentos;
                         if (intentos > 3)
                         {
                             label1.Visible = false;
                             tiempojuego.Stop();
                             nivel2.Stop();
                             nivel3.Stop();
                             //Perdedor Intenta = new Perdedor();
                             //Intenta.Show();


                             misil1.Visible = false;
                             misil2.Visible = false;
                             misil3.Visible = false;
                             lasser.Visible = false;
                             sp1.Visible = false;
                             sp2.Visible = false;
                             nave1.Visible = false;
                             nave2.Visible = false;

                             Juego.Visible = false;
                             Portada.Visible = true;
                             titulo.Visible = true;
                             label1.Visible = true;

                             musica.Stop();



                             label1.Text = "Intentos: 01";
                         }
                         else
                         {
                             Juego.Location = new System.Drawing.Point(303, 211);
                             nave2.Location = new Point(f, 500);

                         }
                     }
                 }
             }

         }

             
        
        

   
        private void Form1_KeyDown(object sender, KeyEventArgs e) 
        {
            
        
                int x = Juego.Location.X;
                int y = Juego.Location.Y;


                if (e.KeyCode == Keys.Right)
                { x += 13;}
                if (e.KeyCode == Keys.Left)
                { x -= 13;}
                if (e.KeyCode == Keys.Up)
                { y -= 13;}
                if (e.KeyCode == Keys.Down)
                { y += 13;}


               Juego.Location = new System.Drawing.Point(x, y);
               i = x;
               j = y;
                if (e.KeyCode==Keys.Space)
                {

                    lasser.Location = new System.Drawing.Point(i+36, j);
                    laser.Start();


                    
                }

        
        }








        private void instruccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instrucciones objinst = new Instrucciones();
            //objinst.Show();

        }

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tiempojuego.Stop();
            nivel2.Stop();
            nivel3.Stop();
                dificultadToolStripMenuItem.Enabled = false;
                pausaToolStripMenuItem.Enabled = false;
        }

        

        private void pausaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Portada.Visible==false)
            {
                tiempojuego.Stop();
                nivel2.Stop();
                nivel3.Stop();
                laser.Stop();
                PAUSA.Visible = true;
            }
            

        }

        private void reanudarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Portada.Visible==false)
            {
                tiempojuego.Enabled = true;
                nivel2.Start();
                nivel3.Start();
                laser.Enabled = true;
                PAUSA.Visible = false;
        
            }
        }
        private void lasser_Click(object sender, EventArgs e)
        {
            
        }


        private void laser_Tick(object sender, EventArgs e)
        {
            
            lasser.Visible = true;
            lasser.Top = lasser.Top - 10;

        }

        private void Portada_Click(object sender, EventArgs e)
        {

        }

   



    }
}
